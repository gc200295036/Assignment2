using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a2nickbrazda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Meal Ordering Form: Created By Nicolas Brazda ~ Last Updated on Sat-December-08/2018
        private void btnOrderNow_Click(object sender, EventArgs e)
        {
            //array "price" (bagel = $3.95, Vegetarian Special = 10.95$ Protein Platter 11.95$)
            double[] price = { 3.95, 10.95, 11.95 };

            int item = comboBox1.SelectedIndex;
            int item2 = comboBox2.SelectedIndex;
            int item3 = comboBox3.SelectedIndex;
            double quantity1;
            double quantity2;
            double quantity3;

            if (comboBox1.SelectedIndex != -1)
            {
                bool isNum = double.TryParse(textBox1.Text, out quantity1);
                if (isNum && quantity1 > 0)
                {

                }

                if (comboBox2.SelectedIndex != -1)
                {
                    bool isNum2 = double.TryParse(textBox2.Text, out quantity2);
                    if (isNum2 && quantity2 > 0)
                        if (comboBox3.SelectedIndex != -1)
                        {
                            bool isNum3 = double.TryParse(textBox3.Text, out quantity3);
                            if (isNum3 && quantity3 > 0)
                            {   //0.13 cent tax
                                double Tax = 0.13;
                                // calculate subtotal
                                double subtotal = price[item] * quantity1 + price[item2] * quantity2 + price[item3] * quantity3;
                                // subtotal * 0.13 (salesTaxRate)
                                double salesTax = subtotal * Tax;
                                // add subtotal + taxes together for Total cost
                                double Total = subtotal + salesTax;
                                //display calculations to label
                                lblTaxes.Text = Convert.ToString(salesTax);
                                lblTotal.Text = Convert.ToString(Total);
                                lblSubtotal.Text = Convert.ToString(subtotal);
                                // Display Invalid labels for special characters in Textboxes



                            }
                        }
                }
            }

        }
        // Make Textboxes Display an Error Message When typing in special characters:
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        { 
         try
        {
         int i = Convert.ToInt32(textBox1.Text.Trim());
        }
        catch
        {
         MessageBox.Show("You Must Enter a Valid Number");
                }
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        {
        try
        {
        int i = Convert.ToInt32(textBox1.Text.Trim());
        }
        catch
        {
        MessageBox.Show("You Must Enter a Valid Number");
                    }
                }
            }

            private void textBox3_TextChanged(object sender, EventArgs e)
            {
                {
                    try
                    {
                        int i = Convert.ToInt32(textBox1.Text.Trim());
                    }
                    catch
                    {
                        MessageBox.Show("You Must Enter a Valid Number");
                    }
                }
            }
        }
    }
        
    
















