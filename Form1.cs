using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Threading;

namespace Rolex_Shop
{
    public partial class Form1 : Form
    {
        //global Varriables
        double pepsiPrice = 100.25;
        double datejustPrice = 200.75;
        double daytonaPrice = 150.75;
        int numPepsi;
        int numDatejust;
        int numDaytona;
        double tendered;
        double money;
        double pepsiReceipt;
        double daytonaReceipt;
        double datejustReceipt;

        SoundPlayer error;
        public Form1()
        {
            InitializeComponent();
            printButton.Visible = false;
            //error = new SoundPlayer(Properties.Resources.ERROR); havent added sound of a cash register yet if you could do that.
            titleLabel.Visible = false;
        }

        private void totalButton_Click(object sender, EventArgs e)
        {
            //when total button is pressed, convert the input to integers, calculate the subtotal, tax and total price.
            //Catch error when user dont enter a number or enter a text message...
            try
            {
                numPepsi = Convert.ToInt16(pepsiInput.Text);
                //numDatejust = Convert.ToInt16(dateInput.Text); cant get it working
                numDaytona = Convert.ToInt16(daytonaInput.Text);


                double banhmi = numPepsi * pepsiPrice;
                double ramen = numDatejust * datejustPrice;
                double boba = numDaytona * daytonaPrice;

                //pepsiReceipt = pepsi;
                //datejustReceipt = datejust; cant get it working
                //daytonaReceipt = daytona;

                double subTotalPrice = (banhmi) + (ramen) + (boba);
                double tax = subTotalPrice * 0.13;
                double totalPrice = subTotalPrice + tax;
                money = totalPrice;

                //subinputLabel.Text = subTotalPrice.ToString("0.00");
                //taxinputLabel.Text = tax.ToString("0.00");
                //totalinputLabel.Text = totalPrice.ToString("0.00"); not working
            }
            catch
            {
                subinputlabel.Text = $"Error";
                taxinputlabel.Text = $"Error";
                //totalinputlabel.Text = $"Error"; not working
                error.Play();
            }


        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            // when calculate change button is pressed, convert the tendered input to double, calculate the change
            // if the tendered money is lower than the total = error
            try
            {
                double changeInput = Convert.ToInt16(tenderedInput.Text);
                double change = (changeInput) - (money);
                changebackLabel.Text = change.ToString("0.00");

                if (change < 0)
                {
                    changebackLabel.Text = $"U r broke";

                }

                printButton.Visible = true;
            }
            catch
            {
                changebackLabel.Text = $"ERROR";
                error.Play();
            }


        }



        private void receiptButton_Click(object sender, EventArgs e)

        // when receipt button click, print receipt.
        {
            try
            {
                tendered = Convert.ToDouble(tenderedInput.Text);
                //SoundPlayer cashPlay = new SoundPlayer(Properties.Resources.receiptSound); sound required
                //cashPlay.Play();
                receiptInput.Text += $"                  {titleLabel.Text}";

                //cashPlay.Play();
                this.Refresh();
                Thread.Sleep(500);

                //receiptInput.Text += $"\n{line.Text}"; not sure

                this.Refresh();
                Thread.Sleep(500);

                //receiptInput.Text += $"\n{line.Text}";

                this.Refresh();
                Thread.Sleep(500);

                //receiptInput.Text += $"\n{numDatejust}           {datejustLabel.Text}                       ${datejusteceipt.ToString("0.00")}";

                this.Refresh();
                Thread.Sleep(500);

               ///* receiptInput.Text += $"\n{numDaytona}  not sure         {daytonaLabel.Text} */            ${daytonaReceipt.ToString("0.00")}";

                this.Refresh();
                Thread.Sleep(500);

                //receiptInput.Text += $"\n{numPepsi}           {pepsiLabel.Text}                          /*   ${pepsiReceipt.ToString("0.00")}";*/

                this.Refresh();
                Thread.Sleep(500);

                //receiptInput.Text += $"\n{line.Text}";

                this.Refresh();
                Thread.Sleep(500);

                receiptInput.Text += $"\n{subinputlabel.Text}                                       ${subinputlabel.Text}";

                this.Refresh();
                Thread.Sleep(500);

                receiptInput.Text += $"\n{taxinputlabel.Text}                                                 ${taxinputlabel.Text}";

                this.Refresh();
                Thread.Sleep(500);

                //receiptInput.Text += $"\n{totalinputlabel.Text}                                              ${totalinputLabel.Text}";

                this.Refresh();
                Thread.Sleep(500);

                //receiptInput.Text += $"\n{line.Text}";

                this.Refresh();
                Thread.Sleep(500);

                receiptInput.Text += $"\n{tenderedInput.Text}                                       ${tendered.ToString("0.00")}";

                this.Refresh();
                Thread.Sleep(500);

                //receiptInput.Text += $"\n{changeLabel.Text}                                            ${changeInput.Text}";

                this.Refresh();
                Thread.Sleep(500);

                //receiptInput.Text += $"\n{line.Text}";

                this.Refresh();
                Thread.Sleep(500);

                receiptInput.Text += $"\n                            Thank You!";

                this.Refresh();
                Thread.Sleep(500);
                receiptInput.Text += $"\n                         Have a nice day!!";
                /*receiptLabel.Text += $"\n */                          /*23rd Feb 2024";*/
            }
            catch
            {
                receiptInput.Text = $"ERROR";
                error.Play();
            }








        }

        private void neworderButton_Click(object sender, EventArgs e)
        {
            //when new order button is clicked reset the input to 0, reset all the label to " " (empty).
            numPepsi = 0;
            numDatejust = 0;
            numDaytona = 0;
            tendered = 0;

            //datejustInput.Text = " ";
            daytonaInput.Text = " ";
            pepsiInput.Text = " ";
            //subinputLabel.Text = " ";
            taxinputlabel.Text = " ";
            //totalinputlabel.Text = " ";
            tenderedInput.Text = " ";
            changebackLabel.Text = " ";
            receiptInput.Text = " ";




        }
    }
    }
    }
    }
}
