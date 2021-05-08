
namespace FinanceApp
{
    partial class ExpenseEntryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExpenseEntryView));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.expenseTitle = new System.Windows.Forms.TextBox();
            this.expenseDate = new System.Windows.Forms.DateTimePicker();
            this.numericExpenseEntry = new System.Windows.Forms.NumericUpDown();
            this.btnSubmitEntries = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericExpenseEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SlateGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(75, 44);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(129, 18);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Title";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.SlateGray;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(75, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(129, 18);
            this.textBox2.TabIndex = 1;
            this.textBox2.Text = "Date";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.SlateGray;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(75, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(129, 18);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Number of Entries";
            // 
            // expenseTitle
            // 
            this.expenseTitle.Location = new System.Drawing.Point(284, 42);
            this.expenseTitle.Name = "expenseTitle";
            this.expenseTitle.Size = new System.Drawing.Size(248, 25);
            this.expenseTitle.TabIndex = 3;
            // 
            // expenseDate
            // 
            this.expenseDate.Location = new System.Drawing.Point(284, 80);
            this.expenseDate.Name = "expenseDate";
            this.expenseDate.Size = new System.Drawing.Size(248, 25);
            this.expenseDate.TabIndex = 4;
            this.expenseDate.ValueChanged += new System.EventHandler(this.ValidateDate);
            // 
            // numericExpenseEntry
            // 
            this.numericExpenseEntry.Location = new System.Drawing.Point(284, 119);
            this.numericExpenseEntry.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericExpenseEntry.Name = "numericExpenseEntry";
            this.numericExpenseEntry.Size = new System.Drawing.Size(76, 25);
            this.numericExpenseEntry.TabIndex = 5;
            // 
            // btnSubmitEntries
            // 
            this.btnSubmitEntries.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSubmitEntries.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitEntries.Location = new System.Drawing.Point(424, 120);
            this.btnSubmitEntries.Name = "btnSubmitEntries";
            this.btnSubmitEntries.Size = new System.Drawing.Size(108, 24);
            this.btnSubmitEntries.TabIndex = 6;
            this.btnSubmitEntries.Text = "Submit";
            this.btnSubmitEntries.UseVisualStyleBackColor = false;
            this.btnSubmitEntries.Click += new System.EventHandler(this.SubmitExpense);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.Location = new System.Drawing.Point(670, 469);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Save Expense";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.SaveExpense);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.DimGray;
            this.btnRefresh.Location = new System.Drawing.Point(727, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(86, 28);
            this.btnRefresh.TabIndex = 8;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.displayTotal);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(769, 57);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 20);
            this.lblTotal.TabIndex = 9;
            // 
            // lblTotalName
            // 
            this.lblTotalName.AutoSize = true;
            this.lblTotalName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotalName.Location = new System.Drawing.Point(708, 57);
            this.lblTotalName.Name = "lblTotalName";
            this.lblTotalName.Size = new System.Drawing.Size(44, 20);
            this.lblTotalName.TabIndex = 10;
            this.lblTotalName.Text = "Total";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(647, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 174);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // ExpenseEntryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(833, 542);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTotalName);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSubmitEntries);
            this.Controls.Add(this.numericExpenseEntry);
            this.Controls.Add(this.expenseDate);
            this.Controls.Add(this.expenseTitle);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "ExpenseEntryView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Record Expense";
            ((System.ComponentModel.ISupportInitialize)(this.numericExpenseEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox expenseTitle;
        private System.Windows.Forms.DateTimePicker expenseDate;
        private System.Windows.Forms.NumericUpDown numericExpenseEntry;
        private System.Windows.Forms.Button btnSubmitEntries;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalName;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}