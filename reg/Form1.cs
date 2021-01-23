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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Reg_botton_click(object sender, EventArgs e)
        {
            string path = @"C:\Users\Hrach\Desktop\ArmathProj\";
            string filename = name_text_box.Text+".txt";
            FileInfo NewUser = new FileInfo(path + filename);
            if(name_text_box.Text == "" || Password_text_box.Text == "" || Password_text_box2.Text == "")

            { 
               
                MessageBox.Show("Invalid Inpud!!!!!");
                return;



            }

            if (Password_text_box.Text == Password_text_box2.Text)
            {}
            else
            {
                MessageBox.Show("Invalid Password!!!!!");
                this.Close();
                return;

            }
            
            if (NewUser.Exists)
            {
                

            }
            else {
                
            
              
            }
          
            using (FileStream fs = new FileStream(path + filename, FileMode.Create))
            {
             
            }
            using(FileStream fs=new FileStream(path+filename,FileMode.Create))
            { } 
            using(StreamWriter sw=new StreamWriter(path+filename))
            {
                sw.WriteLine( name_text_box.Text);
                sw.WriteLine( Password_text_box.Text);

            }
            log_in log = new log_in();
            this.Hide();
            log.ShowDialog();
            this.Close();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form0 choice = new Form0();
            this.Hide();
            choice.ShowDialog();
        }
    }
}
