namespace Client
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBox_YourPort = new System.Windows.Forms.TextBox();
            this.Label_Listening_Port = new System.Windows.Forms.Label();
            this.Label_MyIP = new System.Windows.Forms.Label();
            this.TextBox_YourIP = new System.Windows.Forms.TextBox();
            this.TextBox_YourName = new System.Windows.Forms.TextBox();
            this.Label_YourName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TextBox_PartnerPort = new System.Windows.Forms.TextBox();
            this.TextBox_PartnerIP = new System.Windows.Forms.TextBox();
            this.Label_PartnerPort = new System.Windows.Forms.Label();
            this.Label_PartnerIP = new System.Windows.Forms.Label();
            this.Button_Connect = new System.Windows.Forms.Button();
            this.GroupBox_Information_Conncet = new System.Windows.Forms.GroupBox();
            this.TextBox_Send = new System.Windows.Forms.TextBox();
            this.Button_Send = new System.Windows.Forms.Button();
            this.Label_Title = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.restartToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GroupBox_Chat = new System.Windows.Forms.GroupBox();
            this.Listbox_Chat = new System.Windows.Forms.ListBox();
            this.GroupBox_Information = new System.Windows.Forms.GroupBox();
            this.Label_CipherText = new System.Windows.Forms.Label();
            this.TextBox_Message_Encrypt = new System.Windows.Forms.TextBox();
            this.Button_Calculator_Key = new System.Windows.Forms.Button();
            this.Label_Key = new System.Windows.Forms.Label();
            this.TextBox_Key = new System.Windows.Forms.TextBox();
            this.Button_Key_Private = new System.Windows.Forms.Button();
            this.TextBox_KeyPrivate = new System.Windows.Forms.TextBox();
            this.Label_Key_Private = new System.Windows.Forms.Label();
            this.Button_Accept_P = new System.Windows.Forms.Button();
            this.Button_Random = new System.Windows.Forms.Button();
            this.TextBox_G = new System.Windows.Forms.TextBox();
            this.Label_G = new System.Windows.Forms.Label();
            this.Label_p = new System.Windows.Forms.Label();
            this.TextBox_P = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.GroupBox_Information_Conncet.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.GroupBox_Chat.SuspendLayout();
            this.GroupBox_Information.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBox_YourPort);
            this.groupBox1.Controls.Add(this.Label_Listening_Port);
            this.groupBox1.Controls.Add(this.Label_MyIP);
            this.groupBox1.Controls.Add(this.TextBox_YourIP);
            this.groupBox1.Controls.Add(this.TextBox_YourName);
            this.groupBox1.Controls.Add(this.Label_YourName);
            this.groupBox1.Location = new System.Drawing.Point(6, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 158);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "This Device";
            // 
            // TextBox_YourPort
            // 
            this.TextBox_YourPort.Location = new System.Drawing.Point(106, 111);
            this.TextBox_YourPort.Name = "TextBox_YourPort";
            this.TextBox_YourPort.Size = new System.Drawing.Size(98, 21);
            this.TextBox_YourPort.TabIndex = 5;
            this.TextBox_YourPort.TabStop = false;
            this.TextBox_YourPort.Text = "8080";
            // 
            // Label_Listening_Port
            // 
            this.Label_Listening_Port.AutoSize = true;
            this.Label_Listening_Port.Location = new System.Drawing.Point(17, 117);
            this.Label_Listening_Port.Name = "Label_Listening_Port";
            this.Label_Listening_Port.Size = new System.Drawing.Size(82, 15);
            this.Label_Listening_Port.TabIndex = 4;
            this.Label_Listening_Port.Text = "Listening port";
            // 
            // Label_MyIP
            // 
            this.Label_MyIP.AutoSize = true;
            this.Label_MyIP.Location = new System.Drawing.Point(17, 77);
            this.Label_MyIP.Name = "Label_MyIP";
            this.Label_MyIP.Size = new System.Drawing.Size(45, 15);
            this.Label_MyIP.TabIndex = 3;
            this.Label_MyIP.Text = "Your IP";
            // 
            // TextBox_YourIP
            // 
            this.TextBox_YourIP.Location = new System.Drawing.Point(91, 71);
            this.TextBox_YourIP.Name = "TextBox_YourIP";
            this.TextBox_YourIP.Size = new System.Drawing.Size(113, 21);
            this.TextBox_YourIP.TabIndex = 2;
            this.TextBox_YourIP.TabStop = false;
            // 
            // TextBox_YourName
            // 
            this.TextBox_YourName.Location = new System.Drawing.Point(91, 30);
            this.TextBox_YourName.Name = "TextBox_YourName";
            this.TextBox_YourName.Size = new System.Drawing.Size(113, 21);
            this.TextBox_YourName.TabIndex = 1;
            this.TextBox_YourName.TabStop = false;
            // 
            // Label_YourName
            // 
            this.Label_YourName.AutoSize = true;
            this.Label_YourName.Location = new System.Drawing.Point(17, 36);
            this.Label_YourName.Name = "Label_YourName";
            this.Label_YourName.Size = new System.Drawing.Size(41, 15);
            this.Label_YourName.TabIndex = 0;
            this.Label_YourName.Text = "Name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TextBox_PartnerPort);
            this.groupBox2.Controls.Add(this.TextBox_PartnerIP);
            this.groupBox2.Controls.Add(this.Label_PartnerPort);
            this.groupBox2.Controls.Add(this.Label_PartnerIP);
            this.groupBox2.Location = new System.Drawing.Point(6, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(220, 101);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Partner";
            // 
            // TextBox_PartnerPort
            // 
            this.TextBox_PartnerPort.Location = new System.Drawing.Point(98, 71);
            this.TextBox_PartnerPort.Name = "TextBox_PartnerPort";
            this.TextBox_PartnerPort.Size = new System.Drawing.Size(113, 21);
            this.TextBox_PartnerPort.TabIndex = 3;
            this.TextBox_PartnerPort.TabStop = false;
            // 
            // TextBox_PartnerIP
            // 
            this.TextBox_PartnerIP.Location = new System.Drawing.Point(98, 30);
            this.TextBox_PartnerIP.Name = "TextBox_PartnerIP";
            this.TextBox_PartnerIP.Size = new System.Drawing.Size(113, 21);
            this.TextBox_PartnerIP.TabIndex = 2;
            this.TextBox_PartnerIP.TabStop = false;
            // 
            // Label_PartnerPort
            // 
            this.Label_PartnerPort.AutoSize = true;
            this.Label_PartnerPort.Location = new System.Drawing.Point(7, 77);
            this.Label_PartnerPort.Name = "Label_PartnerPort";
            this.Label_PartnerPort.Size = new System.Drawing.Size(81, 15);
            this.Label_PartnerPort.TabIndex = 1;
            this.Label_PartnerPort.Text = "Partner\'s Port";
            // 
            // Label_PartnerIP
            // 
            this.Label_PartnerIP.AutoSize = true;
            this.Label_PartnerIP.Location = new System.Drawing.Point(7, 36);
            this.Label_PartnerIP.Name = "Label_PartnerIP";
            this.Label_PartnerIP.Size = new System.Drawing.Size(70, 15);
            this.Label_PartnerIP.TabIndex = 0;
            this.Label_PartnerIP.Text = "Partner\'s IP";
            // 
            // Button_Connect
            // 
            this.Button_Connect.Location = new System.Drawing.Point(117, 292);
            this.Button_Connect.Name = "Button_Connect";
            this.Button_Connect.Size = new System.Drawing.Size(100, 40);
            this.Button_Connect.TabIndex = 2;
            this.Button_Connect.TabStop = false;
            this.Button_Connect.Text = "Connect";
            this.Button_Connect.UseVisualStyleBackColor = true;
            this.Button_Connect.Click += new System.EventHandler(this.Button_Connect_Click);
            // 
            // GroupBox_Information_Conncet
            // 
            this.GroupBox_Information_Conncet.Controls.Add(this.groupBox1);
            this.GroupBox_Information_Conncet.Controls.Add(this.Button_Connect);
            this.GroupBox_Information_Conncet.Controls.Add(this.groupBox2);
            this.GroupBox_Information_Conncet.Location = new System.Drawing.Point(12, 36);
            this.GroupBox_Information_Conncet.Name = "GroupBox_Information_Conncet";
            this.GroupBox_Information_Conncet.Size = new System.Drawing.Size(273, 339);
            this.GroupBox_Information_Conncet.TabIndex = 3;
            this.GroupBox_Information_Conncet.TabStop = false;
            this.GroupBox_Information_Conncet.Text = "Connection Information ";
            // 
            // TextBox_Send
            // 
            this.TextBox_Send.Enabled = false;
            this.TextBox_Send.Location = new System.Drawing.Point(19, 282);
            this.TextBox_Send.Multiline = true;
            this.TextBox_Send.Name = "TextBox_Send";
            this.TextBox_Send.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TextBox_Send.Size = new System.Drawing.Size(376, 49);
            this.TextBox_Send.TabIndex = 2;
            this.TextBox_Send.TabStop = false;
            // 
            // Button_Send
            // 
            this.Button_Send.Enabled = false;
            this.Button_Send.Location = new System.Drawing.Point(401, 282);
            this.Button_Send.Name = "Button_Send";
            this.Button_Send.Size = new System.Drawing.Size(71, 49);
            this.Button_Send.TabIndex = 1;
            this.Button_Send.TabStop = false;
            this.Button_Send.Text = "Send";
            this.Button_Send.UseVisualStyleBackColor = true;
            this.Button_Send.Click += new System.EventHandler(this.Button_Send_Click);
            // 
            // Label_Title
            // 
            this.Label_Title.AutoSize = true;
            this.Label_Title.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.Label_Title.Location = new System.Drawing.Point(489, 14);
            this.Label_Title.Name = "Label_Title";
            this.Label_Title.Size = new System.Drawing.Size(90, 19);
            this.Label_Title.TabIndex = 4;
            this.Label_Title.Text = "CHAT LAN";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1145, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.restartToolStripMenuItem,
            this.exitToolStripMenuItem1});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // restartToolStripMenuItem
            // 
            this.restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            this.restartToolStripMenuItem.Size = new System.Drawing.Size(116, 6);
            // 
            // exitToolStripMenuItem1
            // 
            this.exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            this.exitToolStripMenuItem1.Size = new System.Drawing.Size(119, 22);
            this.exitToolStripMenuItem1.Text = "Exit";
            this.exitToolStripMenuItem1.Click += new System.EventHandler(this.exitToolStripMenuItem1_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionInformationToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // connectionInformationToolStripMenuItem
            // 
            this.connectionInformationToolStripMenuItem.Name = "connectionInformationToolStripMenuItem";
            this.connectionInformationToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.connectionInformationToolStripMenuItem.Text = "Connection Information";
            this.connectionInformationToolStripMenuItem.Click += new System.EventHandler(this.connectionInformationToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // GroupBox_Chat
            // 
            this.GroupBox_Chat.Controls.Add(this.TextBox_Send);
            this.GroupBox_Chat.Controls.Add(this.Listbox_Chat);
            this.GroupBox_Chat.Controls.Add(this.Button_Send);
            this.GroupBox_Chat.Location = new System.Drawing.Point(654, 36);
            this.GroupBox_Chat.Name = "GroupBox_Chat";
            this.GroupBox_Chat.Size = new System.Drawing.Size(479, 339);
            this.GroupBox_Chat.TabIndex = 6;
            this.GroupBox_Chat.TabStop = false;
            this.GroupBox_Chat.Text = "Chat";
            // 
            // Listbox_Chat
            // 
            this.Listbox_Chat.FormattingEnabled = true;
            this.Listbox_Chat.HorizontalScrollbar = true;
            this.Listbox_Chat.ItemHeight = 14;
            this.Listbox_Chat.Location = new System.Drawing.Point(19, 20);
            this.Listbox_Chat.Name = "Listbox_Chat";
            this.Listbox_Chat.ScrollAlwaysVisible = true;
            this.Listbox_Chat.Size = new System.Drawing.Size(376, 256);
            this.Listbox_Chat.TabIndex = 0;
            this.Listbox_Chat.TabStop = false;
            // 
            // GroupBox_Information
            // 
            this.GroupBox_Information.Controls.Add(this.Label_CipherText);
            this.GroupBox_Information.Controls.Add(this.TextBox_Message_Encrypt);
            this.GroupBox_Information.Controls.Add(this.Button_Calculator_Key);
            this.GroupBox_Information.Controls.Add(this.Label_Key);
            this.GroupBox_Information.Controls.Add(this.TextBox_Key);
            this.GroupBox_Information.Controls.Add(this.Button_Key_Private);
            this.GroupBox_Information.Controls.Add(this.TextBox_KeyPrivate);
            this.GroupBox_Information.Controls.Add(this.Label_Key_Private);
            this.GroupBox_Information.Controls.Add(this.Button_Accept_P);
            this.GroupBox_Information.Controls.Add(this.Button_Random);
            this.GroupBox_Information.Controls.Add(this.TextBox_G);
            this.GroupBox_Information.Controls.Add(this.Label_G);
            this.GroupBox_Information.Controls.Add(this.Label_p);
            this.GroupBox_Information.Controls.Add(this.TextBox_P);
            this.GroupBox_Information.Location = new System.Drawing.Point(291, 36);
            this.GroupBox_Information.Name = "GroupBox_Information";
            this.GroupBox_Information.Size = new System.Drawing.Size(357, 339);
            this.GroupBox_Information.TabIndex = 7;
            this.GroupBox_Information.TabStop = false;
            this.GroupBox_Information.Text = "Information";
            // 
            // Label_CipherText
            // 
            this.Label_CipherText.AutoSize = true;
            this.Label_CipherText.Location = new System.Drawing.Point(7, 209);
            this.Label_CipherText.Name = "Label_CipherText";
            this.Label_CipherText.Size = new System.Drawing.Size(90, 15);
            this.Label_CipherText.TabIndex = 14;
            this.Label_CipherText.Text = "CipherText AES";
            // 
            // TextBox_Message_Encrypt
            // 
            this.TextBox_Message_Encrypt.Location = new System.Drawing.Point(7, 229);
            this.TextBox_Message_Encrypt.Multiline = true;
            this.TextBox_Message_Encrypt.Name = "TextBox_Message_Encrypt";
            this.TextBox_Message_Encrypt.ReadOnly = true;
            this.TextBox_Message_Encrypt.Size = new System.Drawing.Size(344, 103);
            this.TextBox_Message_Encrypt.TabIndex = 13;
            this.TextBox_Message_Encrypt.TabStop = false;
            // 
            // Button_Calculator_Key
            // 
            this.Button_Calculator_Key.Location = new System.Drawing.Point(213, 166);
            this.Button_Calculator_Key.Name = "Button_Calculator_Key";
            this.Button_Calculator_Key.Size = new System.Drawing.Size(116, 23);
            this.Button_Calculator_Key.TabIndex = 12;
            this.Button_Calculator_Key.TabStop = false;
            this.Button_Calculator_Key.Text = "Calculate Key ";
            this.Button_Calculator_Key.UseVisualStyleBackColor = true;
            this.Button_Calculator_Key.Click += new System.EventHandler(this.Button_Calculator_Key_Click);
            // 
            // Label_Key
            // 
            this.Label_Key.AutoSize = true;
            this.Label_Key.Location = new System.Drawing.Point(38, 174);
            this.Label_Key.Name = "Label_Key";
            this.Label_Key.Size = new System.Drawing.Size(36, 15);
            this.Label_Key.TabIndex = 11;
            this.Label_Key.Text = "Key : ";
            // 
            // TextBox_Key
            // 
            this.TextBox_Key.Location = new System.Drawing.Point(94, 168);
            this.TextBox_Key.Name = "TextBox_Key";
            this.TextBox_Key.ReadOnly = true;
            this.TextBox_Key.Size = new System.Drawing.Size(113, 21);
            this.TextBox_Key.TabIndex = 10;
            this.TextBox_Key.TabStop = false;
            // 
            // Button_Key_Private
            // 
            this.Button_Key_Private.Location = new System.Drawing.Point(213, 123);
            this.Button_Key_Private.Name = "Button_Key_Private";
            this.Button_Key_Private.Size = new System.Drawing.Size(116, 23);
            this.Button_Key_Private.TabIndex = 9;
            this.Button_Key_Private.TabStop = false;
            this.Button_Key_Private.Text = "Accept Key Private";
            this.Button_Key_Private.UseVisualStyleBackColor = true;
            this.Button_Key_Private.Click += new System.EventHandler(this.Button_Key_Private_Click);
            // 
            // TextBox_KeyPrivate
            // 
            this.TextBox_KeyPrivate.Enabled = false;
            this.TextBox_KeyPrivate.Location = new System.Drawing.Point(94, 125);
            this.TextBox_KeyPrivate.Name = "TextBox_KeyPrivate";
            this.TextBox_KeyPrivate.Size = new System.Drawing.Size(113, 21);
            this.TextBox_KeyPrivate.TabIndex = 7;
            this.TextBox_KeyPrivate.TabStop = false;
            // 
            // Label_Key_Private
            // 
            this.Label_Key_Private.AutoSize = true;
            this.Label_Key_Private.Location = new System.Drawing.Point(21, 131);
            this.Label_Key_Private.Name = "Label_Key_Private";
            this.Label_Key_Private.Size = new System.Drawing.Size(67, 15);
            this.Label_Key_Private.TabIndex = 6;
            this.Label_Key_Private.Text = "Private Key";
            // 
            // Button_Accept_P
            // 
            this.Button_Accept_P.Enabled = false;
            this.Button_Accept_P.Location = new System.Drawing.Point(213, 78);
            this.Button_Accept_P.Name = "Button_Accept_P";
            this.Button_Accept_P.Size = new System.Drawing.Size(116, 23);
            this.Button_Accept_P.TabIndex = 5;
            this.Button_Accept_P.TabStop = false;
            this.Button_Accept_P.Text = "Accept P";
            this.Button_Accept_P.UseVisualStyleBackColor = true;
            this.Button_Accept_P.Click += new System.EventHandler(this.Button_Accept_P_and_G_Click);
            // 
            // Button_Random
            // 
            this.Button_Random.Enabled = false;
            this.Button_Random.Location = new System.Drawing.Point(24, 78);
            this.Button_Random.Name = "Button_Random";
            this.Button_Random.Size = new System.Drawing.Size(116, 23);
            this.Button_Random.TabIndex = 4;
            this.Button_Random.TabStop = false;
            this.Button_Random.Text = "Random";
            this.Button_Random.UseVisualStyleBackColor = true;
            this.Button_Random.Click += new System.EventHandler(this.Button_Random_Click);
            // 
            // TextBox_G
            // 
            this.TextBox_G.Enabled = false;
            this.TextBox_G.Location = new System.Drawing.Point(229, 34);
            this.TextBox_G.Name = "TextBox_G";
            this.TextBox_G.Size = new System.Drawing.Size(100, 21);
            this.TextBox_G.TabIndex = 3;
            this.TextBox_G.TabStop = false;
            // 
            // Label_G
            // 
            this.Label_G.AutoSize = true;
            this.Label_G.Font = new System.Drawing.Font("Arial", 10F);
            this.Label_G.Location = new System.Drawing.Point(192, 39);
            this.Label_G.Name = "Label_G";
            this.Label_G.Size = new System.Drawing.Size(31, 16);
            this.Label_G.TabIndex = 2;
            this.Label_G.Text = "G : ";
            // 
            // Label_p
            // 
            this.Label_p.AutoSize = true;
            this.Label_p.Font = new System.Drawing.Font("Arial", 10F);
            this.Label_p.Location = new System.Drawing.Point(21, 39);
            this.Label_p.Name = "Label_p";
            this.Label_p.Size = new System.Drawing.Size(29, 16);
            this.Label_p.TabIndex = 1;
            this.Label_p.Text = "P : ";
            // 
            // TextBox_P
            // 
            this.TextBox_P.Enabled = false;
            this.TextBox_P.Location = new System.Drawing.Point(56, 34);
            this.TextBox_P.Name = "TextBox_P";
            this.TextBox_P.Size = new System.Drawing.Size(100, 21);
            this.TextBox_P.TabIndex = 0;
            this.TextBox_P.TabStop = false;
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 399);
            this.Controls.Add(this.GroupBox_Information);
            this.Controls.Add(this.GroupBox_Chat);
            this.Controls.Add(this.Label_Title);
            this.Controls.Add(this.GroupBox_Information_Conncet);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 8.5F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Client";
            this.Text = "Lan Chat";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Client_FormClosed);
            this.Load += new System.EventHandler(this.Client_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.GroupBox_Information_Conncet.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GroupBox_Chat.ResumeLayout(false);
            this.GroupBox_Chat.PerformLayout();
            this.GroupBox_Information.ResumeLayout(false);
            this.GroupBox_Information.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBox_YourPort;
        private System.Windows.Forms.Label Label_Listening_Port;
        private System.Windows.Forms.Label Label_MyIP;
        private System.Windows.Forms.TextBox TextBox_YourIP;
        private System.Windows.Forms.TextBox TextBox_YourName;
        private System.Windows.Forms.Label Label_YourName;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TextBox_PartnerPort;
        private System.Windows.Forms.TextBox TextBox_PartnerIP;
        private System.Windows.Forms.Label Label_PartnerPort;
        private System.Windows.Forms.Label Label_PartnerIP;
        private System.Windows.Forms.Button Button_Connect;
        private System.Windows.Forms.GroupBox GroupBox_Information_Conncet;
        private System.Windows.Forms.Label Label_Title;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.GroupBox GroupBox_Chat;
        private System.Windows.Forms.TextBox TextBox_Send;
        private System.Windows.Forms.Button Button_Send;
        private System.Windows.Forms.ListBox Listbox_Chat;
        private System.Windows.Forms.GroupBox GroupBox_Information;
        private System.Windows.Forms.Button Button_Random;
        private System.Windows.Forms.TextBox TextBox_G;
        private System.Windows.Forms.Label Label_G;
        private System.Windows.Forms.Label Label_p;
        private System.Windows.Forms.TextBox TextBox_P;
        private System.Windows.Forms.Button Button_Accept_P;
        private System.Windows.Forms.Button Button_Key_Private;
        private System.Windows.Forms.TextBox TextBox_KeyPrivate;
        private System.Windows.Forms.Label Label_Key_Private;
        private System.Windows.Forms.Button Button_Calculator_Key;
        private System.Windows.Forms.Label Label_Key;
        private System.Windows.Forms.TextBox TextBox_Key;
        private System.Windows.Forms.TextBox TextBox_Message_Encrypt;
        private System.Windows.Forms.Label Label_CipherText;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator restartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem1;
    }
}



