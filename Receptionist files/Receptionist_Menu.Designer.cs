namespace Repair_Heads_compiled_program
{
    partial class Receptionist_Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Receptionist_Menu));
            this.btnRequestService = new System.Windows.Forms.Button();
            this.picBackground = new System.Windows.Forms.PictureBox();
            this.picProfile = new System.Windows.Forms.PictureBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.lblEditProfile = new System.Windows.Forms.LinkLabel();
            this.btnRegisterNewCustomer = new System.Windows.Forms.Button();
            this.btnReceivePayment = new System.Windows.Forms.Button();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRequestService
            // 
            this.btnRequestService.BackColor = System.Drawing.Color.White;
            this.btnRequestService.Location = new System.Drawing.Point(418, 204);
            this.btnRequestService.Name = "btnRequestService";
            this.btnRequestService.Size = new System.Drawing.Size(300, 50);
            this.btnRequestService.TabIndex = 2;
            this.btnRequestService.Text = "request a new service for registered customer";
            this.btnRequestService.UseVisualStyleBackColor = false;
            this.btnRequestService.Click += new System.EventHandler(this.btnRequestService_Click);
            // 
            // picBackground
            // 
            this.picBackground.Image = ((System.Drawing.Image)(resources.GetObject("picBackground.Image")));
            this.picBackground.Location = new System.Drawing.Point(0, 0);
            this.picBackground.Margin = new System.Windows.Forms.Padding(0);
            this.picBackground.Name = "picBackground";
            this.picBackground.Size = new System.Drawing.Size(800, 500);
            this.picBackground.TabIndex = 7;
            this.picBackground.TabStop = false;
            // 
            // picProfile
            // 
            this.picProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.picProfile.Image = ((System.Drawing.Image)(resources.GetObject("picProfile.Image")));
            this.picProfile.Location = new System.Drawing.Point(67, 83);
            this.picProfile.Name = "picProfile";
            this.picProfile.Size = new System.Drawing.Size(200, 200);
            this.picProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picProfile.TabIndex = 8;
            this.picProfile.TabStop = false;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.lblUserID.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUserID.ForeColor = System.Drawing.Color.White;
            this.lblUserID.Location = new System.Drawing.Point(129, 270);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(68, 25);
            this.lblUserID.TabIndex = 11;
            this.lblUserID.Text = "rec000";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.lblRole.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRole.ForeColor = System.Drawing.Color.White;
            this.lblRole.Location = new System.Drawing.Point(108, 69);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(114, 25);
            this.lblRole.TabIndex = 12;
            this.lblRole.Text = "Receptionist";
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.White;
            this.btnSignOut.Location = new System.Drawing.Point(12, 12);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(116, 30);
            this.btnSignOut.TabIndex = 5;
            this.btnSignOut.Text = "Sign Out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // lblEditProfile
            // 
            this.lblEditProfile.AutoSize = true;
            this.lblEditProfile.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(29)))));
            this.lblEditProfile.Location = new System.Drawing.Point(129, 385);
            this.lblEditProfile.Name = "lblEditProfile";
            this.lblEditProfile.Padding = new System.Windows.Forms.Padding(2);
            this.lblEditProfile.Size = new System.Drawing.Size(68, 19);
            this.lblEditProfile.TabIndex = 4;
            this.lblEditProfile.TabStop = true;
            this.lblEditProfile.Text = "Edit profile";
            this.lblEditProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblEditProfile_LinkClicked);
            // 
            // btnRegisterNewCustomer
            // 
            this.btnRegisterNewCustomer.BackColor = System.Drawing.Color.White;
            this.btnRegisterNewCustomer.Location = new System.Drawing.Point(418, 148);
            this.btnRegisterNewCustomer.Name = "btnRegisterNewCustomer";
            this.btnRegisterNewCustomer.Size = new System.Drawing.Size(300, 50);
            this.btnRegisterNewCustomer.TabIndex = 1;
            this.btnRegisterNewCustomer.Text = "register a new customer";
            this.btnRegisterNewCustomer.UseVisualStyleBackColor = false;
            this.btnRegisterNewCustomer.Click += new System.EventHandler(this.btnRegisterNewCustomer_Click);
            // 
            // btnReceivePayment
            // 
            this.btnReceivePayment.BackColor = System.Drawing.Color.White;
            this.btnReceivePayment.Location = new System.Drawing.Point(418, 260);
            this.btnReceivePayment.Name = "btnReceivePayment";
            this.btnReceivePayment.Size = new System.Drawing.Size(300, 50);
            this.btnReceivePayment.TabIndex = 3;
            this.btnReceivePayment.Text = "Receive payment";
            this.btnReceivePayment.UseVisualStyleBackColor = false;
            this.btnReceivePayment.Click += new System.EventHandler(this.btnReceivePayment_Click);
            // 
            // lblFullName
            // 
            this.lblFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(25)))));
            this.lblFullName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFullName.ForeColor = System.Drawing.Color.White;
            this.lblFullName.Location = new System.Drawing.Point(38, 295);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(267, 44);
            this.lblFullName.TabIndex = 29;
            this.lblFullName.Text = "Full Name";
            this.lblFullName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(25)))));
            this.lblEmail.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(38, 332);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(267, 44);
            this.lblEmail.TabIndex = 30;
            this.lblEmail.Text = "Email";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Receptionist_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.btnReceivePayment);
            this.Controls.Add(this.btnRegisterNewCustomer);
            this.Controls.Add(this.lblEditProfile);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblUserID);
            this.Controls.Add(this.picProfile);
            this.Controls.Add(this.btnRequestService);
            this.Controls.Add(this.picBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 500);
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "Receptionist_Menu";
            this.Text = "Receptionist Menu";
            this.Load += new System.EventHandler(this.Receptionist_Menu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBackground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picProfile)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button btnRequestService;
        private PictureBox picBackground;
        private PictureBox picProfile;
        private Label lblUserID;
        private Label lblRole;
        private Button btnSignOut;
        private LinkLabel lblEditProfile;
        private Button btnRegisterNewCustomer;
        private Button btnReceivePayment;
        private Label lblFullName;
        private Label lblEmail;
    }
}