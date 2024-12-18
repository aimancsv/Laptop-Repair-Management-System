namespace Repair_Heads_compiled_program
{
    partial class CRS
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CRS));
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCS = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.rbtnS1 = new System.Windows.Forms.RadioButton();
            this.rbtnS2 = new System.Windows.Forms.RadioButton();
            this.rbtnS3 = new System.Windows.Forms.RadioButton();
            this.rbtnS4 = new System.Windows.Forms.RadioButton();
            this.rbtnS5 = new System.Windows.Forms.RadioButton();
            this.rbtnS6 = new System.Windows.Forms.RadioButton();
            this.rbtnS7 = new System.Windows.Forms.RadioButton();
            this.rbtnS8 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtnNormal = new System.Windows.Forms.RadioButton();
            this.rbtnUrgent = new System.Windows.Forms.RadioButton();
            this.lblCurrentService = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(472, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Change Requested Services";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(447, 439);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Current Status: ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblStatus.Location = new System.Drawing.Point(541, 439);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(2, 17);
            this.lblStatus.TabIndex = 3;
            this.lblStatus.Click += new System.EventHandler(this.lblStatus_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(12, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(331, 15);
            this.label5.TabIndex = 4;
            this.label5.Text = "*You can change the service if the current status is \"Pending\"";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(9, 90);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(417, 294);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(83, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(245, 40);
            this.label6.TabIndex = 6;
            this.label6.Text = "Services Pricelist";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btnCS
            // 
            this.btnCS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(198)))), ((int)(((byte)(28)))));
            this.btnCS.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCS.Location = new System.Drawing.Point(506, 382);
            this.btnCS.Name = "btnCS";
            this.btnCS.Size = new System.Drawing.Size(215, 37);
            this.btnCS.TabIndex = 8;
            this.btnCS.Text = "Change Services";
            this.btnCS.UseVisualStyleBackColor = false;
            this.btnCS.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(463, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(127, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "Select New Services";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(462, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 17);
            this.label8.TabIndex = 12;
            this.label8.Text = "Currect Service";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(7, 7);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 25);
            this.button3.TabIndex = 14;
            this.button3.Text = "back";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // rbtnS1
            // 
            this.rbtnS1.AutoSize = true;
            this.rbtnS1.BackColor = System.Drawing.Color.Transparent;
            this.rbtnS1.Location = new System.Drawing.Point(4, 12);
            this.rbtnS1.Name = "rbtnS1";
            this.rbtnS1.Size = new System.Drawing.Size(207, 19);
            this.rbtnS1.TabIndex = 15;
            this.rbtnS1.TabStop = true;
            this.rbtnS1.Text = "Remove virus, malware or spyware";
            this.rbtnS1.UseVisualStyleBackColor = false;
            this.rbtnS1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // rbtnS2
            // 
            this.rbtnS2.AutoSize = true;
            this.rbtnS2.BackColor = System.Drawing.Color.Transparent;
            this.rbtnS2.Location = new System.Drawing.Point(4, 32);
            this.rbtnS2.Name = "rbtnS2";
            this.rbtnS2.Size = new System.Drawing.Size(253, 19);
            this.rbtnS2.TabIndex = 16;
            this.rbtnS2.TabStop = true;
            this.rbtnS2.Text = "Troubleshot and fix computer running slow";
            this.rbtnS2.UseVisualStyleBackColor = false;
            this.rbtnS2.CheckedChanged += new System.EventHandler(this.rbtnS2_CheckedChanged);
            // 
            // rbtnS3
            // 
            this.rbtnS3.AutoSize = true;
            this.rbtnS3.BackColor = System.Drawing.Color.Transparent;
            this.rbtnS3.Location = new System.Drawing.Point(4, 52);
            this.rbtnS3.Name = "rbtnS3";
            this.rbtnS3.Size = new System.Drawing.Size(168, 19);
            this.rbtnS3.TabIndex = 17;
            this.rbtnS3.TabStop = true;
            this.rbtnS3.Text = "Laptop screen replacement";
            this.rbtnS3.UseVisualStyleBackColor = false;
            // 
            // rbtnS4
            // 
            this.rbtnS4.AutoSize = true;
            this.rbtnS4.BackColor = System.Drawing.Color.Transparent;
            this.rbtnS4.Location = new System.Drawing.Point(4, 72);
            this.rbtnS4.Name = "rbtnS4";
            this.rbtnS4.Size = new System.Drawing.Size(183, 19);
            this.rbtnS4.TabIndex = 18;
            this.rbtnS4.TabStop = true;
            this.rbtnS4.Text = "Laptop keyboard replacement";
            this.rbtnS4.UseVisualStyleBackColor = false;
            this.rbtnS4.CheckedChanged += new System.EventHandler(this.rbtnS4_CheckedChanged);
            // 
            // rbtnS5
            // 
            this.rbtnS5.AutoSize = true;
            this.rbtnS5.BackColor = System.Drawing.Color.Transparent;
            this.rbtnS5.Location = new System.Drawing.Point(4, 92);
            this.rbtnS5.Name = "rbtnS5";
            this.rbtnS5.Size = new System.Drawing.Size(171, 19);
            this.rbtnS5.TabIndex = 19;
            this.rbtnS5.TabStop = true;
            this.rbtnS5.Text = "Laptop battery replacement";
            this.rbtnS5.UseVisualStyleBackColor = false;
            // 
            // rbtnS6
            // 
            this.rbtnS6.AutoSize = true;
            this.rbtnS6.BackColor = System.Drawing.Color.Transparent;
            this.rbtnS6.Location = new System.Drawing.Point(4, 112);
            this.rbtnS6.Name = "rbtnS6";
            this.rbtnS6.Size = new System.Drawing.Size(244, 19);
            this.rbtnS6.TabIndex = 20;
            this.rbtnS6.TabStop = true;
            this.rbtnS6.Text = "Operating System Format and Installation";
            this.rbtnS6.UseVisualStyleBackColor = false;
            // 
            // rbtnS7
            // 
            this.rbtnS7.AutoSize = true;
            this.rbtnS7.BackColor = System.Drawing.Color.Transparent;
            this.rbtnS7.Location = new System.Drawing.Point(4, 132);
            this.rbtnS7.Name = "rbtnS7";
            this.rbtnS7.Size = new System.Drawing.Size(162, 19);
            this.rbtnS7.TabIndex = 21;
            this.rbtnS7.TabStop = true;
            this.rbtnS7.Text = "Data backup and recovery";
            this.rbtnS7.UseVisualStyleBackColor = false;
            // 
            // rbtnS8
            // 
            this.rbtnS8.AutoSize = true;
            this.rbtnS8.BackColor = System.Drawing.Color.Transparent;
            this.rbtnS8.Location = new System.Drawing.Point(4, 152);
            this.rbtnS8.Name = "rbtnS8";
            this.rbtnS8.Size = new System.Drawing.Size(168, 19);
            this.rbtnS8.TabIndex = 22;
            this.rbtnS8.TabStop = true;
            this.rbtnS8.Text = "Internet connectivity issues";
            this.rbtnS8.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.rbtnS8);
            this.groupBox1.Controls.Add(this.rbtnS7);
            this.groupBox1.Controls.Add(this.rbtnS6);
            this.groupBox1.Controls.Add(this.rbtnS5);
            this.groupBox1.Controls.Add(this.rbtnS4);
            this.groupBox1.Controls.Add(this.rbtnS3);
            this.groupBox1.Controls.Add(this.rbtnS2);
            this.groupBox1.Controls.Add(this.rbtnS1);
            this.groupBox1.Location = new System.Drawing.Point(464, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 175);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rbtnNormal
            // 
            this.rbtnNormal.AutoSize = true;
            this.rbtnNormal.BackColor = System.Drawing.Color.Transparent;
            this.rbtnNormal.Location = new System.Drawing.Point(468, 345);
            this.rbtnNormal.Name = "rbtnNormal";
            this.rbtnNormal.Size = new System.Drawing.Size(63, 19);
            this.rbtnNormal.TabIndex = 24;
            this.rbtnNormal.TabStop = true;
            this.rbtnNormal.Text = "normal";
            this.rbtnNormal.UseVisualStyleBackColor = false;
            // 
            // rbtnUrgent
            // 
            this.rbtnUrgent.AutoSize = true;
            this.rbtnUrgent.BackColor = System.Drawing.Color.Transparent;
            this.rbtnUrgent.Location = new System.Drawing.Point(539, 345);
            this.rbtnUrgent.Name = "rbtnUrgent";
            this.rbtnUrgent.Size = new System.Drawing.Size(60, 19);
            this.rbtnUrgent.TabIndex = 25;
            this.rbtnUrgent.TabStop = true;
            this.rbtnUrgent.Text = "urgent";
            this.rbtnUrgent.UseVisualStyleBackColor = false;
            // 
            // lblCurrentService
            // 
            this.lblCurrentService.BackColor = System.Drawing.Color.Transparent;
            this.lblCurrentService.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCurrentService.Location = new System.Drawing.Point(463, 111);
            this.lblCurrentService.Name = "lblCurrentService";
            this.lblCurrentService.Size = new System.Drawing.Size(299, 23);
            this.lblCurrentService.TabIndex = 26;
            this.lblCurrentService.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblCurrentService.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // CRS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lblCurrentService);
            this.Controls.Add(this.rbtnUrgent);
            this.Controls.Add(this.rbtnNormal);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCS);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "CRS";
            this.Text = "Change Requested Service";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label3;
        private Label lblStatus;
        private Label label5;
        private PictureBox pictureBox1;
        private Label label6;
        private Button btnCS;
        private Label label7;
        private Label label8;
        private Button button3;
        private RadioButton rbtnS1;
        private RadioButton rbtnS2;
        private RadioButton rbtnS3;
        private RadioButton rbtnS4;
        private RadioButton rbtnS5;
        private RadioButton rbtnS6;
        private RadioButton rbtnS7;
        private RadioButton rbtnS8;
        private GroupBox groupBox1;
        private RadioButton rbtnNormal;
        private RadioButton rbtnUrgent;
        private Label lblCurrentService;
    }
}