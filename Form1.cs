using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FOOD_ORDERING_PROJECT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

  
        private void Login_Click(object sender, EventArgs e)
        {
            new Login_frm().Show();
            this.Hide();
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You should login First","Error");
        }

        private void Signup_Click(object sender, EventArgs e)
        {
            new Signup().Show();
            this.Hide();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("You are already in Home","Food Station");
        }

      
    }
}
