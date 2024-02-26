namespace ProjectAlpha
{
    partial class DonerBloodTypes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DonerBloodTypes));
            this.dgvBloodtypes = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxBloodTypes = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnDInfo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloodtypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBloodtypes
            // 
            this.dgvBloodtypes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvBloodtypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBloodtypes.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvBloodtypes.Location = new System.Drawing.Point(0, 110);
            this.dgvBloodtypes.Name = "dgvBloodtypes";
            this.dgvBloodtypes.Size = new System.Drawing.Size(946, 459);
            this.dgvBloodtypes.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Blood Type :";
            // 
            // comboBoxBloodTypes
            // 
            this.comboBoxBloodTypes.FormattingEnabled = true;
            this.comboBoxBloodTypes.Items.AddRange(new object[] {
            "A RhD positive (A+)",
            "A RhD negative (A-)",
            "B RhD positive (B+)",
            "B RhD negative (B-)",
            "O RhD positive (O+)",
            "O RhD negative (O-)",
            "AB RhD positive (AB+)",
            "AB RhD negative (AB-)"});
            this.comboBoxBloodTypes.Location = new System.Drawing.Point(306, 32);
            this.comboBoxBloodTypes.Name = "comboBoxBloodTypes";
            this.comboBoxBloodTypes.Size = new System.Drawing.Size(269, 21);
            this.comboBoxBloodTypes.TabIndex = 2;
            this.comboBoxBloodTypes.SelectedIndexChanged += new System.EventHandler(this.comboBoxBloodTypes_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "<---- Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // btnDInfo
            // 
            this.btnDInfo.Location = new System.Drawing.Point(12, 41);
            this.btnDInfo.Name = "btnDInfo";
            this.btnDInfo.Size = new System.Drawing.Size(75, 41);
            this.btnDInfo.TabIndex = 4;
            this.btnDInfo.Text = "Donor Infomation";
            this.btnDInfo.UseVisualStyleBackColor = true;
            this.btnDInfo.Click += new System.EventHandler(this.btnDInfo_Click);
            // 
            // DonerBloodTypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 569);
            this.Controls.Add(this.btnDInfo);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.comboBoxBloodTypes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvBloodtypes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DonerBloodTypes";
            this.Text = "Blood Donors";
            this.Load += new System.EventHandler(this.DonerBloodTypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBloodtypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBloodtypes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxBloodTypes;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnDInfo;
    }
}