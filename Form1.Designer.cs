namespace Rolex_Shop
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.numberWatches_Label = new System.Windows.Forms.Label();
            this.numberBracelets_Label = new System.Windows.Forms.Label();
            this.numberCufflinks_Label = new System.Windows.Forms.Label();
            this.watchBox = new System.Windows.Forms.TextBox();
            this.braceletBox = new System.Windows.Forms.TextBox();
            this.cufflinkBox = new System.Windows.Forms.TextBox();
            this.title = new System.Windows.Forms.Label();
            this.subTotal_Label = new System.Windows.Forms.Label();
            this.totalCost_Label = new System.Windows.Forms.Label();
            this.taxTotal_Label = new System.Windows.Forms.Label();
            this.divider1_Label = new System.Windows.Forms.Label();
            this.calculateTotal_Button = new System.Windows.Forms.Button();
            this.amountTendered_Label = new System.Windows.Forms.Label();
            this.tenderedBox = new System.Windows.Forms.TextBox();
            this.changeGiven_Label = new System.Windows.Forms.Label();
            this.calculateChange_Button = new System.Windows.Forms.Button();
            this.divider2_Label = new System.Windows.Forms.Label();
            this.printReceipt_Button = new System.Windows.Forms.Button();
            this.tryCatch_Label = new System.Windows.Forms.Label();
            this.newOrder_Button = new System.Windows.Forms.Button();
            this.changeError_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberWatches_Label
            // 
            this.numberWatches_Label.AutoSize = true;
            this.numberWatches_Label.Location = new System.Drawing.Point(12, 62);
            this.numberWatches_Label.Name = "numberWatches_Label";
            this.numberWatches_Label.Size = new System.Drawing.Size(102, 13);
            this.numberWatches_Label.TabIndex = 1;
            this.numberWatches_Label.Text = "Number of Watches";
            // 
            // numberBracelets_Label
            // 
            this.numberBracelets_Label.AutoSize = true;
            this.numberBracelets_Label.Location = new System.Drawing.Point(12, 88);
            this.numberBracelets_Label.Name = "numberBracelets_Label";
            this.numberBracelets_Label.Size = new System.Drawing.Size(103, 13);
            this.numberBracelets_Label.TabIndex = 2;
            this.numberBracelets_Label.Text = "Number of Bracelets";
            // 
            // numberCufflinks_Label
            // 
            this.numberCufflinks_Label.AutoSize = true;
            this.numberCufflinks_Label.Location = new System.Drawing.Point(12, 114);
            this.numberCufflinks_Label.Name = "numberCufflinks_Label";
            this.numberCufflinks_Label.Size = new System.Drawing.Size(99, 13);
            this.numberCufflinks_Label.TabIndex = 3;
            this.numberCufflinks_Label.Text = "Number of Cufflinks";
            // 
            // watchBox
            // 
            this.watchBox.Location = new System.Drawing.Point(145, 59);
            this.watchBox.Name = "watchBox";
            this.watchBox.Size = new System.Drawing.Size(43, 20);
            this.watchBox.TabIndex = 4;
            // 
            // braceletBox
            // 
            this.braceletBox.Location = new System.Drawing.Point(145, 85);
            this.braceletBox.Name = "braceletBox";
            this.braceletBox.Size = new System.Drawing.Size(43, 20);
            this.braceletBox.TabIndex = 5;
            // 
            // cufflinkBox
            // 
            this.cufflinkBox.Location = new System.Drawing.Point(145, 111);
            this.cufflinkBox.Name = "cufflinkBox";
            this.cufflinkBox.Size = new System.Drawing.Size(43, 20);
            this.cufflinkBox.TabIndex = 6;
            // 
            // title
            // 
            this.title.BackColor = System.Drawing.Color.DarkGreen;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.ImageAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.title.Location = new System.Drawing.Point(-2, -1);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(490, 48);
            this.title.TabIndex = 8;
            this.title.Text = "  Rolex Luxury Collection";
            this.title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // subTotal_Label
            // 
            this.subTotal_Label.Location = new System.Drawing.Point(9, 172);
            this.subTotal_Label.Name = "subTotal_Label";
            this.subTotal_Label.Size = new System.Drawing.Size(176, 17);
            this.subTotal_Label.TabIndex = 9;
            this.subTotal_Label.Text = "Sub Total:";
            // 
            // totalCost_Label
            // 
            this.totalCost_Label.Location = new System.Drawing.Point(9, 226);
            this.totalCost_Label.Name = "totalCost_Label";
            this.totalCost_Label.Size = new System.Drawing.Size(176, 17);
            this.totalCost_Label.TabIndex = 10;
            this.totalCost_Label.Text = "Total:";
            // 
            // taxTotal_Label
            // 
            this.taxTotal_Label.Location = new System.Drawing.Point(9, 200);
            this.taxTotal_Label.Name = "taxTotal_Label";
            this.taxTotal_Label.Size = new System.Drawing.Size(176, 17);
            this.taxTotal_Label.TabIndex = 11;
            this.taxTotal_Label.Text = "Tax:";
            // 
            // divider1_Label
            // 
            this.divider1_Label.BackColor = System.Drawing.Color.Black;
            this.divider1_Label.Location = new System.Drawing.Point(12, 252);
            this.divider1_Label.Name = "divider1_Label";
            this.divider1_Label.Size = new System.Drawing.Size(176, 13);
            this.divider1_Label.TabIndex = 12;
            // 
            // calculateTotal_Button
            // 
            this.calculateTotal_Button.Location = new System.Drawing.Point(12, 137);
            this.calculateTotal_Button.Name = "calculateTotal_Button";
            this.calculateTotal_Button.Size = new System.Drawing.Size(176, 23);
            this.calculateTotal_Button.TabIndex = 13;
            this.calculateTotal_Button.Text = "Calculate Totals";
            this.calculateTotal_Button.UseVisualStyleBackColor = true;
            this.calculateTotal_Button.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // amountTendered_Label
            // 
            this.amountTendered_Label.AutoSize = true;
            this.amountTendered_Label.Location = new System.Drawing.Point(12, 276);
            this.amountTendered_Label.Name = "amountTendered_Label";
            this.amountTendered_Label.Size = new System.Drawing.Size(92, 13);
            this.amountTendered_Label.TabIndex = 14;
            this.amountTendered_Label.Text = "Amount Tendered";
            // 
            // tenderedBox
            // 
            this.tenderedBox.Location = new System.Drawing.Point(145, 273);
            this.tenderedBox.Name = "tenderedBox";
            this.tenderedBox.Size = new System.Drawing.Size(43, 20);
            this.tenderedBox.TabIndex = 15;
            // 
            // changeGiven_Label
            // 
            this.changeGiven_Label.Location = new System.Drawing.Point(12, 325);
            this.changeGiven_Label.Name = "changeGiven_Label";
            this.changeGiven_Label.Size = new System.Drawing.Size(204, 26);
            this.changeGiven_Label.TabIndex = 16;
            this.changeGiven_Label.Text = "Change: ";
            // 
            // calculateChange_Button
            // 
            this.calculateChange_Button.Location = new System.Drawing.Point(12, 299);
            this.calculateChange_Button.Name = "calculateChange_Button";
            this.calculateChange_Button.Size = new System.Drawing.Size(176, 23);
            this.calculateChange_Button.TabIndex = 17;
            this.calculateChange_Button.Text = "Calculate Change";
            this.calculateChange_Button.UseVisualStyleBackColor = true;
            this.calculateChange_Button.Click += new System.EventHandler(this.calculateChange_Button_Click);
            // 
            // divider2_Label
            // 
            this.divider2_Label.BackColor = System.Drawing.Color.Black;
            this.divider2_Label.Location = new System.Drawing.Point(12, 351);
            this.divider2_Label.Name = "divider2_Label";
            this.divider2_Label.Size = new System.Drawing.Size(176, 13);
            this.divider2_Label.TabIndex = 18;
            // 
            // printReceipt_Button
            // 
            this.printReceipt_Button.Location = new System.Drawing.Point(12, 377);
            this.printReceipt_Button.Name = "printReceipt_Button";
            this.printReceipt_Button.Size = new System.Drawing.Size(176, 23);
            this.printReceipt_Button.TabIndex = 19;
            this.printReceipt_Button.Text = "Print Receipt";
            this.printReceipt_Button.UseVisualStyleBackColor = true;
            this.printReceipt_Button.Click += new System.EventHandler(this.printReceipt_Button_Click);
            // 
            // tryCatch_Label
            // 
            this.tryCatch_Label.AutoSize = true;
            this.tryCatch_Label.Location = new System.Drawing.Point(256, 361);
            this.tryCatch_Label.Name = "tryCatch_Label";
            this.tryCatch_Label.Size = new System.Drawing.Size(179, 13);
            this.tryCatch_Label.TabIndex = 20;
            this.tryCatch_Label.Text = "Must be a number value of at least 0";
            // 
            // newOrder_Button
            // 
            this.newOrder_Button.Location = new System.Drawing.Point(259, 378);
            this.newOrder_Button.Name = "newOrder_Button";
            this.newOrder_Button.Size = new System.Drawing.Size(176, 23);
            this.newOrder_Button.TabIndex = 21;
            this.newOrder_Button.Text = "New Order";
            this.newOrder_Button.UseVisualStyleBackColor = true;
            this.newOrder_Button.Click += new System.EventHandler(this.newOrder_Button_Click);
            // 
            // changeError_Label
            // 
            this.changeError_Label.AutoSize = true;
            this.changeError_Label.Location = new System.Drawing.Point(245, 341);
            this.changeError_Label.Name = "changeError_Label";
            this.changeError_Label.Size = new System.Drawing.Size(199, 13);
            this.changeError_Label.TabIndex = 23;
            this.changeError_Label.Text = "Must be equal to or more than Total Cost";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(487, 413);
            this.Controls.Add(this.changeError_Label);
            this.Controls.Add(this.newOrder_Button);
            this.Controls.Add(this.tryCatch_Label);
            this.Controls.Add(this.printReceipt_Button);
            this.Controls.Add(this.divider2_Label);
            this.Controls.Add(this.calculateChange_Button);
            this.Controls.Add(this.changeGiven_Label);
            this.Controls.Add(this.tenderedBox);
            this.Controls.Add(this.amountTendered_Label);
            this.Controls.Add(this.calculateTotal_Button);
            this.Controls.Add(this.divider1_Label);
            this.Controls.Add(this.taxTotal_Label);
            this.Controls.Add(this.totalCost_Label);
            this.Controls.Add(this.subTotal_Label);
            this.Controls.Add(this.title);
            this.Controls.Add(this.cufflinkBox);
            this.Controls.Add(this.braceletBox);
            this.Controls.Add(this.watchBox);
            this.Controls.Add(this.numberCufflinks_Label);
            this.Controls.Add(this.numberBracelets_Label);
            this.Controls.Add(this.numberWatches_Label);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Rolex Luxury Collection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.Label numberWatches_Label;
        private System.Windows.Forms.Label numberBracelets_Label;
        private System.Windows.Forms.Label numberCufflinks_Label;
        private System.Windows.Forms.TextBox watchBox;
        private System.Windows.Forms.TextBox braceletBox;
        private System.Windows.Forms.TextBox cufflinkBox;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Label subTotal_Label;
        private System.Windows.Forms.Label totalCost_Label;
        private System.Windows.Forms.Label taxTotal_Label;
        private System.Windows.Forms.Label divider1_Label;
        private System.Windows.Forms.Button calculateTotal_Button;
        private System.Windows.Forms.Label amountTendered_Label;
        private System.Windows.Forms.TextBox tenderedBox;
        private System.Windows.Forms.Label changeGiven_Label;
        private System.Windows.Forms.Button calculateChange_Button;
        private System.Windows.Forms.Label divider2_Label;
        private System.Windows.Forms.Button printReceipt_Button;
        private System.Windows.Forms.Label tryCatch_Label;
        private System.Windows.Forms.Button newOrder_Button;
        private System.Windows.Forms.Label changeError_Label;
    }
}
