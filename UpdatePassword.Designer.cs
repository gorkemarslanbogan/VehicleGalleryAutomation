namespace VeritabanıGörsel
{
    partial class UpdatePassword
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2_passwordTry = new System.Windows.Forms.TextBox();
            this.textBox2_password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_userName = new System.Windows.Forms.TextBox();
            this.textBox1_eskiSifre = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonsClass1 = new VeritabanıGörsel.buttonsClass();
            this.label_Captcha = new System.Windows.Forms.Label();
            this.textBox1_result = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(44, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Yeni Şifre Tekrar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Yeni Şifre";
            // 
            // textBox2_passwordTry
            // 
            this.textBox2_passwordTry.Location = new System.Drawing.Point(169, 148);
            this.textBox2_passwordTry.Name = "textBox2_passwordTry";
            this.textBox2_passwordTry.PasswordChar = '*';
            this.textBox2_passwordTry.Size = new System.Drawing.Size(186, 20);
            this.textBox2_passwordTry.TabIndex = 9;
            // 
            // textBox2_password
            // 
            this.textBox2_password.Location = new System.Drawing.Point(169, 118);
            this.textBox2_password.Name = "textBox2_password";
            this.textBox2_password.PasswordChar = '*';
            this.textBox2_password.Size = new System.Drawing.Size(186, 20);
            this.textBox2_password.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(60, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Kullanıcı Adı ";
            // 
            // textBox1_userName
            // 
            this.textBox1_userName.Location = new System.Drawing.Point(169, 55);
            this.textBox1_userName.Name = "textBox1_userName";
            this.textBox1_userName.Size = new System.Drawing.Size(186, 20);
            this.textBox1_userName.TabIndex = 12;
            // 
            // textBox1_eskiSifre
            // 
            this.textBox1_eskiSifre.Location = new System.Drawing.Point(169, 87);
            this.textBox1_eskiSifre.Name = "textBox1_eskiSifre";
            this.textBox1_eskiSifre.PasswordChar = '*';
            this.textBox1_eskiSifre.Size = new System.Drawing.Size(186, 20);
            this.textBox1_eskiSifre.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(69, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 17);
            this.label4.TabIndex = 15;
            this.label4.Text = "Eski Şifre";
            // 
            // buttonsClass1
            // 
            this.buttonsClass1.BackColor = System.Drawing.Color.MidnightBlue;
            this.buttonsClass1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.buttonsClass1.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.buttonsClass1.BorderRadius = 10;
            this.buttonsClass1.BorderSize = 0;
            this.buttonsClass1.FlatAppearance.BorderSize = 0;
            this.buttonsClass1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonsClass1.ForeColor = System.Drawing.Color.White;
            this.buttonsClass1.Location = new System.Drawing.Point(141, 213);
            this.buttonsClass1.Name = "buttonsClass1";
            this.buttonsClass1.Size = new System.Drawing.Size(214, 37);
            this.buttonsClass1.TabIndex = 16;
            this.buttonsClass1.Text = "Şifreyi Güncelle";
            this.buttonsClass1.UseVisualStyleBackColor = false;
            this.buttonsClass1.Click += new System.EventHandler(this.buttonsClass1_Click);
            // 
            // label_Captcha
            // 
            this.label_Captcha.AutoSize = true;
            this.label_Captcha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label_Captcha.Location = new System.Drawing.Point(49, 174);
            this.label_Captcha.Name = "label_Captcha";
            this.label_Captcha.Size = new System.Drawing.Size(0, 17);
            this.label_Captcha.TabIndex = 17;
            // 
            // textBox1_result
            // 
            this.textBox1_result.Location = new System.Drawing.Point(274, 176);
            this.textBox1_result.Name = "textBox1_result";
            this.textBox1_result.Size = new System.Drawing.Size(81, 20);
            this.textBox1_result.TabIndex = 18;
            // 
            // UpdatePassword
            // 
            this.AcceptButton = this.buttonsClass1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 303);
            this.Controls.Add(this.textBox1_result);
            this.Controls.Add(this.label_Captcha);
            this.Controls.Add(this.buttonsClass1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1_eskiSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1_userName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2_passwordTry);
            this.Controls.Add(this.textBox2_password);
            this.Name = "UpdatePassword";
            this.Text = "Şifremi Değiştir";
            this.Load += new System.EventHandler(this.UpdatePassword_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2_passwordTry;
        private System.Windows.Forms.TextBox textBox2_password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_userName;
        private System.Windows.Forms.TextBox textBox1_eskiSifre;
        private System.Windows.Forms.Label label4;
        private buttonsClass buttonsClass1;
        private System.Windows.Forms.Label label_Captcha;
        private System.Windows.Forms.TextBox textBox1_result;
    }
}