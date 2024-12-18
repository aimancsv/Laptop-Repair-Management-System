namespace Repair_Heads_compiled_program
{
    partial class Receive_Payment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receive_Payment));
            this.btnAccept = new System.Windows.Forms.Button();
            this.lblCustomerDetails = new System.Windows.Forms.Label();
            this.cmbServiceID = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.lblOrderDetails = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.White;
            this.btnAccept.Location = new System.Drawing.Point(429, 329);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(300, 53);
            this.btnAccept.TabIndex = 35;
            this.btnAccept.Text = "Accept Payment";
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // lblCustomerDetails
            // 
            this.lblCustomerDetails.AutoSize = true;
            this.lblCustomerDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.lblCustomerDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCustomerDetails.ForeColor = System.Drawing.Color.White;
            this.lblCustomerDetails.Location = new System.Drawing.Point(22, 285);
            this.lblCustomerDetails.Name = "lblCustomerDetails";
            this.lblCustomerDetails.Size = new System.Drawing.Size(69, 105);
            this.lblCustomerDetails.TabIndex = 33;
            this.lblCustomerDetails.Text = "UserID:\r\nName: \r\nEmail: \r\nPhone: \r\nAddress:\r\n";
            // 
            // cmbServiceID
            // 
            this.cmbServiceID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServiceID.FormattingEnabled = true;
            this.cmbServiceID.Location = new System.Drawing.Point(22, 73);
            this.cmbServiceID.Name = "cmbServiceID";
            this.cmbServiceID.Size = new System.Drawing.Size(280, 23);
            this.cmbServiceID.TabIndex = 32;
            this.cmbServiceID.SelectedIndexChanged += new System.EventHandler(this.cmbServiceID_SelectedIndexChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(22, 45);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(148, 25);
            this.lblEmail.TabIndex = 31;
            this.lblEmail.Text = "Enter Service ID:";
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(12, 12);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(116, 33);
            this.btnSignOut.TabIndex = 30;
            this.btnSignOut.Text = "Cancel";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // picProfile
            // 
            this.picProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.picProfile.Image = ((System.Drawing.Image)(resources.GetObject("picProfile.Image")));
            this.picProfile.Location = new System.Drawing.Point(75, 98);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(200, 200);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picProfile.TabIndex = 29;
            this.picProfile.TabStop = false;
            // 
            // picBackground
            // 
            this.picBackground.Image = ((System.Drawing.Image)(resources.GetObject("picBackground.Image")));
            this.picBackground.Location = new System.Drawing.Point(0, 0);
            this.picBackground.Margin = new System.Windows.Forms.Padding(0);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(800, 503);
            this.picBackground.TabIndex = 28;
            this.picBackground.TabStop = false;
            // 
            // lblOrderDetails
            // 
            this.lblOrderDetails.AutoSize = true;
            this.lblOrderDetails.Location = new System.Drawing.Point(6, 15);
            this.lblOrderDetails.Name = "lblOrderDetails";
            this.lblOrderDetails.Size = new System.Drawing.Size(130, 150);
            this.lblOrderDetails.TabIndex = 25;
            this.lblOrderDetails.Text = "Service type:\r\n\r\n\r\nDescription:\r\n\r\n\r\nService submitted date:\r\n\r\n\r\nTotal fees:\r\n";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.lblOrderDetails);
            this.groupBox1.Location = new System.Drawing.Point(429, 73);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 199);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // Receive_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblCustomerDetails);
            this.Controls.Add(this.cmbServiceID);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.picProfile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picBackground);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Receive_Payment";
            this.Text = "Receive_Payment";
            this.Load += new System.EventHandler(this.Receive_Payment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnAccept;
        private Label lblCustomerDetails;
        private ComboBox cmbServiceID;
        private Label lblEmail;
        private Button btnSignOut;
        private PictureBox picProfile;
        private PictureBox picBackground;
        private Label lblOrderDetails;
        private GroupBox groupBox1;
    }
}