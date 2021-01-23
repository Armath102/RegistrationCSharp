using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reg
{
    public partial class Form0 : Form
    {
        public Form0()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 choice = new Form1();
            this.Hide();
            choice.ShowDialog();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
           log_in choice = new log_in();
            this.Hide();
            choice.ShowDialog();
        }
    }
}
