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
    public partial class Menu : Form
    {
        const double price_smallpizza = 250;
        const double price_mediumpizza = 500;
        const double price_largepizza = 1100;

        const double price_zinger = 450;
        const double price_beef = 500;
        const double price_chicken = 300;

        const double price_soup = 200;
        const double price_rice = 250;
        const double price_Manchurian = 350;
        const double price_noodles = 250;

        double subtotal,tax,total;
        double Tax_Rate = 3.1;

        public Menu()
        {
            InitializeComponent();
        }

        
      
//*******************************************Exit**************************************************************
        private void ext_button_Click(object sender, EventArgs e)
        {
            DialogResult iExit;

            iExit = MessageBox.Show("Confirm you want to Exit?","Food Station",MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (iExit == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

//*******************************************RestTextBoxes()**********************************************************
        private void RestTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach(Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Text = "0";

                    else
                        func(control.Controls);
            };

            func(Controls);
        }

//*******************************************RestCheckBoxes()**********************************************************
        private void RestCheckBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is CheckBox)
                        (control as CheckBox).Checked = false;

                    else
                        func(control.Controls);
            };

            func(Controls);
        }


//*******************************************EnableTextBoxes()*********************************************************
        private void EnableTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Enabled = false;

                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void Reset_button_Click(object sender, EventArgs e)
        {
            RestTextBoxes();
            RestCheckBoxes();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            EnableTextBoxes();
        }


        private void tot_button_Click(object sender, EventArgs e)
        {
            double[] itemcost = new double[10];
            itemcost[0] = Convert.ToDouble(smalltextBox1.Text) * price_smallpizza;
            itemcost[1] = Convert.ToDouble(mediumtextBox2.Text) * price_mediumpizza;
            itemcost[2] = Convert.ToDouble(largetextBox3.Text) * price_largepizza;

            itemcost[3] = Convert.ToDouble(zingertextBox.Text) * price_zinger;
            itemcost[4] = Convert.ToDouble(BeeftextBox.Text) * price_beef;
            itemcost[5] = Convert.ToDouble(chickentextBox.Text) * price_chicken;


            itemcost[6] = Convert.ToDouble(stextBox1.Text) * price_soup;
            itemcost[7] = Convert.ToDouble(rtextBox2.Text) * price_rice;
            itemcost[8] = Convert.ToDouble(mtextBox3.Text) * price_Manchurian;
            itemcost[9] = Convert.ToDouble(ntextBox4.Text) * price_noodles;


            subtotal = itemcost[0] + itemcost[1] + itemcost[2] + itemcost[3] + itemcost[4] + itemcost[5] + itemcost[6] + itemcost[7] + itemcost[8] + itemcost[9];

            subtot_textbox.Text = Convert.ToString(subtotal);
            tax = (subtotal * Tax_Rate) / 100;
            Tax_textBox.Text = Convert.ToString(tax);
            total = (subtotal + tax);
            tot_textBox.Text = Convert.ToString(total);

        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            if (subtotal == 0)
            {
                MessageBox.Show("You should Order Something First","Error");
            }
            else
            {
                new Confirm_Order().Show();
                this.Hide();
            }
        }

        private void smallcheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (smallcheckBox1.Checked == true)
            {
                smalltextBox1.Enabled = true;
                smalltextBox1.Text = "";
                smalltextBox1.Focus();

            }
            else
            {
                smalltextBox1.Enabled = false;
                smalltextBox1.Text = "0";
            }
        }

        private void mediumcheckBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (mediumcheckBox2.Checked == true)
            {
                mediumtextBox2.Enabled = true;
                mediumtextBox2.Text = "";
                mediumtextBox2.Focus();

            }
            else
            {
                mediumtextBox2.Enabled = false;
                mediumtextBox2.Text = "0";
            }
        }

        private void lagecheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            //largetextBox3
            if (lagecheckBox1.Checked == true)
            {
                largetextBox3.Enabled = true;
                largetextBox3.Text = "";
                largetextBox3.Focus();

            }
            else
            {
                largetextBox3.Enabled = false;
                largetextBox3.Text = "0";
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            //zingertextBox
            if (checkBox7.Checked == true)
            {
                zingertextBox.Enabled = true;
                zingertextBox.Text = "";
                zingertextBox.Focus();

            }
            else
            {
                zingertextBox.Enabled = false;
                zingertextBox.Text = "0";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            //BeeftextBox
            if (checkBox5.Checked == true)
            {
                BeeftextBox.Enabled = true;
                BeeftextBox.Text = "";
                BeeftextBox.Focus();

            }
            else
            {
                BeeftextBox.Enabled = false;
                BeeftextBox.Text = "0";
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            //chickentextBox
            if (checkBox6.Checked == true)
            {
                chickentextBox.Enabled = true;
                chickentextBox.Text = "";
                chickentextBox.Focus();

            }
            else
            {
                chickentextBox.Enabled = false;
                chickentextBox.Text = "0";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //stextBox1
            if (checkBox1.Checked == true)
            {
                stextBox1.Enabled = true;
                stextBox1.Text = "";
                stextBox1.Focus();

            }
            else
            {
                stextBox1.Enabled = false;
                stextBox1.Text = "0";
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            //rtextBox2
            if (checkBox2.Checked == true)
            {
                rtextBox2.Enabled = true;
                rtextBox2.Text = "";
                rtextBox2.Focus();

            }
            else
            {
                rtextBox2.Enabled = false;
                rtextBox2.Text = "0";
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            //mtextBox3
            if (checkBox3.Checked == true)
            {
                mtextBox3.Enabled = true;
                mtextBox3.Text = "";
                mtextBox3.Focus();

            }
            else
            {
                mtextBox3.Enabled = false;
                mtextBox3.Text = "0";
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            //ntextBox4
            if (checkBox4.Checked == true)
            {
                ntextBox4.Enabled = true;
                ntextBox4.Text = "";
                ntextBox4.Focus();

            }
            else
            {
                ntextBox4.Enabled = false;
                ntextBox4.Text = "0";
            }
        }
  }
 }

        

        

        

       
        

      

        
       
    


