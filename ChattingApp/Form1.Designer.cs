namespace ChattingApp
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
            this.components = new System.ComponentModel.Container();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.panelControl = new System.Windows.Forms.Panel();
            this.buttoMinimaze = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panelConfig = new System.Windows.Forms.Panel();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonExpand = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbClient2Port = new ns1.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbClient2Ip = new ns1.BunifuMaterialTextbox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbClient1Port = new ns1.BunifuMaterialTextbox();
            this.LabelPort = new System.Windows.Forms.Label();
            this.tbClient1Ip = new ns1.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            this.listBoxChat = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxChat = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelControl.SuspendLayout();
            this.panelConfig.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // panelControl
            // 
            this.panelControl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.panelControl.Controls.Add(this.buttoMinimaze);
            this.panelControl.Controls.Add(this.buttonClose);
            this.panelControl.Controls.Add(this.label1);
            this.panelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl.Location = new System.Drawing.Point(0, 0);
            this.panelControl.Name = "panelControl";
            this.panelControl.Size = new System.Drawing.Size(324, 29);
            this.panelControl.TabIndex = 0;
            // 
            // buttoMinimaze
            // 
            this.buttoMinimaze.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttoMinimaze.FlatAppearance.BorderSize = 0;
            this.buttoMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttoMinimaze.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttoMinimaze.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttoMinimaze.Location = new System.Drawing.Point(252, 0);
            this.buttoMinimaze.Name = "buttoMinimaze";
            this.buttoMinimaze.Size = new System.Drawing.Size(36, 29);
            this.buttoMinimaze.TabIndex = 2;
            this.buttoMinimaze.Text = "-";
            this.buttoMinimaze.UseVisualStyleBackColor = true;
            this.buttoMinimaze.Click += new System.EventHandler(this.buttoMinimaze_Click);
            // 
            // buttonClose
            // 
            this.buttonClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClose.FlatAppearance.BorderSize = 0;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.buttonClose.ForeColor = System.Drawing.Color.FloralWhite;
            this.buttonClose.Location = new System.Drawing.Point(288, 0);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(36, 29);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "X";
            this.buttonClose.UseVisualStyleBackColor = true;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aplikasi Chatting Lokal";
            // 
            // panelConfig
            // 
            this.panelConfig.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.panelConfig.Controls.Add(this.buttonSave);
            this.panelConfig.Controls.Add(this.buttonExpand);
            this.panelConfig.Controls.Add(this.groupBox2);
            this.panelConfig.Controls.Add(this.groupBox1);
            this.panelConfig.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelConfig.Location = new System.Drawing.Point(0, 29);
            this.panelConfig.Name = "panelConfig";
            this.panelConfig.Size = new System.Drawing.Size(324, 33);
            this.panelConfig.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.Color.CadetBlue;
            this.buttonSave.FlatAppearance.BorderSize = 0;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.White;
            this.buttonSave.Location = new System.Drawing.Point(0, 211);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(324, 23);
            this.buttonSave.TabIndex = 6;
            this.buttonSave.Text = "Connect";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonExpand
            // 
            this.buttonExpand.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.buttonExpand.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonExpand.FlatAppearance.BorderSize = 0;
            this.buttonExpand.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExpand.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExpand.ForeColor = System.Drawing.Color.White;
            this.buttonExpand.Location = new System.Drawing.Point(0, 10);
            this.buttonExpand.Name = "buttonExpand";
            this.buttonExpand.Size = new System.Drawing.Size(324, 23);
            this.buttonExpand.TabIndex = 2;
            this.buttonExpand.Text = "Configuration";
            this.buttonExpand.UseVisualStyleBackColor = false;
            this.buttonExpand.Click += new System.EventHandler(this.buttonExpand_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbClient2Port);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.tbClient2Ip);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(20, 98);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(279, 84);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Client 2";
            // 
            // tbClient2Port
            // 
            this.tbClient2Port.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbClient2Port.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClient2Port.ForeColor = System.Drawing.Color.White;
            this.tbClient2Port.HintForeColor = System.Drawing.Color.White;
            this.tbClient2Port.HintText = "";
            this.tbClient2Port.isPassword = false;
            this.tbClient2Port.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbClient2Port.LineIdleColor = System.Drawing.Color.Gray;
            this.tbClient2Port.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbClient2Port.LineThickness = 2;
            this.tbClient2Port.Location = new System.Drawing.Point(173, 30);
            this.tbClient2Port.Margin = new System.Windows.Forms.Padding(4);
            this.tbClient2Port.Name = "tbClient2Port";
            this.tbClient2Port.Size = new System.Drawing.Size(82, 31);
            this.tbClient2Port.TabIndex = 2;
            this.tbClient2Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(138, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Port";
            // 
            // tbClient2Ip
            // 
            this.tbClient2Ip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbClient2Ip.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClient2Ip.ForeColor = System.Drawing.Color.White;
            this.tbClient2Ip.HintForeColor = System.Drawing.Color.White;
            this.tbClient2Ip.HintText = "";
            this.tbClient2Ip.isPassword = false;
            this.tbClient2Ip.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbClient2Ip.LineIdleColor = System.Drawing.Color.Gray;
            this.tbClient2Ip.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbClient2Ip.LineThickness = 2;
            this.tbClient2Ip.Location = new System.Drawing.Point(43, 30);
            this.tbClient2Ip.Margin = new System.Windows.Forms.Padding(4);
            this.tbClient2Ip.Name = "tbClient2Ip";
            this.tbClient2Ip.Size = new System.Drawing.Size(82, 31);
            this.tbClient2Ip.TabIndex = 0;
            this.tbClient2Ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(20, 35);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "IP";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbClient1Port);
            this.groupBox1.Controls.Add(this.LabelPort);
            this.groupBox1.Controls.Add(this.tbClient1Ip);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(20, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(279, 84);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Client 1";
            // 
            // tbClient1Port
            // 
            this.tbClient1Port.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbClient1Port.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClient1Port.ForeColor = System.Drawing.Color.White;
            this.tbClient1Port.HintForeColor = System.Drawing.Color.White;
            this.tbClient1Port.HintText = "";
            this.tbClient1Port.isPassword = false;
            this.tbClient1Port.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbClient1Port.LineIdleColor = System.Drawing.Color.Gray;
            this.tbClient1Port.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbClient1Port.LineThickness = 2;
            this.tbClient1Port.Location = new System.Drawing.Point(173, 30);
            this.tbClient1Port.Margin = new System.Windows.Forms.Padding(4);
            this.tbClient1Port.Name = "tbClient1Port";
            this.tbClient1Port.Size = new System.Drawing.Size(82, 31);
            this.tbClient1Port.TabIndex = 2;
            this.tbClient1Port.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // LabelPort
            // 
            this.LabelPort.AutoSize = true;
            this.LabelPort.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPort.ForeColor = System.Drawing.Color.White;
            this.LabelPort.Location = new System.Drawing.Point(138, 35);
            this.LabelPort.Name = "LabelPort";
            this.LabelPort.Size = new System.Drawing.Size(28, 13);
            this.LabelPort.TabIndex = 3;
            this.LabelPort.Text = "Port";
            // 
            // tbClient1Ip
            // 
            this.tbClient1Ip.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbClient1Ip.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClient1Ip.ForeColor = System.Drawing.Color.White;
            this.tbClient1Ip.HintForeColor = System.Drawing.Color.White;
            this.tbClient1Ip.HintText = "";
            this.tbClient1Ip.isPassword = false;
            this.tbClient1Ip.LineFocusedColor = System.Drawing.Color.Blue;
            this.tbClient1Ip.LineIdleColor = System.Drawing.Color.Gray;
            this.tbClient1Ip.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.tbClient1Ip.LineThickness = 2;
            this.tbClient1Ip.Location = new System.Drawing.Point(43, 30);
            this.tbClient1Ip.Margin = new System.Windows.Forms.Padding(4);
            this.tbClient1Ip.Name = "tbClient1Ip";
            this.tbClient1Ip.Size = new System.Drawing.Size(82, 31);
            this.tbClient1Ip.TabIndex = 0;
            this.tbClient1Ip.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP";
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.panelControl;
            this.bunifuDragControl1.Vertical = true;
            // 
            // listBoxChat
            // 
            this.listBoxChat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxChat.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxChat.FormattingEnabled = true;
            this.listBoxChat.Location = new System.Drawing.Point(0, 62);
            this.listBoxChat.Name = "listBoxChat";
            this.listBoxChat.Size = new System.Drawing.Size(324, 456);
            this.listBoxChat.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(32)))), ((int)(((byte)(52)))));
            this.panel1.Controls.Add(this.buttonSend);
            this.panel1.Controls.Add(this.textBoxChat);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 437);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 81);
            this.panel1.TabIndex = 3;
            // 
            // buttonSend
            // 
            this.buttonSend.FlatAppearance.BorderSize = 0;
            this.buttonSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSend.ForeColor = System.Drawing.Color.White;
            this.buttonSend.Location = new System.Drawing.Point(238, 12);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 57);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxChat
            // 
            this.textBoxChat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.textBoxChat.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxChat.ForeColor = System.Drawing.Color.White;
            this.textBoxChat.Location = new System.Drawing.Point(20, 15);
            this.textBoxChat.Multiline = true;
            this.textBoxChat.Name = "textBoxChat";
            this.textBoxChat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxChat.Size = new System.Drawing.Size(212, 51);
            this.textBoxChat.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(220, 57);
            this.panel2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonSend;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 518);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.listBoxChat);
            this.Controls.Add(this.panelConfig);
            this.Controls.Add(this.panelControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelControl.ResumeLayout(false);
            this.panelControl.PerformLayout();
            this.panelConfig.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ns1.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panelConfig;
        private System.Windows.Forms.Panel panelControl;
        private ns1.BunifuDragControl bunifuDragControl1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private ns1.BunifuMaterialTextbox tbClient1Ip;
        private System.Windows.Forms.Label LabelPort;
        private ns1.BunifuMaterialTextbox tbClient1Port;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private ns1.BunifuMaterialTextbox tbClient2Port;
        private System.Windows.Forms.Label label4;
        private ns1.BunifuMaterialTextbox tbClient2Ip;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonExpand;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.ListBox listBoxChat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxChat;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttoMinimaze;
    }
}

