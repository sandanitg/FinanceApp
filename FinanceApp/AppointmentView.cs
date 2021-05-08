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
    public partial class AppointmentView : Form
    {
        public AppointmentView()
        {
            InitializeComponent();
        }
        public Appointment appointments { get; set; }
        private void SubmitAppointment(object sender, EventArgs e)
        {
            this.appointments = new Appointment();
            this.appointments.title = this.appTitle.Text;
            this.appointments.startTime = this.appStartTime.Text;
            this.appointments.endTime = this.appEndTime.Text;
            this.appointments.location = this.appLocation.Text;
            this.appointments.recurring = this.radioRecurring.Checked;
            this.appointments.oneoff = this.radioOneoff.Checked;

            //Store: Temp store before pushing data cross-app-domain

            String workingDir = Directory.GetCurrentDirectory();
            XmlTextWriter textWriter = new XmlTextWriter("myAppointment.xml", null);
            textWriter.Formatting = Formatting.Indented;
            textWriter.Indentation = 4;
            textWriter.WriteStartDocument();

            textWriter.WriteStartElement("Appointment");

            textWriter.WriteStartElement("Title");
            textWriter.WriteString(this.appTitle.Text);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("StartTime");
            textWriter.WriteValue(this.appStartTime.Text);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("EndTime");
            textWriter.WriteValue(this.appEndTime.Text);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("Location");
            textWriter.WriteValue(this.appLocation.Text);
            textWriter.WriteEndElement();

            if (this.appointments.recurring is true)
            {
                textWriter.WriteStartElement("Occurence");
                textWriter.WriteString("Recurring");
                textWriter.WriteEndElement();
            }
            else if (this.appointments.oneoff is true)
            {
                textWriter.WriteStartElement("Occurence");
                textWriter.WriteString("One-off");
                textWriter.WriteEndElement();
            }

            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();

            textWriter.Close();
            Console.ReadLine();

            this.Close();
        }

        

        private void ValidateEndDate(object sender, EventArgs e)
        {
            if (appStartTime.Value > appEndTime.Value)
            {
                MessageBox.Show("End Date should after Start Date");
                appEndTime.Value = appStartTime.Value;
            }
        }
    }
}
