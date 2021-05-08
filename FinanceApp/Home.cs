using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinanceApp
{
    public partial class Home : Form
    {
        TransactionManagement myDataSet = new TransactionManagement();

        public Home()
        {
            InitializeComponent();
        }

        //Expense incomeDetails = null;
        //User userDetails = null;
        
        private void RecordIncome(object sender, EventArgs e)
        {
            IncomeEntryView incomeScreen = new IncomeEntryView();
            incomeScreen.Activate();
            incomeScreen.ShowDialog();
            //this.incomeDetails = incomeScreen.IncomeEntries;

            /*//add data onto memory resident database
            TransactionManagement.UserRow row = this.myDataSet.User.NewUserRow();
            row.userId = this.userDetails.userId;
            row.userName = this.userDetails.userName;
            row.password = this.userDetails.password;
            row.email = this.userDetails.email;

            TransactionManagement.IncomeRow childrow = this.myDataSet.Income.NewIncomeRow();
            childrow.incomeId = this.userDetails.incom*/
           
        }

        private void RecordExpense(object sender, EventArgs e)
        {
            ExpenseEntryView expenseScreen = new ExpenseEntryView();
            expenseScreen.Activate();
            expenseScreen.ShowDialog();
        }

        private void DisplayReport(object sender, EventArgs e)
        {
            ReportView reportScreen = new ReportView();
            reportScreen.Activate();
            reportScreen.ShowDialog();
        }

        private void CreateTask(object sender, EventArgs e)
        {
            TaskView taskScreen = new TaskView();
            taskScreen.Activate();
            taskScreen.ShowDialog();
        }


        private void CreateAppointment(object sender, EventArgs e)
        {
            AppointmentView appointmentScreen = new AppointmentView();
            appointmentScreen.Activate();
            appointmentScreen.ShowDialog();
        }

        private void ShowFinancialState(object sender, EventArgs e)
        {
            FinancialStatusView financialStateScreen = new FinancialStatusView();
            financialStateScreen.Activate();
            financialStateScreen.ShowDialog();
        }

        private void CreateContact(object sender, EventArgs e)
        {
            ContactView contactScreen = new ContactView();
            contactScreen.Activate();
            contactScreen.ShowDialog();
        }

        /* private void btnUpdateUser_Click(object sender, EventArgs e)
       {
           UserScreen userScreen = new UserScreen();
           userScreen.Activate();
           userScreen.ShowDialog();
       }*/

        /*private void btnShowWeeklyView_Click(object sender, EventArgs e)
        {
            WeeklyViewScreen weeklyViewScreen = new WeeklyViewScreen();
            weeklyViewScreen.Activate();
            weeklyViewScreen.ShowDialog();
        }*/

      
    }
}
