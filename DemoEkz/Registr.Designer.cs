namespace DemoEkz
{
    partial class Registr
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
            this.label1 = new System.Windows.Forms.Label();
            this.Surname_box = new System.Windows.Forms.TextBox();
            this.Name_box = new System.Windows.Forms.TextBox();
            this.Patron_box = new System.Windows.Forms.TextBox();
            this.log_box = new System.Windows.Forms.TextBox();
            this.pwd_box = new System.Windows.Forms.TextBox();
            this.zareg_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(195, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // Surname_box
            // 
            this.Surname_box.Location = new System.Drawing.Point(151, 147);
            this.Surname_box.Name = "Surname_box";
            this.Surname_box.Size = new System.Drawing.Size(171, 22);
            this.Surname_box.TabIndex = 1;
            // 
            // Name_box
            // 
            this.Name_box.Location = new System.Drawing.Point(151, 187);
            this.Name_box.Name = "Name_box";
            this.Name_box.Size = new System.Drawing.Size(171, 22);
            this.Name_box.TabIndex = 2;
            // 
            // Patron_box
            // 
            this.Patron_box.Location = new System.Drawing.Point(151, 227);
            this.Patron_box.Name = "Patron_box";
            this.Patron_box.Size = new System.Drawing.Size(171, 22);
            this.Patron_box.TabIndex = 3;
            // 
            // log_box
            // 
            this.log_box.Location = new System.Drawing.Point(151, 266);
            this.log_box.Name = "log_box";
            this.log_box.Size = new System.Drawing.Size(171, 22);
            this.log_box.TabIndex = 4;
            // 
            // pwd_box
            // 
            this.pwd_box.Location = new System.Drawing.Point(151, 304);
            this.pwd_box.Name = "pwd_box";
            this.pwd_box.Size = new System.Drawing.Size(171, 22);
            this.pwd_box.TabIndex = 5;
            // 
            // zareg_btn
            // 
            this.zareg_btn.Location = new System.Drawing.Point(151, 359);
            this.zareg_btn.Name = "zareg_btn";
            this.zareg_btn.Size = new System.Drawing.Size(171, 49);
            this.zareg_btn.TabIndex = 6;
            this.zareg_btn.Text = "Зарегестрироваться";
            this.zareg_btn.UseVisualStyleBackColor = true;
            this.zareg_btn.Click += new System.EventHandler(this.zareg_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(72, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Фамилия:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Имя:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Отчество:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Логин:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(82, 307);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Пароль:";
            // 
            // Registr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 514);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.zareg_btn);
            this.Controls.Add(this.pwd_box);
            this.Controls.Add(this.log_box);
            this.Controls.Add(this.Patron_box);
            this.Controls.Add(this.Name_box);
            this.Controls.Add(this.Surname_box);
            this.Controls.Add(this.label1);
            this.Name = "Registr";
            this.Text = "Регистрация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Surname_box;
        private System.Windows.Forms.TextBox Name_box;
        private System.Windows.Forms.TextBox Patron_box;
        private System.Windows.Forms.TextBox log_box;
        private System.Windows.Forms.TextBox pwd_box;
        private System.Windows.Forms.Button zareg_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}