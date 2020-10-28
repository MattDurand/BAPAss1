namespace BAPAss1
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
            this.serverLoginBox = new System.Windows.Forms.GroupBox();
            this.submitServerButton = new System.Windows.Forms.Button();
            this.tableBox = new System.Windows.Forms.TextBox();
            this.tableLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.pizzaMenuBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hawaiianPizzaBox = new System.Windows.Forms.TextBox();
            this.pepperoniPizzaBox = new System.Windows.Forms.TextBox();
            this.margheritaPizzaBox = new System.Windows.Forms.TextBox();
            this.HawaiianLabel = new System.Windows.Forms.Label();
            this.pepperoniLabel = new System.Windows.Forms.Label();
            this.margheritaLabel = new System.Windows.Forms.Label();
            this.orderControlBox = new System.Windows.Forms.GroupBox();
            this.exitButton = new System.Windows.Forms.Button();
            this.summaryButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.orderButton = new System.Windows.Forms.Button();
            this.orderSummaryBox = new System.Windows.Forms.GroupBox();
            this.summaryBox = new System.Windows.Forms.GroupBox();
            this.avgBox = new System.Windows.Forms.TextBox();
            this.totalReceiptBox = new System.Windows.Forms.TextBox();
            this.pizzaTotalBox = new System.Windows.Forms.TextBox();
            this.transactionBox = new System.Windows.Forms.TextBox();
            this.avgLabel = new System.Windows.Forms.Label();
            this.receiptsLabel = new System.Windows.Forms.Label();
            this.totalPizzas = new System.Windows.Forms.Label();
            this.transactionsLabel = new System.Windows.Forms.Label();
            this.itemsLabel = new System.Windows.Forms.Label();
            this.billLabel = new System.Windows.Forms.Label();
            this.nameLabel2 = new System.Windows.Forms.Label();
            this.itemBox = new System.Windows.Forms.TextBox();
            this.nameBox2 = new System.Windows.Forms.TextBox();
            this.billBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.serverLoginBox.SuspendLayout();
            this.pizzaMenuBox.SuspendLayout();
            this.orderControlBox.SuspendLayout();
            this.orderSummaryBox.SuspendLayout();
            this.summaryBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // serverLoginBox
            // 
            this.serverLoginBox.Controls.Add(this.submitServerButton);
            this.serverLoginBox.Controls.Add(this.tableBox);
            this.serverLoginBox.Controls.Add(this.tableLabel);
            this.serverLoginBox.Controls.Add(this.nameBox);
            this.serverLoginBox.Controls.Add(this.nameLabel);
            this.serverLoginBox.Location = new System.Drawing.Point(12, 12);
            this.serverLoginBox.Name = "serverLoginBox";
            this.serverLoginBox.Size = new System.Drawing.Size(452, 43);
            this.serverLoginBox.TabIndex = 0;
            this.serverLoginBox.TabStop = false;
            // 
            // submitServerButton
            // 
            this.submitServerButton.Location = new System.Drawing.Point(361, 10);
            this.submitServerButton.Name = "submitServerButton";
            this.submitServerButton.Size = new System.Drawing.Size(75, 23);
            this.submitServerButton.TabIndex = 4;
            this.submitServerButton.Text = "&Start";
            this.submitServerButton.UseVisualStyleBackColor = true;
            this.submitServerButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // tableBox
            // 
            this.tableBox.Location = new System.Drawing.Point(255, 12);
            this.tableBox.Name = "tableBox";
            this.tableBox.Size = new System.Drawing.Size(100, 20);
            this.tableBox.TabIndex = 3;
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.Location = new System.Drawing.Point(195, 15);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(54, 13);
            this.tableLabel.TabIndex = 2;
            this.tableLabel.Text = "Table No:";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(89, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(100, 20);
            this.nameBox.TabIndex = 1;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(11, 15);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(72, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Server Name:";
            // 
            // pizzaMenuBox
            // 
            this.pizzaMenuBox.Controls.Add(this.label1);
            this.pizzaMenuBox.Controls.Add(this.hawaiianPizzaBox);
            this.pizzaMenuBox.Controls.Add(this.pepperoniPizzaBox);
            this.pizzaMenuBox.Controls.Add(this.margheritaPizzaBox);
            this.pizzaMenuBox.Controls.Add(this.HawaiianLabel);
            this.pizzaMenuBox.Controls.Add(this.pepperoniLabel);
            this.pizzaMenuBox.Controls.Add(this.margheritaLabel);
            this.pizzaMenuBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pizzaMenuBox.Location = new System.Drawing.Point(12, 61);
            this.pizzaMenuBox.Name = "pizzaMenuBox";
            this.pizzaMenuBox.Size = new System.Drawing.Size(452, 100);
            this.pizzaMenuBox.TabIndex = 1;
            this.pizzaMenuBox.TabStop = false;
            this.pizzaMenuBox.Text = "Pizza Menu";
            this.pizzaMenuBox.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(333, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "€2.49 Service Charge \r\napplied to all tables \r\nafter order is placed";
            // 
            // hawaiianPizzaBox
            // 
            this.hawaiianPizzaBox.Location = new System.Drawing.Point(197, 74);
            this.hawaiianPizzaBox.Name = "hawaiianPizzaBox";
            this.hawaiianPizzaBox.Size = new System.Drawing.Size(100, 20);
            this.hawaiianPizzaBox.TabIndex = 5;
            this.hawaiianPizzaBox.Text = "0";
            this.hawaiianPizzaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pepperoniPizzaBox
            // 
            this.pepperoniPizzaBox.Location = new System.Drawing.Point(197, 47);
            this.pepperoniPizzaBox.Name = "pepperoniPizzaBox";
            this.pepperoniPizzaBox.Size = new System.Drawing.Size(100, 20);
            this.pepperoniPizzaBox.TabIndex = 4;
            this.pepperoniPizzaBox.Text = "0";
            this.pepperoniPizzaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // margheritaPizzaBox
            // 
            this.margheritaPizzaBox.Location = new System.Drawing.Point(197, 20);
            this.margheritaPizzaBox.Name = "margheritaPizzaBox";
            this.margheritaPizzaBox.Size = new System.Drawing.Size(100, 20);
            this.margheritaPizzaBox.TabIndex = 3;
            this.margheritaPizzaBox.Text = "0";
            this.margheritaPizzaBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // HawaiianLabel
            // 
            this.HawaiianLabel.AutoSize = true;
            this.HawaiianLabel.Location = new System.Drawing.Point(11, 77);
            this.HawaiianLabel.Name = "HawaiianLabel";
            this.HawaiianLabel.Size = new System.Drawing.Size(121, 13);
            this.HawaiianLabel.TabIndex = 2;
            this.HawaiianLabel.Text = "Hawaiian Pizza - €12.79";
            // 
            // pepperoniLabel
            // 
            this.pepperoniLabel.AutoSize = true;
            this.pepperoniLabel.Location = new System.Drawing.Point(11, 50);
            this.pepperoniLabel.Name = "pepperoniLabel";
            this.pepperoniLabel.Size = new System.Drawing.Size(125, 13);
            this.pepperoniLabel.TabIndex = 1;
            this.pepperoniLabel.Text = "Pepperoni Pizza - €11.50";
            // 
            // margheritaLabel
            // 
            this.margheritaLabel.AutoSize = true;
            this.margheritaLabel.Location = new System.Drawing.Point(11, 23);
            this.margheritaLabel.Name = "margheritaLabel";
            this.margheritaLabel.Size = new System.Drawing.Size(106, 13);
            this.margheritaLabel.TabIndex = 0;
            this.margheritaLabel.Text = "Margherita Pizza - €9";
            // 
            // orderControlBox
            // 
            this.orderControlBox.Controls.Add(this.exitButton);
            this.orderControlBox.Controls.Add(this.summaryButton);
            this.orderControlBox.Controls.Add(this.clearButton);
            this.orderControlBox.Controls.Add(this.orderButton);
            this.orderControlBox.Location = new System.Drawing.Point(12, 167);
            this.orderControlBox.Name = "orderControlBox";
            this.orderControlBox.Size = new System.Drawing.Size(452, 61);
            this.orderControlBox.TabIndex = 2;
            this.orderControlBox.TabStop = false;
            this.orderControlBox.Visible = false;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(361, 20);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "&Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // summaryButton
            // 
            this.summaryButton.Location = new System.Drawing.Point(243, 20);
            this.summaryButton.Name = "summaryButton";
            this.summaryButton.Size = new System.Drawing.Size(75, 23);
            this.summaryButton.TabIndex = 2;
            this.summaryButton.Text = "&Summary";
            this.summaryButton.UseVisualStyleBackColor = true;
            this.summaryButton.Click += new System.EventHandler(this.summaryButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(131, 19);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 1;
            this.clearButton.Text = "&Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // orderButton
            // 
            this.orderButton.Location = new System.Drawing.Point(14, 19);
            this.orderButton.Name = "orderButton";
            this.orderButton.Size = new System.Drawing.Size(75, 23);
            this.orderButton.TabIndex = 0;
            this.orderButton.Text = "&Order";
            this.orderButton.UseVisualStyleBackColor = true;
            this.orderButton.Click += new System.EventHandler(this.orderButton_Click);
            // 
            // orderSummaryBox
            // 
            this.orderSummaryBox.Controls.Add(this.summaryBox);
            this.orderSummaryBox.Controls.Add(this.itemsLabel);
            this.orderSummaryBox.Controls.Add(this.billLabel);
            this.orderSummaryBox.Controls.Add(this.nameLabel2);
            this.orderSummaryBox.Controls.Add(this.itemBox);
            this.orderSummaryBox.Controls.Add(this.nameBox2);
            this.orderSummaryBox.Controls.Add(this.billBox);
            this.orderSummaryBox.Location = new System.Drawing.Point(12, 235);
            this.orderSummaryBox.Name = "orderSummaryBox";
            this.orderSummaryBox.Size = new System.Drawing.Size(452, 135);
            this.orderSummaryBox.TabIndex = 3;
            this.orderSummaryBox.TabStop = false;
            this.orderSummaryBox.Text = "Table Order Summary";
            this.orderSummaryBox.Visible = false;
            // 
            // summaryBox
            // 
            this.summaryBox.Controls.Add(this.avgBox);
            this.summaryBox.Controls.Add(this.totalReceiptBox);
            this.summaryBox.Controls.Add(this.pizzaTotalBox);
            this.summaryBox.Controls.Add(this.transactionBox);
            this.summaryBox.Controls.Add(this.avgLabel);
            this.summaryBox.Controls.Add(this.receiptsLabel);
            this.summaryBox.Controls.Add(this.totalPizzas);
            this.summaryBox.Controls.Add(this.transactionsLabel);
            this.summaryBox.Location = new System.Drawing.Point(0, -1);
            this.summaryBox.Name = "summaryBox";
            this.summaryBox.Size = new System.Drawing.Size(453, 136);
            this.summaryBox.TabIndex = 6;
            this.summaryBox.TabStop = false;
            this.summaryBox.Text = "Company Summary Data";
            this.summaryBox.Visible = false;
            // 
            // avgBox
            // 
            this.avgBox.Enabled = false;
            this.avgBox.Location = new System.Drawing.Point(199, 103);
            this.avgBox.Name = "avgBox";
            this.avgBox.Size = new System.Drawing.Size(99, 20);
            this.avgBox.TabIndex = 7;
            // 
            // totalReceiptBox
            // 
            this.totalReceiptBox.Enabled = false;
            this.totalReceiptBox.Location = new System.Drawing.Point(199, 77);
            this.totalReceiptBox.Name = "totalReceiptBox";
            this.totalReceiptBox.Size = new System.Drawing.Size(99, 20);
            this.totalReceiptBox.TabIndex = 6;
            // 
            // pizzaTotalBox
            // 
            this.pizzaTotalBox.Enabled = false;
            this.pizzaTotalBox.Location = new System.Drawing.Point(198, 51);
            this.pizzaTotalBox.Name = "pizzaTotalBox";
            this.pizzaTotalBox.Size = new System.Drawing.Size(99, 20);
            this.pizzaTotalBox.TabIndex = 5;
            // 
            // transactionBox
            // 
            this.transactionBox.Enabled = false;
            this.transactionBox.Location = new System.Drawing.Point(199, 25);
            this.transactionBox.Name = "transactionBox";
            this.transactionBox.Size = new System.Drawing.Size(99, 20);
            this.transactionBox.TabIndex = 4;
            // 
            // avgLabel
            // 
            this.avgLabel.AutoSize = true;
            this.avgLabel.Location = new System.Drawing.Point(11, 101);
            this.avgLabel.Name = "avgLabel";
            this.avgLabel.Size = new System.Drawing.Size(118, 13);
            this.avgLabel.TabIndex = 3;
            this.avgLabel.Text = "Avg. Transaction Value";
            // 
            // receiptsLabel
            // 
            this.receiptsLabel.AutoSize = true;
            this.receiptsLabel.Location = new System.Drawing.Point(11, 75);
            this.receiptsLabel.Name = "receiptsLabel";
            this.receiptsLabel.Size = new System.Drawing.Size(76, 13);
            this.receiptsLabel.TabIndex = 2;
            this.receiptsLabel.Text = "Total Receipts";
            // 
            // totalPizzas
            // 
            this.totalPizzas.AutoSize = true;
            this.totalPizzas.Location = new System.Drawing.Point(11, 49);
            this.totalPizzas.Name = "totalPizzas";
            this.totalPizzas.Size = new System.Drawing.Size(64, 13);
            this.totalPizzas.TabIndex = 1;
            this.totalPizzas.Text = "Total Pizzas";
            // 
            // transactionsLabel
            // 
            this.transactionsLabel.AutoSize = true;
            this.transactionsLabel.Location = new System.Drawing.Point(11, 23);
            this.transactionsLabel.Name = "transactionsLabel";
            this.transactionsLabel.Size = new System.Drawing.Size(95, 13);
            this.transactionsLabel.TabIndex = 0;
            this.transactionsLabel.Text = "Total Transactions";
            // 
            // itemsLabel
            // 
            this.itemsLabel.AutoSize = true;
            this.itemsLabel.Location = new System.Drawing.Point(11, 54);
            this.itemsLabel.Name = "itemsLabel";
            this.itemsLabel.Size = new System.Drawing.Size(59, 13);
            this.itemsLabel.TabIndex = 4;
            this.itemsLabel.Text = "Total Items";
            // 
            // billLabel
            // 
            this.billLabel.AutoSize = true;
            this.billLabel.Location = new System.Drawing.Point(11, 80);
            this.billLabel.Name = "billLabel";
            this.billLabel.Size = new System.Drawing.Size(50, 13);
            this.billLabel.TabIndex = 5;
            this.billLabel.Text = "Table Bill";
            // 
            // nameLabel2
            // 
            this.nameLabel2.AutoSize = true;
            this.nameLabel2.Location = new System.Drawing.Point(11, 28);
            this.nameLabel2.Name = "nameLabel2";
            this.nameLabel2.Size = new System.Drawing.Size(69, 13);
            this.nameLabel2.TabIndex = 3;
            this.nameLabel2.Text = "Server Name";
            // 
            // itemBox
            // 
            this.itemBox.Enabled = false;
            this.itemBox.Location = new System.Drawing.Point(198, 51);
            this.itemBox.Name = "itemBox";
            this.itemBox.Size = new System.Drawing.Size(100, 20);
            this.itemBox.TabIndex = 2;
            // 
            // nameBox2
            // 
            this.nameBox2.Enabled = false;
            this.nameBox2.Location = new System.Drawing.Point(198, 25);
            this.nameBox2.Name = "nameBox2";
            this.nameBox2.Size = new System.Drawing.Size(100, 20);
            this.nameBox2.TabIndex = 1;
            // 
            // billBox
            // 
            this.billBox.Enabled = false;
            this.billBox.Location = new System.Drawing.Point(198, 77);
            this.billBox.Name = "billBox";
            this.billBox.Size = new System.Drawing.Size(100, 20);
            this.billBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(130, 376);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 208);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(470, 598);
            this.Controls.Add(this.orderSummaryBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.orderControlBox);
            this.Controls.Add(this.serverLoginBox);
            this.Controls.Add(this.pizzaMenuBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Welcome to Sult";
            this.serverLoginBox.ResumeLayout(false);
            this.serverLoginBox.PerformLayout();
            this.pizzaMenuBox.ResumeLayout(false);
            this.pizzaMenuBox.PerformLayout();
            this.orderControlBox.ResumeLayout(false);
            this.orderSummaryBox.ResumeLayout(false);
            this.orderSummaryBox.PerformLayout();
            this.summaryBox.ResumeLayout(false);
            this.summaryBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox serverLoginBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button submitServerButton;
        private System.Windows.Forms.TextBox tableBox;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.GroupBox pizzaMenuBox;
        private System.Windows.Forms.TextBox hawaiianPizzaBox;
        private System.Windows.Forms.TextBox pepperoniPizzaBox;
        private System.Windows.Forms.TextBox margheritaPizzaBox;
        private System.Windows.Forms.Label HawaiianLabel;
        private System.Windows.Forms.Label pepperoniLabel;
        private System.Windows.Forms.Label margheritaLabel;
        private System.Windows.Forms.GroupBox orderControlBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button summaryButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button orderButton;
        private System.Windows.Forms.GroupBox orderSummaryBox;
        private System.Windows.Forms.Label itemsLabel;
        private System.Windows.Forms.Label nameLabel2;
        private System.Windows.Forms.TextBox itemBox;
        private System.Windows.Forms.TextBox nameBox2;
        private System.Windows.Forms.TextBox billBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label billLabel;
        private System.Windows.Forms.GroupBox summaryBox;
        private System.Windows.Forms.TextBox avgBox;
        private System.Windows.Forms.TextBox totalReceiptBox;
        private System.Windows.Forms.TextBox pizzaTotalBox;
        private System.Windows.Forms.TextBox transactionBox;
        private System.Windows.Forms.Label avgLabel;
        private System.Windows.Forms.Label receiptsLabel;
        private System.Windows.Forms.Label totalPizzas;
        private System.Windows.Forms.Label transactionsLabel;
    }
}

