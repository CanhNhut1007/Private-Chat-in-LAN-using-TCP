namespace Client
{
    partial class About
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(About));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Label_appname = new System.Windows.Forms.Label();
            this.Label_Version = new System.Windows.Forms.Label();
            this.Label_author = new System.Windows.Forms.Label();
            this.Button_Ok = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(28, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Label_appname
            // 
            this.Label_appname.AutoSize = true;
            this.Label_appname.Location = new System.Drawing.Point(112, 15);
            this.Label_appname.Name = "Label_appname";
            this.Label_appname.Size = new System.Drawing.Size(83, 14);
            this.Label_appname.TabIndex = 1;
            this.Label_appname.Text = "Label_appname";
            // 
            // Label_Version
            // 
            this.Label_Version.AutoSize = true;
            this.Label_Version.Location = new System.Drawing.Point(112, 40);
            this.Label_Version.Name = "Label_Version";
            this.Label_Version.Size = new System.Drawing.Size(55, 14);
            this.Label_Version.TabIndex = 2;
            this.Label_Version.Text = "<version>";
            // 
            // Label_author
            // 
            this.Label_author.AutoSize = true;
            this.Label_author.Location = new System.Drawing.Point(112, 67);
            this.Label_author.Name = "Label_author";
            this.Label_author.Size = new System.Drawing.Size(50, 14);
            this.Label_author.TabIndex = 3;
            this.Label_author.Text = "<author>";
            // 
            // Button_Ok
            // 
            this.Button_Ok.Location = new System.Drawing.Point(166, 89);
            this.Button_Ok.Name = "Button_Ok";
            this.Button_Ok.Size = new System.Drawing.Size(87, 29);
            this.Button_Ok.TabIndex = 4;
            this.Button_Ok.Text = "Ok";
            this.Button_Ok.UseVisualStyleBackColor = true;
            this.Button_Ok.Click += new System.EventHandler(this.Button_Ok_Click);
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 122);
            this.Controls.Add(this.Button_Ok);
            this.Controls.Add(this.Label_author);
            this.Controls.Add(this.Label_Version);
            this.Controls.Add(this.Label_appname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "About";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_appname;
        private System.Windows.Forms.Label Label_Version;
        private System.Windows.Forms.Label Label_author;
        private System.Windows.Forms.Button Button_Ok;
    }
}