using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BAPAss1
{
    public partial class Form1 : Form
    {
        //Server Login Variables
        public String serverName;
        public int tableNo;

        //Pizza pricing variables
        decimal margheritaPrice = 9;
        decimal pepperoniPrice = 11.50m;
        decimal hawaiianPrice = 12.79m;
        int margheritasOrdered;
        int pepperonisOrdered;
        int hawaiiansOrdered;
        int itemsOrdered;
        decimal orderTotal;

        //Service Charge does not change and as such remains a Constant
        const decimal SERVICE_CHARGE = 2.49m;

        //Summary Data Variables
        int transactionTotal = 0;
        int pizzaTotal = 0;
        decimal totalReceipts = 0;
        decimal averageTransactions = 0;

        public Form1()
        {
            InitializeComponent();
        }

        //Server Login Method
        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                /*Gets Server Name as text and converts Table Number to Integer
                Exception is thrown if Table Number can't be converted to an Integer
                an error is thrown*/
                serverName = nameBox.Text;
                tableNo = Int32.Parse(tableBox.Text);
                //Checks that both fields are not null 
                if ((serverName != null) && (tableBox != null))
                {
                    serverLoginBox.Visible = false;
                    pizzaMenuBox.Visible = true;
                    orderControlBox.Visible = true;
                }
            }
            catch {
                MessageBox.Show("Please enter a Name and Table Number. Table Number may only contain numbers.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Exit the application
        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Enter table order
        private void orderButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Converts quantity entered into Integers
                margheritasOrdered = Int32.Parse(margheritaPizzaBox.Text);
                pepperonisOrdered = Int32.Parse(pepperoniPizzaBox.Text);
                hawaiiansOrdered = Int32.Parse(hawaiianPizzaBox.Text);

                //Calculating total price of the order and quantity of items ordered
                orderTotal = ((margheritaPrice * margheritasOrdered) + (pepperoniPrice * pepperonisOrdered) + (hawaiianPrice * hawaiiansOrdered) + SERVICE_CHARGE);
                itemsOrdered = (margheritasOrdered + pepperonisOrdered + hawaiiansOrdered);

                //Populating order summary details
                nameBox2.Text = serverName;
                itemBox.Text = itemsOrdered.ToString();
                billBox.Text = orderTotal.ToString();

                //Summary Data
                transactionTotal++;
                pizzaTotal = pizzaTotal + margheritasOrdered + pepperonisOrdered + hawaiiansOrdered;
                totalReceipts = totalReceipts + orderTotal;

                orderSummaryBox.Visible = true;
                summaryBox.Visible = false;
            }
            catch {
                MessageBox.Show("Please enter a value for all Items", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Clears Server inputs
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Resetting textboxes to default
            margheritaPizzaBox.Text = "0";
            pepperoniPizzaBox.Text = "0";
            hawaiianPizzaBox.Text = "0";

            nameBox2.Text = "";
            itemBox.Text = "";
            billBox.Text = "";

            nameBox.Text = "";
            tableBox.Text = "";

            summaryBox.Visible = false;
            orderSummaryBox.Visible = false;
            serverLoginBox.Visible = true;
            pizzaMenuBox.Visible = false;
            orderControlBox.Visible = false;

            //Reset Variables for new login
            margheritasOrdered = 0;
            pepperonisOrdered = 0;
            hawaiiansOrdered = 0;
            itemsOrdered = 0;
            transactionTotal = 0;
            pizzaTotal = 0;
            totalReceipts = 0;
            averageTransactions = 0;

            //Renables the order button for next user if disabled by Summary
            if (orderButton.Enabled == false)
            {
                orderButton.Enabled = true;
            }

        }

        private void summaryButton_Click(object sender, EventArgs e)
        {
            try {
            summaryBox.Visible = true;
            orderSummaryBox.Visible = true;
            pizzaMenuBox.Visible = false;

            averageTransactions = totalReceipts / transactionTotal;

            //Populating Summary Data
            transactionBox.Text = transactionTotal.ToString();
            pizzaTotalBox.Text = pizzaTotal.ToString();
            totalReceiptBox.Text = "€" + totalReceipts.ToString();
            avgBox.Text = "€" + averageTransactions.ToString();

            orderButton.Enabled = false;
            }
            catch
            {
                MessageBox.Show("An order must be placed before a summary is available.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                summaryBox.Visible = false;
                orderSummaryBox.Visible = false;
                pizzaMenuBox.Visible = true;
            }
        }
    }
}
