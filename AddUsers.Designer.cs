namespace VeritabanıGörsel
{
    partial class AddUsers
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
            this.textBox1_userName = new System.Windows.Forms.TextBox();
            this.textBox2_password = new System.Windows.Forms.TextBox();
            this.textBox2_passwordTry = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButton1_admin = new System.Windows.Forms.RadioButton();
            this.radioButton1_personel = new System.Windows.Forms.RadioButton();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1_userName
            // 
            this.textBox1_userName.Location = new System.Drawing.Point(148, 61);
            this.textBox1_userName.Name = "textBox1_userName";
            this.textBox1_userName.Size = new System.Drawing.Size(186, 20);
            this.textBox1_userName.TabIndex = 0;
            // 
            // textBox2_password
            // 
            this.textBox2_password.Location = new System.Drawing.Point(148, 94);
            this.textBox2_password.Name = "textBox2_password";
            this.textBox2_password.PasswordChar = '*';
            this.textBox2_password.Size = new System.Drawing.Size(186, 20);
            this.textBox2_password.TabIndex = 1;
            // 
            // textBox2_passwordTry
            // 
            this.textBox2_passwordTry.Location = new System.Drawing.Point(148, 124);
            this.textBox2_passwordTry.Name = "textBox2_passwordTry";
            this.textBox2_passwordTry.PasswordChar = '*';
            this.textBox2_passwordTry.Size = new System.Drawing.Size(186, 20);
            this.textBox2_passwordTry.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(148, 194);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 28);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(43, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Adı ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(63, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Şifre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(43, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Şifre Tekrar";
            // 
            // radioButton1_admin
            // 
            this.radioButton1_admin.AutoSize = true;
            this.radioButton1_admin.Location = new System.Drawing.Point(166, 159);
            this.radioButton1_admin.Name = "radioButton1_admin";
            this.radioButton1_admin.Size = new System.Drawing.Size(63, 17);
            this.radioButton1_admin.TabIndex = 7;
            this.radioButton1_admin.Text = "Yönetici";
            this.radioButton1_admin.UseVisualStyleBackColor = true;
            // 
            // radioButton1_personel
            // 
            this.radioButton1_personel.AutoSize = true;
            this.radioButton1_personel.Checked = true;
            this.radioButton1_personel.Location = new System.Drawing.Point(254, 159);
            this.radioButton1_personel.Name = "radioButton1_personel";
            this.radioButton1_personel.Size = new System.Drawing.Size(66, 17);
            this.radioButton1_personel.TabIndex = 8;
            this.radioButton1_personel.TabStop = true;
            this.radioButton1_personel.Text = "Personel";
            this.radioButton1_personel.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(37, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kullanıcı Türü";
            // 
            // AddUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 281);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.radioButton1_personel);
            this.Controls.Add(this.radioButton1_admin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2_passwordTry);
            this.Controls.Add(this.textBox2_password);
            this.Controls.Add(this.textBox1_userName);
            this.Name = "AddUsers";
            this.Text = "Kullanıcı Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1_userName;
        private System.Windows.Forms.TextBox textBox2_password;
        private System.Windows.Forms.TextBox textBox2_passwordTry;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioButton1_admin;
        private System.Windows.Forms.RadioButton radioButton1_personel;
        private System.Windows.Forms.Label label4;
    }
}