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
    public partial class TaskView : Form
    {
        public TaskView()
        {
            InitializeComponent();
        }
        public Task tasks { get; set; }

        private void SubmitTask(object sender, EventArgs e)
        {
            this.tasks = new Task();
            this.tasks.title = this.taskTitle.Text;
            this.tasks.description = this.taskDescription.Text;
            this.tasks.status = this.taskStatus.Text;
            this.tasks.recurring = this.radioRecurring.Checked;
            this.tasks.oneoff = this.radioOneOff.Checked;

            //Store: Temp store before pushing data cross-app-domain

            String workingDir = Directory.GetCurrentDirectory();
            XmlTextWriter textWriter = new XmlTextWriter("myTask.xml", null);
            textWriter.Formatting = Formatting.Indented;
            textWriter.Indentation = 4;
            textWriter.WriteStartDocument();

            textWriter.WriteStartElement("Task");

            textWriter.WriteStartElement("TaskTitle");
            textWriter.WriteString(this.tasks.title);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("Description");
            textWriter.WriteValue(this.tasks.description);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("Status");
            textWriter.WriteValue(this.tasks.status);
            textWriter.WriteEndElement();

            if(this.tasks.recurring is true)
            {
                textWriter.WriteStartElement("Occurence");
                textWriter.WriteString("Recurring");
                textWriter.WriteEndElement();
            }
            else if(this.tasks.oneoff is true)
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
    }
}
