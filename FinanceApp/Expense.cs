using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp
{
    public class Expense : Transaction
    {
        public Expense()
        {
        }

        public Expense(String expenseTitle, DateTime date, float amount, Contact payee)
        {
            this.expenseTitle = expenseTitle;
            this.date = date;
            this.amount = amount;
            this.payee = payee;
        }

      
        public String expenseTitle { get; set; }

        public DateTime date { get; set; }

        public float amount { get; set; }

        public Contact payee {get; set; }

        public void Store()
        {
        }

    }
}
