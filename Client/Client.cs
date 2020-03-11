using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Net;
using System.Diagnostics;
using System.Threading;
using static System.Math;
using System.Security.Cryptography;
using System.IO;

namespace Client
{
    public partial class Client : Form
    {
        TCPModel tcpmodel;
        SocketModel socket;
        string myname;
        TCPClient tcpclient;
        string message;
        byte[] byteReceive;
        Thread Connect_To_Server;
        int flag1 = -1;
        bool check = false;
        Thread Thread_Accept_Connect;
        Thread Thread_Accept_Connect_Client;
        byte[] encrypted;
        long mod_private;
        bool flag = false;
        static long prime_p;
        static long primitive_root;
        string Modulo_KeyPrivate;
        byte[] Key = new Byte[32];
        bool random = false;

        public Client()
        {
            InitializeComponent();
            this.TextBox_YourIP.Text = GetIPv4();

        }
        private void Client_Load(object selnder, EventArgs e)
        {
            this.TextBox_YourName.Text = Environment.UserName;
            myname = this.TextBox_YourName.Text;
            CheckForIllegalCrossThreadCalls = false;
            tcpmodel = new TCPModel(this.TextBox_YourIP.Text, int.Parse(this.TextBox_YourPort.Text));
            tcpmodel.Listen();
        }

