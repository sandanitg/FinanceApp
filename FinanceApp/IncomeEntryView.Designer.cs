
namespace FinanceApp
{
    partial class IncomeEntryView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IncomeEntryView));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.incomeTitle = new System.Windows.Forms.TextBox();
            this.incomeDate = new System.Windows.Forms.DateTimePicker();
            this.numericIncomeEntry = new System.Windows.Forms.NumericUpDown();
            this.btnSubmitEntries = new System.Windows.Forms.Button();
            this.btnSaveIncome = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.labelTotalName = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericIncomeEntry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SlateGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(74, 45);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
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
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(74, 80);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
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
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(74, 119);
            this.textBox3.Margin = new System.Windows.Forms.Padding(2);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(129, 18);
            this.textBox3.TabIndex = 2;
            this.textBox3.Text = "Number of Entries";
            // 
            // incomeTitle
            // 
            this.incomeTitle.Location = new System.Drawing.Point(283, 42);
            this.incomeTitle.Margin = new System.Windows.Forms.Padding(2);
            this.incomeTitle.Name = "incomeTitle";
            this.incomeTitle.Size = new System.Drawing.Size(248, 25);
            this.incomeTitle.TabIndex = 3;
            // 
            // incomeDate
            // 
            this.incomeDate.Location = new System.Drawing.Point(283, 74);
            this.incomeDate.Margin = new System.Windows.Forms.Padding(2);
            this.incomeDate.Name = "incomeDate";
            this.incomeDate.Size = new System.Drawing.Size(248, 25);
            this.incomeDate.TabIndex = 4;
            this.incomeDate.ValueChanged += new System.EventHandler(this.validateDate);
            // 
            // numericIncomeEntry
            // 
            this.numericIncomeEntry.Location = new System.Drawing.Point(283, 115);
            this.numericIncomeEntry.Margin = new System.Windows.Forms.Padding(2);
            this.numericIncomeEntry.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericIncomeEntry.Name = "numericIncomeEntry";
            this.numericIncomeEntry.Size = new System.Drawing.Size(74, 25);
            this.numericIncomeEntry.TabIndex = 5;
            // 
            // btnSubmitEntries
            // 
            this.btnSubmitEntries.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSubmitEntries.ForeColor = System.Drawing.Color.Black;
            this.btnSubmitEntries.Location = new System.Drawing.Point(424, 115);
            this.btnSubmitEntries.Margin = new System.Windows.Forms.Padding(2);
            this.btnSubmitEntries.Name = "btnSubmitEntries";
            this.btnSubmitEntries.Size = new System.Drawing.Size(107, 25);
            this.btnSubmitEntries.TabIndex = 6;
            this.btnSubmitEntries.Text = "Submit";
            this.btnSubmitEntries.UseVisualStyleBackColor = false;
            this.btnSubmitEntries.Click += new System.EventHandler(this.SubmitIncome);
            // 
            // btnSaveIncome
            // 
            this.btnSaveIncome.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btnSaveIncome.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSaveIncome.Location = new System.Drawing.Point(670, 481);
            this.btnSaveIncome.Name = "btnSaveIncome";
            this.btnSaveIncome.Size = new System.Drawing.Size(150, 38);
            this.btnSaveIncome.TabIndex = 7;
            this.btnSaveIncome.Text = "Save Income";
            this.btnSaveIncome.UseVisualStyleBackColor = false;
            this.btnSaveIncome.Click += new System.EventHandler(this.SaveIncome);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(752, 68);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 20);
            this.lblTotal.TabIndex = 8;
            // 
            // labelTotalName
            // 
            this.labelTotalName.AutoSize = true;
            this.labelTotalName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTotalName.ForeColor = System.Drawing.Color.White;
            this.labelTotalName.Location = new System.Drawing.Point(702, 68);
            this.labelTotalName.Name = "labelTotalName";
            this.labelTotalName.Size = new System.Drawing.Size(44, 20);
            this.labelTotalName.TabIndex = 9;
            this.labelTotalName.Text = "Total";
            // 
            // btnRefresh
            // 
            this.btnRefresh.ForeColor = System.Drawing.Color.DimGray;
            this.btnRefresh.Location = new System.Drawing.Point(726, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(94, 33);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.displayTotal);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(641, 249);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(174, 174);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // IncomeEntryView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(827, 531);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.labelTotalName);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnSaveIncome);
            this.Controls.Add(this.btnSubmitEntries);
            this.Controls.Add(this.numericIncomeEntry);
            this.Controls.Add(this.incomeDate);
            this.Controls.Add(this.incomeTitle);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Name = "IncomeEntryView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Record Income";
            ((System.ComponentModel.ISupportInitialize)(this.numericIncomeEntry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.DateTimePicker incomeDate;
        private System.Windows.Forms.NumericUpDown numericIncomeEntry;
        private System.Windows.Forms.Button btnSubmitEntries;
        private System.Windows.Forms.Button btnSaveIncome;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label labelTotalName;
        private System.Windows.Forms.TextBox incomeTitle;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}