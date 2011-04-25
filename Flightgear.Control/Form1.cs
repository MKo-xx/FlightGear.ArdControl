using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO.Ports;

namespace Flightgear.Control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Threads
        private Thread thread_receive_from_flightgear_      = null;
        private Thread thread_send_to_flightgear_           = null;
        private Thread thread_receive_from_serial_port_     = null;
        private Thread thread_calibrate_from_serial_port_   = null;
        
        //Refresh button
        private void refresh_button_Click(object sender, EventArgs e)
        {
            portlist_comboBox.Items.Clear();
            foreach (string s in SerialPort.GetPortNames())
            {
                portlist_comboBox.Items.Add(s);
            }
        }
        
        //Connect buttons
        private void connect_serial_button_Click(object sender, EventArgs e)
        {
            if (null == thread_receive_from_serial_port_)
            {
                if (-1 == portlist_comboBox.SelectedIndex)
                {
                    MessageBox.Show("Select Com port");
                    return;
                }
                string port_name = portlist_comboBox.SelectedItem.ToString(); // get serial port name
                serial_port_ = new SerialPort(port_name, 9600); // set port name and speed 9600 bits/second
                serial_port_.Open(); // connect to port

                thread_receive_from_serial_port_ = new Thread(receive_from_serial_port);
                thread_receive_from_serial_port_.Start();
                connect_serial_button.Text = "Disconnect";
                
                calibrate_button.Enabled = false;
                reset_button.Enabled = false;
            }
            else
            {
                thread_receive_from_serial_port_.Abort();
                thread_receive_from_serial_port_ = null;
                connect_serial_button.Text = "Connect";

                serial_port_.Close();
                serial_port_ = null;

                calibrate_button.Enabled = true;
                reset_button.Enabled = true;
            }
        }

        private void connect_fg_receive_button_Click(object sender, EventArgs e)
        {
            if (null == thread_receive_from_flightgear_)
            {
                thread_receive_from_flightgear_ = new Thread(receive_from_flightgear);
                thread_receive_from_flightgear_.Start();
                connect_fg_receive_button.Text = "Disconnect";
            }
            else
            {
                receiving_UdpClient.Close();
                receiving_UdpClient = null;

                thread_receive_from_flightgear_.Abort();
                thread_receive_from_flightgear_ = null;
                connect_fg_receive_button.Text = "Connect";
            }
        }

        private void connect_fg_send_button_Click(object sender, EventArgs e)
        {
            if (null == thread_send_to_flightgear_)
            {
                thread_send_to_flightgear_ = new Thread(send_to_flightgear);
                thread_send_to_flightgear_.Start();
                connect_fg_send_button.Text = "Disconnect";

                calibrate_button.Enabled = false;
            }
            else
            {
                sending_UdpClient.Close();
                sending_UdpClient = null;

                thread_send_to_flightgear_.Abort();
                thread_send_to_flightgear_ = null;
                connect_fg_send_button.Text = "Connect";
                
                calibrate_button.Enabled = true;
            }
        }

        //Receive from Serial port
        private SerialPort serial_port_ = null;
        private void receive_from_serial_port()
        {
            while (serial_port_.IsOpen)
            {
                try
                {
                    string str = serial_port_.ReadLine(); //

                    String[] data = str.Split(',');

                    if (3 != data.Length)
                        continue;
                    try
                    {
                        aileron_current_rx_value = int.Parse(data[0]);
                        throttle_current_rx_value = int.Parse(data[1]);
                        elevator_current_rx_value = int.Parse(data[2]);
                    }
                    catch(Exception)
                    {
                        continue;
                    }
                    update_control_status();
                }
                catch (TimeoutException) { }
                Thread.Sleep(100);
            }
        }

        private void calibrate_from_serial()
        {
            while (serial_port_.IsOpen)
            {
                try
                {
                    string str = serial_port_.ReadLine(); //

                    String[] data = str.Split(',');

                    if (3 != data.Length)
                        continue;

                    aileron_current_rx_value  = int.Parse(data[0]);
                    throttle_current_rx_value = int.Parse(data[1]);
                    elevator_current_rx_value = int.Parse(data[2]);

                    if (throttle_current_rx_value < throttle_min_rx_value)
                        throttle_min_rx_value = throttle_current_rx_value;
                    if (throttle_current_rx_value > throttle_max_rx_value)
                        throttle_max_rx_value = throttle_current_rx_value;

                    if (elevator_current_rx_value < elevator_min_rx_value)
                        elevator_min_rx_value = elevator_current_rx_value;
                    if (elevator_current_rx_value > elevator_max_rx_value)
                        elevator_max_rx_value = elevator_current_rx_value;

                    if (aileron_current_rx_value < aileron_min_rx_value)
                        aileron_min_rx_value = aileron_current_rx_value;
                    if (aileron_current_rx_value > aileron_max_rx_value)
                        aileron_max_rx_value = aileron_current_rx_value;

                    update_control_status();
                }
                catch (TimeoutException) { }
                Thread.Sleep(100);
            }
        }

        //Receive from FlightGear
        private UdpClient receiving_UdpClient = null;
        private void receive_from_flightgear()
        {
            receiving_UdpClient = new UdpClient(49001);
            while (true)
            {
                IPEndPoint RemoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);

                Byte[] receiveBytes = receiving_UdpClient.Receive(ref RemoteIpEndPoint);

                string[] data = Encoding.ASCII.GetString(receiveBytes).Split(',');

                throttle_from_fg_value  = float.Parse(data[2]);
                elevator_from_fg_value  = float.Parse(data[1]);
                aileron_from_fg_value   = float.Parse(data[0]);
                airspeed_from_fg_value  = float.Parse(data[3]);

                update_control_status();

                Thread.Sleep(100);
            }
        }

        //Send to FlightGear
        private UdpClient sending_UdpClient = null;
        private void send_to_flightgear()
        {
            sending_UdpClient = new UdpClient();
            while (true)
            {
                string send_data = aileron_current_fg_value.ToString() + "," + elevator_current_fg_value.ToString() + "," + throttle_current_fg_value.ToString() + "\n";

                Byte[] sendBytes = Encoding.ASCII.GetBytes(send_data);
                sending_UdpClient.Send(sendBytes, sendBytes.Length, "127.0.0.1", 49000);
                
                Thread.Sleep(100);
            }
        }
        /*  aileron_max = 1660;
            aileron_min = 1300;
            elevator_max = 1840;
            elevator_min = 1130;
            throttle_max = 1635;
            throttle_min = 1290;
        */

        //Input values
        private float throttle_current_rx_value     = 1500;        
        private float throttle_min_rx_value         = 1500;
        private float throttle_max_rx_value         = 1501;
        private float throttle_current_fg_value     = 0;
        private float throttle_min_fg_value         = 0;
        private float throttle_max_fg_value         = 1;


        private float elevator_current_rx_value     = 1500;        
        private float elevator_min_rx_value         = 1500;
        private float elevator_max_rx_value         = 1501;
        private float elevator_current_fg_value     = 0;
        private float elevator_min_fg_value         = -1;
        private float elevator_max_fg_value         = 1;

        
        private float aileron_current_rx_value      = 1500;
        private float aileron_min_rx_value          = 1500;
        private float aileron_max_rx_value          = 1501;
        private float aileron_current_fg_value      = 0;
        private float aileron_min_fg_value          = -1;
        private float aileron_max_fg_value          = 1;

        //Output Values
        private float throttle_from_fg_value        = 0;
        private float elevator_from_fg_value        = 0;
        private float aileron_from_fg_value         = 0;
        private float airspeed_from_fg_value        = 0;        

        delegate void SetTextCallback();
        private void update_control_status()
        {
            if (this.throttle_current_rx_textBox.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(update_control_status);
                this.Invoke(d, new object[] { });
            }
            else
            {
                //update fg current
                throttle_current_fg_value = throttle_min_fg_value + (throttle_current_rx_value - throttle_min_rx_value) * (throttle_max_fg_value - throttle_min_fg_value) / (throttle_max_rx_value - throttle_min_rx_value);
                elevator_current_fg_value = elevator_min_fg_value + (elevator_current_rx_value - elevator_min_rx_value) * (elevator_max_fg_value - elevator_min_fg_value) / (elevator_max_rx_value - elevator_min_rx_value);
                aileron_current_fg_value = aileron_min_fg_value + (aileron_current_rx_value - aileron_min_rx_value) * (aileron_max_fg_value - aileron_min_fg_value) / (aileron_max_rx_value - aileron_min_rx_value);


                throttle_current_rx_textBox.Text = throttle_current_rx_value.ToString();
                throttle_min_rx_textBox.Text = throttle_min_rx_value.ToString();
                throttle_max_rx_textBox.Text = throttle_max_rx_value.ToString();
                throttle_current_fg_textBox.Text = throttle_current_fg_value.ToString();
                throttle_min_fg_textBox.Text = throttle_min_fg_value.ToString();
                throttle_max_fg_textBox.Text = throttle_max_fg_value.ToString();

                elevator_current_rx_textBox.Text = elevator_current_rx_value.ToString();
                elevator_min_rx_textBox.Text = elevator_min_rx_value.ToString();
                elevator_max_rx_textBox.Text = elevator_max_rx_value.ToString();
                elevator_current_fg_textBox.Text = elevator_current_fg_value.ToString();
                elevator_min_fg_textBox.Text = elevator_min_fg_value.ToString();
                elevator_max_fg_textBox.Text = elevator_max_fg_value.ToString();

                aileron_current_rx_textBox.Text = aileron_current_rx_value.ToString();
                aileron_min_rx_textBox.Text = aileron_min_rx_value.ToString();
                aileron_max_rx_textBox.Text = aileron_max_rx_value.ToString();
                aileron_current_fg_textBox.Text = aileron_current_fg_value.ToString();
                aileron_min_fg_textBox.Text = aileron_min_fg_value.ToString();
                aileron_max_fg_textBox.Text = aileron_max_fg_value.ToString();

                throttle_recv_textBox.Text = throttle_from_fg_value.ToString();
                elevator_recv_textBox.Text = elevator_from_fg_value.ToString();
                aileron_recv_textBox.Text  = aileron_from_fg_value.ToString();
                airspeed_recv_textBox.Text = airspeed_from_fg_value.ToString();

            }
        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            throttle_current_rx_value   = 1500;
            throttle_min_rx_value       = 1500;
            throttle_max_rx_value       = 1501;
            throttle_current_fg_value   = 0;
            throttle_min_fg_value       = 0;
            throttle_max_fg_value       = 1;

            elevator_current_rx_value   = 1500;
            elevator_min_rx_value       = 1500;
            elevator_max_rx_value       = 1501;
            elevator_current_fg_value   = 0;
            elevator_min_fg_value       = -1;
            elevator_max_fg_value       = 1;

            aileron_current_rx_value    = 1500;
            aileron_min_rx_value        = 1500;
            aileron_max_rx_value        = 1501;
            aileron_current_fg_value    = 0;
            aileron_min_fg_value        = -1;
            aileron_max_fg_value        = 1;

            throttle_from_fg_value      = 0;
            elevator_from_fg_value      = 0;
            aileron_from_fg_value       = 0;
            airspeed_from_fg_value      = 0; 

            update_control_status();
        }

        private void calibrate_button_Click(object sender, EventArgs e)
        {
            if (null == thread_calibrate_from_serial_port_)
            {
                if (-1 == portlist_comboBox.SelectedIndex)
                {
                    MessageBox.Show("Select Com port");
                    return;
                }
                string port_name = portlist_comboBox.SelectedItem.ToString(); // get serial port name
                serial_port_ = new SerialPort(port_name, 9600); // set port name and speed 9600 bits/second
                serial_port_.Open(); // connect to port

                thread_calibrate_from_serial_port_ = new Thread(calibrate_from_serial);
                thread_calibrate_from_serial_port_.Start();
                calibrate_button.Text = "Finish Calibrating";

                connect_serial_button.Enabled = false;
                reset_button.Enabled = false;
            }
            else
            {
                thread_calibrate_from_serial_port_.Abort();
                thread_calibrate_from_serial_port_ = null;
                calibrate_button.Text = "Calibrate";

                connect_serial_button.Enabled = true;
                reset_button.Enabled = true;

                serial_port_.Close();
                serial_port_ = null;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (null != thread_receive_from_flightgear_)
            {
                receiving_UdpClient.Close();
                receiving_UdpClient = null;

                thread_receive_from_flightgear_.Abort();
                thread_receive_from_flightgear_ = null;
            }
            
            if (null != thread_send_to_flightgear_)
            {
                sending_UdpClient.Close();
                sending_UdpClient = null;

                thread_send_to_flightgear_.Abort();
                thread_send_to_flightgear_ = null;
            }
            
            if (null != thread_receive_from_serial_port_)
            {
                thread_receive_from_serial_port_.Abort();
                thread_receive_from_serial_port_ = null;

                serial_port_.Close();
                serial_port_ = null;
            }

            if (null != thread_calibrate_from_serial_port_)
            {
                thread_calibrate_from_serial_port_.Abort();
                thread_calibrate_from_serial_port_ = null;

                serial_port_.Close();
                serial_port_ = null;
            }
        }
    }
}
