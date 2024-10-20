namespace EmployeeApplication
{
    partial class frmComputeSalary
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TextFirstName = new System.Windows.Forms.TextBox();
            this.TextLastName = new System.Windows.Forms.TextBox();
            this.TextDepartment = new System.Windows.Forms.TextBox();
            this.TextJobTitle = new System.Windows.Forms.TextBox();
            this.TextRatePerHour = new System.Windows.Forms.TextBox();
            this.TextHoursWorked = new System.Windows.Forms.TextBox();
            this.btnComputeSalary = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(359, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Last Name";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 175);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Rate Per Hour";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(359, 175);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Total Hours worked";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(359, 75);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Job Title";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 75);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Department";
            // 
            // TextFirstName
            // 
            this.TextFirstName.Location = new System.Drawing.Point(19, 47);
            this.TextFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextFirstName.Name = "TextFirstName";
            this.TextFirstName.Size = new System.Drawing.Size(276, 22);
            this.TextFirstName.TabIndex = 6;
            this.TextFirstName.TextChanged += new System.EventHandler(this.TextFirstName_TextChanged);
            // 
            // TextLastName
            // 
            this.TextLastName.Location = new System.Drawing.Point(364, 49);
            this.TextLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextLastName.Name = "TextLastName";
            this.TextLastName.Size = new System.Drawing.Size(276, 22);
            this.TextLastName.TabIndex = 7;
            // 
            // TextDepartment
            // 
            this.TextDepartment.Location = new System.Drawing.Point(19, 103);
            this.TextDepartment.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextDepartment.Name = "TextDepartment";
            this.TextDepartment.Size = new System.Drawing.Size(276, 22);
            this.TextDepartment.TabIndex = 8;
            // 
            // TextJobTitle
            // 
            this.TextJobTitle.Location = new System.Drawing.Point(364, 104);
            this.TextJobTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextJobTitle.Name = "TextJobTitle";
            this.TextJobTitle.Size = new System.Drawing.Size(276, 22);
            this.TextJobTitle.TabIndex = 9;
            // 
            // TextRatePerHour
            // 
            this.TextRatePerHour.Location = new System.Drawing.Point(13, 220);
            this.TextRatePerHour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextRatePerHour.Name = "TextRatePerHour";
            this.TextRatePerHour.Size = new System.Drawing.Size(282, 22);
            this.TextRatePerHour.TabIndex = 10;
            // 
            // TextHoursWorked
            // 
            this.TextHoursWorked.Location = new System.Drawing.Point(364, 220);
            this.TextHoursWorked.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TextHoursWorked.Name = "TextHoursWorked";
            this.TextHoursWorked.Size = new System.Drawing.Size(276, 22);
            this.TextHoursWorked.TabIndex = 11;
            this.TextHoursWorked.TextChanged += new System.EventHandler(this.TextHoursWorked_TextChanged);
            // 
            // btnComputeSalary
            // 
            this.btnComputeSalary.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnComputeSalary.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnComputeSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnComputeSalary.Location = new System.Drawing.Point(239, 377);
            this.btnComputeSalary.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnComputeSalary.Name = "btnComputeSalary";
            this.btnComputeSalary.Size = new System.Drawing.Size(188, 43);
            this.btnComputeSalary.TabIndex = 12;
            this.btnComputeSalary.Text = "Compute Salary";
            this.btnComputeSalary.UseVisualStyleBackColor = false;
            this.btnComputeSalary.Click += new System.EventHandler(this.btnComputeSalary_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(13, 313);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 25);
            this.lblResult.TabIndex = 13;
            this.lblResult.Click += new System.EventHandler(this.lblResult_Click);
            // 
            // frmComputeSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(732, 444);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnComputeSalary);
            this.Controls.Add(this.TextHoursWorked);
            this.Controls.Add(this.TextRatePerHour);
            this.Controls.Add(this.TextJobTitle);
            this.Controls.Add(this.TextDepartment);
            this.Controls.Add(this.TextLastName);
            this.Controls.Add(this.TextFirstName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmComputeSalary";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Employee Salary Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TextFirstName;
        private System.Windows.Forms.TextBox TextLastName;
        private System.Windows.Forms.TextBox TextDepartment;
        private System.Windows.Forms.TextBox TextJobTitle;
        private System.Windows.Forms.TextBox TextRatePerHour;
        private System.Windows.Forms.TextBox TextHoursWorked;
        private System.Windows.Forms.Button btnComputeSalary;
        private System.Windows.Forms.Label lblResult;
    }
}
