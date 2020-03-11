using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
            this.Label_appname.Text = "LAN Chat";
            this.Label_Version.Text = "Version 1.0";
            this.Label_author.Text = "Programing by TCN + PĐTQ";
        }

        private void Button_Ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

