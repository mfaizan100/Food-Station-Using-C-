using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FOOD_ORDERING_PROJECT
{
    public partial class Login_frm : Form
    {
        public string username1, password;
        public Login_frm()
        {
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                var sr = new System.IO.StreamReader("C:\\Food Station\\Registered Accounts\\" + textbox1.Text + "\\Login.ID");
                username1 = sr.ReadLine();
                password = sr.ReadLine();
                sr.Close();

                if (username1 == textbox1.Text && password == textbox2.Text)
                {
                    new Menu().Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username or password is incorrect", "Error");
                }
            }
            catch (System.IO.DirectoryNotFoundException ex)
            {
                MessageBox.Show("User doesn't exist!", "Error!");
            }
        }




        private void ext_button_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm you want to Exit?", "Food Station", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        

       

        
    }
}
