
namespace TheBirdNest
{
    partial class Home
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.txtMenu = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.btnSearchCage = new System.Windows.Forms.Button();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bttnAddBird = new System.Windows.Forms.Button();
            this.btnAddCage = new System.Windows.Forms.Button();
            this.btnSearchBird = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblHatchingDate = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker3 = new System.ComponentModel.BackgroundWorker();
            this.userControlAddBird1 = new TheBirdNest.userControlAddBird();
            this.userControlAddCage1 = new TheBirdNest.UserControlAddCage();
            this.panel2.SuspendLayout();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtMenu
            // 
            this.txtMenu.BackColor = System.Drawing.Color.SaddleBrown;
            this.txtMenu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMenu.Font = new System.Drawing.Font("Nirmala UI", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMenu.ForeColor = System.Drawing.Color.White;
            this.txtMenu.Location = new System.Drawing.Point(413, 10);
            this.txtMenu.Margin = new System.Windows.Forms.Padding(0);
            this.txtMenu.Multiline = true;
            this.txtMenu.Name = "txtMenu";
            this.txtMenu.Size = new System.Drawing.Size(273, 55);
            this.txtMenu.TabIndex = 5;
            this.txtMenu.TabStop = false;
            this.txtMenu.Text = "Birdnest";
            this.txtMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMenu.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.panelMenu);
            this.panel2.Location = new System.Drawing.Point(47, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(992, 517);
            this.panel2.TabIndex = 5;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panelMenu.Controls.Add(this.userControlAddCage1);
            this.panelMenu.Controls.Add(this.textBox1);
            this.panelMenu.Controls.Add(this.pictureBox3);
            this.panelMenu.Controls.Add(this.pictureBox1);
            this.panelMenu.Controls.Add(this.pictureBox5);
            this.panelMenu.Controls.Add(this.btnSearchCage);
            this.panelMenu.Controls.Add(this.pictureBox4);
            this.panelMenu.Controls.Add(this.pictureBox2);
            this.panelMenu.Controls.Add(this.bttnAddBird);
            this.panelMenu.Controls.Add(this.btnAddCage);
            this.panelMenu.Controls.Add(this.btnSearchBird);
            this.panelMenu.Controls.Add(this.userControlAddBird1);
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(992, 517);
            this.panelMenu.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Nirmala UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.textBox1.Location = new System.Drawing.Point(102, 35);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(117, 37);
            this.textBox1.TabIndex = 23;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "MENU";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox3.BackgroundImage = global::TheBirdNest.Properties.Resources.icons8_search_30;
            this.pictureBox3.Location = new System.Drawing.Point(5, 326);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TheBirdNest.Properties.Resources.birdnest_logo_75px;
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(75, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox5.BackgroundImage = global::TheBirdNest.Properties.Resources.icons8_bird_30;
            this.pictureBox5.Location = new System.Drawing.Point(5, 113);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(30, 30);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            // 
            // btnSearchCage
            // 
            this.btnSearchCage.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSearchCage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchCage.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCage.ForeColor = System.Drawing.Color.White;
            this.btnSearchCage.Location = new System.Drawing.Point(0, 321);
            this.btnSearchCage.Name = "btnSearchCage";
            this.btnSearchCage.Size = new System.Drawing.Size(239, 47);
            this.btnSearchCage.TabIndex = 20;
            this.btnSearchCage.Text = "    SEARCH CAGE";
            this.btnSearchCage.UseVisualStyleBackColor = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox4.BackgroundImage = global::TheBirdNest.Properties.Resources.icons8_cage_30;
            this.pictureBox4.Location = new System.Drawing.Point(5, 186);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(30, 30);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.SaddleBrown;
            this.pictureBox2.BackgroundImage = global::TheBirdNest.Properties.Resources.icons8_search_30;
            this.pictureBox2.Location = new System.Drawing.Point(5, 256);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // bttnAddBird
            // 
            this.bttnAddBird.BackColor = System.Drawing.Color.SaddleBrown;
            this.bttnAddBird.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttnAddBird.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttnAddBird.ForeColor = System.Drawing.Color.White;
            this.bttnAddBird.Location = new System.Drawing.Point(0, 111);
            this.bttnAddBird.Name = "bttnAddBird";
            this.bttnAddBird.Size = new System.Drawing.Size(239, 47);
            this.bttnAddBird.TabIndex = 16;
            this.bttnAddBird.Text = "ADD BIRD";
            this.bttnAddBird.UseVisualStyleBackColor = false;
            this.bttnAddBird.Click += new System.EventHandler(this.bttnAddBird_Click);
            // 
            // btnAddCage
            // 
            this.btnAddCage.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnAddCage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddCage.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCage.ForeColor = System.Drawing.Color.White;
            this.btnAddCage.Location = new System.Drawing.Point(0, 181);
            this.btnAddCage.Name = "btnAddCage";
            this.btnAddCage.Size = new System.Drawing.Size(240, 47);
            this.btnAddCage.TabIndex = 9;
            this.btnAddCage.Text = "ADD CAGE";
            this.btnAddCage.UseVisualStyleBackColor = false;
            this.btnAddCage.Click += new System.EventHandler(this.btnAddCage_Click);
            // 
            // btnSearchBird
            // 
            this.btnSearchBird.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSearchBird.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchBird.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchBird.ForeColor = System.Drawing.Color.White;
            this.btnSearchBird.Location = new System.Drawing.Point(0, 251);
            this.btnSearchBird.Name = "btnSearchBird";
            this.btnSearchBird.Size = new System.Drawing.Size(239, 47);
            this.btnSearchBird.TabIndex = 18;
            this.btnSearchBird.Text = "    SEARCH BIRD";
            this.btnSearchBird.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.lblHatchingDate);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtMenu);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 655);
            this.panel1.TabIndex = 5;
            // 
            // lblHatchingDate
            // 
            this.lblHatchingDate.AutoSize = true;
            this.lblHatchingDate.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHatchingDate.ForeColor = System.Drawing.Color.White;
            this.lblHatchingDate.Location = new System.Drawing.Point(328, 57);
            this.lblHatchingDate.Name = "lblHatchingDate";
            this.lblHatchingDate.Size = new System.Drawing.Size(442, 28);
            this.lblHatchingDate.TabIndex = 8;
            this.lblHatchingDate.Text = "\"A bird in the hand is worth two in the bush\"";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(283, 107);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 523);
            this.panel3.TabIndex = 7;
            // 
            // userControlAddBird1
            // 
            this.userControlAddBird1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.userControlAddBird1.Location = new System.Drawing.Point(238, -1);
            this.userControlAddBird1.Name = "userControlAddBird1";
            this.userControlAddBird1.Size = new System.Drawing.Size(754, 515);
            this.userControlAddBird1.TabIndex = 22;
            // 
            // userControlAddCage1
            // 
            this.userControlAddCage1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.userControlAddCage1.Location = new System.Drawing.Point(238, 0);
            this.userControlAddCage1.Name = "userControlAddCage1";
            this.userControlAddCage1.Size = new System.Drawing.Size(754, 515);
            this.userControlAddCage1.TabIndex = 24;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.panel1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.panel2.ResumeLayout(false);
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.TextBox txtMenu;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelMenu;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Button btnAddCage;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button bttnAddBird;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnSearchCage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnSearchBird;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker3;
        private System.Windows.Forms.Panel panel3;
        private userControlAddBird userControlAddBird1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblHatchingDate;
        private UserControlAddCage userControlAddCage1;
    }
}