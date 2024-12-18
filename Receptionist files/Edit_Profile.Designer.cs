namespace Repair_Heads_compiled_program
{
    partial class Edit_Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Edit_Profile));
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.lblCurrentDetails = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.btnUpdateProfile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtpDoB = new System.Windows.Forms.DateTimePicker();
            this.cbNewAddress = new System.Windows.Forms.CheckBox();
            this.txtNewAddress = new System.Windows.Forms.TextBox();
            this.cbNewPhone = new System.Windows.Forms.CheckBox();
            this.txtNewPhone = new System.Windows.Forms.TextBox();
            this.cbNewEmail = new System.Windows.Forms.CheckBox();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.cbNewDoB = new System.Windows.Forms.CheckBox();
            this.cbNewPassword = new System.Windows.Forms.CheckBox();
            this.txtNewPassword = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.cbShowPassword = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picBackground
            // 
            this.picBackground.Image = ((System.Drawing.Image)(resources.GetObject("picBackground.Image")));
            this.picBackground.Location = new System.Drawing.Point(-8, -20);
            this.picBackground.Margin = new System.Windows.Forms.Padding(0);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(800, 500);
            this.picBackground.TabIndex = 8;
            this.picBackground.TabStop = false;
            // 
            // lblCurrentDetails
            // 
            this.lblCurrentDetails.AutoSize = true;
            this.lblCurrentDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.lblCurrentDetails.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCurrentDetails.ForeColor = System.Drawing.Color.White;
            this.lblCurrentDetails.Location = new System.Drawing.Point(22, 248);
            this.lblCurrentDetails.Name = "lblCurrentDetails";
            this.lblCurrentDetails.Size = new System.Drawing.Size(79, 147);
            this.lblCurrentDetails.TabIndex = 39;
            this.lblCurrentDetails.Text = "UserID:\r\nPassword:\r\nName:\r\nDoB:\r\nEmail:\r\nPhone:\r\nAddress:";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(12, 12);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 33);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // picProfile
            // 
            this.picProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.picProfile.Image = ((System.Drawing.Image)(resources.GetObject("picProfile.Image")));
            this.picProfile.Location = new System.Drawing.Point(75, 62);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(200, 200);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picProfile.TabIndex = 36;
            this.picProfile.TabStop = false;
            // 
            // btnUpdateProfile
            // 
            this.btnUpdateProfile.BackColor = System.Drawing.Color.White;
            this.btnUpdateProfile.Location = new System.Drawing.Point(429, 329);
            this.btnUpdateProfile.Name = "btnUpdateProfile";
            this.btnUpdateProfile.Size = new System.Drawing.Size(300, 53);
            this.btnUpdateProfile.TabIndex = 11;
            this.btnUpdateProfile.Text = "Update profile";
            this.btnUpdateProfile.UseVisualStyleBackColor = false;
            this.btnUpdateProfile.Click += new System.EventHandler(this.btnUpdateProfile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dtpDoB);
            this.groupBox1.Controls.Add(this.cbNewAddress);
            this.groupBox1.Controls.Add(this.txtNewAddress);
            this.groupBox1.Controls.Add(this.cbNewPhone);
            this.groupBox1.Controls.Add(this.txtNewPhone);
            this.groupBox1.Controls.Add(this.cbNewEmail);
            this.groupBox1.Controls.Add(this.txtNewEmail);
            this.groupBox1.Controls.Add(this.cbNewDoB);
            this.groupBox1.Controls.Add(this.cbNewPassword);
            this.groupBox1.Controls.Add(this.txtNewPassword);
            this.groupBox1.Location = new System.Drawing.Point(429, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(300, 235);
            this.groupBox1.TabIndex = 40;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose and fill details to change:";
            // 
            // dtpDoB
            // 
            this.dtpDoB.Location = new System.Drawing.Point(118, 51);
            this.dtpDoB.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.Size = new System.Drawing.Size(176, 23);
            this.dtpDoB.TabIndex = 4;
            this.dtpDoB.Value = new System.DateTime(2022, 6, 9, 15, 2, 21, 0);
            this.dtpDoB.ValueChanged += new System.EventHandler(this.dtpDoB_ValueChanged);
            // 
            // cbNewAddress
            // 
            this.cbNewAddress.AutoSize = true;
            this.cbNewAddress.Location = new System.Drawing.Point(6, 140);
            this.cbNewAddress.Name = "cbNewAddress";
            this.cbNewAddress.Size = new System.Drawing.Size(98, 19);
            this.cbNewAddress.TabIndex = 9;
            this.cbNewAddress.Text = "New Address:";
            this.cbNewAddress.UseVisualStyleBackColor = true;
            this.cbNewAddress.CheckedChanged += new System.EventHandler(this.cbNewAddress_CheckedChanged);
            // 
            // txtNewAddress
            // 
            this.txtNewAddress.AcceptsReturn = true;
            this.txtNewAddress.Location = new System.Drawing.Point(6, 165);
            this.txtNewAddress.Multiline = true;
            this.txtNewAddress.Name = "txtNewAddress";
            this.txtNewAddress.Size = new System.Drawing.Size(288, 64);
            this.txtNewAddress.TabIndex = 10;
            this.txtNewAddress.TextChanged += new System.EventHandler(this.txtNewAddress_TextChanged);
            // 
            // cbNewPhone
            // 
            this.cbNewPhone.AutoSize = true;
            this.cbNewPhone.Location = new System.Drawing.Point(6, 111);
            this.cbNewPhone.Name = "cbNewPhone";
            this.cbNewPhone.Size = new System.Drawing.Size(90, 19);
            this.cbNewPhone.TabIndex = 7;
            this.cbNewPhone.Text = "New Phone:";
            this.cbNewPhone.UseVisualStyleBackColor = true;
            this.cbNewPhone.CheckedChanged += new System.EventHandler(this.cbNewPhone_CheckedChanged);
            // 
            // txtNewPhone
            // 
            this.txtNewPhone.Location = new System.Drawing.Point(118, 109);
            this.txtNewPhone.Name = "txtNewPhone";
            this.txtNewPhone.Size = new System.Drawing.Size(176, 23);
            this.txtNewPhone.TabIndex = 8;
            this.txtNewPhone.TextChanged += new System.EventHandler(this.txtNewPhone_TextChanged);
            // 
            // cbNewEmail
            // 
            this.cbNewEmail.AutoSize = true;
            this.cbNewEmail.Location = new System.Drawing.Point(6, 82);
            this.cbNewEmail.Name = "cbNewEmail";
            this.cbNewEmail.Size = new System.Drawing.Size(85, 19);
            this.cbNewEmail.TabIndex = 5;
            this.cbNewEmail.Text = "New Email:";
            this.cbNewEmail.UseVisualStyleBackColor = true;
            this.cbNewEmail.CheckedChanged += new System.EventHandler(this.cbNewEmail_CheckedChanged);
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.Location = new System.Drawing.Point(118, 80);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(176, 23);
            this.txtNewEmail.TabIndex = 6;
            this.txtNewEmail.TextChanged += new System.EventHandler(this.txtNewEmail_TextChanged);
            // 
            // cbNewDoB
            // 
            this.cbNewDoB.AutoSize = true;
            this.cbNewDoB.Location = new System.Drawing.Point(6, 53);
            this.cbNewDoB.Name = "cbNewDoB";
            this.cbNewDoB.Size = new System.Drawing.Size(78, 19);
            this.cbNewDoB.TabIndex = 3;
            this.cbNewDoB.Text = "New DoB:";
            this.cbNewDoB.UseVisualStyleBackColor = true;
            this.cbNewDoB.CheckedChanged += new System.EventHandler(this.cbNewDoB_CheckedChanged);
            // 
            // cbNewPassword
            // 
            this.cbNewPassword.AutoSize = true;
            this.cbNewPassword.Location = new System.Drawing.Point(6, 24);
            this.cbNewPassword.Name = "cbNewPassword";
            this.cbNewPassword.Size = new System.Drawing.Size(106, 19);
            this.cbNewPassword.TabIndex = 1;
            this.cbNewPassword.Text = "New Password:";
            this.cbNewPassword.UseVisualStyleBackColor = true;
            this.cbNewPassword.CheckedChanged += new System.EventHandler(this.cbNewPassword_CheckedChanged);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Location = new System.Drawing.Point(118, 22);
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.Size = new System.Drawing.Size(176, 23);
            this.txtNewPassword.TabIndex = 2;
            this.txtNewPassword.TextChanged += new System.EventHandler(this.txtNewPassword_TextChanged);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(22, 48);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(142, 25);
            this.lblRole.TabIndex = 42;
            this.lblRole.Text = "Current Details:";
            // 
            // cbShowPassword
            // 
            this.cbShowPassword.AutoSize = true;
            this.cbShowPassword.Location = new System.Drawing.Point(8, 273);
            this.cbShowPassword.Name = "cbShowPassword";
            this.cbShowPassword.Size = new System.Drawing.Size(15, 14);
            this.cbShowPassword.TabIndex = 12;
            this.cbShowPassword.UseVisualStyleBackColor = true;
            this.cbShowPassword.CheckedChanged += new System.EventHandler(this.cbShowPassword_CheckedChanged);
            // 
            // Edit_Profile
            // 
            this.AcceptButton = this.btnUpdateProfile;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.cbShowPassword);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblCurrentDetails);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.picProfile);
            this.Controls.Add(this.btnUpdateProfile);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.picBackground);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Edit_Profile";
            this.Text = "Edit_Profile";
            this.Load += new System.EventHandler(this.Edit_Profile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox picBackground;
        private Label lblCurrentDetails;
        private Button btnCancel;
        private PictureBox picProfile;
        private Button btnUpdateProfile;
        private GroupBox groupBox1;
        private CheckBox cbNewAddress;
        private TextBox txtNewAddress;
        private CheckBox cbNewPhone;
        private TextBox txtNewPhone;
        private CheckBox cbNewEmail;
        private TextBox txtNewEmail;
        private CheckBox cbNewDoB;
        private CheckBox cbNewPassword;
        private TextBox txtNewPassword;
        private Label lblRole;
        private CheckBox cbShowPassword;
        private DateTimePicker dtpDoB;
    }
}