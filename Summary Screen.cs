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
    public partial class Summary_Screen : Form
    {
        double Gross = information.GrossPay;
        //reducing a global variable down to a local one
        double tax = 0;
        double NI = 0;
        double netpay;
        //assinging the rest of the variables for the form 


        

        public Summary_Screen()
        {
            InitializeComponent();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            Form New_Entry = new New_Entry();
            New_Entry.Show();
            this.Hide();
         //when the new button is clicked this form will close and the new entry form will open
          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
         //when the exit button is clicked the application will close down 
        }


        private void Summary_Screen_Load(object sender, EventArgs e)
        {
            txtEmployNu.Text = information.ID;
            txtGrossPay.Text = information.GrossPay.ToString("C");
            txtHours.Text = information.Worked;
         //on form load the labels on the form will change to the global variables stored
         //from the new entry page 

            if (Gross > 0)
            {
                tax = Gross * 0.2;
                txtTax.Text = tax.ToString("C");
            }
            else
            {
                tax = Gross; 
            }
         //If else statment to work out the amount of tax to be deducted from the gross pay. 
         //if the gross pay is over £0 then the tax is equal to the gross pay * 0.2 as tax is always paid
         //this is stored in the tax variable and shown in the txtTax text box
            if (Gross > 157)
            {
                NI = Gross * 0.12;
                txtNatinsur.Text = NI.ToString("C");
            }
            else
            {
                NI = 0;
                txtNatinsur.Text = 0.ToString("C");
            }
         //If else statment to work out the amout of National Insurance to be deducted from gross pay
         //If the gross pay is over £157 then NI has to be deducted at 12%. Therefore NI = Grosspay * 0.12
         //this result is then stored in the NI variable and shown in the txtNatinsur text box.

            netpay = Gross - tax - NI;
            txtNetPay.Text = netpay.ToString("C");
         //This is working out the netpay. The calculation is GrossPay variable - the tax variable
         //- the NI variable. this is then shown in the netpay text box.
            
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.ShowDialog();
        }
        //line of code to show a print preview of selected dialog when the button is pressed

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DialogResult printResponse;
            printResponse = printDialog1.ShowDialog();
            if (printResponse == DialogResult.OK)
                printDocument1.Print();
        }
        //code to tell the programme to print the selected information 
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Font myfont = new Font("Arial", 16, FontStyle.Bold);
            Brush myBrush = new SolidBrush(Color.Black);

            e.Graphics.DrawString("Hair by Visage Payslip", myfont, myBrush, 5, 5);
            e.Graphics.DrawString("Employee Number : " + information.ID.ToString(), myfont, myBrush, 5, 40);
            e.Graphics.DrawString("Hours Worked : " + information.Worked.ToString(), myfont, myBrush, 5, 75);
            e.Graphics.DrawString("Gross Pay : " + information.GrossPay.ToString("C"), myfont, myBrush, 5, 110);
            e.Graphics.DrawString("Income Tax Deductions : " + tax.ToString("C"), myfont, myBrush, 5, 145);
            e.Graphics.DrawString("National Insurance Deductions : " + NI.ToString("C"), myfont, myBrush, 5, 180);
            e.Graphics.DrawString("Net Pay : " + netpay.ToString("C"), myfont, myBrush, 5, 215);
         //This gorup of code is telling the programme what to print. By declaring the brush and the font
         //it then shows what lines to print out and what variables to get the figures from
         //aslong side the coordinates for the line to start at. 
        }
    }
}
