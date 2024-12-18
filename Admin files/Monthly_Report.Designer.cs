namespace Repair_Heads_compiled_program
{
    partial class Monthly_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Monthly_Report));
            this.lblSerReport = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.dateTimePickerMonth = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerYear = new System.Windows.Forms.DateTimePicker();
            this.listSerReport = new System.Windows.Forms.ListView();
            this.ServiceID = new System.Windows.Forms.ColumnHeader();
            this.SubmittedDate = new System.Windows.Forms.ColumnHeader();
            this.Urgency = new System.Windows.Forms.ColumnHeader();
            this.ServiceStatus = new System.Windows.Forms.ColumnHeader();
            this.CollectionDate = new System.Windows.Forms.ColumnHeader();
            this.Fee = new System.Windows.Forms.ColumnHeader();
            this.Payment = new System.Windows.Forms.ColumnHeader();
            this.lblYear = new System.Windows.Forms.Label();
            this.lblMonth = new System.Windows.Forms.Label();
            this.lblTotIncom = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnTotIncome = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSerReport
            // 
            this.lblSerReport.AutoSize = true;
            this.lblSerReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.lblSerReport.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSerReport.ForeColor = System.Drawing.Color.White;
            this.lblSerReport.Location = new System.Drawing.Point(10, 9);
            this.lblSerReport.Name = "lblSerReport";
            this.lblSerReport.Size = new System.Drawing.Size(250, 32);
            this.lblSerReport.TabIndex = 0;
            this.lblSerReport.Text = "View Service Report ";
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.White;
            this.btnBack.FlatAppearance.BorderSize = 0;
            this.btnBack.Location = new System.Drawing.Point(10, 326);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(114, 40);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.button2_Click);
            // 
            // picBox
            // 
            this.picBox.Image = ((System.Drawing.Image)(resources.GetObject("picBox.Image")));
            this.picBox.Location = new System.Drawing.Point(1, -4);
            this.picBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(909, 375);
            this.picBox.TabIndex = 5;
            this.picBox.TabStop = false;
            // 
            // dateTimePickerMonth
            // 
            this.dateTimePickerMonth.CustomFormat = "mm/yy";
            this.dateTimePickerMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerMonth.Location = new System.Drawing.Point(19, 72);
            this.dateTimePickerMonth.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerMonth.Name = "dateTimePickerMonth";
            this.dateTimePickerMonth.Size = new System.Drawing.Size(126, 23);
            this.dateTimePickerMonth.TabIndex = 6;
            this.dateTimePickerMonth.ValueChanged += new System.EventHandler(this.dateTimePickerMonth_ValueChanged);
            // 
            // dateTimePickerYear
            // 
            this.dateTimePickerYear.CustomFormat = "mm/yy";
            this.dateTimePickerYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerYear.Location = new System.Drawing.Point(156, 72);
            this.dateTimePickerYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dateTimePickerYear.Name = "dateTimePickerYear";
            this.dateTimePickerYear.Size = new System.Drawing.Size(126, 23);
            this.dateTimePickerYear.TabIndex = 8;
            this.dateTimePickerYear.ValueChanged += new System.EventHandler(this.dateTimePickerYear_ValueChanged);
            // 
            // listSerReport
            // 
            this.listSerReport.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ServiceID,
            this.SubmittedDate,
            this.Urgency,
            this.ServiceStatus,
            this.CollectionDate,
            this.Fee,
            this.Payment});
            this.listSerReport.FullRowSelect = true;
            this.listSerReport.GridLines = true;
            this.listSerReport.Location = new System.Drawing.Point(19, 99);
            this.listSerReport.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listSerReport.Name = "listSerReport";
            this.listSerReport.Size = new System.Drawing.Size(649, 153);
            this.listSerReport.TabIndex = 11;
            this.listSerReport.UseCompatibleStateImageBehavior = false;
            this.listSerReport.View = System.Windows.Forms.View.Details;
            // 
            // ServiceID
            // 
            this.ServiceID.Text = "Service ID";
            this.ServiceID.Width = 65;
            // 
            // SubmittedDate
            // 
            this.SubmittedDate.Text = "Submitted Date";
            this.SubmittedDate.Width = 150;
            // 
            // Urgency
            // 
            this.Urgency.Text = "Urgency";
            // 
            // ServiceStatus
            // 
            this.ServiceStatus.Text = "Service Status";
            this.ServiceStatus.Width = 100;
            // 
            // CollectionDate
            // 
            this.CollectionDate.Text = "Collection Date";
            this.CollectionDate.Width = 150;
            // 
            // Fee
            // 
            this.Fee.Text = "Fee";
            this.Fee.Width = 50;
            // 
            // Payment
            // 
            this.Payment.Text = "Payment";
            this.Payment.Width = 70;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.lblYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblYear.Location = new System.Drawing.Point(156, 49);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(98, 21);
            this.lblYear.TabIndex = 7;
            this.lblYear.Text = "Select Year:";
            // 
            // lblMonth
            // 
            this.lblMonth.AutoSize = true;
            this.lblMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.lblMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMonth.Location = new System.Drawing.Point(19, 49);
            this.lblMonth.Name = "lblMonth";
            this.lblMonth.Size = new System.Drawing.Size(115, 21);
            this.lblMonth.TabIndex = 12;
            this.lblMonth.Text = "Select Month:";
            // 
            // lblTotIncom
            // 
            this.lblTotIncom.AutoSize = true;
            this.lblTotIncom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.lblTotIncom.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotIncom.ForeColor = System.Drawing.Color.White;
            this.lblTotIncom.Location = new System.Drawing.Point(10, 284);
            this.lblTotIncom.Name = "lblTotIncom";
            this.lblTotIncom.Size = new System.Drawing.Size(169, 32);
            this.lblTotIncom.TabIndex = 14;
            this.lblTotIncom.Text = "Total Income:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.lblTotal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTotal.ForeColor = System.Drawing.Color.Black;
            this.lblTotal.Location = new System.Drawing.Point(197, 280);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 37);
            this.lblTotal.TabIndex = 14;
            // 
            // btnTotIncome
            // 
            this.btnTotIncome.BackColor = System.Drawing.Color.White;
            this.btnTotIncome.FlatAppearance.BorderSize = 0;
            this.btnTotIncome.Location = new System.Drawing.Point(18, 257);
            this.btnTotIncome.Name = "btnTotIncome";
            this.btnTotIncome.Size = new System.Drawing.Size(280, 23);
            this.btnTotIncome.TabIndex = 2;
            this.btnTotIncome.Text = "View Total Income for selected month";
            this.btnTotIncome.UseVisualStyleBackColor = false;
            this.btnTotIncome.Click += new System.EventHandler(this.btnTotIncome_Click);
            // 
            // Monthly_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(705, 371);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTotIncom);
            this.Controls.Add(this.lblMonth);
            this.Controls.Add(this.listSerReport);
            this.Controls.Add(this.dateTimePickerYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.dateTimePickerMonth);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnTotIncome);
            this.Controls.Add(this.lblSerReport);
            this.Controls.Add(this.picBox);
            this.DoubleBuffered = true;
            this.Name = "Monthly_Report";
            this.Text = "Monthly Report";
            this.Load += new System.EventHandler(this.Monthly_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblSerReport;
        private Button btnBack;
        private PictureBox picBox;
        private DateTimePicker dateTimePickerMonth;
        private DateTimePicker dateTimePickerYear;
        private ListView listSerReport;
        private ColumnHeader ServiceID;
        private ColumnHeader SubmittedDate;
        private ColumnHeader Urgency;
        private ColumnHeader ServiceStatus;
        private ColumnHeader CollectionDate;
        private ColumnHeader Fee;
        private Label lblYear;
        private Label lblMonth;
        private Label lblTotIncom;
        private Label lblTotal;
        private Button btnTotIncome;
        private ColumnHeader Payment;
    }
}