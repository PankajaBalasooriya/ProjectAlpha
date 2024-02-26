namespace ProjectAlpha
{
    partial class FindDoners
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindDoners));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblvalue = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtDID = new System.Windows.Forms.TextBox();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.txtNIC = new System.Windows.Forms.TextBox();
            this.txtGen = new System.Windows.Forms.TextBox();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.lblAccording = new System.Windows.Forms.Label();
            this.comboBoxAccording = new System.Windows.Forms.ComboBox();
            this.btncle = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.comboBoxBlood = new System.Windows.Forms.ComboBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnHeadersVisible = false;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 225);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(955, 221);
            this.dataGridView1.TabIndex = 0;
            // 
            // lblvalue
            // 
            this.lblvalue.AutoSize = true;
            this.lblvalue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblvalue.Location = new System.Drawing.Point(467, 63);
            this.lblvalue.Name = "lblvalue";
            this.lblvalue.Size = new System.Drawing.Size(49, 18);
            this.lblvalue.TabIndex = 1;
            this.lblvalue.Text = "Value";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(645, 59);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(170, 20);
            this.txtSearch.TabIndex = 2;
            // 
            // txtDID
            // 
            this.txtDID.Enabled = false;
            this.txtDID.Location = new System.Drawing.Point(5, 135);
            this.txtDID.Name = "txtDID";
            this.txtDID.Size = new System.Drawing.Size(85, 20);
            this.txtDID.TabIndex = 46;
            this.txtDID.TextChanged += new System.EventHandler(this.txtDID_TextChanged);
            this.txtDID.DoubleClick += new System.EventHandler(this.txtDID_DoubleClick);
            this.txtDID.Enter += new System.EventHandler(this.txtDID_Enter);
            // 
            // txtDName
            // 
            this.txtDName.Enabled = false;
            this.txtDName.Location = new System.Drawing.Point(87, 135);
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(144, 20);
            this.txtDName.TabIndex = 45;
            this.txtDName.DoubleClick += new System.EventHandler(this.FindDoners_DoubleClick);
            // 
            // txtNIC
            // 
            this.txtNIC.Enabled = false;
            this.txtNIC.Location = new System.Drawing.Point(227, 135);
            this.txtNIC.Name = "txtNIC";
            this.txtNIC.Size = new System.Drawing.Size(100, 20);
            this.txtNIC.TabIndex = 44;
            this.txtNIC.DoubleClick += new System.EventHandler(this.FindDoners_DoubleClick);
            // 
            // txtGen
            // 
            this.txtGen.Enabled = false;
            this.txtGen.Location = new System.Drawing.Point(326, 135);
            this.txtGen.Name = "txtGen";
            this.txtGen.Size = new System.Drawing.Size(67, 20);
            this.txtGen.TabIndex = 43;
            this.txtGen.DoubleClick += new System.EventHandler(this.FindDoners_DoubleClick);
            // 
            // txtAdd
            // 
            this.txtAdd.Enabled = false;
            this.txtAdd.Location = new System.Drawing.Point(390, 135);
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(206, 20);
            this.txtAdd.TabIndex = 42;
            this.txtAdd.DoubleClick += new System.EventHandler(this.FindDoners_DoubleClick);
            // 
            // txtTelNo
            // 
            this.txtTelNo.Enabled = false;
            this.txtTelNo.Location = new System.Drawing.Point(798, 135);
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(70, 20);
            this.txtTelNo.TabIndex = 41;
            this.txtTelNo.DoubleClick += new System.EventHandler(this.FindDoners_DoubleClick);
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.Location = new System.Drawing.Point(591, 135);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(177, 20);
            this.txtEmail.TabIndex = 40;
            this.txtEmail.DoubleClick += new System.EventHandler(this.FindDoners_DoubleClick);
            // 
            // txtAge
            // 
            this.txtAge.Enabled = false;
            this.txtAge.Location = new System.Drawing.Point(762, 135);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(42, 20);
            this.txtAge.TabIndex = 39;
            this.txtAge.DoubleClick += new System.EventHandler(this.FindDoners_DoubleClick);
            // 
            // textBox9
            // 
            this.textBox9.Enabled = false;
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(866, 119);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(89, 22);
            this.textBox9.TabIndex = 38;
            this.textBox9.Text = "BloodGroup";
            // 
            // textBox8
            // 
            this.textBox8.Enabled = false;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(5, 119);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(85, 22);
            this.textBox8.TabIndex = 37;
            this.textBox8.Text = "DonerID";
            // 
            // textBox7
            // 
            this.textBox7.Enabled = false;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(87, 119);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(144, 22);
            this.textBox7.TabIndex = 36;
            this.textBox7.Text = "DonerName";
            // 
            // textBox6
            // 
            this.textBox6.Enabled = false;
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(227, 119);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 35;
            this.textBox6.Text = "NIC";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(326, 119);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(67, 22);
            this.textBox5.TabIndex = 34;
            this.textBox5.Text = "Gender";
            // 
            // textBox4
            // 
            this.textBox4.Enabled = false;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(390, 119);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(206, 22);
            this.textBox4.TabIndex = 33;
            this.textBox4.Text = "Address";
            // 
            // textBox3
            // 
            this.textBox3.Enabled = false;
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(798, 119);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(70, 22);
            this.textBox3.TabIndex = 32;
            this.textBox3.Text = " TelNo";
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(591, 119);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 22);
            this.textBox2.TabIndex = 31;
            this.textBox2.Text = "Email";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(762, 119);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(42, 22);
            this.textBox1.TabIndex = 30;
            this.textBox1.Text = "Age";
            // 
            // btnFind
            // 
            this.btnFind.Location = new System.Drawing.Point(860, 60);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(75, 23);
            this.btnFind.TabIndex = 48;
            this.btnFind.Text = "Search";
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // lblAccording
            // 
            this.lblAccording.AutoSize = true;
            this.lblAccording.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAccording.Location = new System.Drawing.Point(467, 27);
            this.lblAccording.Name = "lblAccording";
            this.lblAccording.Size = new System.Drawing.Size(161, 18);
            this.lblAccording.TabIndex = 49;
            this.lblAccording.Text = "Search According to";
            // 
            // comboBoxAccording
            // 
            this.comboBoxAccording.FormattingEnabled = true;
            this.comboBoxAccording.Items.AddRange(new object[] {
            "DonerID",
            "NIC",
            "TelNo"});
            this.comboBoxAccording.Location = new System.Drawing.Point(645, 27);
            this.comboBoxAccording.Name = "comboBoxAccording";
            this.comboBoxAccording.Size = new System.Drawing.Size(171, 21);
            this.comboBoxAccording.TabIndex = 50;
            // 
            // btncle
            // 
            this.btncle.Location = new System.Drawing.Point(860, 25);
            this.btncle.Name = "btncle";
            this.btncle.Size = new System.Drawing.Size(75, 23);
            this.btncle.TabIndex = 51;
            this.btncle.Text = "Clear";
            this.btncle.UseVisualStyleBackColor = true;
            this.btncle.Click += new System.EventHandler(this.btncle_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(15, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 52;
            this.btnBack.Text = "<---- Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Location = new System.Drawing.Point(697, 175);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(107, 30);
            this.btnUpdate.TabIndex = 53;
            this.btnUpdate.Text = "Update Record";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // comboBoxBlood
            // 
            this.comboBoxBlood.Enabled = false;
            this.comboBoxBlood.FormattingEnabled = true;
            this.comboBoxBlood.Items.AddRange(new object[] {
            "A RhD positive (A+)",
            "A RhD negative (A-)",
            "B RhD positive (B+)",
            "B RhD negative (B-)",
            "O RhD positive (O+)",
            "O RhD negative (O-)",
            "AB RhD positive (AB+)",
            "AB RhD negative (AB-)"});
            this.comboBoxBlood.Location = new System.Drawing.Point(866, 135);
            this.comboBoxBlood.Name = "comboBoxBlood";
            this.comboBoxBlood.Size = new System.Drawing.Size(89, 21);
            this.comboBoxBlood.TabIndex = 54;
            // 
            // btnDel
            // 
            this.btnDel.Enabled = false;
            this.btnDel.Location = new System.Drawing.Point(828, 175);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(107, 30);
            this.btnDel.TabIndex = 55;
            this.btnDel.Text = "Delete Record";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(15, 41);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 38);
            this.btnNew.TabIndex = 56;
            this.btnNew.Text = "Add a New Donor";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FindDoners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(955, 446);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.comboBoxBlood);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btncle);
            this.Controls.Add(this.comboBoxAccording);
            this.Controls.Add(this.lblAccording);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtDID);
            this.Controls.Add(this.txtDName);
            this.Controls.Add(this.txtNIC);
            this.Controls.Add(this.txtGen);
            this.Controls.Add(this.txtAdd);
            this.Controls.Add(this.txtTelNo);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblvalue);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FindDoners";
            this.Text = "Doner Details";
            this.Load += new System.EventHandler(this.FindDoners_Load);
            this.DoubleClick += new System.EventHandler(this.FindDoners_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblvalue;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtDID;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.TextBox txtNIC;
        private System.Windows.Forms.TextBox txtGen;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label lblAccording;
        private System.Windows.Forms.ComboBox comboBoxAccording;
        private System.Windows.Forms.Button btncle;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBoxBlood;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnNew;
    }
}