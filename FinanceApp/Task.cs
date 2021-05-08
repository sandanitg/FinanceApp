using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp
{
    public class Task
    {
        public String title { get; set; }
        public String description { get; set; }
        public String status { get; set; }
        public Boolean recurring { get; set; }
        public Boolean oneoff { get; set; 
        }

    }
}
