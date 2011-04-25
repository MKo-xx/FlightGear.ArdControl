namespace Flightgear.Control
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.throttle_trackBar = new System.Windows.Forms.TrackBar();
            this.throttle_label = new System.Windows.Forms.Label();
            this.throttle_current_fg_textBox = new System.Windows.Forms.TextBox();
            this.elevator_current_fg_textBox = new System.Windows.Forms.TextBox();
            this.elevator_label = new System.Windows.Forms.Label();
            this.elevator_trackBar = new System.Windows.Forms.TrackBar();
            this.aileron_current_fg_textBox = new System.Windows.Forms.TextBox();
            this.aileron_label = new System.Windows.Forms.Label();
            this.aileron_trackBar = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.connect_fg_receive_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.airspeed_recv_textBox = new System.Windows.Forms.TextBox();
            this.aileron_recv_textBox = new System.Windows.Forms.TextBox();
            this.elevator_recv_textBox = new System.Windows.Forms.TextBox();
            this.throttle_recv_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.airspeed_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.refresh_button = new System.Windows.Forms.Button();
            this.connect_serial_button = new System.Windows.Forms.Button();
            this.portlist_comboBox = new System.Windows.Forms.ComboBox();
            this.reset_button = new System.Windows.Forms.Button();
            this.calibrate_button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.connect_fg_send_button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.aileron_max_rx_textBox = new System.Windows.Forms.TextBox();
            this.aileron_min_rx_textBox = new System.Windows.Forms.TextBox();
            this.aileron_max_fg_textBox = new System.Windows.Forms.TextBox();
            this.aileron_min_fg_textBox = new System.Windows.Forms.TextBox();
            this.aileron_current_rx_textBox = new System.Windows.Forms.TextBox();
            this.elevator_max_rx_textBox = new System.Windows.Forms.TextBox();
            this.elevator_min_rx_textBox = new System.Windows.Forms.TextBox();
            this.elevator_max_fg_textBox = new System.Windows.Forms.TextBox();
            this.elevator_min_fg_textBox = new System.Windows.Forms.TextBox();
            this.elevator_current_rx_textBox = new System.Windows.Forms.TextBox();
            this.throttle_max_rx_textBox = new System.Windows.Forms.TextBox();
            this.throttle_min_rx_textBox = new System.Windows.Forms.TextBox();
            this.throttle_max_fg_textBox = new System.Windows.Forms.TextBox();
            this.throttle_min_fg_textBox = new System.Windows.Forms.TextBox();
            this.throttle_current_rx_textBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.throttle_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevator_trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aileron_trackBar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // throttle_trackBar
            // 
            this.throttle_trackBar.Location = new System.Drawing.Point(83, 27);
            this.throttle_trackBar.Name = "throttle_trackBar";
            this.throttle_trackBar.Size = new System.Drawing.Size(234, 45);
            this.throttle_trackBar.TabIndex = 1;
            // 
            // throttle_label
            // 
            this.throttle_label.AutoSize = true;
            this.throttle_label.Location = new System.Drawing.Point(3, 24);
            this.throttle_label.Name = "throttle_label";
            this.throttle_label.Size = new System.Drawing.Size(43, 13);
            this.throttle_label.TabIndex = 2;
            this.throttle_label.Text = "Throttle";
            // 
            // throttle_current_fg_textBox
            // 
            this.throttle_current_fg_textBox.Location = new System.Drawing.Point(323, 27);
            this.throttle_current_fg_textBox.Name = "throttle_current_fg_textBox";
            this.throttle_current_fg_textBox.ReadOnly = true;
            this.throttle_current_fg_textBox.Size = new System.Drawing.Size(74, 20);
            this.throttle_current_fg_textBox.TabIndex = 9;
            // 
            // elevator_current_fg_textBox
            // 
            this.elevator_current_fg_textBox.Location = new System.Drawing.Point(323, 99);
            this.elevator_current_fg_textBox.Name = "elevator_current_fg_textBox";
            this.elevator_current_fg_textBox.ReadOnly = true;
            this.elevator_current_fg_textBox.Size = new System.Drawing.Size(74, 20);
            this.elevator_current_fg_textBox.TabIndex = 17;
            // 
            // elevator_label
            // 
            this.elevator_label.AutoSize = true;
            this.elevator_label.Location = new System.Drawing.Point(3, 96);
            this.elevator_label.Name = "elevator_label";
            this.elevator_label.Size = new System.Drawing.Size(46, 13);
            this.elevator_label.TabIndex = 16;
            this.elevator_label.Text = "Elevator";
            // 
            // elevator_trackBar
            // 
            this.elevator_trackBar.Location = new System.Drawing.Point(83, 99);
            this.elevator_trackBar.Maximum = 20;
            this.elevator_trackBar.Name = "elevator_trackBar";
            this.elevator_trackBar.Size = new System.Drawing.Size(234, 45);
            this.elevator_trackBar.TabIndex = 15;
            // 
            // aileron_current_fg_textBox
            // 
            this.aileron_current_fg_textBox.Location = new System.Drawing.Point(323, 171);
            this.aileron_current_fg_textBox.Name = "aileron_current_fg_textBox";
            this.aileron_current_fg_textBox.ReadOnly = true;
            this.aileron_current_fg_textBox.Size = new System.Drawing.Size(74, 20);
            this.aileron_current_fg_textBox.TabIndex = 22;
            // 
            // aileron_label
            // 
            this.aileron_label.AutoSize = true;
            this.aileron_label.Location = new System.Drawing.Point(3, 168);
            this.aileron_label.Name = "aileron_label";
            this.aileron_label.Size = new System.Drawing.Size(39, 13);
            this.aileron_label.TabIndex = 21;
            this.aileron_label.Text = "Aileron";
            // 
            // aileron_trackBar
            // 
            this.aileron_trackBar.Location = new System.Drawing.Point(83, 171);
            this.aileron_trackBar.Maximum = 20;
            this.aileron_trackBar.Name = "aileron_trackBar";
            this.aileron_trackBar.Size = new System.Drawing.Size(234, 45);
            this.aileron_trackBar.TabIndex = 20;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.connect_fg_receive_button);
            this.groupBox1.Controls.Add(this.tableLayoutPanel2);
            this.groupBox1.Location = new System.Drawing.Point(2, 408);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 193);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // connect_fg_receive_button
            // 
            this.connect_fg_receive_button.Location = new System.Drawing.Point(45, 19);
            this.connect_fg_receive_button.Name = "connect_fg_receive_button";
            this.connect_fg_receive_button.Size = new System.Drawing.Size(85, 23);
            this.connect_fg_receive_button.TabIndex = 35;
            this.connect_fg_receive_button.Text = "Connect";
            this.connect_fg_receive_button.UseVisualStyleBackColor = true;
            this.connect_fg_receive_button.Click += new System.EventHandler(this.connect_fg_receive_button_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.airspeed_recv_textBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.aileron_recv_textBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.elevator_recv_textBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.throttle_recv_textBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.airspeed_label, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(23, 55);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(230, 132);
            this.tableLayoutPanel2.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 28;
            this.label1.Text = "throttle";
            // 
            // airspeed_recv_textBox
            // 
            this.airspeed_recv_textBox.Location = new System.Drawing.Point(118, 102);
            this.airspeed_recv_textBox.Name = "airspeed_recv_textBox";
            this.airspeed_recv_textBox.ReadOnly = true;
            this.airspeed_recv_textBox.Size = new System.Drawing.Size(100, 20);
            this.airspeed_recv_textBox.TabIndex = 23;
            // 
            // aileron_recv_textBox
            // 
            this.aileron_recv_textBox.Location = new System.Drawing.Point(118, 69);
            this.aileron_recv_textBox.Name = "aileron_recv_textBox";
            this.aileron_recv_textBox.ReadOnly = true;
            this.aileron_recv_textBox.Size = new System.Drawing.Size(100, 20);
            this.aileron_recv_textBox.TabIndex = 24;
            // 
            // elevator_recv_textBox
            // 
            this.elevator_recv_textBox.Location = new System.Drawing.Point(118, 36);
            this.elevator_recv_textBox.Name = "elevator_recv_textBox";
            this.elevator_recv_textBox.ReadOnly = true;
            this.elevator_recv_textBox.Size = new System.Drawing.Size(100, 20);
            this.elevator_recv_textBox.TabIndex = 25;
            // 
            // throttle_recv_textBox
            // 
            this.throttle_recv_textBox.Location = new System.Drawing.Point(118, 3);
            this.throttle_recv_textBox.Name = "throttle_recv_textBox";
            this.throttle_recv_textBox.ReadOnly = true;
            this.throttle_recv_textBox.Size = new System.Drawing.Size(100, 20);
            this.throttle_recv_textBox.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 30;
            this.label3.Text = "aileron";
            // 
            // airspeed_label
            // 
            this.airspeed_label.AutoSize = true;
            this.airspeed_label.Location = new System.Drawing.Point(3, 99);
            this.airspeed_label.Name = "airspeed_label";
            this.airspeed_label.Size = new System.Drawing.Size(47, 13);
            this.airspeed_label.TabIndex = 26;
            this.airspeed_label.Text = "airspeed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "elevator";
            // 
            // refresh_button
            // 
            this.refresh_button.Location = new System.Drawing.Point(6, 19);
            this.refresh_button.Name = "refresh_button";
            this.refresh_button.Size = new System.Drawing.Size(57, 28);
            this.refresh_button.TabIndex = 27;
            this.refresh_button.Text = "Refresh";
            this.refresh_button.UseVisualStyleBackColor = true;
            this.refresh_button.Click += new System.EventHandler(this.refresh_button_Click);
            // 
            // connect_serial_button
            // 
            this.connect_serial_button.Location = new System.Drawing.Point(196, 17);
            this.connect_serial_button.Name = "connect_serial_button";
            this.connect_serial_button.Size = new System.Drawing.Size(80, 28);
            this.connect_serial_button.TabIndex = 28;
            this.connect_serial_button.Text = "Connect";
            this.connect_serial_button.UseVisualStyleBackColor = true;
            this.connect_serial_button.Click += new System.EventHandler(this.connect_serial_button_Click);
            // 
            // portlist_comboBox
            // 
            this.portlist_comboBox.FormattingEnabled = true;
            this.portlist_comboBox.Location = new System.Drawing.Point(69, 24);
            this.portlist_comboBox.Name = "portlist_comboBox";
            this.portlist_comboBox.Size = new System.Drawing.Size(121, 21);
            this.portlist_comboBox.TabIndex = 29;
            // 
            // reset_button
            // 
            this.reset_button.Location = new System.Drawing.Point(18, 29);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(75, 23);
            this.reset_button.TabIndex = 30;
            this.reset_button.Text = "Reset";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // calibrate_button
            // 
            this.calibrate_button.Location = new System.Drawing.Point(296, 17);
            this.calibrate_button.Name = "calibrate_button";
            this.calibrate_button.Size = new System.Drawing.Size(121, 28);
            this.calibrate_button.TabIndex = 31;
            this.calibrate_button.Text = "Calibrate";
            this.calibrate_button.UseVisualStyleBackColor = true;
            this.calibrate_button.Click += new System.EventHandler(this.calibrate_button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.refresh_button);
            this.groupBox2.Controls.Add(this.portlist_comboBox);
            this.groupBox2.Controls.Add(this.connect_serial_button);
            this.groupBox2.Controls.Add(this.calibrate_button);
            this.groupBox2.Location = new System.Drawing.Point(2, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(516, 64);
            this.groupBox2.TabIndex = 32;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serial port";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.connect_fg_send_button);
            this.groupBox3.Controls.Add(this.tableLayoutPanel1);
            this.groupBox3.Controls.Add(this.reset_button);
            this.groupBox3.Location = new System.Drawing.Point(2, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(823, 320);
            this.groupBox3.TabIndex = 33;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input";
            // 
            // connect_fg_send_button
            // 
            this.connect_fg_send_button.Location = new System.Drawing.Point(201, 29);
            this.connect_fg_send_button.Name = "connect_fg_send_button";
            this.connect_fg_send_button.Size = new System.Drawing.Size(87, 23);
            this.connect_fg_send_button.TabIndex = 34;
            this.connect_fg_send_button.Text = "Connect";
            this.connect_fg_send_button.UseVisualStyleBackColor = true;
            this.connect_fg_send_button.Click += new System.EventHandler(this.connect_fg_send_button_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 8;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.aileron_max_rx_textBox, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.aileron_min_rx_textBox, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.aileron_max_fg_textBox, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.aileron_min_fg_textBox, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.aileron_current_rx_textBox, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.elevator_max_rx_textBox, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.elevator_min_rx_textBox, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.elevator_max_fg_textBox, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.elevator_min_fg_textBox, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.elevator_current_rx_textBox, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.throttle_max_rx_textBox, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.throttle_min_rx_textBox, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.throttle_max_fg_textBox, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.throttle_min_fg_textBox, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.throttle_current_rx_textBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label11, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.elevator_trackBar, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label7, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.aileron_current_fg_textBox, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.throttle_current_fg_textBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.elevator_current_fg_textBox, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.throttle_label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.aileron_trackBar, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.elevator_label, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.aileron_label, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.throttle_trackBar, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.label10, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 67);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 240);
            this.tableLayoutPanel1.TabIndex = 34;
            // 
            // aileron_max_rx_textBox
            // 
            this.aileron_max_rx_textBox.Location = new System.Drawing.Point(723, 171);
            this.aileron_max_rx_textBox.Name = "aileron_max_rx_textBox";
            this.aileron_max_rx_textBox.ReadOnly = true;
            this.aileron_max_rx_textBox.Size = new System.Drawing.Size(74, 20);
            this.aileron_max_rx_textBox.TabIndex = 53;
            // 
            // aileron_min_rx_textBox
            // 
            this.aileron_min_rx_textBox.Location = new System.Drawing.Point(643, 171);
            this.aileron_min_rx_textBox.Name = "aileron_min_rx_textBox";
            this.aileron_min_rx_textBox.ReadOnly = true;
            this.aileron_min_rx_textBox.Size = new System.Drawing.Size(74, 20);
            this.aileron_min_rx_textBox.TabIndex = 52;
            // 
            // aileron_max_fg_textBox
            // 
            this.aileron_max_fg_textBox.Location = new System.Drawing.Point(563, 171);
            this.aileron_max_fg_textBox.Name = "aileron_max_fg_textBox";
            this.aileron_max_fg_textBox.ReadOnly = true;
            this.aileron_max_fg_textBox.Size = new System.Drawing.Size(74, 20);
            this.aileron_max_fg_textBox.TabIndex = 51;
            // 
            // aileron_min_fg_textBox
            // 
            this.aileron_min_fg_textBox.Location = new System.Drawing.Point(483, 171);
            this.aileron_min_fg_textBox.Name = "aileron_min_fg_textBox";
            this.aileron_min_fg_textBox.ReadOnly = true;
            this.aileron_min_fg_textBox.Size = new System.Drawing.Size(74, 20);
            this.aileron_min_fg_textBox.TabIndex = 50;
            // 
            // aileron_current_rx_textBox
            // 
            this.aileron_current_rx_textBox.Location = new System.Drawing.Point(403, 171);
            this.aileron_current_rx_textBox.Name = "aileron_current_rx_textBox";
            this.aileron_current_rx_textBox.ReadOnly = true;
            this.aileron_current_rx_textBox.Size = new System.Drawing.Size(74, 20);
            this.aileron_current_rx_textBox.TabIndex = 49;
            // 
            // elevator_max_rx_textBox
            // 
            this.elevator_max_rx_textBox.Location = new System.Drawing.Point(723, 99);
            this.elevator_max_rx_textBox.Name = "elevator_max_rx_textBox";
            this.elevator_max_rx_textBox.ReadOnly = true;
            this.elevator_max_rx_textBox.Size = new System.Drawing.Size(74, 20);
            this.elevator_max_rx_textBox.TabIndex = 48;
            // 
            // elevator_min_rx_textBox
            // 
            this.elevator_min_rx_textBox.Location = new System.Drawing.Point(643, 99);
            this.elevator_min_rx_textBox.Name = "elevator_min_rx_textBox";
            this.elevator_min_rx_textBox.ReadOnly = true;
            this.elevator_min_rx_textBox.Size = new System.Drawing.Size(74, 20);
            this.elevator_min_rx_textBox.TabIndex = 47;
            // 
            // elevator_max_fg_textBox
            // 
            this.elevator_max_fg_textBox.Location = new System.Drawing.Point(563, 99);
            this.elevator_max_fg_textBox.Name = "elevator_max_fg_textBox";
            this.elevator_max_fg_textBox.ReadOnly = true;
            this.elevator_max_fg_textBox.Size = new System.Drawing.Size(74, 20);
            this.elevator_max_fg_textBox.TabIndex = 46;
            // 
            // elevator_min_fg_textBox
            // 
            this.elevator_min_fg_textBox.Location = new System.Drawing.Point(483, 99);
            this.elevator_min_fg_textBox.Name = "elevator_min_fg_textBox";
            this.elevator_min_fg_textBox.ReadOnly = true;
            this.elevator_min_fg_textBox.Size = new System.Drawing.Size(74, 20);
            this.elevator_min_fg_textBox.TabIndex = 45;
            // 
            // elevator_current_rx_textBox
            // 
            this.elevator_current_rx_textBox.Location = new System.Drawing.Point(403, 99);
            this.elevator_current_rx_textBox.Name = "elevator_current_rx_textBox";
            this.elevator_current_rx_textBox.ReadOnly = true;
            this.elevator_current_rx_textBox.Size = new System.Drawing.Size(74, 20);
            this.elevator_current_rx_textBox.TabIndex = 44;
            // 
            // throttle_max_rx_textBox
            // 
            this.throttle_max_rx_textBox.Location = new System.Drawing.Point(723, 27);
            this.throttle_max_rx_textBox.Name = "throttle_max_rx_textBox";
            this.throttle_max_rx_textBox.ReadOnly = true;
            this.throttle_max_rx_textBox.Size = new System.Drawing.Size(74, 20);
            this.throttle_max_rx_textBox.TabIndex = 43;
            // 
            // throttle_min_rx_textBox
            // 
            this.throttle_min_rx_textBox.Location = new System.Drawing.Point(643, 27);
            this.throttle_min_rx_textBox.Name = "throttle_min_rx_textBox";
            this.throttle_min_rx_textBox.ReadOnly = true;
            this.throttle_min_rx_textBox.Size = new System.Drawing.Size(74, 20);
            this.throttle_min_rx_textBox.TabIndex = 42;
            // 
            // throttle_max_fg_textBox
            // 
            this.throttle_max_fg_textBox.Location = new System.Drawing.Point(563, 27);
            this.throttle_max_fg_textBox.Name = "throttle_max_fg_textBox";
            this.throttle_max_fg_textBox.ReadOnly = true;
            this.throttle_max_fg_textBox.Size = new System.Drawing.Size(74, 20);
            this.throttle_max_fg_textBox.TabIndex = 41;
            // 
            // throttle_min_fg_textBox
            // 
            this.throttle_min_fg_textBox.Location = new System.Drawing.Point(483, 27);
            this.throttle_min_fg_textBox.Name = "throttle_min_fg_textBox";
            this.throttle_min_fg_textBox.ReadOnly = true;
            this.throttle_min_fg_textBox.Size = new System.Drawing.Size(74, 20);
            this.throttle_min_fg_textBox.TabIndex = 40;
            // 
            // throttle_current_rx_textBox
            // 
            this.throttle_current_rx_textBox.Location = new System.Drawing.Point(403, 27);
            this.throttle_current_rx_textBox.Name = "throttle_current_rx_textBox";
            this.throttle_current_rx_textBox.ReadOnly = true;
            this.throttle_current_rx_textBox.Size = new System.Drawing.Size(74, 20);
            this.throttle_current_rx_textBox.TabIndex = 39;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(403, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Current RX";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(323, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 13);
            this.label7.TabIndex = 38;
            this.label7.Text = "Current FG";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 37;
            this.label6.Text = "Current";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "Control";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(723, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(69, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Maximum RX";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(643, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Minimum RX";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(563, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Maximum FG";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(483, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 36;
            this.label5.Text = "Minimum FG";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 646);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.throttle_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.elevator_trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aileron_trackBar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TrackBar throttle_trackBar;
        private System.Windows.Forms.Label throttle_label;
        private System.Windows.Forms.TextBox throttle_current_fg_textBox;
        private System.Windows.Forms.TextBox elevator_current_fg_textBox;
        private System.Windows.Forms.Label elevator_label;
        private System.Windows.Forms.TrackBar elevator_trackBar;
        private System.Windows.Forms.TextBox aileron_current_fg_textBox;
        private System.Windows.Forms.Label aileron_label;
        private System.Windows.Forms.TrackBar aileron_trackBar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label airspeed_label;
        private System.Windows.Forms.TextBox elevator_recv_textBox;
        private System.Windows.Forms.TextBox aileron_recv_textBox;
        private System.Windows.Forms.TextBox airspeed_recv_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox throttle_recv_textBox;
        private System.Windows.Forms.Button refresh_button;
        private System.Windows.Forms.Button connect_serial_button;
        private System.Windows.Forms.ComboBox portlist_comboBox;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.Button calibrate_button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox aileron_max_rx_textBox;
        private System.Windows.Forms.TextBox aileron_min_rx_textBox;
        private System.Windows.Forms.TextBox aileron_max_fg_textBox;
        private System.Windows.Forms.TextBox aileron_min_fg_textBox;
        private System.Windows.Forms.TextBox aileron_current_rx_textBox;
        private System.Windows.Forms.TextBox elevator_max_rx_textBox;
        private System.Windows.Forms.TextBox elevator_min_rx_textBox;
        private System.Windows.Forms.TextBox elevator_max_fg_textBox;
        private System.Windows.Forms.TextBox elevator_min_fg_textBox;
        private System.Windows.Forms.TextBox elevator_current_rx_textBox;
        private System.Windows.Forms.TextBox throttle_max_rx_textBox;
        private System.Windows.Forms.TextBox throttle_min_rx_textBox;
        private System.Windows.Forms.TextBox throttle_max_fg_textBox;
        private System.Windows.Forms.TextBox throttle_min_fg_textBox;
        private System.Windows.Forms.TextBox throttle_current_rx_textBox;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Button connect_fg_send_button;
        private System.Windows.Forms.Button connect_fg_receive_button;
    }
}

