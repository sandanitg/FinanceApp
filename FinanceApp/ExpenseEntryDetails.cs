using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinanceApp
{
    public partial class ExpenseEntryDetails : UserControl
    {
        public ExpenseEntryDetails()
        {
            InitializeComponent();
        }

        public Expense getDetails(String title, DateTime date)
        {
            return new Expense(title, date, float.Parse(this.txtAmount.Text), new Contact("Anne", "Frank", "anne@frank.com", "011235456"));
        }
    }
}
