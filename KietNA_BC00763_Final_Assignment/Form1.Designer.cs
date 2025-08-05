namespace KietNA_BC00763_Final_Assignment
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            custumerName = new Label();
            txtCustumerName = new TextBox();
            typeOfCustumer = new Label();
            comboTypeOfCustumer = new ComboBox();
            numberOfPeople = new Label();
            txtNumberOfPeople = new TextBox();
            lastMonthWaterUsed = new Label();
            txtLastMonthWaterUsed = new TextBox();
            thisMonthWaterUsed = new Label();
            txtThisMonthWaterUsed = new TextBox();
            buttonCaculator = new Button();
            listWaterBill = new ListView();
            txtSearch = new TextBox();
            lbSearch = new Label();
            comboSort = new ComboBox();
            btPrintBill = new Button();
            SuspendLayout();
            // 
            // custumerName
            // 
            custumerName.AutoSize = true;
            custumerName.Location = new Point(67, 67);
            custumerName.Name = "custumerName";
            custumerName.Size = new Size(118, 20);
            custumerName.TabIndex = 0;
            custumerName.Text = "Custumer Name:";
            custumerName.Click += label1_Click;
            // 
            // txtCustumerName
            // 
            txtCustumerName.Location = new Point(67, 90);
            txtCustumerName.Name = "txtCustumerName";
            txtCustumerName.Size = new Size(250, 27);
            txtCustumerName.TabIndex = 1;
            // 
            // typeOfCustumer
            // 
            typeOfCustumer.AutoSize = true;
            typeOfCustumer.Location = new Point(67, 137);
            typeOfCustumer.Name = "typeOfCustumer";
            typeOfCustumer.Size = new Size(129, 20);
            typeOfCustumer.TabIndex = 2;
            typeOfCustumer.Text = "Type Of Custumer:";
            // 
            // comboTypeOfCustumer
            // 
            comboTypeOfCustumer.FormattingEnabled = true;
            comboTypeOfCustumer.Location = new Point(67, 160);
            comboTypeOfCustumer.Name = "comboTypeOfCustumer";
            comboTypeOfCustumer.Size = new Size(250, 28);
            comboTypeOfCustumer.TabIndex = 3;
            comboTypeOfCustumer.SelectedIndexChanged += comboTypeOfCustumer_SelectedIndexChanged;
            // 
            // numberOfPeople
            // 
            numberOfPeople.AutoSize = true;
            numberOfPeople.Location = new Point(67, 205);
            numberOfPeople.Name = "numberOfPeople";
            numberOfPeople.Size = new Size(135, 20);
            numberOfPeople.TabIndex = 4;
            numberOfPeople.Text = "Number Of People:";
            // 
            // txtNumberOfPeople
            // 
            txtNumberOfPeople.Enabled = false;
            txtNumberOfPeople.Location = new Point(67, 228);
            txtNumberOfPeople.Name = "txtNumberOfPeople";
            txtNumberOfPeople.Size = new Size(250, 27);
            txtNumberOfPeople.TabIndex = 5;
            // 
            // lastMonthWaterUsed
            // 
            lastMonthWaterUsed.AutoSize = true;
            lastMonthWaterUsed.Location = new Point(67, 276);
            lastMonthWaterUsed.Name = "lastMonthWaterUsed";
            lastMonthWaterUsed.Size = new Size(165, 20);
            lastMonthWaterUsed.TabIndex = 6;
            lastMonthWaterUsed.Text = "Last Month Water Used:";
            // 
            // txtLastMonthWaterUsed
            // 
            txtLastMonthWaterUsed.Location = new Point(67, 299);
            txtLastMonthWaterUsed.Name = "txtLastMonthWaterUsed";
            txtLastMonthWaterUsed.Size = new Size(250, 27);
            txtLastMonthWaterUsed.TabIndex = 7;
            // 
            // thisMonthWaterUsed
            // 
            thisMonthWaterUsed.AutoSize = true;
            thisMonthWaterUsed.Location = new Point(67, 344);
            thisMonthWaterUsed.Name = "thisMonthWaterUsed";
            thisMonthWaterUsed.Size = new Size(165, 20);
            thisMonthWaterUsed.TabIndex = 8;
            thisMonthWaterUsed.Text = "This Month Water Used:";
            // 
            // txtThisMonthWaterUsed
            // 
            txtThisMonthWaterUsed.Location = new Point(67, 367);
            txtThisMonthWaterUsed.Name = "txtThisMonthWaterUsed";
            txtThisMonthWaterUsed.Size = new Size(250, 27);
            txtThisMonthWaterUsed.TabIndex = 9;
            // 
            // buttonCaculator
            // 
            buttonCaculator.Location = new Point(223, 419);
            buttonCaculator.Name = "buttonCaculator";
            buttonCaculator.Size = new Size(94, 29);
            buttonCaculator.TabIndex = 10;
            buttonCaculator.Text = "Caculator";
            buttonCaculator.UseVisualStyleBackColor = true;
            buttonCaculator.Click += buttonCaculator_Click;
            // 
            // listWaterBill
            // 
            listWaterBill.FullRowSelect = true;
            listWaterBill.Location = new Point(529, 67);
            listWaterBill.Name = "listWaterBill";
            listWaterBill.Size = new Size(939, 383);
            listWaterBill.TabIndex = 11;
            listWaterBill.UseCompatibleStateImageBehavior = false;
            listWaterBill.SelectedIndexChanged += listWaterBill_SelectedIndexChanged;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(529, 34);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(328, 27);
            txtSearch.TabIndex = 12;
            txtSearch.TextChanged += txtSearch_TextChaged;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Location = new Point(529, 11);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(56, 20);
            lbSearch.TabIndex = 13;
            lbSearch.Text = "Search:";
            // 
            // comboSort
            // 
            comboSort.FormattingEnabled = true;
            comboSort.Items.AddRange(new object[] { "Small to Large", "Large to Small" });
            comboSort.Location = new Point(879, 33);
            comboSort.Name = "comboSort";
            comboSort.Size = new Size(230, 28);
            comboSort.TabIndex = 14;
            comboSort.SelectedIndexChanged += comboSort_SelectedIndexChanged;
            // 
            // btPrintBill
            // 
            btPrintBill.Location = new Point(1374, 458);
            btPrintBill.Name = "btPrintBill";
            btPrintBill.Size = new Size(94, 29);
            btPrintBill.TabIndex = 15;
            btPrintBill.Text = "Print Bill";
            btPrintBill.UseVisualStyleBackColor = true;
            btPrintBill.Click += btPrintBill_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1552, 499);
            Controls.Add(btPrintBill);
            Controls.Add(comboSort);
            Controls.Add(lbSearch);
            Controls.Add(txtSearch);
            Controls.Add(listWaterBill);
            Controls.Add(buttonCaculator);
            Controls.Add(txtThisMonthWaterUsed);
            Controls.Add(thisMonthWaterUsed);
            Controls.Add(txtLastMonthWaterUsed);
            Controls.Add(lastMonthWaterUsed);
            Controls.Add(txtNumberOfPeople);
            Controls.Add(numberOfPeople);
            Controls.Add(comboTypeOfCustumer);
            Controls.Add(typeOfCustumer);
            Controls.Add(txtCustumerName);
            Controls.Add(custumerName);
            Name = "Form1";
            Load += Form1_load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label custumerName;
        private TextBox txtCustumerName;
        private Label typeOfCustumer;
        private ComboBox comboTypeOfCustumer;
        private Label numberOfPeople;
        private TextBox txtNumberOfPeople;
        private Label lastMonthWaterUsed;
        private TextBox txtLastMonthWaterUsed;
        private Label thisMonthWaterUsed;
        private TextBox txtThisMonthWaterUsed;
        private Button buttonCaculator;
        private TextBox txtSearch;
        private Label lbSearch;
        private ComboBox comboSort;
        private Button btPrintBill;
        public ListView listWaterBill;
    }
}
