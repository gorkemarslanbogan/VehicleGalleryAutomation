namespace VeritabanıGörsel
{
    partial class addCustomer
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox2_surName = new System.Windows.Forms.TextBox();
            this.textBox1_userName = new System.Windows.Forms.TextBox();
            this.maskedTextBox1_telephone = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(30, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Telefon Numarası";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(67, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Soyad";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(77, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Ad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(156, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(186, 28);
            this.button1.TabIndex = 14;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox2_surName
            // 
            this.textBox2_surName.Location = new System.Drawing.Point(156, 100);
            this.textBox2_surName.Name = "textBox2_surName";
            this.textBox2_surName.Size = new System.Drawing.Size(186, 20);
            this.textBox2_surName.TabIndex = 8;
            // 
            // textBox1_userName
            // 
            this.textBox1_userName.Location = new System.Drawing.Point(156, 67);
            this.textBox1_userName.Name = "textBox1_userName";
            this.textBox1_userName.Size = new System.Drawing.Size(186, 20);
            this.textBox1_userName.TabIndex = 7;
            // 
            // maskedTextBox1_telephone
            // 
            this.maskedTextBox1_telephone.Location = new System.Drawing.Point(156, 129);
            this.maskedTextBox1_telephone.Mask = "(999) 000-00-00";
            this.maskedTextBox1_telephone.Name = "maskedTextBox1_telephone";
            this.maskedTextBox1_telephone.Size = new System.Drawing.Size(186, 20);
            this.maskedTextBox1_telephone.TabIndex = 10;
            // 
            // addCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 293);
            this.Controls.Add(this.maskedTextBox1_telephone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox2_surName);
            this.Controls.Add(this.textBox1_userName);
            this.Name = "addCustomer";
            this.Text = "Müşteri Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox2_surName;
        private System.Windows.Forms.TextBox textBox1_userName;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1_telephone;
    }
}