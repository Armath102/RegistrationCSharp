using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reg
{
    public partial class log_in : Form
    {
        public log_in()
        {
            InitializeComponent();
        }




        private void Sign_in_Button_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Hrach\Desktop\ArmathProj\";
            string filename = Username_Sign_in_box.Text + ".txt";
            FileInfo NewUser = new FileInfo(path + filename);
            if (Username_Sign_in_box.Text == "" || Password_Signin_box.Text == "")
            {
                MessageBox.Show("Invalid Inpud!!!!!");
                return;

            }


            if (!NewUser.Exists)
            {
                MessageBox.Show("The User Is Not Found!!");
                this.Close();
                return;

            }
            string username;
            string password;
            using (StreamReader sr = new StreamReader(path + filename))
            {

                username = sr.ReadLine();
                password = sr.ReadLine();


                if (username == Username_Sign_in_box.Text && password == Password_Signin_box.Text)
                {
                    MessageBox.Show("Welcome " + username);
                    this.Close();

                }
                else
                {
                    MessageBox.Show("Sorry But User is Not Found!");
                    this.Close();
                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form0 choice = new Form0();
            this.Hide();
            choice.ShowDialog();
        }
    }
}
