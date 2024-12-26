namespace Project__3_V1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpNewEmployee = new GroupBox();
            btnClear = new Button();
            btnAddToPayroll = new Button();
            txtEmployeePay = new TextBox();
            txtHourlyRate = new TextBox();
            txtHoursWorked = new TextBox();
            txtEmployeeName = new TextBox();
            lblEmployeePay = new Label();
            lblHourlyRate = new Label();
            lblHoursWorked = new Label();
            lblEmployeeName = new Label();
            lblNumberEmployees = new Label();
            lblPayrollTotal = new Label();
            txtNumberEmployees = new TextBox();
            txtPayrollTotal = new TextBox();
            lstPayrollSum = new ListBox();
            btnExit = new Button();
            grpNewEmployee.SuspendLayout();
            SuspendLayout();
            // 
            // grpNewEmployee
            // 
            grpNewEmployee.Controls.Add(btnClear);
            grpNewEmployee.Controls.Add(btnAddToPayroll);
            grpNewEmployee.Controls.Add(txtEmployeePay);
            grpNewEmployee.Controls.Add(txtHourlyRate);
            grpNewEmployee.Controls.Add(txtHoursWorked);
            grpNewEmployee.Controls.Add(txtEmployeeName);
            grpNewEmployee.Controls.Add(lblEmployeePay);
            grpNewEmployee.Controls.Add(lblHourlyRate);
            grpNewEmployee.Controls.Add(lblHoursWorked);
            grpNewEmployee.Controls.Add(lblEmployeeName);
            grpNewEmployee.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpNewEmployee.Location = new Point(139, 71);
            grpNewEmployee.Name = "grpNewEmployee";
            grpNewEmployee.Size = new Size(465, 271);
            grpNewEmployee.TabIndex = 0;
            grpNewEmployee.TabStop = false;
            grpNewEmployee.Text = "New Employee";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(248, 170);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(123, 24);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnAddToPayroll
            // 
            btnAddToPayroll.Location = new Point(46, 170);
            btnAddToPayroll.Name = "btnAddToPayroll";
            btnAddToPayroll.Size = new Size(123, 24);
            btnAddToPayroll.TabIndex = 11;
            btnAddToPayroll.Text = "Add to Payroll";
            btnAddToPayroll.UseVisualStyleBackColor = true;
            btnAddToPayroll.Click += btnAddToPayroll_Click;
            // 
            // txtEmployeePay
            // 
            txtEmployeePay.Location = new Point(175, 204);
            txtEmployeePay.Name = "txtEmployeePay";
            txtEmployeePay.Size = new Size(100, 23);
            txtEmployeePay.TabIndex = 10;
            // 
            // txtHourlyRate
            // 
            txtHourlyRate.Location = new Point(175, 124);
            txtHourlyRate.Name = "txtHourlyRate";
            txtHourlyRate.Size = new Size(100, 23);
            txtHourlyRate.TabIndex = 9;
            txtHourlyRate.Tag = "Hourly rate";
            // 
            // txtHoursWorked
            // 
            txtHoursWorked.Location = new Point(175, 77);
            txtHoursWorked.Name = "txtHoursWorked";
            txtHoursWorked.Size = new Size(100, 23);
            txtHoursWorked.TabIndex = 8;
            txtHoursWorked.Tag = "Hours worked";
            // 
            // txtEmployeeName
            // 
            txtEmployeeName.Location = new Point(175, 33);
            txtEmployeeName.Name = "txtEmployeeName";
            txtEmployeeName.Size = new Size(100, 23);
            txtEmployeeName.TabIndex = 7;
            txtEmployeeName.Tag = "Employee";
            // 
            // lblEmployeePay
            // 
            lblEmployeePay.AutoSize = true;
            lblEmployeePay.Location = new Point(35, 212);
            lblEmployeePay.Name = "lblEmployeePay";
            lblEmployeePay.Size = new Size(86, 15);
            lblEmployeePay.TabIndex = 4;
            lblEmployeePay.Text = "Employee Pay:";
            // 
            // lblHourlyRate
            // 
            lblHourlyRate.AutoSize = true;
            lblHourlyRate.Location = new Point(35, 124);
            lblHourlyRate.Name = "lblHourlyRate";
            lblHourlyRate.Size = new Size(76, 15);
            lblHourlyRate.TabIndex = 3;
            lblHourlyRate.Tag = "Rate";
            lblHourlyRate.Text = "Hourly Rate:";
            // 
            // lblHoursWorked
            // 
            lblHoursWorked.AutoSize = true;
            lblHoursWorked.Location = new Point(35, 85);
            lblHoursWorked.Name = "lblHoursWorked";
            lblHoursWorked.Size = new Size(91, 15);
            lblHoursWorked.TabIndex = 2;
            lblHoursWorked.Tag = "Hours";
            lblHoursWorked.Text = "Hours Worked:";
            // 
            // lblEmployeeName
            // 
            lblEmployeeName.AutoSize = true;
            lblEmployeeName.Location = new Point(35, 41);
            lblEmployeeName.Name = "lblEmployeeName";
            lblEmployeeName.Size = new Size(100, 15);
            lblEmployeeName.TabIndex = 1;
            lblEmployeeName.Text = "Employee Name:";
            // 
            // lblNumberEmployees
            // 
            lblNumberEmployees.AutoSize = true;
            lblNumberEmployees.Location = new Point(139, 443);
            lblNumberEmployees.Name = "lblNumberEmployees";
            lblNumberEmployees.Size = new Size(77, 15);
            lblNumberEmployees.TabIndex = 5;
            lblNumberEmployees.Text = "# Employees:";
            // 
            // lblPayrollTotal
            // 
            lblPayrollTotal.AutoSize = true;
            lblPayrollTotal.Location = new Point(387, 443);
            lblPayrollTotal.Name = "lblPayrollTotal";
            lblPayrollTotal.Size = new Size(74, 15);
            lblPayrollTotal.TabIndex = 6;
            lblPayrollTotal.Text = "Payroll Total:";
            // 
            // txtNumberEmployees
            // 
            txtNumberEmployees.Location = new Point(242, 435);
            txtNumberEmployees.Name = "txtNumberEmployees";
            txtNumberEmployees.Size = new Size(100, 23);
            txtNumberEmployees.TabIndex = 11;
            // 
            // txtPayrollTotal
            // 
            txtPayrollTotal.Location = new Point(481, 435);
            txtPayrollTotal.Name = "txtPayrollTotal";
            txtPayrollTotal.Size = new Size(100, 23);
            txtPayrollTotal.TabIndex = 12;
            // 
            // lstPayrollSum
            // 
            lstPayrollSum.FormattingEnabled = true;
            lstPayrollSum.ItemHeight = 15;
            lstPayrollSum.Location = new Point(681, 77);
            lstPayrollSum.Name = "lstPayrollSum";
            lstPayrollSum.Size = new Size(284, 259);
            lstPayrollSum.TabIndex = 13;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(824, 463);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(123, 24);
            btnExit.TabIndex = 13;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1043, 606);
            Controls.Add(btnExit);
            Controls.Add(lstPayrollSum);
            Controls.Add(txtPayrollTotal);
            Controls.Add(txtNumberEmployees);
            Controls.Add(lblPayrollTotal);
            Controls.Add(lblNumberEmployees);
            Controls.Add(grpNewEmployee);
            Name = "Form1";
            Text = "Payroll Calculation";
            grpNewEmployee.ResumeLayout(false);
            grpNewEmployee.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpNewEmployee;
        private Label lblEmployeeName;
        private Label lblEmployeePay;
        private Label lblHourlyRate;
        private Label lblHoursWorked;
        private Label lblNumberEmployees;
        private TextBox txtHourlyRate;
        private TextBox txtHoursWorked;
        private TextBox txtEmployeeName;
        private Label lblPayrollTotal;
        private TextBox txtEmployeePay;
        private TextBox txtNumberEmployees;
        private TextBox txtPayrollTotal;
        private Button btnClear;
        private Button btnAddToPayroll;
        private ListBox lstPayrollSum;
        private Button btnExit;
    }
}
