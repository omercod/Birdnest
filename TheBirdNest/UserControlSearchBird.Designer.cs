namespace TheBirdNest
{
    partial class UserControlBirdSearch
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
            this.radiobtnSearchBirdFeMaleGender = new System.Windows.Forms.RadioButton();
            this.radiobtnSearchBirdMaleGender = new System.Windows.Forms.RadioButton();
            this.dateSearchBirdHatchingDate = new System.Windows.Forms.DateTimePicker();
            this.lblSearchBird = new System.Windows.Forms.TextBox();
            this.lblSearchBirdGender = new System.Windows.Forms.Label();
            this.lblSearchHatchingDate = new System.Windows.Forms.Label();
            this.txtBirdSpecies = new System.Windows.Forms.TextBox();
            this.lblSearchBirdSpecies = new System.Windows.Forms.Label();
            this.txtSerialNumberSearchBird = new System.Windows.Forms.TextBox();
            this.lblSerialNumberSearchBird = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnToSearchBird = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // radiobtnSearchBirdFeMaleGender
            // 
            this.radiobtnSearchBirdFeMaleGender.AutoSize = true;
            this.radiobtnSearchBirdFeMaleGender.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnSearchBirdFeMaleGender.Location = new System.Drawing.Point(320, 259);
            this.radiobtnSearchBirdFeMaleGender.Name = "radiobtnSearchBirdFeMaleGender";
            this.radiobtnSearchBirdFeMaleGender.Size = new System.Drawing.Size(88, 27);
            this.radiobtnSearchBirdFeMaleGender.TabIndex = 42;
            this.radiobtnSearchBirdFeMaleGender.TabStop = true;
            this.radiobtnSearchBirdFeMaleGender.Text = "Female";
            this.radiobtnSearchBirdFeMaleGender.UseVisualStyleBackColor = true;
            // 
            // radiobtnSearchBirdMaleGender
            // 
            this.radiobtnSearchBirdMaleGender.AutoSize = true;
            this.radiobtnSearchBirdMaleGender.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtnSearchBirdMaleGender.Location = new System.Drawing.Point(232, 257);
            this.radiobtnSearchBirdMaleGender.Name = "radiobtnSearchBirdMaleGender";
            this.radiobtnSearchBirdMaleGender.Size = new System.Drawing.Size(70, 27);
            this.radiobtnSearchBirdMaleGender.TabIndex = 41;
            this.radiobtnSearchBirdMaleGender.TabStop = true;
            this.radiobtnSearchBirdMaleGender.Text = "Male";
            this.radiobtnSearchBirdMaleGender.UseVisualStyleBackColor = true;
            // 
            // dateSearchBirdHatchingDate
            // 
            this.dateSearchBirdHatchingDate.CalendarFont = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSearchBirdHatchingDate.CustomFormat = "dd-MM-yyyy";
            this.dateSearchBirdHatchingDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateSearchBirdHatchingDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateSearchBirdHatchingDate.Location = new System.Drawing.Point(232, 206);
            this.dateSearchBirdHatchingDate.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateSearchBirdHatchingDate.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateSearchBirdHatchingDate.Name = "dateSearchBirdHatchingDate";
            this.dateSearchBirdHatchingDate.Size = new System.Drawing.Size(218, 34);
            this.dateSearchBirdHatchingDate.TabIndex = 40;
            this.dateSearchBirdHatchingDate.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            // 
            // lblSearchBird
            // 
            this.lblSearchBird.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblSearchBird.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblSearchBird.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBird.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSearchBird.Location = new System.Drawing.Point(202, 18);
            this.lblSearchBird.Margin = new System.Windows.Forms.Padding(0);
            this.lblSearchBird.Multiline = true;
            this.lblSearchBird.Name = "lblSearchBird";
            this.lblSearchBird.Size = new System.Drawing.Size(273, 55);
            this.lblSearchBird.TabIndex = 37;
            this.lblSearchBird.TabStop = false;
            this.lblSearchBird.Text = "SEARCH BIRD";
            this.lblSearchBird.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.lblSearchBird.TextChanged += new System.EventHandler(this.lblAddBird_TextChanged);
            // 
            // lblSearchBirdGender
            // 
            this.lblSearchBirdGender.AutoSize = true;
            this.lblSearchBirdGender.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBirdGender.Location = new System.Drawing.Point(72, 256);
            this.lblSearchBirdGender.Name = "lblSearchBirdGender";
            this.lblSearchBirdGender.Size = new System.Drawing.Size(131, 28);
            this.lblSearchBirdGender.TabIndex = 30;
            this.lblSearchBirdGender.Text = "Bird Gender:";
            // 
            // lblSearchHatchingDate
            // 
            this.lblSearchHatchingDate.AutoSize = true;
            this.lblSearchHatchingDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchHatchingDate.Location = new System.Drawing.Point(72, 206);
            this.lblSearchHatchingDate.Name = "lblSearchHatchingDate";
            this.lblSearchHatchingDate.Size = new System.Drawing.Size(154, 28);
            this.lblSearchHatchingDate.TabIndex = 29;
            this.lblSearchHatchingDate.Text = "Hatching Date:";
            // 
            // txtBirdSpecies
            // 
            this.txtBirdSpecies.BackColor = System.Drawing.Color.FloralWhite;
            this.txtBirdSpecies.Font = new System.Drawing.Font("Nirmala UI", 12F);
            this.txtBirdSpecies.Location = new System.Drawing.Point(232, 155);
            this.txtBirdSpecies.Name = "txtBirdSpecies";
            this.txtBirdSpecies.Size = new System.Drawing.Size(218, 34);
            this.txtBirdSpecies.TabIndex = 26;
            // 
            // lblSearchBirdSpecies
            // 
            this.lblSearchBirdSpecies.AutoSize = true;
            this.lblSearchBirdSpecies.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBirdSpecies.Location = new System.Drawing.Point(72, 155);
            this.lblSearchBirdSpecies.Name = "lblSearchBirdSpecies";
            this.lblSearchBirdSpecies.Size = new System.Drawing.Size(132, 28);
            this.lblSearchBirdSpecies.TabIndex = 25;
            this.lblSearchBirdSpecies.Text = "Bird Species:";
            // 
            // txtSerialNumberSearchBird
            // 
            this.txtSerialNumberSearchBird.BackColor = System.Drawing.Color.FloralWhite;
            this.txtSerialNumberSearchBird.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSerialNumberSearchBird.Location = new System.Drawing.Point(232, 106);
            this.txtSerialNumberSearchBird.Name = "txtSerialNumberSearchBird";
            this.txtSerialNumberSearchBird.Size = new System.Drawing.Size(218, 34);
            this.txtSerialNumberSearchBird.TabIndex = 24;
            // 
            // lblSerialNumberSearchBird
            // 
            this.lblSerialNumberSearchBird.AutoSize = true;
            this.lblSerialNumberSearchBird.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSerialNumberSearchBird.Location = new System.Drawing.Point(72, 106);
            this.lblSerialNumberSearchBird.Name = "lblSerialNumberSearchBird";
            this.lblSerialNumberSearchBird.Size = new System.Drawing.Size(154, 28);
            this.lblSerialNumberSearchBird.TabIndex = 23;
            this.lblSerialNumberSearchBird.Text = "Serial Number:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TheBirdNest.Properties.Resources.icons8_bird_100;
            this.pictureBox1.Location = new System.Drawing.Point(557, 83);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // btnToSearchBird
            // 
            this.btnToSearchBird.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnToSearchBird.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToSearchBird.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToSearchBird.ForeColor = System.Drawing.Color.White;
            this.btnToSearchBird.Location = new System.Drawing.Point(232, 384);
            this.btnToSearchBird.Name = "btnToSearchBird";
            this.btnToSearchBird.Size = new System.Drawing.Size(239, 47);
            this.btnToSearchBird.TabIndex = 43;
            this.btnToSearchBird.Text = "SEARCH BIRD";
            this.btnToSearchBird.UseVisualStyleBackColor = false;
            // 
            // UserControlBirdSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.btnToSearchBird);
            this.Controls.Add(this.radiobtnSearchBirdFeMaleGender);
            this.Controls.Add(this.radiobtnSearchBirdMaleGender);
            this.Controls.Add(this.dateSearchBirdHatchingDate);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblSearchBird);
            this.Controls.Add(this.lblSearchBirdGender);
            this.Controls.Add(this.lblSearchHatchingDate);
            this.Controls.Add(this.txtBirdSpecies);
            this.Controls.Add(this.lblSearchBirdSpecies);
            this.Controls.Add(this.txtSerialNumberSearchBird);
            this.Controls.Add(this.lblSerialNumberSearchBird);
            this.Name = "UserControlBirdSearch";
            this.Size = new System.Drawing.Size(754, 515);
            this.Load += new System.EventHandler(this.UserControlBirdSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radiobtnSearchBirdFeMaleGender;
        private System.Windows.Forms.RadioButton radiobtnSearchBirdMaleGender;
        private System.Windows.Forms.DateTimePicker dateSearchBirdHatchingDate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox lblSearchBird;
        private System.Windows.Forms.Label lblSearchBirdGender;
        private System.Windows.Forms.Label lblSearchHatchingDate;
        private System.Windows.Forms.TextBox txtBirdSpecies;
        private System.Windows.Forms.Label lblSearchBirdSpecies;
        private System.Windows.Forms.TextBox txtSerialNumberSearchBird;
        private System.Windows.Forms.Label lblSerialNumberSearchBird;
        private System.Windows.Forms.Button btnToSearchBird;
    }
}
