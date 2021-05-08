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
    public partial class ContactView : Form
    {
        public ContactView()
        {
            InitializeComponent();
        }
        public Contact ContactEntry { get; set; }

        private void SaveContact(object sender, EventArgs e)
        {
            this.ContactEntry = new Contact();
            this.ContactEntry.firstName = this.txtFirstname.Text;
            this.ContactEntry.lastName = this.txtLastname.Text;
            this.ContactEntry.email = this.txtEmail.Text;
            this.ContactEntry.telNo = this.txtTel.Text;

            //Store: Temp store before pushing data cross-app-domain

            String workingDir = Directory.GetCurrentDirectory();
            XmlTextWriter textWriter = new XmlTextWriter("myContatc.xml", null);
            textWriter.Formatting = Formatting.Indented;
            textWriter.Indentation = 4;
            textWriter.WriteStartDocument();

            textWriter.WriteStartElement("Contact");

            textWriter.WriteStartElement("Firstname");
            textWriter.WriteString(this.ContactEntry.firstName);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("Lastname");
            textWriter.WriteValue(this.ContactEntry.lastName);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("Email");
            textWriter.WriteValue(this.ContactEntry.email);
            textWriter.WriteEndElement();

            textWriter.WriteStartElement("TelNo");
            textWriter.WriteValue(this.ContactEntry.telNo);
            textWriter.WriteEndElement();

            textWriter.WriteEndElement();
            textWriter.WriteEndDocument();

            textWriter.Close();
            Console.ReadLine();

            this.Close();
        }
    }
}
