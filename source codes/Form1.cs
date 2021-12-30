using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace PizzaCalcultor
{
    public partial class PizzaCalculator : Form
    {
        public PizzaCalculator()
        {
            InitializeComponent();
        }
        Pizza customerPizza = new Pizza();

        

            private void PizzaCalculator_Load(object sender, EventArgs e)
        {
            String[] toppings = { "Pepperoni", "Sausage", "Ham", "Anchovies", "Onion", "Green Pepper", "Mushrooms", "Jalapeno", "Xtra Cheese" };
            chkLstToppings.Items.Clear();
            foreach (string topping in toppings) {
                chkLstToppings.Items.Add(topping);
            }
            radSmall.Checked = true;
            radThin.Checked = true;
            radCarryOut.Checked = true;

            String today = DateTime.Now.ToString("dd-MM-yyyy");
            lblDate.Text = today;
            String Username = "Username";
            lblUsernaame.Text = Username; 
        }

        private bool TestNameAndAddress()
        {
            bool error = false;
            if (String.IsNullOrEmpty(txtName.Text))
            {
                error = true;
                MessageBox.Show("Name is Required for all orders", "Name Error");
                txtName.Focus();
            }
            if (radDelivery.Checked && (String.IsNullOrEmpty(txtAddress.Text) || String.IsNullOrEmpty(txtCity.Text) || String.IsNullOrEmpty(txtZip.Text)))
            {
                error = true;
                MessageBox.Show("Full Address is Required for all delivery orders", "Delivery error");

            }
            return error;
        }

        private void btnProcessOrder_Click(object sender, EventArgs e)
        {
            if(!TestNameAndAddress())
            {
                customerPizza.ItemName = "Build Your Own";
                customerPizza.ItemDescription = "Build Your own Custom Pizza with any Toppings";

                if (radSmall.Checked)
                {
                    customerPizza.Size = "Small";
                }
                else if (radMedium.Checked)
                {
                    customerPizza.Size = "Medium";
                }
                else if (radLarge.Checked)
                {
                    customerPizza.Size = "Large";
                }
                else
                {
                    customerPizza.Size = "XtraLarge";
                }

                if (radThin.Checked)
                {
                    customerPizza.CrustType = "Crunchy Thin";
                }
                else if (radHandTossed.Checked)
                {
                    customerPizza.CrustType = "Hand Tossed";
                }
                else if (radPan.Checked)
                {
                    customerPizza.CrustType = "Pan";
                }
                else
                {
                    customerPizza.CrustType = "Brooklyn";
                }
                customerPizza.NumberOfToppings = chkLstToppings.CheckedItems.Count;

                customerPizza.Price = Pizza.CalculatePriceOfPizza(customerPizza);
                
                if (chkPizzaClubMember.Checked)
                {
                    customerPizza.Price = customerPizza.Price * 0.90F;
                }

                lstOutput.Items.Clear();
                lstOutput.Items.Add(customerPizza.ItemName + "\n");
                lstOutput.Items.Add(customerPizza.ItemDescription + "\n");
                lstOutput.Items.Add("");
                lstOutput.Items.Add("You Ordered a " + customerPizza.Size + "Pizza with a" + customerPizza.CrustType + "Crust.\n");
                lstOutput.Items.Add("with the following toppings:");
                for (int i = 0; i < chkLstToppings.CheckedItems.Count; i++)
                {
                    lstOutput.Items.Add(" " + chkLstToppings.CheckedItems[i] + "\n");
                }
                lstOutput.Items.Add("");
                lstOutput.Items.Add("Your Total is: " + customerPizza.Price);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

          
            radBrooklyn.Checked = false; // disable 
            radCarryOut.Checked =true; // disable 
            radDelivery.Checked = false; // disable 
            radHandTossed.Checked = false; // disable 
            radiXtraLarge.Checked = false; // disable 
            radLarge.Checked = false; // disable 
            radMedium.Checked = false; // disable
            radPan.Checked = false; // disable 
            radSmall.Checked = true; // disable 
            radThin.Checked = true; // disable 
            chkPizzaClubMember.Checked = false; //disable checkbox
            lstOutput.Items.Clear();//clear list


            //clear checklist view
            foreach (ListViewItem item in chkLstToppings.Items)
            {
                item.Checked = false;
            }





        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
