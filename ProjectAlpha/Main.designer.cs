namespace ProjectAlpha
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnDonerReg = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSignout = new System.Windows.Forms.Button();
            this.btnDonInfo = new System.Windows.Forms.Button();
            this.btnSearchDonor = new System.Windows.Forms.Button();
            this.btnStock = new System.Windows.Forms.Button();
            this.btupdateStock = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDonerReg
            // 
            this.btnDonerReg.BackColor = System.Drawing.Color.Transparent;
            this.btnDonerReg.Location = new System.Drawing.Point(16, 19);
            this.btnDonerReg.Name = "btnDonerReg";
            this.btnDonerReg.Size = new System.Drawing.Size(91, 37);
            this.btnDonerReg.TabIndex = 0;
            this.btnDonerReg.Text = "Doner Registration";
            this.btnDonerReg.UseVisualStyleBackColor = false;
            this.btnDonerReg.Click += new System.EventHandler(this.btnDonerReg_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(360, 396);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(74, 26);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSignout
            // 
            this.btnSignout.Location = new System.Drawing.Point(281, 396);
            this.btnSignout.Name = "btnSignout";
            this.btnSignout.Size = new System.Drawing.Size(73, 26);
            this.btnSignout.TabIndex = 2;
            this.btnSignout.Text = "SignOut";
            this.btnSignout.UseVisualStyleBackColor = true;
            this.btnSignout.Click += new System.EventHandler(this.btnSignout_Click);
            // 
            // btnDonInfo
            // 
            this.btnDonInfo.BackColor = System.Drawing.Color.Transparent;
            this.btnDonInfo.Location = new System.Drawing.Point(16, 106);
            this.btnDonInfo.Name = "btnDonInfo";
            this.btnDonInfo.Size = new System.Drawing.Size(91, 37);
            this.btnDonInfo.TabIndex = 3;
            this.btnDonInfo.Text = "Doner Information";
            this.btnDonInfo.UseVisualStyleBackColor = false;
            this.btnDonInfo.Click += new System.EventHandler(this.btnDonInfo_Click);
            // 
            // btnSearchDonor
            // 
            this.btnSearchDonor.BackColor = System.Drawing.Color.Transparent;
            this.btnSearchDonor.Location = new System.Drawing.Point(16, 193);
            this.btnSearchDonor.Name = "btnSearchDonor";
            this.btnSearchDonor.Size = new System.Drawing.Size(91, 47);
            this.btnSearchDonor.TabIndex = 4;
            this.btnSearchDonor.Text = "Search a Doner through Blood Group";
            this.btnSearchDonor.UseVisualStyleBackColor = false;
            this.btnSearchDonor.Click += new System.EventHandler(this.btnSearchDonor_Click);
            // 
            // btnStock
            // 
            this.btnStock.Location = new System.Drawing.Point(21, 19);
            this.btnStock.Name = "btnStock";
            this.btnStock.Size = new System.Drawing.Size(91, 37);
            this.btnStock.TabIndex = 5;
            this.btnStock.Text = "Blood Bank Stock";
            this.btnStock.UseVisualStyleBackColor = true;
            this.btnStock.Click += new System.EventHandler(this.btnStock_Click);
            // 
            // btupdateStock
            // 
            this.btupdateStock.Location = new System.Drawing.Point(21, 106);
            this.btupdateStock.Name = "btupdateStock";
            this.btupdateStock.Size = new System.Drawing.Size(91, 47);
            this.btupdateStock.TabIndex = 6;
            this.btupdateStock.Text = "Update Stock";
            this.btupdateStock.UseVisualStyleBackColor = true;
            this.btupdateStock.Click += new System.EventHandler(this.btupdateStock_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.btnStock);
            this.groupBox1.Controls.Add(this.btupdateStock);
            this.groupBox1.Location = new System.Drawing.Point(315, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 178);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Blood bank Stock";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.btnDonerReg);
            this.groupBox2.Controls.Add(this.btnDonInfo);
            this.groupBox2.Controls.Add(this.btnSearchDonor);
            this.groupBox2.Location = new System.Drawing.Point(13, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(124, 269);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Donor";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(460, 442);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSignout);
            this.Controls.Add(this.btnExit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.Text = "Main Menu";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDonerReg;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnSignout;
        private System.Windows.Forms.Button btnDonInfo;
        private System.Windows.Forms.Button btnSearchDonor;
        private System.Windows.Forms.Button btnStock;
        private System.Windows.Forms.Button btupdateStock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}