        public string GetListeningIP(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties adapterProperties = item.GetIPProperties();
                    if (adapterProperties.GatewayAddresses.FirstOrDefault() != null)
                    {
                        foreach (UnicastIPAddressInformation ip in adapterProperties.UnicastAddresses)
                        {
                            if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                            {
                                output = ip.Address.ToString();
                            }
                        }
                    }
                }
            }
            return output;
        }

        public string GetIPv4()
        {
            foreach (NetworkInterface ni in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (ni.NetworkInterfaceType == NetworkInterfaceType.Ethernet && GetListeningIP(NetworkInterfaceType.Ethernet).Length >= 1)
                {
                    return GetListeningIP(NetworkInterfaceType.Ethernet);
                }
                else if (ni.NetworkInterfaceType == NetworkInterfaceType.Wireless80211 && GetListeningIP(NetworkInterfaceType.Wireless80211).Length >= 1)
                {
                    return GetListeningIP(NetworkInterfaceType.Wireless80211);
                }
            }

            IPHostEntry IPHost = Dns.GetHostByName(Dns.GetHostName());

            return IPHost.AddressList[0].ToString();
        }



        private void TextBox_MyIP_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }

        private void connectionInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Connect_information connect_inf = new Connect_information();
            connect_inf.Show();
        }

        private string Decrypt_String_AES(byte[] cipherText, byte[] Key, byte[] IV1)
        {
            if (cipherText == null || cipherText.Length <= 0)
                throw new ArgumentNullException("cipherText");
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            string plaintext;
            using (Aes aes1 = Aes.Create())
            {
                aes1.Key = Key;
                aes1.IV = IV1;
                ICryptoTransform decryptor = aes1.CreateDecryptor(aes1.Key, aes1.IV);

                using (MemoryStream Decrypt = new MemoryStream(cipherText))
                {
                    using (CryptoStream CsDecrypt = new CryptoStream(Decrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader Sr = new StreamReader(CsDecrypt))
                        {
                            plaintext = Sr.ReadToEnd();
                        }
                    }

                }
            }
            return plaintext;
        }

        public static Int32 ConvertByteArrayToInt32(byte[] b)
        {

            return BitConverter.ToInt32(b, 0);

        }

        private void Thread_Write()
        {
            string str1;
            string str2;
            string str;
            while (check)
            {
                try
                {
                    byteReceive = socket.ReceiveData();
                    message = Encoding.UTF8.GetString(byteReceive);
                    if (message != null)
                    {
                        // Xử lý nhận P, G và " G ^ A mod P " với A : Private Key
                        if (message.Contains("#Prime_p:"))
                        {
                            str = message;
                            string[] str3 = str.Split('#');
                            string[] str5 = str3[1].Split(':');
                            string prime_p = str5[1];
                            this.TextBox_P.Text = prime_p;
                            string[] str4;

                            if (str3[2].Contains("$Primitive_root:"))
                            {
                                str4 = str.Split('$');
                                string[] str6 = str4[1].Split(':');
                                string Premitive_root = str6[1];
                                this.TextBox_G.Text = Premitive_root;
                                if (str4[2].Contains("&Keyprivate:"))
                                {
                                    string[] str7 = str.Split('&');
                                    string[] str8 = str7[1].Split(':');
                                    string PrivateKey = str8[1];
                                    Modulo_KeyPrivate = PrivateKey;
                                }
                            }
                            this.Button_Random.Enabled = false;
                            this.Button_Accept_P.Enabled = false;
                            this.TextBox_P.ReadOnly = true;
                            this.TextBox_G.ReadOnly = true;
                        }
                        else if (message.Contains("$Primitive_root:"))
                        {
                            str1 = message;
                            string[] str4 = str1.Split('$');
                            string[] str6 = str4[1].Split(':');
                            string Premitive_root = str6[1];
                            this.TextBox_G.Text = Premitive_root;
                            this.TextBox_P.ReadOnly = true;
                            this.TextBox_G.ReadOnly = true;
                        }

                        else if (message.Contains("&Keyprivate:"))
                        {
                            str2 = message;
                            string[] str4 = str2.Split('&');
                            string[] str7 = str4[1].Split(':');
                            string PrivateKey = str7[1];
                            Modulo_KeyPrivate = PrivateKey;
                        }
                        else
                        {
                            //Nhận data gồm length(IV + cipherText) + IV + cipherText
                            byte[] Key1 = Encoding.UTF8.GetBytes(this.TextBox_Key.Text);

                            int dem = 0;
                            for (int i = 0; i < 32; i++)
                            {
                                if (dem < Key1.Length)
                                {
                                    Key[i] = Key1[dem++];
                                }
                                if (dem == Key1.Length)
                                    dem = 0;
                            }

                            byte[] data_length = new byte[4];

                            for (int i = 0; i < 4; i++)
                            {
                                data_length[i] = byteReceive[i];
                            }

                            Int32 length = ConvertByteArrayToInt32(data_length);

                            byte[] IV = new byte[16];
                            try
                            {
                                byte[] byte_data = new byte[length - 16];

                                int count = 0;

                                for (int i = 4; i < data_length.Length + length; i++)
                                {
                                    if (i < 4 + 16)
                                        IV[i - 4] = byteReceive[i];
                                    else
                                        byte_data[count++] = byteReceive[i];
                                }
                                string str_IV = Convert.ToBase64String(IV);
                                string cipher = Convert.ToBase64String(byte_data);

                                string plaintext = Decrypt_String_AES(byte_data, Key, IV);
                                Listbox_Chat.Items.Add(plaintext);
                                TextBox_Message_Encrypt.Text = "IV : " + str_IV + "\r\n";
                                TextBox_Message_Encrypt.Text += "Cipher Text : " + cipher;
                            }
                            catch (Exception)
                            {
                                check = false;
                                flag1 = -1;
                                Listbox_Chat.Items.Add("Your friend was exit!");
                                this.TextBox_P.Text = "";
                                this.TextBox_G.Text = "";
                                this.TextBox_Key.Text = "";
                                this.TextBox_KeyPrivate.Text = "";
                                this.TextBox_KeyPrivate.ReadOnly = false;
                                this.Button_Accept_P.Enabled = true;
                                this.Button_Send.Enabled = false;
                                this.Button_Random.Enabled = true;
                                this.Button_Calculator_Key.Enabled = true;
                                this.Button_Key_Private.Enabled = true;
                                this.Button_Connect.Enabled = true;
                                this.TextBox_G.ReadOnly = false;
                                this.TextBox_P.ReadOnly = false;
                                Thread_Accept_Connect.Abort();
                                Thread_Accept_Connect_Client.Abort();
                                Connect_To_Server.Abort();

                            }

                        }

                    }

                }
                catch (NullReferenceException ex)
                {
                    Console.WriteLine("Error " + ex.StackTrace);
                }
            }
        }

        public void Thread_Conncet_To_Server()
        {
            while (flag1 == -1)
                flag1 = tcpclient.Connect_To_Server();
        }

        public void Accept_Connect_Client()
        {
            while (check == false)
            {
                if (flag1 == 1)
                {
                    Socket s = tcpmodel.AcceptNewConnection();
                    socket = new SocketModel(s);
                    check = true;
                    break;
                }
            }
        }

        public void Accept_Connection()
        {
            tcpclient = new TCPClient(this.TextBox_PartnerIP.Text, int.Parse(this.TextBox_PartnerPort.Text));

            Connect_To_Server = new Thread(new ThreadStart(Thread_Conncet_To_Server));
            Connect_To_Server.IsBackground = true;
            Connect_To_Server.Start();

            Thread_Accept_Connect_Client = new Thread(new ThreadStart(Accept_Connect_Client));
            Thread_Accept_Connect_Client.IsBackground = true;
            Thread_Accept_Connect_Client.Start();

        }

        public void Receive_Data()
        {
            Thread_Write();
        }

        public void MultiScript()
        {
            Accept_Connection();

            while (true)
            {
                Receive_Data();
            }
        }

        private byte[] Encrypt_String_Aes(string plaintext, byte[] Key, byte[] IV)
        {
            if (plaintext == null || plaintext.Length <= 0)
            {
                throw new ArgumentNullException("plaintext");
            }
            if (Key == null || Key.Length <= 0)
                throw new ArgumentNullException("Key");
            if (IV == null || IV.Length <= 0)
                throw new ArgumentNullException("IV");

            byte[] encrypted;

            //use AES to encrypt with IV is length 16 bit.
            // and Key is length 32 bit
            using (Aes Aes_Encrypt = Aes.Create())
            {
                Aes_Encrypt.Key = Key;
                Aes_Encrypt.IV = IV;

                ICryptoTransform encryptor = Aes_Encrypt.CreateEncryptor(Aes_Encrypt.Key, Aes_Encrypt.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter Sw = new StreamWriter(csEncrypt))
                        {
                            Sw.Write(plaintext);
                        }
                        encrypted = msEncrypt.ToArray();
                    }
                }
            }

            return encrypted;
        }

        private void Button_Connect_Click(object sender, EventArgs e)
        {
            if (this.TextBox_PartnerIP.Text != "" && this.TextBox_PartnerPort.Text != "")
            {
                this.Listbox_Chat.Items.Clear();
                this.Button_Connect.Enabled = false;

                Thread_Accept_Connect = new Thread(new ThreadStart(MultiScript));
                Thread_Accept_Connect.IsBackground = true;
                Thread_Accept_Connect.Start();

                this.Listbox_Chat.Enabled = true;
                this.Button_Send.Enabled = false;
                this.TextBox_Send.Enabled = true;
                this.Button_Random.Enabled = true;
                this.Button_Accept_P.Enabled = true;
                this.TextBox_KeyPrivate.Enabled = true;
                this.TextBox_P.Enabled = true;
                this.TextBox_G.Enabled = true;
                random = true;

                Listbox_Chat.Items.Add("-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");

                Listbox_Chat.Items.Add("###  Connection Started. Listening on " + this.TextBox_PartnerIP.Text + "::" + this.TextBox_PartnerPort.Text + "    ###");
                Listbox_Chat.Items.Add("### You need calculate Key before send message###");
                Listbox_Chat.Items.Add("----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------");
                Listbox_Chat.Items.Add("");

            }
            else
            {
                MessageBox.Show("Not input Partner IP or Partner Port", "Notification!");
            }

        }



        public static byte[] ConvertInt32ToByteArray(int I32)
        {
            return BitConverter.GetBytes(I32);

        }

        private void Button_Send_Click(object sender, EventArgs e)
        {
            try
            {
                string wholemessage = "(" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ")   " + myname + " - " + this.TextBox_Send.Text;
                string mymessage = "(" + DateTime.Now.Hour + ":" + DateTime.Now.Minute + ":" + DateTime.Now.Second + ")   " + "You - " + this.TextBox_Send.Text;

                if (flag1 == 1)
                {
                    byte[] Key1 = Encoding.UTF8.GetBytes(this.TextBox_Key.Text);

                    int dem = 0;
                    for (int i = 0; i < 32; i++)
                    {
                        if (dem < Key1.Length)
                        {
                            Key[i] = Key1[dem++];
                        }
                        if (dem == Key1.Length)
                            dem = 0;
                    }

                    using (Aes aes = Aes.Create())
                    {
                        byte[] IV = aes.IV;
                        encrypted = Encrypt_String_Aes(wholemessage, Key, aes.IV);

                        //string cipherText = Encoding.UTF8.GetString(encrypted);
                        string plaintext = Decrypt_String_AES(encrypted, Key, IV);

                        int count1 = 0;
                        int count2 = 0;
                        int length = IV.Length + encrypted.Length;
                        byte[] byte_length = ConvertInt32ToByteArray(length);

                        byte[] byteSend = new byte[IV.Length + encrypted.Length + byte_length.Length];

                        for (int i = 0; i < IV.Length + encrypted.Length + byte_length.Length; i++)
                        {
                            if (i < byte_length.Length)
                                byteSend[i] = byte_length[i];
                            else if (i < byte_length.Length + IV.Length)
                                byteSend[i] = IV[count1++];
                            else
                            {
                                byteSend[i] = encrypted[count2++];
                            }

                        }

                        tcpclient.SendData(byteSend);
                    }

                }

                Listbox_Chat.Items.Add(mymessage);

                this.TextBox_Send.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Runtime Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button_Connect_Click(sender, e);
        }

        static List<long> listarray = new List<long>();

        public bool Check_Prime(long n)
        {
            if (n < (long)2)
                return false;
            for (long i = (long)2; i <= Sqrt(n); i++)
            {
                if (n % i == (long)0)
                    return false;
            }
            return true;
        }

        private void Init_Array(ref List<long> list)
        {
            list.Add(2);
            for (long i = 3; i < 100000; i += 2)
            {
                if (Check_Prime(i) == true)
                    list.Add(i);
            }
        }

        List<long> list_PrimeFactors = new List<long>();

        List<long> list_divisor = new List<long>();

        private bool Check_Exist(List<long> list, long n)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == n)
                    return true;
            }
            return false;
        }

        private void FindPrimeFactors(ref List<long> list, long n)
        {

            for (long i = 0; i < listarray.Count; i++)
            {
                int dem = (int)i;
                if (n % listarray[dem] == 0)
                {
                    if (Check_Exist(list, listarray[dem]) == false)
                    {
                        list.Add(listarray[dem]);
                    }
                    n = n / listarray[dem];
                }
            }
        }

        private void Find_Divisor(List<long> list, ref List<long> list_divisor, long fi_p)
        {
            for (int i = 0; i < list.Count; i++)
            {
                list_divisor.Add(fi_p / list[i]);
            }
        }

        private long Caculate_Modulo(long a, long x, long p)
        {
            long temp = a % p;

            long dem = 0;

            if (x >= 2)
                temp = (a * a) % p;

            if (x == 3)
            {
                temp = (temp * a) % p;
            }

            for (long i = 4; i < x; i *= 2)
            {
                temp = (temp * temp) % p;
                dem = i;
            }

            if (dem > 0)
            {
                for (long j = dem + 1; j <= x; j++)
                {
                    temp = (temp * a) % p;
                }
            }
            return temp;
        }

        private bool Check(List<long> list_divisor, long number, long p)
        {
            for (int i = 0; i < list_divisor.Count; i++)
            {
                if (Caculate_Modulo(number, list_divisor[i], p) == 1)
                    return false;
            }
            return true;
        }

        private long Find_Premitive_root(List<long> list_divisor, long s, long p)
        {

            for (long i = 2; i <= s; i++)
            {
                if (Check(list_divisor, i, p) == true)
                    return i;
            }
            return 1;
        }

        private void Button_Random_Click(object sender, EventArgs e)
        {
            if (random == true)
            {
                Init_Array(ref listarray);
                Random rand = new Random();
                int number = rand.Next(0, listarray.Count);

                long prime_random_p = listarray[number];
                prime_p = listarray[number];
                this.TextBox_P.Text = listarray[number].ToString();

                long s = prime_random_p - 1;

                FindPrimeFactors(ref list_PrimeFactors, s);

                Find_Divisor(list_PrimeFactors, ref list_divisor, s);

                long smallest_primitive_root = Find_Premitive_root(list_divisor, s, prime_random_p);

                this.TextBox_G.Text = smallest_primitive_root.ToString();
            }
            else
                MessageBox.Show("Not connected!", "Notification!");

        }

        private void Button_Accept_P_and_G_Click(object sender, EventArgs e)
        {
            if (this.TextBox_P.Text != "")
            {
                if (int.Parse(this.TextBox_P.Text) <= 2 || Check_Prime(long.Parse(this.TextBox_P.Text)) == false)
                {
                    MessageBox.Show("P must be Prime elder than 2 ", "Notification!");
                    this.TextBox_G.Text = "";
                }
                else
                {
                    this.Button_Random.Enabled = false;
                    long prime_random_p = long.Parse(this.TextBox_P.Text);
                    long s = prime_random_p - 1;

                    if (prime_random_p != prime_p)
                    {
                        prime_p = prime_random_p;
                        list_PrimeFactors.Clear();
                        list_divisor.Clear();
                        s = prime_random_p - 1;
                        FindPrimeFactors(ref list_PrimeFactors, s);

                        Find_Divisor(list_PrimeFactors, ref list_divisor, s);

                        long smallest_primitive_root = Find_Premitive_root(list_divisor, s, prime_random_p);

                        this.TextBox_G.Text = smallest_primitive_root.ToString();
                    }
                    this.Button_Accept_P.Enabled = false;
                    this.TextBox_P.ReadOnly = true;
                    this.TextBox_G.ReadOnly = true;
                    if (flag1 == 1)
                    {
                        string str = "#Prime_p:" + this.TextBox_P.Text + "#";
                        byte[] send_data = Encoding.UTF8.GetBytes(str);
                        string str1 = "$Primitive_root:" + this.TextBox_G.Text + "$";
                        byte[] send_data1 = Encoding.UTF8.GetBytes(str1);
                        tcpclient.SendData(send_data);
                        tcpclient.SendData(send_data1);
                    }

                    primitive_root = long.Parse(this.TextBox_G.Text);
                }
            }
            else
            {
                MessageBox.Show("Not input P", "Notification!");
            }

        }



        private void Button_Key_Private_Click(object sender, EventArgs e)
        {
            if (this.TextBox_KeyPrivate.Text != "")
            {
                this.Button_Key_Private.Enabled = false;
                long key_private = long.Parse(TextBox_KeyPrivate.Text);
                prime_p = long.Parse(this.TextBox_P.Text);
                primitive_root = long.Parse(this.TextBox_G.Text);
                mod_private = Caculate_Modulo(primitive_root, key_private, prime_p);
                if (flag1 == 1)
                {
                    string str = "&Keyprivate:" + mod_private.ToString() + "&";
                    byte[] send_data = Encoding.UTF8.GetBytes(str);
                    tcpclient.SendData(send_data);

                }
                this.TextBox_KeyPrivate.ReadOnly = true;
                flag = true;
            }
            else
                MessageBox.Show("Not input Private Key", "Notification!");
        }

        private void Button_Calculator_Key_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                if (this.TextBox_KeyPrivate.Text != "")
                {
                    try
                    {
                        long Modulo_Keyprivate = long.Parse(Modulo_KeyPrivate);
                        long keyPrivate = long.Parse(this.TextBox_KeyPrivate.Text);
                        prime_p = long.Parse(this.TextBox_P.Text);
                        long key = Caculate_Modulo(Modulo_Keyprivate, keyPrivate, prime_p);
                        this.TextBox_Key.Text = key.ToString();
                        this.Button_Calculator_Key.Enabled = false;
                        this.Button_Send.Enabled = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Not receive data!", "Notification!");
                    }

                }
            }
            else
                MessageBox.Show("Not accept P or accept Private Key!", "Notification!");


        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Environment.Exit(Environment.ExitCode);
        }
    }
}

