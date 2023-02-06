namespace E_Apartments
{
    partial class Form6
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
            this.txtBuildingName = new System.Windows.Forms.TextBox();
            this.txtBuildingLocation = new System.Windows.Forms.TextBox();
            this.txtRefundableFee = new System.Windows.Forms.TextBox();
            this.txtFirstMonthFee = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbApartmentClass = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBuildingID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtApartmentDetails = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuildingName
            // 
            this.txtBuildingName.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuildingName.Location = new System.Drawing.Point(330, 103);
            this.txtBuildingName.Multiline = true;
            this.txtBuildingName.Name = "txtBuildingName";
            this.txtBuildingName.Size = new System.Drawing.Size(147, 23);
            this.txtBuildingName.TabIndex = 1;
            // 
            // txtBuildingLocation
            // 
            this.txtBuildingLocation.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuildingLocation.Location = new System.Drawing.Point(330, 215);
            this.txtBuildingLocation.Multiline = true;
            this.txtBuildingLocation.Name = "txtBuildingLocation";
            this.txtBuildingLocation.Size = new System.Drawing.Size(273, 42);
            this.txtBuildingLocation.TabIndex = 5;
            this.txtBuildingLocation.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtRefundableFee
            // 
            this.txtRefundableFee.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRefundableFee.Location = new System.Drawing.Point(614, 58);
            this.txtRefundableFee.Multiline = true;
            this.txtRefundableFee.Name = "txtRefundableFee";
            this.txtRefundableFee.Size = new System.Drawing.Size(147, 23);
            this.txtRefundableFee.TabIndex = 10;
            // 
            // txtFirstMonthFee
            // 
            this.txtFirstMonthFee.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstMonthFee.Location = new System.Drawing.Point(614, 97);
            this.txtFirstMonthFee.Multiline = true;
            this.txtFirstMonthFee.Name = "txtFirstMonthFee";
            this.txtFirstMonthFee.Size = new System.Drawing.Size(147, 23);
            this.txtFirstMonthFee.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(194, 324);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(568, 164);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Aqua;
            this.button7.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(196, 281);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(72, 25);
            this.button7.TabIndex = 13;
            this.button7.Text = "New";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Magenta;
            this.button8.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(274, 281);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(72, 25);
            this.button8.TabIndex = 14;
            this.button8.Text = "Add";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Lime;
            this.button9.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(352, 281);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(72, 25);
            this.button9.TabIndex = 15;
            this.button9.Text = "Edit";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Red;
            this.button10.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(430, 281);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(72, 25);
            this.button10.TabIndex = 16;
            this.button10.Text = "Delete";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.Silver;
            this.button11.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button11.Location = new System.Drawing.Point(690, 281);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(72, 25);
            this.button11.TabIndex = 17;
            this.button11.Text = "Search";
            this.button11.UseVisualStyleBackColor = false;
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(537, 283);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(147, 23);
            this.textBox7.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(194, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 14);
            this.label1.TabIndex = 19;
            this.label1.Text = "Building Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 14);
            this.label2.TabIndex = 20;
            this.label2.Text = "Apartment Class";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(194, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 14);
            this.label3.TabIndex = 21;
            this.label3.Text = "Building Location";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(494, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 14);
            this.label5.TabIndex = 23;
            this.label5.Text = "Refundable fee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(494, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 14);
            this.label6.TabIndex = 24;
            this.label6.Text = "First Month\'s fee";
            // 
            // cmbApartmentClass
            // 
            this.cmbApartmentClass.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbApartmentClass.FormattingEnabled = true;
            this.cmbApartmentClass.Items.AddRange(new object[] {
            "Class 1",
            "Class 2",
            "Class 3",
            "Suite"});
            this.cmbApartmentClass.Location = new System.Drawing.Point(330, 146);
            this.cmbApartmentClass.Name = "cmbApartmentClass";
            this.cmbApartmentClass.Size = new System.Drawing.Size(147, 22);
            this.cmbApartmentClass.TabIndex = 25;
            this.cmbApartmentClass.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(194, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 14);
            this.label4.TabIndex = 22;
            this.label4.Text = "Building ID";
            // 
            // txtBuildingID
            // 
            this.txtBuildingID.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuildingID.Location = new System.Drawing.Point(327, 52);
            this.txtBuildingID.Multiline = true;
            this.txtBuildingID.Name = "txtBuildingID";
            this.txtBuildingID.Size = new System.Drawing.Size(150, 28);
            this.txtBuildingID.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(196, 186);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 14);
            this.label7.TabIndex = 26;
            this.label7.Text = "Apartment Details";
            // 
            // txtApartmentDetails
            // 
            this.txtApartmentDetails.Font = new System.Drawing.Font("Georgia", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApartmentDetails.Location = new System.Drawing.Point(330, 180);
            this.txtApartmentDetails.Multiline = true;
            this.txtApartmentDetails.Name = "txtApartmentDetails";
            this.txtApartmentDetails.Size = new System.Drawing.Size(147, 23);
            this.txtApartmentDetails.TabIndex = 27;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 500);
            this.Controls.Add(this.txtApartmentDetails);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbApartmentClass);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtFirstMonthFee);
            this.Controls.Add(this.txtRefundableFee);
            this.Controls.Add(this.txtBuildingID);
            this.Controls.Add(this.txtBuildingLocation);
            this.Controls.Add(this.txtBuildingName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(774, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(774, 500);
            this.Name = "Form6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuildingName;
        private System.Windows.Forms.TextBox txtBuildingLocation;
        private System.Windows.Forms.TextBox txtRefundableFee;
        private System.Windows.Forms.TextBox txtFirstMonthFee;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbApartmentClass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBuildingID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtApartmentDetails;
    }
}