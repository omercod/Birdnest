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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataSearchCage = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSN = new System.Windows.Forms.TextBox();
            this.cmbCgaeMat = new System.Windows.Forms.ComboBox();
            this.btnToSearchCage = new System.Windows.Forms.Button();
            this.lblSearchBird = new System.Windows.Forms.TextBox();
            this.pictCage = new System.Windows.Forms.PictureBox();
            this.picBirdsGif = new System.Windows.Forms.PictureBox();
            this.picRefresh = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataSearchCage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBirdsGif)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).BeginInit();
            this.SuspendLayout();
            // 
            // dataSearchCage
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LightGray;
            this.dataSearchCage.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataSearchCage.BackgroundColor = System.Drawing.Color.AntiqueWhite;
            this.dataSearchCage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataSearchCage.GridColor = System.Drawing.Color.Black;
            this.dataSearchCage.Location = new System.Drawing.Point(0, 220);
            this.dataSearchCage.Name = "dataSearchCage";
            this.dataSearchCage.RowHeadersWidth = 51;
            this.dataSearchCage.RowTemplate.Height = 24;
            this.dataSearchCage.Size = new System.Drawing.Size(754, 295);
            this.dataSearchCage.TabIndex = 63;
            this.dataSearchCage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataSearchBird_CellClick);
            this.dataSearchCage.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataSearchBird_CellMouseDown);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(216, 113);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 1);
            this.panel3.TabIndex = 61;
            // 
            // txtSN
            // 
            this.txtSN.BackColor = System.Drawing.Color.AntiqueWhite;
            this.txtSN.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSN.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSN.ForeColor = System.Drawing.Color.Gray;
            this.txtSN.Location = new System.Drawing.Point(216, 88);
            this.txtSN.Name = "txtSN";
            this.txtSN.Size = new System.Drawing.Size(120, 23);
            this.txtSN.TabIndex = 60;
            this.txtSN.TabStop = false;
            this.txtSN.Text = "Cage Number";
            this.txtSN.Enter += new System.EventHandler(this.txtSN_Enter);
            this.txtSN.Leave += new System.EventHandler(this.txtSN_Leave);
            // 
            // cmbCgaeMat
            // 
            this.cmbCgaeMat.BackColor = System.Drawing.Color.AntiqueWhite;
            this.cmbCgaeMat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCgaeMat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbCgaeMat.Font = new System.Drawing.Font("Nirmala UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbCgaeMat.ForeColor = System.Drawing.Color.Gray;
            this.cmbCgaeMat.FormattingEnabled = true;
            this.cmbCgaeMat.Items.AddRange(new object[] {
            "Material",
            "Iron",
            "Wood",
            "Plastic"});
            this.cmbCgaeMat.Location = new System.Drawing.Point(390, 83);
            this.cmbCgaeMat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbCgaeMat.Name = "cmbCgaeMat";
            this.cmbCgaeMat.Size = new System.Drawing.Size(179, 33);
            this.cmbCgaeMat.TabIndex = 59;
            // 
            // btnToSearchCage
            // 
            this.btnToSearchCage.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnToSearchCage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnToSearchCage.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToSearchCage.ForeColor = System.Drawing.Color.White;
            this.btnToSearchCage.Location = new System.Drawing.Point(258, 145);
            this.btnToSearchCage.Name = "btnToSearchCage";
            this.btnToSearchCage.Size = new System.Drawing.Size(230, 47);
            this.btnToSearchCage.TabIndex = 58;
            this.btnToSearchCage.Text = "SEARCH CAGE";
            this.btnToSearchCage.UseVisualStyleBackColor = false;
            this.btnToSearchCage.Click += new System.EventHandler(this.btnToSearchCage_Click);
            // 
            // lblSearchBird
            // 
            this.lblSearchBird.BackColor = System.Drawing.Color.AntiqueWhite;
            this.lblSearchBird.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lblSearchBird.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblSearchBird.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchBird.ForeColor = System.Drawing.Color.SaddleBrown;
            this.lblSearchBird.Location = new System.Drawing.Point(221, 8);
            this.lblSearchBird.Margin = new System.Windows.Forms.Padding(0);
            this.lblSearchBird.Multiline = true;
            this.lblSearchBird.Name = "lblSearchBird";
            this.lblSearchBird.ReadOnly = true;
            this.lblSearchBird.Size = new System.Drawing.Size(313, 55);
            this.lblSearchBird.TabIndex = 56;
            this.lblSearchBird.TabStop = false;
            this.lblSearchBird.Text = "SEARCH CAGE";
            this.lblSearchBird.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictCage
            // 
            this.pictCage.BackgroundImage = global::TheBirdNest.Properties.Resources.cageBird2_PhotoRoom_png_PhotoRoom;
            this.pictCage.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictCage.Location = new System.Drawing.Point(473, 232);
            this.pictCage.Margin = new System.Windows.Forms.Padding(0);
            this.pictCage.Name = "pictCage";
            this.pictCage.Size = new System.Drawing.Size(170, 211);
            this.pictCage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictCage.TabIndex = 136;
            this.pictCage.TabStop = false;
            // 
            // picBirdsGif
            // 
            this.picBirdsGif.BackColor = System.Drawing.Color.Transparent;
            this.picBirdsGif.BackgroundImage = global::TheBirdNest.Properties.Resources.ezgif_com_resize__1_;
            this.picBirdsGif.Cursor = System.Windows.Forms.Cursors.Default;
            this.picBirdsGif.Location = new System.Drawing.Point(24, 319);
            this.picBirdsGif.Margin = new System.Windows.Forms.Padding(0);
            this.picBirdsGif.Name = "picBirdsGif";
            this.picBirdsGif.Size = new System.Drawing.Size(429, 177);
            this.picBirdsGif.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBirdsGif.TabIndex = 135;
            this.picBirdsGif.TabStop = false;
            // 
            // picRefresh
            // 
            this.picRefresh.BackgroundImage = global::TheBirdNest.Properties.Resources.icons8_refresh_20;
            this.picRefresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picRefresh.Location = new System.Drawing.Point(549, 50);
            this.picRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.picRefresh.Name = "picRefresh";
            this.picRefresh.Size = new System.Drawing.Size(20, 20);
            this.picRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picRefresh.TabIndex = 64;
            this.picRefresh.TabStop = false;
            this.picRefresh.Click += new System.EventHandler(this.picRefresh_Click);
            // 
            // UserControlSearchCage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AntiqueWhite;
            this.Controls.Add(this.pictCage);
            this.Controls.Add(this.picBirdsGif);
            this.Controls.Add(this.picRefresh);
            this.Controls.Add(this.dataSearchCage);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtSN);
            this.Controls.Add(this.cmbCgaeMat);
            this.Controls.Add(this.btnToSearchCage);
            this.Controls.Add(this.lblSearchBird);
            this.Name = "UserControlSearchCage";
            this.Size = new System.Drawing.Size(754, 515);
            this.Load += new System.EventHandler(this.UserControlSearchCage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSearchCage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictCage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBirdsGif)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picRefresh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataSearchCage;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSN;
        private System.Windows.Forms.ComboBox cmbCgaeMat;
        private System.Windows.Forms.Button btnToSearchCage;
        private System.Windows.Forms.TextBox lblSearchBird;
        private System.Windows.Forms.PictureBox picRefresh;
        private System.Windows.Forms.PictureBox picBirdsGif;
        private System.Windows.Forms.PictureBox pictCage;
    }
}
