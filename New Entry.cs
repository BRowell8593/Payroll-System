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
    
    public partial class New_Entry : Form
    {
        public New_Entry()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
                //try and catch validation telling the programme to try everything in this selection
                //making sure each option is selected before user pressing the save button
                //if not succesful running the lines of code under the catch section below
            {
                double wage = 0;
                double hours;
                string position;
                double overtime = 0;
                double overtimepay = 0;
                //variables declared to the button click only

                position = cmbWageRate.SelectedItem.ToString();
                switch (position)
                {

                    case "Manager":
                        wage = 12.00;
                        break;

                    case "Hairdresser":
                        wage = 8.00;
                        break;

                    case "Beauty Therapist":
                        wage = 7.00;
                        break;

                    default:
                        break;
                }
                //switch statment to see which entry has been selected in the combo box for job roles,
                //cycle through each until matched entry is found then stop.

                hours = double.Parse(txtHours.Text);
                //assinging the hours variable to the data entered into the hours text box
                if (hours > 37)
                {
                    overtime = hours - 37;
                    overtimepay = overtime * wage * 1.5;
                }
                //if the hours entered into the text box are over 37 an overtime rate is paid
                //at 1.5 times the wage

                information.GrossPay = overtimepay + (hours * wage) - wage * overtime;
                txtTotal.Text = information.GrossPay.ToString("C");

                //declaring a global variable that will be used on a different form and converting
                //the variable back to text to be dispalyed in the text box.
                btnSave.Enabled = true;

                //code to enable the save button once the submit button is pressed as long as the 
                //try and catch validation is succseful. 
            }
            catch
                //Catch section of try and catch validation, if the try section fails then the code
                //below runs producing an message box with an error.
            {
                MessageBox.Show("Please complete all entries before continuing");
                //message box error message shown when the try and catch validation fails. 
            }

            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
           
            Form Summary_Screen = new Summary_Screen();
            Summary_Screen.Show();
            this.Hide();
            // when save button is clicked close the new entry form and open the Summary Form
        }

        private void New_Entry_Load(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            //The form will load with the Save button disabled
        }

        private void txtEmployNo_TextChanged(object sender, EventArgs e)
        {
            information.ID = txtEmployNo.Text;
            //declaring another global variable to be used on another form this takes the number entered
            //into the text box txtEmployNo and transfers it over to the Summary Screen form.
        }

        private void txtHours_TextChanged(object sender, EventArgs e)
        {
            information.Worked = txtHours.Text;
        }
            //declaring another global variable to be used on another form this takes the number entered
            //into the text box txtHours and transfers it over to the Summary Screen form.

    }
}
