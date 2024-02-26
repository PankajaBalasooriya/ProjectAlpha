namespace ProjectAlpha
{
    partial class BloodStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BloodStock));
            this.dataGridViewStock = new System.Windows.Forms.DataGridView();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewStock
            // 
            this.dataGridViewStock.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStock.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridViewStock.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewStock.Name = "dataGridViewStock";
            this.dataGridViewStock.Size = new System.Drawing.Size(240, 273);
            this.dataGridViewStock.TabIndex = 0;
            this.dataGridViewStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewStock_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(246, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(82, 36);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update Blood Stock";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(246, 54);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(82, 34);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // BloodStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 273);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridViewStock);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BloodStock";
            this.Text = "Blood Bank Stock";
            this.Load += new System.EventHandler(this.BloodStock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewStock;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnclose;
    }
}