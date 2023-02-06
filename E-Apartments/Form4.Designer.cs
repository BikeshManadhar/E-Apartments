namespace E_Apartments
{
    partial class Form4
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtNICPassport = new System.Windows.Forms.TextBox();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblContactNo = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblNICPassport = new System.Windows.Forms.Label();
            this.lblLeaseEndDate = new System.Windows.Forms.Label();
            this.lblDependentDetails = new System.Windows.Forms.Label();
            this.lblEmergencyContactNo = new System.Windows.Forms.Label();
            this.txtDependentDetails = new System.Windows.Forms.TextBox();
            this.dateLeaseEndDate = new System.Windows.Forms.DateTimePicker();
            this.txtEmergencyContactNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateLeaseStartdate = new System.Windows.Forms.DateTimePicker();
            this.cmbApartmentClass = new System.Windows.Forms.ComboBox();
            this.lblApartmentDetails = new System.Windows.Forms.Label();
            this.txtApartmentDetails = new System.Windows.Forms.TextBox();
            this.cmbApartmentNo = new System.Windows.Forms.ComboBox();
            this.lblApartmentNo = new System.Windows.Forms.Label();
            this.lblApartmentClass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(333, 81);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(129, 23);
            this.txtName.TabIndex = 5;
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(199, 310);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(563, 186);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnNew.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNew.Location = new System.Drawing.Point(186, 276);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(74, 28);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Magenta;
            this.btnAdd.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(267, 276);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(74, 28);
            this.btnAdd.TabIndex = 15;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.Lime;
            this.btnEdit.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(347, 276);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(74, 28);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(428, 276);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(74, 28);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.BackColor = System.Drawing.Color.Gray;
            this.btnsearch.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsearch.Location = new System.Drawing.Point(640, 273);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(119, 28);
            this.btnsearch.TabIndex = 18;
            this.btnsearch.Text = "Search";
            this.btnsearch.UseVisualStyleBackColor = false;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(514, 276);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(118, 23);
            this.txtSearch.TabIndex = 19;
            // 
            // txtNICPassport
            // 
            this.txtNICPassport.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNICPassport.Location = new System.Drawing.Point(335, 198);
            this.txtNICPassport.Multiline = true;
            this.txtNICPassport.Name = "txtNICPassport";
            this.txtNICPassport.Size = new System.Drawing.Size(131, 23);
            this.txtNICPassport.TabIndex = 26;
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(335, 168);
            this.txtContactNo.Multiline = true;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(129, 23);
            this.txtContactNo.TabIndex = 27;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(335, 139);
            this.txtEmail.Multiline = true;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(129, 23);
            this.txtEmail.TabIndex = 28;
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(334, 109);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(129, 23);
            this.txtAddress.TabIndex = 29;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(203, 88);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(45, 14);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "Name";
            // 
            // lblContactNo
            // 
            this.lblContactNo.AutoSize = true;
            this.lblContactNo.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContactNo.Location = new System.Drawing.Point(203, 172);
            this.lblContactNo.Name = "lblContactNo";
            this.lblContactNo.Size = new System.Drawing.Size(77, 14);
            this.lblContactNo.TabIndex = 44;
            this.lblContactNo.Text = "Contact No";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(203, 117);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(59, 14);
            this.lblAddress.TabIndex = 45;
            this.lblAddress.Text = "Address";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(204, 147);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 14);
            this.lblEmail.TabIndex = 46;
            this.lblEmail.Text = "Email";
            // 
            // lblNICPassport
            // 
            this.lblNICPassport.AutoSize = true;
            this.lblNICPassport.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNICPassport.Location = new System.Drawing.Point(203, 199);
            this.lblNICPassport.Name = "lblNICPassport";
            this.lblNICPassport.Size = new System.Drawing.Size(91, 14);
            this.lblNICPassport.TabIndex = 47;
            this.lblNICPassport.Text = "NIC/Passport";
            // 
            // lblLeaseEndDate
            // 
            this.lblLeaseEndDate.AutoSize = true;
            this.lblLeaseEndDate.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLeaseEndDate.Location = new System.Drawing.Point(204, 250);
            this.lblLeaseEndDate.Name = "lblLeaseEndDate";
            this.lblLeaseEndDate.Size = new System.Drawing.Size(104, 14);
            this.lblLeaseEndDate.TabIndex = 50;
            this.lblLeaseEndDate.Text = "Lease End Date";
            // 
            // lblDependentDetails
            // 
            this.lblDependentDetails.AutoSize = true;
            this.lblDependentDetails.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDependentDetails.Location = new System.Drawing.Point(484, 56);
            this.lblDependentDetails.Name = "lblDependentDetails";
            this.lblDependentDetails.Size = new System.Drawing.Size(126, 14);
            this.lblDependentDetails.TabIndex = 58;
            this.lblDependentDetails.Text = "Dependent Details";
            // 
            // lblEmergencyContactNo
            // 
            this.lblEmergencyContactNo.AutoSize = true;
            this.lblEmergencyContactNo.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmergencyContactNo.Location = new System.Drawing.Point(483, 86);
            this.lblEmergencyContactNo.Name = "lblEmergencyContactNo";
            this.lblEmergencyContactNo.Size = new System.Drawing.Size(152, 14);
            this.lblEmergencyContactNo.TabIndex = 59;
            this.lblEmergencyContactNo.Text = "Emergency Contact No";
            // 
            // txtDependentDetails
            // 
            this.txtDependentDetails.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDependentDetails.Location = new System.Drawing.Point(637, 52);
            this.txtDependentDetails.Multiline = true;
            this.txtDependentDetails.Name = "txtDependentDetails";
            this.txtDependentDetails.Size = new System.Drawing.Size(132, 23);
            this.txtDependentDetails.TabIndex = 61;
            // 
            // dateLeaseEndDate
            // 
            this.dateLeaseEndDate.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLeaseEndDate.Location = new System.Drawing.Point(333, 250);
            this.dateLeaseEndDate.Name = "dateLeaseEndDate";
            this.dateLeaseEndDate.Size = new System.Drawing.Size(211, 20);
            this.dateLeaseEndDate.TabIndex = 62;
            // 
            // txtEmergencyContactNo
            // 
            this.txtEmergencyContactNo.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmergencyContactNo.Location = new System.Drawing.Point(638, 80);
            this.txtEmergencyContactNo.Multiline = true;
            this.txtEmergencyContactNo.Name = "txtEmergencyContactNo";
            this.txtEmergencyContactNo.Size = new System.Drawing.Size(133, 23);
            this.txtEmergencyContactNo.TabIndex = 63;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(204, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 14);
            this.label1.TabIndex = 70;
            this.label1.Text = "Lease Start Date";
            // 
            // dateLeaseStartdate
            // 
            this.dateLeaseStartdate.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLeaseStartdate.Location = new System.Drawing.Point(333, 224);
            this.dateLeaseStartdate.Name = "dateLeaseStartdate";
            this.dateLeaseStartdate.Size = new System.Drawing.Size(211, 20);
            this.dateLeaseStartdate.TabIndex = 71;
            // 
            // cmbApartmentClass
            // 
            this.cmbApartmentClass.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbApartmentClass.FormattingEnabled = true;
            this.cmbApartmentClass.Items.AddRange(new object[] {
            "class one",
            "class two",
            "class  three",
            "Suite"});
            this.cmbApartmentClass.Location = new System.Drawing.Point(639, 141);
            this.cmbApartmentClass.Name = "cmbApartmentClass";
            this.cmbApartmentClass.Size = new System.Drawing.Size(133, 21);
            this.cmbApartmentClass.TabIndex = 41;
            this.cmbApartmentClass.SelectedIndexChanged += new System.EventHandler(this.cmbApartmentClass_SelectedIndexChanged);
            // 
            // lblApartmentDetails
            // 
            this.lblApartmentDetails.AutoSize = true;
            this.lblApartmentDetails.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApartmentDetails.Location = new System.Drawing.Point(483, 176);
            this.lblApartmentDetails.Name = "lblApartmentDetails";
            this.lblApartmentDetails.Size = new System.Drawing.Size(130, 14);
            this.lblApartmentDetails.TabIndex = 57;
            this.lblApartmentDetails.Text = "Apartment Details";
            // 
            // txtApartmentDetails
            // 
            this.txtApartmentDetails.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApartmentDetails.Location = new System.Drawing.Point(638, 172);
            this.txtApartmentDetails.Multiline = true;
            this.txtApartmentDetails.Name = "txtApartmentDetails";
            this.txtApartmentDetails.Size = new System.Drawing.Size(134, 23);
            this.txtApartmentDetails.TabIndex = 64;
            // 
            // cmbApartmentNo
            // 
            this.cmbApartmentNo.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbApartmentNo.FormattingEnabled = true;
            this.cmbApartmentNo.Location = new System.Drawing.Point(638, 109);
            this.cmbApartmentNo.Name = "cmbApartmentNo";
            this.cmbApartmentNo.Size = new System.Drawing.Size(131, 21);
            this.cmbApartmentNo.TabIndex = 65;
            // 
            // lblApartmentNo
            // 
            this.lblApartmentNo.AutoSize = true;
            this.lblApartmentNo.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApartmentNo.Location = new System.Drawing.Point(483, 110);
            this.lblApartmentNo.Name = "lblApartmentNo";
            this.lblApartmentNo.Size = new System.Drawing.Size(101, 14);
            this.lblApartmentNo.TabIndex = 54;
            this.lblApartmentNo.Text = "Apartment No";
            // 
            // lblApartmentClass
            // 
            this.lblApartmentClass.AutoSize = true;
            this.lblApartmentClass.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApartmentClass.Location = new System.Drawing.Point(484, 143);
            this.lblApartmentClass.Name = "lblApartmentClass";
            this.lblApartmentClass.Size = new System.Drawing.Size(117, 14);
            this.lblApartmentClass.TabIndex = 55;
            this.lblApartmentClass.Text = "Apartment Class";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(204, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 14);
            this.label2.TabIndex = 72;
            this.label2.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Location = new System.Drawing.Point(333, 54);
            this.txtID.Multiline = true;
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(129, 23);
            this.txtID.TabIndex = 73;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 500);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateLeaseStartdate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbApartmentNo);
            this.Controls.Add(this.txtApartmentDetails);
            this.Controls.Add(this.txtEmergencyContactNo);
            this.Controls.Add(this.dateLeaseEndDate);
            this.Controls.Add(this.txtDependentDetails);
            this.Controls.Add(this.lblEmergencyContactNo);
            this.Controls.Add(this.lblDependentDetails);
            this.Controls.Add(this.lblApartmentDetails);
            this.Controls.Add(this.lblApartmentClass);
            this.Controls.Add(this.lblApartmentNo);
            this.Controls.Add(this.lblLeaseEndDate);
            this.Controls.Add(this.lblNICPassport);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblContactNo);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.cmbApartmentClass);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtContactNo);
            this.Controls.Add(this.txtNICPassport);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(774, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(774, 500);
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtNICPassport;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblContactNo;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblNICPassport;
        private System.Windows.Forms.Label lblLeaseEndDate;
        private System.Windows.Forms.Label lblDependentDetails;
        private System.Windows.Forms.Label lblEmergencyContactNo;
        private System.Windows.Forms.TextBox txtDependentDetails;
        private System.Windows.Forms.DateTimePicker dateLeaseEndDate;
        private System.Windows.Forms.TextBox txtEmergencyContactNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateLeaseStartdate;
        private System.Windows.Forms.ComboBox cmbApartmentClass;
        private System.Windows.Forms.Label lblApartmentDetails;
        private System.Windows.Forms.TextBox txtApartmentDetails;
        private System.Windows.Forms.ComboBox cmbApartmentNo;
        private System.Windows.Forms.Label lblApartmentNo;
        private System.Windows.Forms.Label lblApartmentClass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtID;
    }
}