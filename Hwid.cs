using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Security.Principal;

namespace Discord
{
    public partial class Form2 : Form
    {
        private string HWID;
        public Form2()
        {
            InitializeComponent();
            this.HWID = WindowsIdentity.GetCurrent().User.Value;
            WebClient webClient = new WebClient();
            string text = webClient.DownloadString("https://pastebin.com/raw/ITSHWID"); ;
            bool flag = text.Contains(this.HWID);
            bool flag2 = !flag;
            if (flag2)
            {
                Environment.Exit(0);
            }
            bool flag3 = text == this.HWID;
            if (flag3)
            {

            }
        }
    }
}