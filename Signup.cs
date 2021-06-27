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
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        

        private void Signup1_Click(object sender, EventArgs e)
        {
            try
            {
                var sw = new System.IO.StreamWriter("C:\\Food Station\\Registered Accounts\\" + textbox1.Text + "\\Login.ID");
                sw.Write(textbox1.Text + "\n" + textbox2.Text);
                
                sw.Close();
            }
            catch(System.IO.DirectoryNotFoundException ex)
            {
                System.IO.Directory.CreateDirectory("C:\\Food Station\\Registered Accounts\\" + textbox1.Text);
                var sw = new System.IO.StreamWriter("C:\\Food Station\\Registered Accounts\\" + textbox1.Text + "\\Login.ID");
                sw.Write(textbox1.Text + "\n" + textbox2.Text);
                sw.Close();
            }
            
            
        }

        
    }
}
