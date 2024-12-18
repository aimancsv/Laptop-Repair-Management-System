namespace Repair_Heads_compiled_program
{
    partial class frmRequestedServices
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRequestedServices));
            this.btnBackToMenu = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clServiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSubmittedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clRequestedService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUrgency = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clServiceStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clCompletionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.cmbServiceStatus = new System.Windows.Forms.ComboBox();
            this.txtAddDescription = new System.Windows.Forms.TextBox();
            this.txtServiceID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBackToMenu
            // 
            this.btnBackToMenu.BackColor = System.Drawing.Color.White;
            this.btnBackToMenu.Location = new System.Drawing.Point(25, 12);
            this.btnBackToMenu.Name = "btnBackToMenu";
            this.btnBackToMenu.Size = new System.Drawing.Size(116, 30);
            this.btnBackToMenu.TabIndex = 6;
            this.btnBackToMenu.Text = "Back to Menu";
            this.btnBackToMenu.UseVisualStyleBackColor = false;
            this.btnBackToMenu.Click += new System.EventHandler(this.btnBackToMenu_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(344, 1);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(340, 44);
            this.label3.TabIndex = 30;
            this.label3.Text = "Requested Services";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clServiceID,
            this.clUserID,
            this.clSubmittedDate,
            this.clRequestedService,
            this.clUrgency,
            this.clServiceStatus,
            this.clDescription,
            this.clCompletionDate});
            this.dataGridView1.Location = new System.Drawing.Point(25, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 47;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(948, 308);
            this.dataGridView1.TabIndex = 35;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clServiceID
            // 
            this.clServiceID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.clServiceID.DefaultCellStyle = dataGridViewCellStyle1;
            this.clServiceID.HeaderText = "Service ID";
            this.clServiceID.MinimumWidth = 6;
            this.clServiceID.Name = "clServiceID";
            this.clServiceID.ReadOnly = true;
            this.clServiceID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clServiceID.Width = 80;
            // 
            // clUserID
            // 
            this.clUserID.HeaderText = "User ID";
            this.clUserID.MinimumWidth = 6;
            this.clUserID.Name = "clUserID";
            this.clUserID.ReadOnly = true;
            this.clUserID.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clUserID.Width = 80;
            // 
            // clSubmittedDate
            // 
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clSubmittedDate.DefaultCellStyle = dataGridViewCellStyle2;
            this.clSubmittedDate.HeaderText = "Submitted Date";
            this.clSubmittedDate.MinimumWidth = 6;
            this.clSubmittedDate.Name = "clSubmittedDate";
            this.clSubmittedDate.ReadOnly = true;
            this.clSubmittedDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clSubmittedDate.Width = 115;
            // 
            // clRequestedService
            // 
            this.clRequestedService.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clRequestedService.HeaderText = "Requested Service";
            this.clRequestedService.MinimumWidth = 100;
            this.clRequestedService.Name = "clRequestedService";
            this.clRequestedService.ReadOnly = true;
            this.clRequestedService.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // clUrgency
            // 
            this.clUrgency.HeaderText = "Urgency";
            this.clUrgency.MinimumWidth = 6;
            this.clUrgency.Name = "clUrgency";
            this.clUrgency.ReadOnly = true;
            this.clUrgency.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clUrgency.Width = 80;
            // 
            // clServiceStatus
            // 
            this.clServiceStatus.HeaderText = "Service Status";
            this.clServiceStatus.MinimumWidth = 6;
            this.clServiceStatus.Name = "clServiceStatus";
            this.clServiceStatus.ReadOnly = true;
            this.clServiceStatus.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clServiceStatus.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.clServiceStatus.Width = 90;
            // 
            // clDescription
            // 
            this.clDescription.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.clDescription.HeaderText = "Description";
            this.clDescription.MinimumWidth = 6;
            this.clDescription.Name = "clDescription";
            this.clDescription.ReadOnly = true;
            this.clDescription.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.clDescription.Width = 200;
            // 
            // clCompletionDate
            // 
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.clCompletionDate.DefaultCellStyle = dataGridViewCellStyle3;
            this.clCompletionDate.HeaderText = "Collection Date";
            this.clCompletionDate.MinimumWidth = 6;
            this.clCompletionDate.Name = "clCompletionDate";
            this.clCompletionDate.ReadOnly = true;
            this.clCompletionDate.Width = 115;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(389, 436);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(237, 30);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(845, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(128, 30);
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.dtPicker);
            this.groupBox1.Controls.Add(this.cmbServiceStatus);
            this.groupBox1.Controls.Add(this.txtAddDescription);
            this.groupBox1.Controls.Add(this.txtServiceID);
            this.groupBox1.Location = new System.Drawing.Point(25, 377);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(948, 54);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            // 
            // dtPicker
            // 
            this.dtPicker.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtPicker.Location = new System.Drawing.Point(793, 18);
            this.dtPicker.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(145, 23);
            this.dtPicker.TabIndex = 3;
            // 
            // cmbServiceStatus
            // 
            this.cmbServiceStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.cmbServiceStatus.FormattingEnabled = true;
            this.cmbServiceStatus.Items.AddRange(new object[] {
            "pending",
            "in service",
            "completed"});
            this.cmbServiceStatus.Location = new System.Drawing.Point(644, 18);
            this.cmbServiceStatus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbServiceStatus.Name = "cmbServiceStatus";
            this.cmbServiceStatus.Size = new System.Drawing.Size(149, 23);
            this.cmbServiceStatus.TabIndex = 2;
            // 
            // txtAddDescription
            // 
            this.txtAddDescription.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtAddDescription.Location = new System.Drawing.Point(117, 18);
            this.txtAddDescription.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAddDescription.Name = "txtAddDescription";
            this.txtAddDescription.PlaceholderText = "Add Description";
            this.txtAddDescription.Size = new System.Drawing.Size(527, 23);
            this.txtAddDescription.TabIndex = 1;
            // 
            // txtServiceID
            // 
            this.txtServiceID.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtServiceID.Location = new System.Drawing.Point(3, 18);
            this.txtServiceID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtServiceID.Name = "txtServiceID";
            this.txtServiceID.PlaceholderText = "ServiceID";
            this.txtServiceID.ReadOnly = true;
            this.txtServiceID.Size = new System.Drawing.Size(114, 23);
            this.txtServiceID.TabIndex = 0;
            // 
            // frmRequestedServices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(993, 477);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBackToMenu);
            this.MaximumSize = new System.Drawing.Size(1009, 516);
            this.MinimumSize = new System.Drawing.Size(1009, 516);
            this.Name = "frmRequestedServices";
            this.Text = "Requested Services";
            this.Load += new System.EventHandler(this.frmRequestedServices_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnBackToMenu;
        private Label label3;
        private DataGridView dataGridView1;
        private Button btnUpdate;
        private Button btnSave;
        private GroupBox groupBox1;
        private DateTimePicker dtPicker;
        private ComboBox cmbServiceStatus;
        private TextBox txtAddDescription;
        private TextBox txtServiceID;
        private DataGridViewTextBoxColumn clServiceID;
        private DataGridViewTextBoxColumn clUserID;
        private DataGridViewTextBoxColumn clSubmittedDate;
        private DataGridViewTextBoxColumn clRequestedService;
        private DataGridViewTextBoxColumn clUrgency;
        private DataGridViewTextBoxColumn clServiceStatus;
        private DataGridViewTextBoxColumn clDescription;
        private DataGridViewTextBoxColumn clCompletionDate;
    }
}