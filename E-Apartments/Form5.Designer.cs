namespace E_Apartments
{
    partial class Form5
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
            this.cmbBuildingID = new System.Windows.Forms.ComboBox();
            this.cmbBuildingName = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.txtApartmentDetails = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtFirstMonthFee = new System.Windows.Forms.TextBox();
            this.lblFirstMonthFee = new System.Windows.Forms.Label();
            this.txtRefundableFee = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbApartmentClass = new System.Windows.Forms.ComboBox();
            this.txtApartmentNo = new System.Windows.Forms.TextBox();
            this.txtApartmentName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbBuildingID
            // 
            this.cmbBuildingID.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuildingID.FormattingEnabled = true;
            this.cmbBuildingID.Location = new System.Drawing.Point(340, 122);
            this.cmbBuildingID.Name = "cmbBuildingID";
            this.cmbBuildingID.Size = new System.Drawing.Size(133, 21);
            this.cmbBuildingID.TabIndex = 12;
            // 
            // cmbBuildingName
            // 
            this.cmbBuildingName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBuildingName.FormattingEnabled = true;
            this.cmbBuildingName.Location = new System.Drawing.Point(614, 60);
            this.cmbBuildingName.Name = "cmbBuildingName";
            this.cmbBuildingName.Size = new System.Drawing.Size(148, 21);
            this.cmbBuildingName.TabIndex = 14;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(200, 291);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(562, 197);
            this.dataGridView1.TabIndex = 17;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(200, 249);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 36);
            this.button1.TabIndex = 18;
            this.button1.Text = "New";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Magenta;
            this.btnAdd.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(281, 249);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Lime;
            this.button11.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(362, 249);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 36);
            this.button11.TabIndex = 20;
            this.button11.Text = "Edit";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.Red;
            this.button12.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button12.Location = new System.Drawing.Point(443, 249);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(75, 36);
            this.button12.TabIndex = 21;
            this.button12.Text = "Delete";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.Silver;
            this.button13.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button13.Location = new System.Drawing.Point(668, 253);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(94, 25);
            this.button13.TabIndex = 23;
            this.button13.Text = "Search";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // txtApartmentDetails
            // 
            this.txtApartmentDetails.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApartmentDetails.Location = new System.Drawing.Point(615, 126);
            this.txtApartmentDetails.Multiline = true;
            this.txtApartmentDetails.Name = "txtApartmentDetails";
            this.txtApartmentDetails.Size = new System.Drawing.Size(147, 51);
            this.txtApartmentDetails.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(207, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 14);
            this.label1.TabIndex = 26;
            this.label1.Text = "Apartment No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(205, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 14);
            this.label2.TabIndex = 27;
            this.label2.Text = "Apartment Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(484, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 14);
            this.label3.TabIndex = 28;
            this.label3.Text = "Apartment Details";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 14);
            this.label4.TabIndex = 28;
            this.label4.Text = "Building ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(208, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 14);
            this.label6.TabIndex = 30;
            this.label6.Text = "Refundable fee";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(485, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 14);
            this.label8.TabIndex = 32;
            this.label8.Text = "Bulding Name";
            // 
            // txtFirstMonthFee
            // 
            this.txtFirstMonthFee.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstMonthFee.Location = new System.Drawing.Point(341, 181);
            this.txtFirstMonthFee.Multiline = true;
            this.txtFirstMonthFee.Name = "txtFirstMonthFee";
            this.txtFirstMonthFee.Size = new System.Drawing.Size(132, 23);
            this.txtFirstMonthFee.TabIndex = 34;
            // 
            // lblFirstMonthFee
            // 
            this.lblFirstMonthFee.AutoSize = true;
            this.lblFirstMonthFee.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstMonthFee.Location = new System.Drawing.Point(208, 186);
            this.lblFirstMonthFee.Name = "lblFirstMonthFee";
            this.lblFirstMonthFee.Size = new System.Drawing.Size(116, 14);
            this.lblFirstMonthFee.TabIndex = 35;
            this.lblFirstMonthFee.Text = "First Month\'s fee";
            // 
            // txtRefundableFee
            // 
            this.txtRefundableFee.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefundableFee.Location = new System.Drawing.Point(341, 152);
            this.txtRefundableFee.Multiline = true;
            this.txtRefundableFee.Name = "txtRefundableFee";
            this.txtRefundableFee.Size = new System.Drawing.Size(133, 23);
            this.txtRefundableFee.TabIndex = 36;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(485, 99);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 14);
            this.label11.TabIndex = 37;
            this.label11.Text = "Aparment Class";
            // 
            // cmbApartmentClass
            // 
            this.cmbApartmentClass.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbApartmentClass.FormattingEnabled = true;
            this.cmbApartmentClass.Items.AddRange(new object[] {
            "Class1",
            "Class2",
            "Class3",
            "Suite"});
            this.cmbApartmentClass.Location = new System.Drawing.Point(617, 94);
            this.cmbApartmentClass.Name = "cmbApartmentClass";
            this.cmbApartmentClass.Size = new System.Drawing.Size(145, 21);
            this.cmbApartmentClass.TabIndex = 38;
            this.cmbApartmentClass.SelectedIndexChanged += new System.EventHandler(this.cmbApartmentClass_SelectedIndexChanged_1);
            // 
            // txtApartmentNo
            // 
            this.txtApartmentNo.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApartmentNo.Location = new System.Drawing.Point(340, 60);
            this.txtApartmentNo.Multiline = true;
            this.txtApartmentNo.Name = "txtApartmentNo";
            this.txtApartmentNo.Size = new System.Drawing.Size(133, 23);
            this.txtApartmentNo.TabIndex = 5;
            this.txtApartmentNo.TextChanged += new System.EventHandler(this.txtApartmentNo_TextChanged);
            // 
            // txtApartmentName
            // 
            this.txtApartmentName.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApartmentName.Location = new System.Drawing.Point(340, 92);
            this.txtApartmentName.Multiline = true;
            this.txtApartmentName.Name = "txtApartmentName";
            this.txtApartmentName.Size = new System.Drawing.Size(133, 23);
            this.txtApartmentName.TabIndex = 45;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 500);
            this.Controls.Add(this.txtApartmentName);
            this.Controls.Add(this.cmbApartmentClass);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtRefundableFee);
            this.Controls.Add(this.lblFirstMonthFee);
            this.Controls.Add(this.txtFirstMonthFee);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtApartmentDetails);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbBuildingName);
            this.Controls.Add(this.cmbBuildingID);
            this.Controls.Add(this.txtApartmentNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(774, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(774, 500);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbBuildingID;
        private System.Windows.Forms.ComboBox cmbBuildingName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.TextBox txtApartmentDetails;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtFirstMonthFee;
        private System.Windows.Forms.Label lblFirstMonthFee;
        private System.Windows.Forms.TextBox txtRefundableFee;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbApartmentClass;
        private System.Windows.Forms.TextBox txtApartmentNo;
        private System.Windows.Forms.TextBox txtApartmentName;
    }
}