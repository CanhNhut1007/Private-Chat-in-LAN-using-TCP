namespace Client
{
    partial class Connect_information
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Connect_information));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListBox_Conncetion = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ListBox_Conncetion);
            this.groupBox1.Location = new System.Drawing.Point(24, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(460, 309);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
            // 
            // ListBox_Conncetion
            // 
            this.ListBox_Conncetion.FormattingEnabled = true;
            this.ListBox_Conncetion.HorizontalScrollbar = true;
            this.ListBox_Conncetion.ItemHeight = 14;
            this.ListBox_Conncetion.Location = new System.Drawing.Point(6, 19);
            this.ListBox_Conncetion.Name = "ListBox_Conncetion";
            this.ListBox_Conncetion.ScrollAlwaysVisible = true;
            this.ListBox_Conncetion.Size = new System.Drawing.Size(448, 284);
            this.ListBox_Conncetion.TabIndex = 0;
            // 
            // Connect_information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 345);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Connect_information";
            this.Text = "Connect_information";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ListBox_Conncetion;
    }
}