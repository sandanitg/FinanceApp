using NHibernate.Impl;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using Xceed.Wpf.Toolkit;
using MessageBox = System.Windows.Forms.MessageBox;

namespace FinanceApp
{
    public partial class IncomeEntryView : Form
    {
        public IncomeEntryView()
        {
            InitializeComponent();
        }

        public Income IncomeEntries { get; set; }

        IncomeEntryDetails[] incomeRows;

        private void SubmitIncome(object sender, EventArgs e)
        {
            incomeRows = new IncomeEntryDetails[(int)this.numericIncomeEntry.Value];
           // IncomeEntryDetails[] incomeEntries = new IncomeEntryDetails[(int)this.numericIncomeEntry.Value];

            for (int i = 0; i < incomeRows.Length; i++)
            {
                incomeRows[i] = new IncomeEntryDetails();
                incomeRows[i].Location = new System.Drawing.Point(110, 165 + i * 35);
                this.Controls.Add(incomeRows[i]);

            }
        }

        ArrayList incomes = new ArrayList();

        private void SaveIncome(object sender, EventArgs e)
        {
            this.IncomeEntries = new Income();
            this.IncomeEntries.incomeTitle = this.incomeTitle.Text;
            this.IncomeEntries.date = this.incomeDate.Value;
           // this.IncomeEntries.noOfEntries = this.numericIncomeEntry.Value;

            //Store: Temp store before pushing data cross-app-domain
            
            String workingDir = Directory.GetCurrentDirectory();
            XmlTextWriter textWriter = new XmlTextWriter("myIncome.xml", null);
            textWriter.Formatting = Formatting.Indented;
            textWriter.Indentation = 4;
            textWriter.WriteStartDocument();

            textWriter.WriteStartElement("Income Entry");

            textWriter.WriteStartElement("Income Title");
            textWriter.WriteString(this.IncomeEntries.incomeTitle);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("Date");
            textWriter.WriteValue(this.IncomeEntries.date);
            textWriter.WriteEndElement();

            

            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();

            textWriter.Close();
            Console.ReadLine();

            this.Close();

        }

        private void validateDate(object sender, EventArgs e)
        {

            if (incomeDate.Value > DateTime.Now)
            {
                MessageBox.Show("Date should not be a future date");
                incomeDate.Value = DateTime.Now;
            }
        }


       private float getTotal()
        {
            float total = 0;
            for (int i =0; i < this.incomeRows.Length; i++) 
            {
                total += this.incomeRows[i].getDetails(this.incomeTitle.Text, this.incomeDate.Value).amount;
            }
            return total;
        }

        private void displayTotal(object sender, EventArgs e)
        {
            this.lblTotal.Text = getTotal().ToString();
        }
    }
}
