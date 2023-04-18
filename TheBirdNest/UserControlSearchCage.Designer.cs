namespace TheBirdNest
{
    partial class UserControlSearchCage
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxCageSearchMat = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblSearchCage = new System.Windows.Forms.TextBox();
            this.lblSearchCageMaterial = new System.Windows.Forms.Label();
            this.txtSerialNumberSearchCage = new System.Windows.Forms.TextBox();
            this.lblSerialNumberSearchCage = new System.Windows.Forms.Label();
            this.btnSearchCage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxCageSearchMat
            // 
            this.comboBoxCageSearchMat.BackColor = System.Drawing.Color.FloralWhite;
            this.comboBoxCageSearchMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCageSearchMat.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCageSearchMat.ForeColor = System.Drawing.Color.Black;
            this.comboBoxCageSearchMat.FormattingEnabled = true;
            this.comboBoxCageSearchMat.Items.AddRange(new object[] {
            "Iron",
            "Wood",
            "Plastic"});
            this.comboBoxCageSearchMat.Location = new System.Drawing.Point(238, 249);
            this.comboBoxCageSearchMat.Name = "comboBoxCageSearchMat";
            this.comboBoxCageSearchMat.Size = new System.Drawing.Size(218, 33);
            this.comboBoxCageSearchMat.TabIndex = 59;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TheBirdNest.Properties.Resources.icons8_freedom_100;
            this.pictureBox1.Location = new System.Drawing.Point(559, 249);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(87, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 56;
            this.pictureBox1.TabStop = false;
            // 
            // lblSearchCage
            // 
            this.lblSearchCage.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblSearchCage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblSearchCage.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCage.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSearchCage.Location = new System.Drawing.Point(225, 53);
            this.lblSearchCage.Margin = new System.Windows.Forms.Padding(0);
            this.lblSearchCage.Multiline = true;
            this.lblSearchCage.Name = "lblSearchCage";
            this.lblSearchCage.Size = new System.Drawing.Size(273, 55);
            this.lblSearchCage.TabIndex = 55;
            this.lblSearchCage.TabStop = false;
            this.lblSearchCage.Text = "SEARCH CAGE";
            this.lblSearchCage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblSearchCage.TextChanged += new System.EventHandler(this.lblSearchCage_TextChanged);
            // 
            // lblSearchCageMaterial
            // 
            this.lblSearchCageMaterial.AutoSize = true;
            this.lblSearchCageMaterial.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchCageMaterial.Location = new System.Drawing.Point(78, 249);
            this.lblSearchCageMaterial.Name = "lblSearchCageMaterial";
            this.lblSearchCageMaterial.Size = new System.Drawing.Size(149, 28);
            this.lblSearchCageMaterial.TabIndex = 54;
            this.lblSearchCageMaterial.Text = "Cage Material:";
            // 
            // txtSerialNumberSearchCage
            // 
            this.txtSerialNumberSearchCage.BackColor = System.Drawing.Color.FloralWhite;
            this.txtSerialNumberSearchCage.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNumberSearchCage.Location = new System.Drawing.Point(238, 191);
            this.txtSerialNumberSearchCage.Name = "txtSerialNumberSearchCage";
            this.txtSerialNumberSearchCage.Size = new System.Drawing.Size(218, 34);
            this.txtSerialNumberSearchCage.TabIndex = 48;
            // 
            // lblSerialNumberSearchCage
            // 
            this.lblSerialNumberSearchCage.AutoSize = true;
            this.lblSerialNumberSearchCage.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNumberSearchCage.Location = new System.Drawing.Point(78, 191);
            this.lblSerialNumberSearchCage.Name = "lblSerialNumberSearchCage";
            this.lblSerialNumberSearchCage.Size = new System.Drawing.Size(154, 28);
            this.lblSerialNumberSearchCage.TabIndex = 47;
            this.lblSerialNumberSearchCage.Text = "Serial Number:";
            // 
            // btnSearchCage
            // 
            this.btnSearchCage.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSearchCage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCage.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCage.ForeColor = System.Drawing.Color.White;
            this.btnSearchCage.Location = new System.Drawing.Point(225, 354);
            this.btnSearchCage.Name = "btnSearchCage";
            this.btnSearchCage.Size = new System.Drawing.Size(239, 47);
            this.btnSearchCage.TabIndex = 60;
            this.btnSearchCage.Text = "SEARCH CAGE";
            this.btnSearchCage.UseVisualStyleBackColor = false;
            // 
            // UserControlSearchCage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.btnSearchCage);
            this.Controls.Add(this.comboBoxCageSearchMat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSearchCage);
            this.Controls.Add(this.lblSearchCageMaterial);
            this.Controls.Add(this.txtSerialNumberSearchCage);
            this.Controls.Add(this.lblSerialNumberSearchCage);
            this.Name = "UserControlSearchCage";
            this.Size = new System.Drawing.Size(754, 515);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxCageSearchMat;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lblSearchCage;
        private System.Windows.Forms.Label lblSearchCageMaterial;
        private System.Windows.Forms.TextBox txtSerialNumberSearchCage;
        private System.Windows.Forms.Label lblSerialNumberSearchCage;
        private System.Windows.Forms.Button btnSearchCage;
    }
}
