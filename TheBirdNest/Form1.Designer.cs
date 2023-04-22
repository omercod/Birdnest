
namespace TheBirdNest
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelCreateAccount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxShowPass = new System.Windows.Forms.CheckBox();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUserLogIn = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1085, 655);
            this.panel1.TabIndex = 3;
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
            this.textBox1.Text = "Login";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.txtUserLogIn);
            this.panel2.Controls.Add(this.labelCreateAccount);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.checkBoxShowPass);
            this.panel2.Controls.Add(this.btnLogIn);
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
            // 
            // labelCreateAccount
            // 
            this.labelCreateAccount.AutoSize = true;
            this.labelCreateAccount.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateAccount.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelCreateAccount.Location = new System.Drawing.Point(292, 409);
            this.labelCreateAccount.Name = "labelCreateAccount";
            this.labelCreateAccount.Size = new System.Drawing.Size(132, 23);
            this.labelCreateAccount.TabIndex = 10;
            this.labelCreateAccount.Text = "Create Account";
            this.labelCreateAccount.Click += new System.EventHandler(this.labelCreateAccount_Click);
            this.labelCreateAccount.MouseLeave += new System.EventHandler(this.labelCreateAccount_MouseLeave);
            this.labelCreateAccount.MouseHover += new System.EventHandler(this.labelCreateAccount_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 386);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Dont Have an Account ?";
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxShowPass.ForeColor = System.Drawing.Color.SaddleBrown;
            this.checkBoxShowPass.Location = new System.Drawing.Point(380, 275);
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Size = new System.Drawing.Size(147, 24);
            this.checkBoxShowPass.TabIndex = 8;
            this.checkBoxShowPass.Text = "Show Password";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.SaddleBrown;
            this.btnLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogIn.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Location = new System.Drawing.Point(217, 314);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(273, 47);
            this.btnLogIn.TabIndex = 7;
            this.btnLogIn.Text = "LOGIN";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Location = new System.Drawing.Point(177, 272);
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
            this.txtPassword.Location = new System.Drawing.Point(220, 250);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(297, 23);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.TabStop = false;
            this.txtPassword.Text = "Password";
            this.txtPassword.Enter += new System.EventHandler(this.txtPassword_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = global::TheBirdNest.Properties.Resources.icons8_password_30;
            this.pictureBox3.Location = new System.Drawing.Point(177, 237);
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
            this.panel3.Location = new System.Drawing.Point(177, 216);
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
            this.txtUserLogIn.Location = new System.Drawing.Point(220, 193);
            this.txtUserLogIn.Name = "txtUserLogIn";
            this.txtUserLogIn.Size = new System.Drawing.Size(297, 23);
            this.txtUserLogIn.TabIndex = 5;
            this.txtUserLogIn.TabStop = false;
            this.txtUserLogIn.Text = "Username";
            this.txtUserLogIn.TextChanged += new System.EventHandler(this.txtUserLogIn_TextChanged_1);
            this.txtUserLogIn.Enter += new System.EventHandler(this.txtUserLogIn_Enter);
            this.txtUserLogIn.Leave += new System.EventHandler(this.txtUserLogIn_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::TheBirdNest.Properties.Resources.icons8_user_30;
            this.pictureBox2.Location = new System.Drawing.Point(177, 182);
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
            this.pictureBox1.Location = new System.Drawing.Point(275, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(118, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtUserLogIn;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.CheckBox checkBoxShowPass;
        private System.Windows.Forms.Label labelCreateAccount;
        private System.Windows.Forms.Label label1;
    }
}

