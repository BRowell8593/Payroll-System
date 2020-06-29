namespace Hair_by_Visage_Payroll_System
{
    partial class Summary_Screen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Summary_Screen));
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmployNu = new System.Windows.Forms.Label();
            this.lblNetPay = new System.Windows.Forms.Label();
            this.lblNatInsur = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblGrossPay = new System.Windows.Forms.Label();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtNatinsur = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtNetPay = new System.Windows.Forms.TextBox();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.txtEmployNu = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnPreview = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Location = new System.Drawing.Point(95, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(251, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Summary Screen";
            // 
            // lblEmployNu
            // 
            this.lblEmployNu.AutoSize = true;
            this.lblEmployNu.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployNu.Location = new System.Drawing.Point(23, 80);
            this.lblEmployNu.Name = "lblEmployNu";
            this.lblEmployNu.Size = new System.Drawing.Size(152, 23);
            this.lblEmployNu.TabIndex = 1;
            this.lblEmployNu.Text = "Employee Number";
            // 
            // lblNetPay
            // 
            this.lblNetPay.AutoSize = true;
            this.lblNetPay.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetPay.Location = new System.Drawing.Point(23, 245);
            this.lblNetPay.Name = "lblNetPay";
            this.lblNetPay.Size = new System.Drawing.Size(69, 23);
            this.lblNetPay.TabIndex = 2;
            this.lblNetPay.Text = "Net Pay";
            // 
            // lblNatInsur
            // 
            this.lblNatInsur.AutoSize = true;
            this.lblNatInsur.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNatInsur.Location = new System.Drawing.Point(23, 212);
            this.lblNatInsur.Name = "lblNatInsur";
            this.lblNatInsur.Size = new System.Drawing.Size(240, 23);
            this.lblNatInsur.TabIndex = 3;
            this.lblNatInsur.Text = "National Insurance Deduction";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTax.Location = new System.Drawing.Point(23, 179);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(181, 23);
            this.lblTax.TabIndex = 4;
            this.lblTax.Text = "Income Tax Deduction";
            // 
            // lblGrossPay
            // 
            this.lblGrossPay.AutoSize = true;
            this.lblGrossPay.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossPay.Location = new System.Drawing.Point(23, 146);
            this.lblGrossPay.Name = "lblGrossPay";
            this.lblGrossPay.Size = new System.Drawing.Size(87, 23);
            this.lblGrossPay.TabIndex = 5;
            this.lblGrossPay.Text = "Gross Pay";
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHours.Location = new System.Drawing.Point(23, 113);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(121, 23);
            this.lblHours.TabIndex = 6;
            this.lblHours.Text = "Hours Worked";
            // 
            // txtNatinsur
            // 
            this.txtNatinsur.Location = new System.Drawing.Point(295, 212);
            this.txtNatinsur.Name = "txtNatinsur";
            this.txtNatinsur.ReadOnly = true;
            this.txtNatinsur.Size = new System.Drawing.Size(117, 20);
            this.txtNatinsur.TabIndex = 0;
            this.txtNatinsur.TabStop = false;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(295, 179);
            this.txtTax.Name = "txtTax";
            this.txtTax.ReadOnly = true;
            this.txtTax.Size = new System.Drawing.Size(117, 20);
            this.txtTax.TabIndex = 8;
            this.txtTax.TabStop = false;
            // 
            // txtNetPay
            // 
            this.txtNetPay.Location = new System.Drawing.Point(295, 245);
            this.txtNetPay.Name = "txtNetPay";
            this.txtNetPay.ReadOnly = true;
            this.txtNetPay.Size = new System.Drawing.Size(117, 20);
            this.txtNetPay.TabIndex = 9;
            this.txtNetPay.TabStop = false;
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.Location = new System.Drawing.Point(295, 146);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.ReadOnly = true;
            this.txtGrossPay.Size = new System.Drawing.Size(117, 20);
            this.txtGrossPay.TabIndex = 10;
            this.txtGrossPay.TabStop = false;
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(295, 113);
            this.txtHours.Name = "txtHours";
            this.txtHours.ReadOnly = true;
            this.txtHours.Size = new System.Drawing.Size(117, 20);
            this.txtHours.TabIndex = 11;
            this.txtHours.TabStop = false;
            // 
            // txtEmployNu
            // 
            this.txtEmployNu.Location = new System.Drawing.Point(295, 80);
            this.txtEmployNu.Name = "txtEmployNu";
            this.txtEmployNu.ReadOnly = true;
            this.txtEmployNu.Size = new System.Drawing.Size(117, 20);
            this.txtEmployNu.TabIndex = 12;
            this.txtEmployNu.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnExit.Location = new System.Drawing.Point(10, 318);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(100, 40);
            this.btnExit.TabIndex = 13;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Black;
            this.btnPrint.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrint.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnPrint.Location = new System.Drawing.Point(116, 318);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(100, 40);
            this.btnPrint.TabIndex = 14;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Black;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnNew.Location = new System.Drawing.Point(328, 318);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(100, 40);
            this.btnNew.TabIndex = 15;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnPreview
            // 
            this.btnPreview.BackColor = System.Drawing.Color.Black;
            this.btnPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPreview.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreview.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnPreview.Location = new System.Drawing.Point(222, 318);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(100, 40);
            this.btnPreview.TabIndex = 16;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = false;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // Summary_Screen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 381);
            this.Controls.Add(this.btnPreview);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtEmployNu);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtGrossPay);
            this.Controls.Add(this.txtNetPay);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtNatinsur);
            this.Controls.Add(this.lblHours);
            this.Controls.Add(this.lblGrossPay);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblNatInsur);
            this.Controls.Add(this.lblNetPay);
            this.Controls.Add(this.lblEmployNu);
            this.Controls.Add(this.lblTitle);
            this.Name = "Summary_Screen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "201";
            this.Load += new System.EventHandler(this.Summary_Screen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmployNu;
        private System.Windows.Forms.Label lblNetPay;
        private System.Windows.Forms.Label lblNatInsur;
        private System.Windows.Forms.Label lblTax;
        private System.Windows.Forms.Label lblGrossPay;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtNatinsur;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtNetPay;
        private System.Windows.Forms.TextBox txtGrossPay;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.TextBox txtEmployNu;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnPreview;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}