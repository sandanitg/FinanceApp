using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FinanceApp
{
    public partial class IncomeEntryDetails : UserControl
    {
        public IncomeEntryDetails()
        {
            InitializeComponent();
        }

        public Income getDetails(String title, DateTime date)
        {

            return new Income(title, date, float.Parse(this.txtAmount.Text), new Contact("David", "Duffee", "david@duffee.com", "045235456"));

        }

    }
}
