using System;
using System.Collections.Generic;
using System.Text;

namespace FinanceApp
{
    public class Appointment
    {
        public String title { get; set; }
        public String startTime { get; set; }
        public String endTime { get; set; }
        public String location { get; set; }
        public Boolean recurring { get; set; }
        public Boolean oneoff { get; set; }

    }
}
