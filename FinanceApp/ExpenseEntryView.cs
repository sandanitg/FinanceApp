using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace FinanceApp
{
    public partial class ExpenseEntryView : Form
    {
        public ExpenseEntryView()
        {
            InitializeComponent();
        }

        public Expense ExpenseEntries { get; set; }

        ExpenseEntryDetails[] expenseRows;
        private void SubmitExpense(object sender, EventArgs e)
        {
            expenseRows = new ExpenseEntryDetails[(int)this.numericExpenseEntry.Value];

            for (int i = 0; i < expenseRows.Length; i++)
            {
                expenseRows[i] = new ExpenseEntryDetails();
                expenseRows[i].Location = new System.Drawing.Point(110, 150 + i * 35);
                this.Controls.Add(expenseRows[i]);

            }
        }

        private void SaveExpense(object sender, EventArgs e)
        {
            this.ExpenseEntries = new Expense();
            this.ExpenseEntries.expenseTitle = this.expenseTitle.Text;
            this.ExpenseEntries.date = this.expenseDate.Value;
            

            //Store: Temp store before pushing data cross-app-domain

            String workingDir = Directory.GetCurrentDirectory();
            XmlTextWriter textWriter = new XmlTextWriter("myExpense.xml", null);
            textWriter.Formatting = Formatting.Indented;
            textWriter.Indentation = 4;
            textWriter.WriteStartDocument();

            textWriter.WriteStartElement("Expense Entry");

            textWriter.WriteStartElement("Expense Title");
            textWriter.WriteString(this.ExpenseEntries.expenseTitle);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("Date");
            textWriter.WriteValue(this.ExpenseEntries.date);
            textWriter.WriteEndElement();

            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();

            textWriter.Close();
            Console.ReadLine();

            this.Close();
        }

        private void validateDate(object sender, EventArgs e)
        {

            if (expenseDate.Value > DateTime.Now)
            {
                MessageBox.Show("Date should not be a future date");
                expenseDate.Value = DateTime.Now;
            }
        }

        private void ValidateDate(object sender, EventArgs e)
        {
            if (expenseDate.Value > DateTime.Now)
            {
                MessageBox.Show("Date should not be a future date");
                expenseDate.Value = DateTime.Now;
            }
        }

        private float getTotal()
        {
            float total = 0;
            for (int i = 0; i < this.expenseRows.Length; i++)
            {
                total += this.expenseRows[i].getDetails(this.expenseTitle.Text, this.expenseDate.Value).amount;
            }
            return total;
        }

        private void displayTotal(object sender, EventArgs e)
        {
            this.lblTotal.Text = getTotal().ToString();
        }

    }
}
