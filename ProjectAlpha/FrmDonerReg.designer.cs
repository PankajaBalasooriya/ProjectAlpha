namespace ProjectAlpha
{
    partial class FrmDonerReg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmDonerReg));
            this.lblDonName = new System.Windows.Forms.Label();
            this.lblGen = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblTelNo = new System.Windows.Forms.Label();
            this.lblBGroup = new System.Windows.Forms.Label();
            this.txtDName = new System.Windows.Forms.TextBox();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtTelNo = new System.Windows.Forms.TextBox();
            this.rdoMale = new System.Windows.Forms.RadioButton();
            this.rdoFemale = new System.Windows.Forms.RadioButton();
            this.CmbBloodType = new System.Windows.Forms.ComboBox();
            this.lblNic = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDID = new System.Windows.Forms.TextBox();
            this.lblDID = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtAdd = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.DgvDoner = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btncle = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNIC1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoner)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDonName
            // 
            this.lblDonName.AutoSize = true;
            this.lblDonName.Location = new System.Drawing.Point(31, 102);
            this.lblDonName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDonName.Name = "lblDonName";
            this.lblDonName.Size = new System.Drawing.Size(84, 16);
            this.lblDonName.TabIndex = 0;
            this.lblDonName.Text = "Doner Name";
            // 
            // lblGen
            // 
            this.lblGen.AutoSize = true;
            this.lblGen.Location = new System.Drawing.Point(31, 191);
            this.lblGen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGen.Name = "lblGen";
            this.lblGen.Size = new System.Drawing.Size(52, 16);
            this.lblGen.TabIndex = 1;
            this.lblGen.Text = "Gender";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(31, 331);
            this.lblAge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(32, 16);
            this.lblAge.TabIndex = 2;
            this.lblAge.Text = "Age";
            // 
            // lblTelNo
            // 
            this.lblTelNo.AutoSize = true;
            this.lblTelNo.Location = new System.Drawing.Point(31, 370);
            this.lblTelNo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelNo.Name = "lblTelNo";
            this.lblTelNo.Size = new System.Drawing.Size(94, 16);
            this.lblTelNo.TabIndex = 3;
            this.lblTelNo.Text = "Telephone No";
            // 
            // lblBGroup
            // 
            this.lblBGroup.AutoSize = true;
            this.lblBGroup.Location = new System.Drawing.Point(31, 417);
            this.lblBGroup.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBGroup.Name = "lblBGroup";
            this.lblBGroup.Size = new System.Drawing.Size(83, 16);
            this.lblBGroup.TabIndex = 4;
            this.lblBGroup.Text = "Blood Group";
            // 
            // txtDName
            // 
            this.txtDName.Location = new System.Drawing.Point(139, 98);
            this.txtDName.Margin = new System.Windows.Forms.Padding(4);
            this.txtDName.MaxLength = 45;
            this.txtDName.Name = "txtDName";
            this.txtDName.Size = new System.Drawing.Size(349, 22);
            this.txtDName.TabIndex = 5;
            // 
            // txtAge
            // 
            this.txtAge.Location = new System.Drawing.Point(139, 327);
            this.txtAge.Margin = new System.Windows.Forms.Padding(4);
            this.txtAge.MaxLength = 11;
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(132, 22);
            this.txtAge.TabIndex = 6;
            // 
            // txtTelNo
            // 
            this.txtTelNo.Location = new System.Drawing.Point(139, 367);
            this.txtTelNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTelNo.MaxLength = 10;
            this.txtTelNo.Name = "txtTelNo";
            this.txtTelNo.Size = new System.Drawing.Size(171, 22);
            this.txtTelNo.TabIndex = 7;
            // 
            // rdoMale
            // 
            this.rdoMale.AutoSize = true;
            this.rdoMale.Location = new System.Drawing.Point(139, 186);
            this.rdoMale.Margin = new System.Windows.Forms.Padding(4);
            this.rdoMale.Name = "rdoMale";
            this.rdoMale.Size = new System.Drawing.Size(58, 20);
            this.rdoMale.TabIndex = 8;
            this.rdoMale.TabStop = true;
            this.rdoMale.Text = "Male";
            this.rdoMale.UseVisualStyleBackColor = true;
            this.rdoMale.CheckedChanged += new System.EventHandler(this.rdoMale_CheckedChanged);
            // 
            // rdoFemale
            // 
            this.rdoFemale.AutoSize = true;
            this.rdoFemale.Location = new System.Drawing.Point(293, 186);
            this.rdoFemale.Margin = new System.Windows.Forms.Padding(4);
            this.rdoFemale.Name = "rdoFemale";
            this.rdoFemale.Size = new System.Drawing.Size(74, 20);
            this.rdoFemale.TabIndex = 9;
            this.rdoFemale.TabStop = true;
            this.rdoFemale.Text = "Female";
            this.rdoFemale.UseVisualStyleBackColor = true;
            this.rdoFemale.CheckedChanged += new System.EventHandler(this.rdoFemale_CheckedChanged);
            // 
            // CmbBloodType
            // 
            this.CmbBloodType.FormattingEnabled = true;
            this.CmbBloodType.Items.AddRange(new object[] {
            "A RhD positive (A+)",
            "A RhD negative (A-)",
            "B RhD positive (B+)",
            "B RhD negative (B-)",
            "O RhD positive (O+)",
            "O RhD negative (O-)",
            "AB RhD positive (AB+)",
            "AB RhD negative (AB-)"});
            this.CmbBloodType.Location = new System.Drawing.Point(139, 414);
            this.CmbBloodType.Margin = new System.Windows.Forms.Padding(4);
            this.CmbBloodType.Name = "CmbBloodType";
            this.CmbBloodType.Size = new System.Drawing.Size(171, 24);
            this.CmbBloodType.TabIndex = 10;
            this.CmbBloodType.Text = "-Select-";
            // 
            // lblNic
            // 
            this.lblNic.AutoSize = true;
            this.lblNic.Location = new System.Drawing.Point(31, 145);
            this.lblNic.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNic.Name = "lblNic";
            this.lblNic.Size = new System.Drawing.Size(53, 16);
            this.lblNic.TabIndex = 11;
            this.lblNic.Text = "NIC No.";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.txtNIC1);
            this.groupBox1.Controls.Add(this.txtDID);
            this.groupBox1.Controls.Add(this.lblDID);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.txtAdd);
            this.groupBox1.Controls.Add(this.lblAddress);
            this.groupBox1.Controls.Add(this.txtDName);
            this.groupBox1.Controls.Add(this.lblDonName);
            this.groupBox1.Controls.Add(this.lblNic);
            this.groupBox1.Controls.Add(this.lblGen);
            this.groupBox1.Controls.Add(this.CmbBloodType);
            this.groupBox1.Controls.Add(this.lblAge);
            this.groupBox1.Controls.Add(this.rdoFemale);
            this.groupBox1.Controls.Add(this.lblTelNo);
            this.groupBox1.Controls.Add(this.rdoMale);
            this.groupBox1.Controls.Add(this.lblBGroup);
            this.groupBox1.Controls.Add(this.txtTelNo);
            this.groupBox1.Controls.Add(this.txtAge);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(515, 471);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Doner Details";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtDID
            // 
            this.txtDID.Location = new System.Drawing.Point(139, 55);
            this.txtDID.Margin = new System.Windows.Forms.Padding(4);
            this.txtDID.MaxLength = 20;
            this.txtDID.Name = "txtDID";
            this.txtDID.Size = new System.Drawing.Size(171, 22);
            this.txtDID.TabIndex = 18;
            // 
            // lblDID
            // 
            this.lblDID.AutoSize = true;
            this.lblDID.Location = new System.Drawing.Point(31, 59);
            this.lblDID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDID.Name = "lblDID";
            this.lblDID.Size = new System.Drawing.Size(60, 16);
            this.lblDID.TabIndex = 17;
            this.lblDID.Text = "Doner ID";
            this.lblDID.Click += new System.EventHandler(this.lblDID_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(139, 294);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 40;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(349, 22);
            this.txtEmail.TabIndex = 16;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(31, 297);
            this.lblEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(45, 16);
            this.lblEmail.TabIndex = 15;
            this.lblEmail.Text = "E-mail";
            // 
            // txtAdd
            // 
            this.txtAdd.Location = new System.Drawing.Point(139, 231);
            this.txtAdd.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdd.MaxLength = 60;
            this.txtAdd.Multiline = true;
            this.txtAdd.Name = "txtAdd";
            this.txtAdd.Size = new System.Drawing.Size(349, 53);
            this.txtAdd.TabIndex = 14;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(31, 231);
            this.lblAddress.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 16);
            this.lblAddress.TabIndex = 13;
            this.lblAddress.Text = "Address";
            // 
            // DgvDoner
            // 
            this.DgvDoner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDoner.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvDoner.Location = new System.Drawing.Point(0, 497);
            this.DgvDoner.Margin = new System.Windows.Forms.Padding(4);
            this.DgvDoner.Name = "DgvDoner";
            this.DgvDoner.RowHeadersWidth = 51;
            this.DgvDoner.Size = new System.Drawing.Size(809, 185);
            this.DgvDoner.TabIndex = 14;
            this.DgvDoner.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDoner_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnExit);
            this.groupBox2.Controls.Add(this.btncle);
            this.groupBox2.Controls.Add(this.btnRegister);
            this.groupBox2.Location = new System.Drawing.Point(543, 15);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(251, 242);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(23, 162);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(220, 41);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Return To Main Menu";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click_1);
            // 
            // btncle
            // 
            this.btncle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncle.Location = new System.Drawing.Point(23, 102);
            this.btncle.Margin = new System.Windows.Forms.Padding(4);
            this.btncle.Name = "btncle";
            this.btncle.Size = new System.Drawing.Size(220, 44);
            this.btncle.TabIndex = 1;
            this.btncle.Text = "Clear";
            this.btncle.UseVisualStyleBackColor = true;
            this.btncle.Click += new System.EventHandler(this.btncle_Click_1);
            // 
            // btnRegister
            // 
            this.btnRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(23, 36);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(220, 44);
            this.btnRegister.TabIndex = 0;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(543, 277);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(251, 209);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // txtNIC1
            // 
            this.txtNIC1.Location = new System.Drawing.Point(139, 139);
            this.txtNIC1.Name = "txtNIC1";
            this.txtNIC1.Size = new System.Drawing.Size(171, 22);
            this.txtNIC1.TabIndex = 19;
            // 
            // FrmDonerReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(809, 682);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.DgvDoner);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmDonerReg";
            this.Text = "Blood Doner Registration";
            this.Load += new System.EventHandler(this.FrmDonerReg_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDoner)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblDonName;
        private System.Windows.Forms.Label lblGen;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblTelNo;
        private System.Windows.Forms.Label lblBGroup;
        private System.Windows.Forms.TextBox txtDName;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtTelNo;
        private System.Windows.Forms.RadioButton rdoMale;
        private System.Windows.Forms.RadioButton rdoFemale;
        private System.Windows.Forms.ComboBox CmbBloodType;
        private System.Windows.Forms.Label lblNic;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DgvDoner;
        private System.Windows.Forms.TextBox txtAdd;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btncle;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtDID;
        private System.Windows.Forms.Label lblDID;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNIC1;
    }
}