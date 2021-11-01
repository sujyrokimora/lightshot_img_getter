using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace printfinder
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var m = new bruteforce();
            m.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var m = new web();
            m.Show();
        }

        private void main_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button3.Visible = false;
        }
    }
}
