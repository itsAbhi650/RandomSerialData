namespace RandomSerialData
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
            this.Btn_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CmbBx_Port = new System.Windows.Forms.ComboBox();
            this.Btn_Connect = new System.Windows.Forms.Button();
            this.CmbBx_StpBit = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CmbBx_Parity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NUD_RBT = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Pnl_PortControl = new System.Windows.Forms.Panel();
            this.NUD_Timeout = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.CmbBx_DatBit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.CmbBx_Baud = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.NUD_ToRand = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.NUD_FromRand = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_RBT)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Pnl_PortControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Timeout)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_ToRand)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_FromRand)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Start
            // 
            this.Btn_Start.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Start.Enabled = false;
            this.Btn_Start.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Start.Location = new System.Drawing.Point(456, 13);
            this.Btn_Start.Name = "Btn_Start";
            this.Btn_Start.Size = new System.Drawing.Size(83, 49);
            this.Btn_Start.TabIndex = 0;
            this.Btn_Start.Text = "Start";
            this.Btn_Start.UseVisualStyleBackColor = true;
            this.Btn_Start.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Close Client for a timeout event";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.textBox1.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Lime;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(539, 205);
            this.textBox1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Port";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CmbBx_Port
            // 
            this.CmbBx_Port.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBx_Port.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBx_Port.FormattingEnabled = true;
            this.CmbBx_Port.Location = new System.Drawing.Point(12, 21);
            this.CmbBx_Port.Name = "CmbBx_Port";
            this.CmbBx_Port.Size = new System.Drawing.Size(61, 21);
            this.CmbBx_Port.TabIndex = 4;
            // 
            // Btn_Connect
            // 
            this.Btn_Connect.Dock = System.Windows.Forms.DockStyle.Right;
            this.Btn_Connect.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Connect.Location = new System.Drawing.Point(456, 13);
            this.Btn_Connect.Name = "Btn_Connect";
            this.Btn_Connect.Padding = new System.Windows.Forms.Padding(3);
            this.Btn_Connect.Size = new System.Drawing.Size(83, 49);
            this.Btn_Connect.TabIndex = 5;
            this.Btn_Connect.Text = "Connect";
            this.Btn_Connect.UseVisualStyleBackColor = true;
            this.Btn_Connect.Click += new System.EventHandler(this.Btn_Connect_Click);
            // 
            // CmbBx_StpBit
            // 
            this.CmbBx_StpBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBx_StpBit.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBx_StpBit.FormattingEnabled = true;
            this.CmbBx_StpBit.Location = new System.Drawing.Point(213, 21);
            this.CmbBx_StpBit.Name = "CmbBx_StpBit";
            this.CmbBx_StpBit.Size = new System.Drawing.Size(99, 21);
            this.CmbBx_StpBit.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Stop Bits";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CmbBx_Parity
            // 
            this.CmbBx_Parity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBx_Parity.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBx_Parity.FormattingEnabled = true;
            this.CmbBx_Parity.Location = new System.Drawing.Point(146, 21);
            this.CmbBx_Parity.Name = "CmbBx_Parity";
            this.CmbBx_Parity.Size = new System.Drawing.Size(61, 21);
            this.CmbBx_Parity.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(143, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Parity";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(315, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data Bits";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(280, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "RBT";
            this.label6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // NUD_RBT
            // 
            this.NUD_RBT.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_RBT.Location = new System.Drawing.Point(286, 37);
            this.NUD_RBT.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.NUD_RBT.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_RBT.Name = "NUD_RBT";
            this.NUD_RBT.Size = new System.Drawing.Size(52, 20);
            this.NUD_RBT.TabIndex = 13;
            this.NUD_RBT.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Pnl_PortControl);
            this.groupBox1.Controls.Add(this.Btn_Connect);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 205);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox1.Size = new System.Drawing.Size(539, 62);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Port Settings";
            // 
            // Pnl_PortControl
            // 
            this.Pnl_PortControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Pnl_PortControl.Controls.Add(this.NUD_Timeout);
            this.Pnl_PortControl.Controls.Add(this.label8);
            this.Pnl_PortControl.Controls.Add(this.CmbBx_DatBit);
            this.Pnl_PortControl.Controls.Add(this.label7);
            this.Pnl_PortControl.Controls.Add(this.CmbBx_Baud);
            this.Pnl_PortControl.Controls.Add(this.label2);
            this.Pnl_PortControl.Controls.Add(this.CmbBx_Port);
            this.Pnl_PortControl.Controls.Add(this.CmbBx_Parity);
            this.Pnl_PortControl.Controls.Add(this.label4);
            this.Pnl_PortControl.Controls.Add(this.CmbBx_StpBit);
            this.Pnl_PortControl.Controls.Add(this.label3);
            this.Pnl_PortControl.Controls.Add(this.label5);
            this.Pnl_PortControl.Dock = System.Windows.Forms.DockStyle.Left;
            this.Pnl_PortControl.Location = new System.Drawing.Point(0, 13);
            this.Pnl_PortControl.Name = "Pnl_PortControl";
            this.Pnl_PortControl.Size = new System.Drawing.Size(450, 49);
            this.Pnl_PortControl.TabIndex = 15;
            // 
            // NUD_Timeout
            // 
            this.NUD_Timeout.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_Timeout.Location = new System.Drawing.Point(385, 22);
            this.NUD_Timeout.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.NUD_Timeout.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Timeout.Name = "NUD_Timeout";
            this.NUD_Timeout.Size = new System.Drawing.Size(56, 20);
            this.NUD_Timeout.TabIndex = 19;
            this.NUD_Timeout.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(382, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Timeout";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CmbBx_DatBit
            // 
            this.CmbBx_DatBit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBx_DatBit.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBx_DatBit.FormattingEnabled = true;
            this.CmbBx_DatBit.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.CmbBx_DatBit.Location = new System.Drawing.Point(318, 21);
            this.CmbBx_DatBit.Name = "CmbBx_DatBit";
            this.CmbBx_DatBit.Size = new System.Drawing.Size(61, 21);
            this.CmbBx_DatBit.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(76, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Baud";
            this.label7.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // CmbBx_Baud
            // 
            this.CmbBx_Baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbBx_Baud.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbBx_Baud.FormattingEnabled = true;
            this.CmbBx_Baud.Items.AddRange(new object[] {
            "110",
            "150",
            "300",
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200",
            "230400",
            "460800",
            "921600"});
            this.CmbBx_Baud.Location = new System.Drawing.Point(79, 21);
            this.CmbBx_Baud.Name = "CmbBx_Baud";
            this.CmbBx_Baud.Size = new System.Drawing.Size(61, 21);
            this.CmbBx_Baud.TabIndex = 14;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Start);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.NUD_RBT);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(0, 267);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(0);
            this.groupBox2.Size = new System.Drawing.Size(539, 62);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Randomizer";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.NUD_ToRand);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.NUD_FromRand);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 49);
            this.panel1.TabIndex = 16;
            // 
            // NUD_ToRand
            // 
            this.NUD_ToRand.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_ToRand.Location = new System.Drawing.Point(70, 23);
            this.NUD_ToRand.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.NUD_ToRand.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_ToRand.Name = "NUD_ToRand";
            this.NUD_ToRand.Size = new System.Drawing.Size(52, 20);
            this.NUD_ToRand.TabIndex = 17;
            this.NUD_ToRand.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.Control;
            this.label10.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(67, 7);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "To";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // NUD_FromRand
            // 
            this.NUD_FromRand.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NUD_FromRand.Location = new System.Drawing.Point(12, 23);
            this.NUD_FromRand.Maximum = new decimal(new int[] {
            1024,
            0,
            0,
            0});
            this.NUD_FromRand.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_FromRand.Name = "NUD_FromRand";
            this.NUD_FromRand.Size = new System.Drawing.Size(52, 20);
            this.NUD_FromRand.TabIndex = 15;
            this.NUD_FromRand.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_FromRand.ValueChanged += new System.EventHandler(this.NUD_FromRand_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "From";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 342);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "RandomSerialData";
            ((System.ComponentModel.ISupportInitialize)(this.NUD_RBT)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.Pnl_PortControl.ResumeLayout(false);
            this.Pnl_PortControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Timeout)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_ToRand)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_FromRand)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CmbBx_Port;
        private System.Windows.Forms.Button Btn_Connect;
        private System.Windows.Forms.ComboBox CmbBx_StpBit;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CmbBx_Parity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown NUD_RBT;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel Pnl_PortControl;
        private System.Windows.Forms.ComboBox CmbBx_Baud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox CmbBx_DatBit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown NUD_Timeout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NumericUpDown NUD_ToRand;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown NUD_FromRand;
        private System.Windows.Forms.Label label9;
    }
}

