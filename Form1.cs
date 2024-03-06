using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rolex_Shop
{
    public partial class Form1 : Form
    {
        //Declaring global constants
        //Tax cost 
        const double TAXES_COST = 0.13;
        //Item cost 
        const double WATCH_COST = 25000.99;
        const double BRACELET_COST = 5000.49; 
        const double CUFFLINK_COST = 1500.99;

        //Declaring global variables and setting to 0 
        //Number of each item purchased 
        int watchesPurchased = 0;
        int braceletsPurchased = 0;
        int cufflinksPurchased = 0;
        //Costs
        double totalCost = 0;
        double taxTotal = 0;
        double subTotal = 0;
        //Amount given to pay
        double amountTendered = 0;
        //Change given 
        double changeGiven = 0;
        // Order number on receipt
        int orderNum = 1;

        //Declare all graphics
        Graphics g;
        Pen blackPen = new Pen(Color.Black, 5);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        Font titleFont = new Font("Courier", 15, FontStyle.Bold);
        Font normalFont = new Font("Courier", 10);

        //Declare global sounds
        // SoundPlayer printerPlayer = new SoundPlayer(Properties.Resources.printerSound);

        public Form1()
        {
            InitializeComponent();

            //Declare Graphic 
            g = this.CreateGraphics();

            //Try catch label is not visible
            tryCatch_Label.Visible = false;
            //New order button is not visible
            newOrder_Button.Visible = false;
            //Change Error button is not visible
            changeError_Label.Visible = false;

            //Buttons are disabled to be subsequently enabled later 
            printReceipt_Button.Enabled = false;
            calculateChange_Button.Enabled = false;
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            //Program assumes no value in text boxes = 0
            if (watchBox.Text == "")
            {
                watchBox.Text = "0";
            }

            if (braceletBox.Text == "")
            {
                braceletBox.Text = "0";
            }

            if (cufflinkBox.Text == "")
            {
                cufflinkBox.Text = "0";
            }

            //Try-Catch in case value entered is not numerical
            try
            {
                //Text box values are converted to variables.
                watchesPurchased = Convert.ToInt32(watchBox.Text);
                braceletsPurchased = Convert.ToInt32(braceletBox.Text);
                cufflinksPurchased = Convert.ToInt32(cufflinkBox.Text);

                //Totals are calculated
                subTotal = watchesPurchased * WATCH_COST + braceletsPurchased * BRACELET_COST + cufflinksPurchased * CUFFLINK_COST;
                taxTotal = subTotal * TAXES_COST;
                totalCost = subTotal + taxTotal;

                //Totals are inputed into the labels
                taxTotal_Label.Text = "Taxes: " + taxTotal.ToString("C");
                subTotal_Label.Text = "Sub Total: " + subTotal.ToString("C");
                totalCost_Label.Text = "Total Cost: " + totalCost.ToString("C");

                //Calculate change button enabled
                calculateChange_Button.Enabled = true;
            }
            catch
            {
                //Try catch label is shown if the entry is invalid
                tryCatch_Label.Visible = true;
                return;
            }
        }

        private void calculateChange_Button_Click(object sender, EventArgs e)
        {
            try
            {
                //Amount tendered is converted
                amountTendered = Convert.ToDouble(tenderedBox.Text);

                // Amount tendered cannot be less than the total cost 
                if (amountTendered < totalCost)
                {
                    changeError_Label.Visible = true;
                    //Won't allow you to print receipt
                    printReceipt_Button.Enabled = false;
                }
                else
                {
                    // Allowed to print receipt
                    printReceipt_Button.Enabled = true;

                    // Change is calculated 
                    changeGiven = amountTendered - totalCost;

                    // Amount of change is displayed in the label
                    changeGiven_Label.Text = "Change: " + changeGiven.ToString("C");
                }
            }
            catch
            {
                // Try catch label is shown if the entry is invalid 
                tryCatch_Label.Visible = true;
                return;
            }
        }

        private void printReceipt_Button_Click(object sender, EventArgs e)
        {
            // Prevents printing the receipt multiple times
            printReceipt_Button.Enabled = false;
            calculateChange_Button.Enabled = false;
            calculateTotal_Button.Enabled = false;

            // Make text boxes read-only
            tenderedBox.ReadOnly = true;
            watchBox.ReadOnly = true;
            braceletBox.ReadOnly = true;
            cufflinkBox.ReadOnly = true;


            //logo_Label.Visible = false;

            tryCatch_Label.Visible = false;
            changeError_Label.Visible = false;

            //printerPlayer.Play();

            // Receipt printing drawing
            g.Clear(Color.White); // Clears the previous content
            g.DrawRectangle(blackPen, 225, 60, 230, 310);
            Thread.Sleep(500);
            g.DrawString("ROLEX SHOP", titleFont, blackBrush, 230, 70);
            Thread.Sleep(300);
            g.DrawString(DateTime.Now.ToString(), normalFont, blackBrush, 255, 110);
            Thread.Sleep(300);
            g.DrawString("Watches   x " + watchBox.Text + "   @ " + WATCH_COST.ToString("C"), normalFont, blackBrush, 230, 140);
            Thread.Sleep(300);
            g.DrawString("Bracelets  x " + braceletBox.Text + "  @ " + BRACELET_COST.ToString("C"), normalFont, blackBrush, 230, 155);
            Thread.Sleep(300);
            g.DrawString("Cufflinks   x " + cufflinkBox.Text + "   @ " + CUFFLINK_COST.ToString("C"), normalFont, blackBrush, 230, 170);
            Thread.Sleep(300);
            g.DrawString("Sub Total:            " + subTotal.ToString("C"), normalFont, blackBrush, 230, 200);
            Thread.Sleep(300);
            g.DrawString("Tax:                      " + taxTotal.ToString("C"), normalFont, blackBrush, 230, 215);
            Thread.Sleep(300);
            g.DrawString("Total:                    " + totalCost.ToString("C"), normalFont, blackBrush, 230, 230);
            Thread.Sleep(300);
            g.DrawString("Tendered:            " + amountTendered.ToString("C"), normalFont, blackBrush, 230, 245);
            Thread.Sleep(300);
            g.DrawString("Change:               " + changeGiven.ToString("C"), normalFont, blackBrush, 230, 260);
            Thread.Sleep(300);
            g.DrawString("Order Number: " + orderNum++, titleFont, blackBrush, 255, 290);
            Thread.Sleep(300);
            g.DrawString("A Crown for Every Achievement", normalFont, blackBrush, 25, 330);
            Thread.Sleep(2000);

            newOrder_Button.Visible = true;
        }

        private void newOrder_Button_Click(object sender, EventArgs e)
        {
            newOrder_Button.Visible = false;

            g.Clear(this.BackColor); 

            // Reset UI elements for a new order
            printReceipt_Button.Enabled = false;
            calculateChange_Button.Enabled = false;
            calculateTotal_Button.Enabled = true; // Re-enable the calculate total button

            // Clear text boxes and labels
            watchBox.Text = "";
            braceletBox.Text = "";
            cufflinkBox.Text = "";
            tenderedBox.Text = "";
            taxTotal_Label.Text = "Taxes: ";
            subTotal_Label.Text = "Sub Total:";
            totalCost_Label.Text = "Total Cost:";
            changeGiven_Label.Text = "Change:";

            // Reset variables to 0
            watchesPurchased = 0;
            braceletsPurchased = 0;
            cufflinksPurchased = 0;
            totalCost = 0;
            taxTotal = 0;
            subTotal = 0;
            amountTendered = 0;
            changeGiven = 0;

            // Make text boxes editable again
            tenderedBox.ReadOnly = false;
            watchBox.ReadOnly = false;
            braceletBox.ReadOnly = false;
            cufflinkBox.ReadOnly = false;
        }
    }
}
