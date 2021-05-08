using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp
{
    public class Contact
    {
        public Contact()
        {
        }

        public Contact(string firstName, string lastName, string email, string telNo)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.telNo = telNo;
        }

        public String firstName { get; set; }

        public String lastName { get; set; }

        public String email { get; set; }

        public String telNo { get; set; }
        //public String 
    }
}
