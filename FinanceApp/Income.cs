using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp
{
    public class Income : Transaction
    {

        public String incomeTitle { get; set; }
        
        public DateTime date { get; set; }

        public float amount { get; set; }

        public Contact payer { get; set; }

        public Income()
        {
        }

        public Income( String incomeTitle, DateTime date, float amount, Contact payer)
        {
           
            this.incomeTitle = incomeTitle;
            this.date = date;
            this.amount = amount;
            this.payer = payer;
        }

        public void StoreIncome() { 
        


        }
    }
}
