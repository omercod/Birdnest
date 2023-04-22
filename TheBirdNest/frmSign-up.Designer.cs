
namespace TheBirdNest
{
    partial class frmSign_up
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtID = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.btnSignUp = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUserLogIn = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SaddleBrown;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 655);
            this.panel1.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.SaddleBrown;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(401, 52);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(273, 55);
            this.textBox1.TabIndex = 5;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "Sign-Up";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtUserLogIn);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.txtID);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.labelLogin);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.checkBoxShowPass);
            this.panel2.Controls.Add(this.btnSignUp);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.txtPassword);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Location = new System.Drawing.Point(184, 110);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 476);
            this.panel2.TabIndex = 5;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Black;
            this.panel5.Location = new System.Drawing.Point(177, 306);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(360, 1);
            this.panel5.TabIndex = 12;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtID.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.ForeColor = System.Drawing.Color.DarkGray;
            this.txtID.Location = new System.Drawing.Point(217, 284);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(297, 23);
            this.txtID.TabIndex = 13;
            this.txtID.TabStop = false;
            this.txtID.Text = "ID";
            this.txtID.Enter += new System.EventHandler(this.txtID_Enter);
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackgroundImage = global::TheBirdNest.Properties.Resources.icons8_identification_documents_26;
            this.pictureBox4.Location = new System.Drawing.Point(178, 276);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelLogin.Location = new System.Drawing.Point(290, 423);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(126, 23);
            this.labelLogin.TabIndex = 10;
            this.labelLogin.Text = "Back to LOGIN";
            this.labelLogin.Click += new System.EventHandler(this.labelLogin_Click);
            this.labelLogin.MouseLeave += new System.EventHandler(this.labelLogin_MouseLeave);
            this.labelLogin.MouseHover += new System.EventHandler(this.labelLogin_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Already Have an Account?";
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPass.ForeColor = System.Drawing.Color.SaddleBrown;
            this.checkBoxShowPass.Location = new System.Drawing.Point(380, 251);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(147, 24);
            this.checkBoxShowPass.TabIndex = 8;
            this.checkBoxShowPass.Text = "Show Password";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // btnSignUp
            // 
            this.btnSignUp.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnSignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignUp.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignUp.ForeColor = System.Drawing.Color.White;
            this.btnSignUp.Location = new System.Drawing.Point(220, 332);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(273, 47);
            this.btnSignUp.TabIndex = 7;
            this.btnSignUp.Text = "SIGN-UP";
            this.btnSignUp.UseVisualStyleBackColor = false;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(177, 248);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(360, 1);
            this.panel4.TabIndex = 6;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.White;
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.Location = new System.Drawing.Point(220, 226);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(297, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "Password";
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TheBirdNest.Properties.Resources.icons8_password_30;
            this.pictureBox3.Location = new System.Drawing.Point(177, 215);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(30, 30);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(177, 192);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(360, 1);
            this.panel3.TabIndex = 3;
            // 
            // txtUserLogIn
            // 
            this.txtUserLogIn.BackColor = System.Drawing.Color.White;
            this.txtUserLogIn.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUserLogIn.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserLogIn.ForeColor = System.Drawing.Color.DarkGray;
            this.txtUserLogIn.Location = new System.Drawing.Point(220, 167);
            this.txtUserLogIn.Name = "txtUserLogIn";
            this.txtUserLogIn.Size = new System.Drawing.Size(297, 23);
            this.txtUserLogIn.TabIndex = 5;
            this.txtUserLogIn.TabStop = false;
            this.txtUserLogIn.Text = "Username";
            this.txtUserLogIn.Enter += new System.EventHandler(this.txtUserLogIn_Enter);
            this.txtUserLogIn.Leave += new System.EventHandler(this.txtUserLogIn_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TheBirdNest.Properties.Resources.icons8_user_30;
            this.pictureBox2.Location = new System.Drawing.Point(177, 157);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(30, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::TheBirdNest.Properties.Resources.Birds_Nest;
            this.pictureBox1.Location = new System.Drawing.Point(282, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(112, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmSign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.panel1);
            this.Name = "frmSign_up";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSign_up";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtUserLogIn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}