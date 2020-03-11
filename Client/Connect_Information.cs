using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.IO;

namespace Client
{
    public partial class Connect_information : Form
    {
        public Connect_information()
        {
            InitializeComponent();
            string url = "http://checkip.dyndns.org/";
            System.Net.WebRequest rq = System.Net.WebRequest.Create(url);
            System.Net.WebResponse resp = rq.GetResponse();
            System.IO.StreamReader Sr = new System.IO.StreamReader(resp.GetResponseStream());

            string responce = Sr.ReadToEnd().Trim();
            string[] a = responce.Split(':');
            string a2 = a[1].ToString();
            string[] a3 = a2.Split('<');
            string a4 = a3[0];

            var Host = Dns.GetHostByName(Dns.GetHostName());
            foreach (var ip in Host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                    ListBox_Conncetion.Items.Add("Local ip Address " + ip.ToString());
            }
            ListBox_Conncetion.Items.Add("My public IP is " + a4);
            ListBox_Conncetion.Items.Add("");
            ListBox_Conncetion.Items.Add("Listing All Network Interfaces on: " + Environment.MachineName.ToUpper());
            ListBox_Conncetion.Items.Add("---------------------------------------------------------------------");

            foreach (NetworkInterface x in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (x.NetworkInterfaceType == NetworkInterfaceType.Ethernet || x.NetworkInterfaceType == NetworkInterfaceType.Ethernet3Megabit || x.NetworkInterfaceType == NetworkInterfaceType.FastEthernetFx || x.NetworkInterfaceType == NetworkInterfaceType.FastEthernetT || x.NetworkInterfaceType == NetworkInterfaceType.GigabitEthernet || x.NetworkInterfaceType == NetworkInterfaceType.Wireless80211)
                {
                    foreach (UnicastIPAddressInformation ip in x.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                            ListBox_Conncetion.Items.Add(x.Description + " - " + ip.Address.ToString() + " (" + x.Name + ")");
                    }
                }


            }
        }
    }
}

