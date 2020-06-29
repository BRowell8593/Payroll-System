namespace Hair_by_Visage_Payroll_System
{
    partial class New_Entry
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblEmployNo = new System.Windows.Forms.Label();
            this.lblEmployWR = new System.Windows.Forms.Label();
            this.lblEmployHours = new System.Windows.Forms.Label();
            this.txtEmployNo = new System.Windows.Forms.TextBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.cmbWageRate = new System.Windows.Forms.ComboBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Black;
            this.lblTitle.Font = new System.Drawing.Font("Broadway", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblTitle.Location = new System.Drawing.Point(61, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(233, 27);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "New Entry Form";
            // 
            // lblEmployNo
            // 
            this.lblEmployNo.AutoSize = true;
            this.lblEmployNo.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployNo.Location = new System.Drawing.Point(12, 62);
            this.lblEmployNo.Name = "lblEmployNo";
            this.lblEmployNo.Size = new System.Drawing.Size(127, 19);
            this.lblEmployNo.TabIndex = 1;
            this.lblEmployNo.Text = "Employee Number";
            // 
            // lblEmployWR
            // 
            this.lblEmployWR.AutoSize = true;
            this.lblEmployWR.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployWR.Location = new System.Drawing.Point(12, 91);
            this.lblEmployWR.Name = "lblEmployWR";
            this.lblEmployWR.Size = new System.Drawing.Size(147, 19);
            this.lblEmployWR.TabIndex = 2;
            this.lblEmployWR.Text = "Employee Wage Rate";
            // 
            // lblEmployHours
            // 
            this.lblEmployHours.AutoSize = true;
            this.lblEmployHours.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmployHours.Location = new System.Drawing.Point(12, 120);
            this.lblEmployHours.Name = "lblEmployHours";
            this.lblEmployHours.Size = new System.Drawing.Size(166, 19);
            this.lblEmployHours.TabIndex = 3;
            this.lblEmployHours.Text = "Employee Hours Worked";
            // 
            // txtEmployNo
            // 
            this.txtEmployNo.Location = new System.Drawing.Point(184, 62);
            this.txtEmployNo.Name = "txtEmployNo";
            this.txtEmployNo.Size = new System.Drawing.Size(124, 20);
            this.txtEmployNo.TabIndex = 4;
            this.txtEmployNo.TextChanged += new System.EventHandler(this.txtEmployNo_TextChanged);
            // 
            // txtHours
            // 
            this.txtHours.Location = new System.Drawing.Point(184, 120);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(124, 20);
            this.txtHours.TabIndex = 5;
            this.txtHours.TextChanged += new System.EventHandler(this.txtHours_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Black;
            this.btnSubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSubmit.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSubmit.Location = new System.Drawing.Point(16, 191);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(130, 40);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // cmbWageRate
            // 
            this.cmbWageRate.FormattingEnabled = true;
            this.cmbWageRate.Items.AddRange(new object[] {
            "Manager",
            "Hairdresser",
            "Beauty Therapist"});
            this.cmbWageRate.Location = new System.Drawing.Point(184, 92);
            this.cmbWageRate.Name = "cmbWageRate";
            this.cmbWageRate.Size = new System.Drawing.Size(124, 21);
            this.cmbWageRate.TabIndex = 8;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(12, 153);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(154, 19);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Employee Gross Wage";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(184, 153);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(124, 20);
            this.txtTotal.TabIndex = 10;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Black;
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSave.Location = new System.Drawing.Point(178, 191);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(130, 40);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "SAVE";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // New_Entry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 266);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.cmbWageRate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtHours);
            this.Controls.Add(this.txtEmployNo);
            this.Controls.Add(this.lblEmployHours);
            this.Controls.Add(this.lblEmployWR);
            this.Controls.Add(this.lblEmployNo);
            this.Controls.Add(this.lblTitle);
            this.Name = "New_Entry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New_Entry";
            this.Load += new System.EventHandler(this.New_Entry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblEmployNo;
        private System.Windows.Forms.Label lblEmployWR;
        private System.Windows.Forms.Label lblEmployHours;
        private System.Windows.Forms.TextBox txtEmployNo;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.ComboBox cmbWageRate;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnSave;
    }
}