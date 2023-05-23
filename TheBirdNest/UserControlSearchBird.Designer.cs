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
            this.dateHatching = new System.Windows.Forms.DateTimePicker();
            this.lblSearchBird = new System.Windows.Forms.TextBox();
            this.btnToSearchBird = new System.Windows.Forms.Button();
            this.cmbBirdSpe = new System.Windows.Forms.ComboBox();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbBirdGender = new System.Windows.Forms.ComboBox();
            this.dataSearchBird = new System.Windows.Forms.DataGridView();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearchBird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // dateHatching
            // 
            this.dateHatching.CalendarFont = new System.Drawing.Font("Nirmala UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateHatching.CalendarMonthBackground = System.Drawing.Color.AntiqueWhite;
            this.dateHatching.CustomFormat = "";
            this.dateHatching.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateHatching.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHatching.Location = new System.Drawing.Point(521, 106);
            this.dateHatching.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateHatching.MinDate = new System.DateTime(1900, 1, 1, 0, 0, 0, 0);
            this.dateHatching.Name = "dateHatching";
            this.dateHatching.Size = new System.Drawing.Size(177, 34);
            this.dateHatching.TabIndex = 40;
            this.dateHatching.Value = new System.DateTime(2023, 1, 1, 0, 0, 0, 0);
            this.dateHatching.ValueChanged += new System.EventHandler(this.dateHatching_ValueChanged);
            // 
            // lblSearchBird
            // 
            this.lblSearchBird.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblSearchBird.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblSearchBird.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSearchBird.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBird.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSearchBird.Location = new System.Drawing.Point(221, 16);
            this.lblSearchBird.Margin = new System.Windows.Forms.Padding(0);
            this.lblSearchBird.Multiline = true;
            this.lblSearchBird.Name = "lblSearchBird";
            this.lblSearchBird.ReadOnly = true;
            this.lblSearchBird.Size = new System.Drawing.Size(273, 55);
            this.lblSearchBird.TabIndex = 37;
            this.lblSearchBird.TabStop = false;
            this.lblSearchBird.Text = "SEARCH BIRD";
            this.lblSearchBird.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnToSearchBird
            // 
            this.btnToSearchBird.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnToSearchBird.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToSearchBird.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToSearchBird.ForeColor = System.Drawing.Color.White;
            this.btnToSearchBird.Location = new System.Drawing.Point(259, 158);
            this.btnToSearchBird.Name = "btnToSearchBird";
            this.btnToSearchBird.Size = new System.Drawing.Size(202, 47);
            this.btnToSearchBird.TabIndex = 43;
            this.btnToSearchBird.Text = "SEARCH BIRD";
            this.btnToSearchBird.UseVisualStyleBackColor = false;
            this.btnToSearchBird.Click += new System.EventHandler(this.btnToSearchBird_Click);
            // 
            // cmbBirdSpe
            // 
            this.cmbBirdSpe.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbBirdSpe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBirdSpe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBirdSpe.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBirdSpe.ForeColor = System.Drawing.Color.Gray;
            this.cmbBirdSpe.FormattingEnabled = true;
            this.cmbBirdSpe.Items.AddRange(new object[] {
            "Species",
            "American Goldian",
            "European Goldian",
            "Australian Goldian"});
            this.cmbBirdSpe.Location = new System.Drawing.Point(185, 107);
            this.cmbBirdSpe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBirdSpe.Name = "cmbBirdSpe";
            this.cmbBirdSpe.Size = new System.Drawing.Size(179, 33);
            this.cmbBirdSpe.TabIndex = 50;
            // 
            // txtSN
            // 
            this.txtSN.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtSN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSN.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSN.ForeColor = System.Drawing.Color.Gray;
            this.txtSN.Location = new System.Drawing.Point(46, 114);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(120, 23);
            this.txtSN.TabIndex = 51;
            this.txtSN.TabStop = false;
            this.txtSN.Text = "Serial Number";
            this.txtSN.Enter += new System.EventHandler(this.txtSN_Enter);
            this.txtSN.Leave += new System.EventHandler(this.txtSN_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(46, 139);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 1);
            this.panel3.TabIndex = 52;
            // 
            // cmbBirdGender
            // 
            this.cmbBirdGender.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbBirdGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBirdGender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBirdGender.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBirdGender.ForeColor = System.Drawing.Color.Gray;
            this.cmbBirdGender.FormattingEnabled = true;
            this.cmbBirdGender.Items.AddRange(new object[] {
            "Gender",
            "Male",
            "Female"});
            this.cmbBirdGender.Location = new System.Drawing.Point(381, 106);
            this.cmbBirdGender.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbBirdGender.Name = "cmbBirdGender";
            this.cmbBirdGender.Size = new System.Drawing.Size(125, 33);
            this.cmbBirdGender.TabIndex = 53;
            // 
            // dataSearchBird
            // 
            this.dataSearchBird.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataSearchBird.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSearchBird.GridColor = System.Drawing.Color.SaddleBrown;
            this.dataSearchBird.Location = new System.Drawing.Point(0, 220);
            this.dataSearchBird.Name = "dataSearchBird";
            this.dataSearchBird.RowHeadersWidth = 51;
            this.dataSearchBird.RowTemplate.Height = 24;
            this.dataSearchBird.Size = new System.Drawing.Size(754, 295);
            this.dataSearchBird.TabIndex = 54;
            this.dataSearchBird.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataSearchBird_CellClick);
            this.dataSearchBird.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataSearchBird_CellMouseDown);
            // 
            // picRefresh
            // 
            this.picRefresh.BackgroundImage = global::TheBirdNest.Properties.Resources.icons8_refresh_20;
            this.picRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRefresh.Location = new System.Drawing.Point(678, 77);
            this.picRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(20, 20);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRefresh.TabIndex = 56;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // UserControlBirdSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.dataSearchBird);
            this.Controls.Add(this.cmbBirdGender);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.cmbBirdSpe);
            this.Controls.Add(this.btnToSearchBird);
            this.Controls.Add(this.dateHatching);
            this.Controls.Add(this.lblSearchBird);
            this.Name = "UserControlBirdSearch";
            this.Size = new System.Drawing.Size(754, 515);
            this.Load += new System.EventHandler(this.UserControlBirdSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSearchBird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateHatching;
        private System.Windows.Forms.TextBox lblSearchBird;
        private System.Windows.Forms.Button btnToSearchBird;
        private System.Windows.Forms.ComboBox cmbBirdSpe;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbBirdGender;
        private System.Windows.Forms.DataGridView dataSearchBird;
        private System.Windows.Forms.PictureBox picRefresh;
    }
}
