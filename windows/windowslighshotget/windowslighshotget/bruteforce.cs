using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;


namespace printfinder
{
    public partial class bruteforce : Form
    {
        private static Random random = new Random();
        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        
        public bruteforce()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for(int i=1; i<=vars.num; i++)
            {
                string link=RandomString(6);
                vars.fulllink = "https://prnt.sc/" + link;
                System.Diagnostics.Process.Start(vars.fulllink.ToLower());
                Thread.Sleep(100);
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            vars.num = Convert.ToInt32(numericUpDown1.Value);
        }

    }
}
