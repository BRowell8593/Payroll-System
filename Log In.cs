using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hair_by_Visage_Payroll_System
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string user;
            string password;  
            //variables declared only to the button click event

            user = txtUsername.Text;
            password = txtPassword.Text; 
            //assigning variables 

            if ((user == "VisageAdmin" ) && (password == "Password1"))
            {
                Form welcome = new New_Entry();
                welcome.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Log In");
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
             //If statment used to check if the log in credentials match, if they do allow entry
             // if they do not show message box with error message, clear the text boxes and 
             //cusor back to Username text box.
            }
        }
    }
}
