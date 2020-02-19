namespace Stokes_Assign6_EZLoan_Processing
{
    partial class Form1
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbLoanAmount = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbLoanAmount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbIntRate = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbNumYears = new System.Windows.Forms.Label();
            this.lbCarDetails = new System.Windows.Forms.Label();
            this.lbCarMake = new System.Windows.Forms.Label();
            this.lbCarModel = new System.Windows.Forms.Label();
            this.lbCarYear = new System.Windows.Forms.Label();
            this.lbCarColor = new System.Windows.Forms.Label();
            this.tbCarMake = new System.Windows.Forms.TextBox();
            this.tbCarModel = new System.Windows.Forms.TextBox();
            this.tbCarYear = new System.Windows.Forms.TextBox();
            this.tbCarColor = new System.Windows.Forms.TextBox();
            this.lbHomeDetails = new System.Windows.Forms.Label();
            this.lbHomAdd = new System.Windows.Forms.Label();
            this.lbHomeSqFt = new System.Windows.Forms.Label();
            this.lbHomeYrBlt = new System.Windows.Forms.Label();
            this.tbHomeAdd = new System.Windows.Forms.TextBox();
            this.tbHomeSqFt = new System.Windows.Forms.TextBox();
            this.tbHomeYrBlt = new System.Windows.Forms.TextBox();
            this.btProcess = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(191, 35);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(882, 55);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Customer Kiosk - Apply for a loan today!";
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(52, 126);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(160, 32);
            this.lbFirstName.TabIndex = 1;
            this.lbFirstName.Text = "First Name:";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(52, 184);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(159, 32);
            this.lbLastName.TabIndex = 2;
            this.lbLastName.Text = "Last Name:";
            // 
            // lbLoanAmount
            // 
            this.lbLoanAmount.AutoSize = true;
            this.lbLoanAmount.Location = new System.Drawing.Point(52, 242);
            this.lbLoanAmount.Name = "lbLoanAmount";
            this.lbLoanAmount.Size = new System.Drawing.Size(192, 32);
            this.lbLoanAmount.TabIndex = 3;
            this.lbLoanAmount.Text = "Loan Amount:";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(290, 126);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(290, 38);
            this.tbFirstName.TabIndex = 4;
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(290, 184);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(290, 38);
            this.tbLastName.TabIndex = 5;
            // 
            // tbLoanAmount
            // 
            this.tbLoanAmount.Location = new System.Drawing.Point(290, 242);
            this.tbLoanAmount.Name = "tbLoanAmount";
            this.tbLoanAmount.Size = new System.Drawing.Size(290, 38);
            this.tbLoanAmount.TabIndex = 6;
            this.tbLoanAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(861, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 32);
            this.label1.TabIndex = 7;
            this.label1.Text = "Type of Loan";
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "Auto",
            "Home"});
            this.cbType.Location = new System.Drawing.Point(795, 184);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(312, 39);
            this.cbType.TabIndex = 8;
            this.cbType.Text = "Select Loan Type";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Interest Rate:";
            // 
            // lbIntRate
            // 
            this.lbIntRate.AutoSize = true;
            this.lbIntRate.Location = new System.Drawing.Point(290, 340);
            this.lbIntRate.Name = "lbIntRate";
            this.lbIntRate.Size = new System.Drawing.Size(0, 32);
            this.lbIntRate.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 339);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(235, 32);
            this.label7.TabIndex = 11;
            this.label7.Text = "Number of Years:";
            // 
            // lbNumYears
            // 
            this.lbNumYears.AutoSize = true;
            this.lbNumYears.Location = new System.Drawing.Point(795, 340);
            this.lbNumYears.Name = "lbNumYears";
            this.lbNumYears.Size = new System.Drawing.Size(0, 32);
            this.lbNumYears.TabIndex = 12;
            // 
            // lbCarDetails
            // 
            this.lbCarDetails.AutoSize = true;
            this.lbCarDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCarDetails.Location = new System.Drawing.Point(139, 484);
            this.lbCarDetails.Name = "lbCarDetails";
            this.lbCarDetails.Size = new System.Drawing.Size(217, 46);
            this.lbCarDetails.TabIndex = 13;
            this.lbCarDetails.Text = "Car Details";
            this.lbCarDetails.Visible = false;
            // 
            // lbCarMake
            // 
            this.lbCarMake.AutoSize = true;
            this.lbCarMake.Location = new System.Drawing.Point(58, 559);
            this.lbCarMake.Name = "lbCarMake";
            this.lbCarMake.Size = new System.Drawing.Size(92, 32);
            this.lbCarMake.TabIndex = 14;
            this.lbCarMake.Text = "Make:";
            this.lbCarMake.Visible = false;
            // 
            // lbCarModel
            // 
            this.lbCarModel.AutoSize = true;
            this.lbCarModel.Location = new System.Drawing.Point(58, 615);
            this.lbCarModel.Name = "lbCarModel";
            this.lbCarModel.Size = new System.Drawing.Size(101, 32);
            this.lbCarModel.TabIndex = 15;
            this.lbCarModel.Text = "Model:";
            this.lbCarModel.Visible = false;
            // 
            // lbCarYear
            // 
            this.lbCarYear.AutoSize = true;
            this.lbCarYear.Location = new System.Drawing.Point(58, 671);
            this.lbCarYear.Name = "lbCarYear";
            this.lbCarYear.Size = new System.Drawing.Size(83, 32);
            this.lbCarYear.TabIndex = 16;
            this.lbCarYear.Text = "Year:";
            this.lbCarYear.Visible = false;
            // 
            // lbCarColor
            // 
            this.lbCarColor.AutoSize = true;
            this.lbCarColor.Location = new System.Drawing.Point(58, 727);
            this.lbCarColor.Name = "lbCarColor";
            this.lbCarColor.Size = new System.Drawing.Size(91, 32);
            this.lbCarColor.TabIndex = 17;
            this.lbCarColor.Text = "Color:";
            this.lbCarColor.Visible = false;
            // 
            // tbCarMake
            // 
            this.tbCarMake.Location = new System.Drawing.Point(230, 559);
            this.tbCarMake.Name = "tbCarMake";
            this.tbCarMake.Size = new System.Drawing.Size(218, 38);
            this.tbCarMake.TabIndex = 18;
            this.tbCarMake.Visible = false;
            // 
            // tbCarModel
            // 
            this.tbCarModel.Location = new System.Drawing.Point(230, 615);
            this.tbCarModel.Name = "tbCarModel";
            this.tbCarModel.Size = new System.Drawing.Size(218, 38);
            this.tbCarModel.TabIndex = 19;
            this.tbCarModel.Visible = false;
            // 
            // tbCarYear
            // 
            this.tbCarYear.Location = new System.Drawing.Point(230, 671);
            this.tbCarYear.Name = "tbCarYear";
            this.tbCarYear.Size = new System.Drawing.Size(218, 38);
            this.tbCarYear.TabIndex = 20;
            this.tbCarYear.Visible = false;
            // 
            // tbCarColor
            // 
            this.tbCarColor.Location = new System.Drawing.Point(230, 727);
            this.tbCarColor.Name = "tbCarColor";
            this.tbCarColor.Size = new System.Drawing.Size(218, 38);
            this.tbCarColor.TabIndex = 21;
            this.tbCarColor.Visible = false;
            // 
            // lbHomeDetails
            // 
            this.lbHomeDetails.AutoSize = true;
            this.lbHomeDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHomeDetails.Location = new System.Drawing.Point(714, 484);
            this.lbHomeDetails.Name = "lbHomeDetails";
            this.lbHomeDetails.Size = new System.Drawing.Size(260, 46);
            this.lbHomeDetails.TabIndex = 22;
            this.lbHomeDetails.Text = "Home Details";
            this.lbHomeDetails.Visible = false;
            // 
            // lbHomAdd
            // 
            this.lbHomAdd.AutoSize = true;
            this.lbHomAdd.Location = new System.Drawing.Point(716, 565);
            this.lbHomAdd.Name = "lbHomAdd";
            this.lbHomAdd.Size = new System.Drawing.Size(127, 32);
            this.lbHomAdd.TabIndex = 23;
            this.lbHomAdd.Text = "Address:";
            this.lbHomAdd.Visible = false;
            // 
            // lbHomeSqFt
            // 
            this.lbHomeSqFt.AutoSize = true;
            this.lbHomeSqFt.Location = new System.Drawing.Point(716, 621);
            this.lbHomeSqFt.Name = "lbHomeSqFt";
            this.lbHomeSqFt.Size = new System.Drawing.Size(130, 32);
            this.lbHomeSqFt.TabIndex = 24;
            this.lbHomeSqFt.Text = "Sq. Feet:";
            this.lbHomeSqFt.Visible = false;
            // 
            // lbHomeYrBlt
            // 
            this.lbHomeYrBlt.AutoSize = true;
            this.lbHomeYrBlt.Location = new System.Drawing.Point(716, 677);
            this.lbHomeYrBlt.Name = "lbHomeYrBlt";
            this.lbHomeYrBlt.Size = new System.Drawing.Size(147, 32);
            this.lbHomeYrBlt.TabIndex = 25;
            this.lbHomeYrBlt.Text = "Year Built:";
            this.lbHomeYrBlt.Visible = false;
            // 
            // tbHomeAdd
            // 
            this.tbHomeAdd.Location = new System.Drawing.Point(886, 565);
            this.tbHomeAdd.Name = "tbHomeAdd";
            this.tbHomeAdd.Size = new System.Drawing.Size(406, 38);
            this.tbHomeAdd.TabIndex = 26;
            this.tbHomeAdd.Visible = false;
            // 
            // tbHomeSqFt
            // 
            this.tbHomeSqFt.Location = new System.Drawing.Point(886, 621);
            this.tbHomeSqFt.Name = "tbHomeSqFt";
            this.tbHomeSqFt.Size = new System.Drawing.Size(221, 38);
            this.tbHomeSqFt.TabIndex = 27;
            this.tbHomeSqFt.Visible = false;
            // 
            // tbHomeYrBlt
            // 
            this.tbHomeYrBlt.Location = new System.Drawing.Point(886, 677);
            this.tbHomeYrBlt.Name = "tbHomeYrBlt";
            this.tbHomeYrBlt.Size = new System.Drawing.Size(221, 38);
            this.tbHomeYrBlt.TabIndex = 28;
            this.tbHomeYrBlt.Visible = false;
            // 
            // btProcess
            // 
            this.btProcess.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.btProcess.ForeColor = System.Drawing.Color.Yellow;
            this.btProcess.Location = new System.Drawing.Point(722, 755);
            this.btProcess.Name = "btProcess";
            this.btProcess.Size = new System.Drawing.Size(570, 56);
            this.btProcess.TabIndex = 29;
            this.btProcess.Text = "Process Request";
            this.btProcess.UseVisualStyleBackColor = false;
            this.btProcess.Click += new System.EventHandler(this.btProcess_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(1409, 985);
            this.Controls.Add(this.btProcess);
            this.Controls.Add(this.tbHomeYrBlt);
            this.Controls.Add(this.tbHomeSqFt);
            this.Controls.Add(this.tbHomeAdd);
            this.Controls.Add(this.lbHomeYrBlt);
            this.Controls.Add(this.lbHomeSqFt);
            this.Controls.Add(this.lbHomAdd);
            this.Controls.Add(this.lbHomeDetails);
            this.Controls.Add(this.tbCarColor);
            this.Controls.Add(this.tbCarYear);
            this.Controls.Add(this.tbCarModel);
            this.Controls.Add(this.tbCarMake);
            this.Controls.Add(this.lbCarColor);
            this.Controls.Add(this.lbCarYear);
            this.Controls.Add(this.lbCarModel);
            this.Controls.Add(this.lbCarMake);
            this.Controls.Add(this.lbCarDetails);
            this.Controls.Add(this.lbNumYears);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbIntRate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLoanAmount);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbLoanAmount);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
            this.Controls.Add(this.lbTitle);
            this.ForeColor = System.Drawing.Color.SeaShell;
            this.Name = "Form1";
            this.Text = "EZ Loan Processing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbLoanAmount;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbLoanAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbIntRate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbNumYears;
        private System.Windows.Forms.Label lbCarDetails;
        private System.Windows.Forms.Label lbCarMake;
        private System.Windows.Forms.Label lbCarModel;
        private System.Windows.Forms.Label lbCarYear;
        private System.Windows.Forms.Label lbCarColor;
        private System.Windows.Forms.TextBox tbCarMake;
        private System.Windows.Forms.TextBox tbCarModel;
        private System.Windows.Forms.TextBox tbCarYear;
        private System.Windows.Forms.TextBox tbCarColor;
        private System.Windows.Forms.Label lbHomeDetails;
        private System.Windows.Forms.Label lbHomAdd;
        private System.Windows.Forms.Label lbHomeSqFt;
        private System.Windows.Forms.Label lbHomeYrBlt;
        private System.Windows.Forms.TextBox tbHomeAdd;
        private System.Windows.Forms.TextBox tbHomeSqFt;
        private System.Windows.Forms.TextBox tbHomeYrBlt;
        private System.Windows.Forms.Button btProcess;
    }
}

