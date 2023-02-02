namespace DemoEkz
{
    partial class Avtoriz
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.log_btn = new System.Windows.Forms.Button();
            this.reg_btn = new System.Windows.Forms.Button();
            this.log_box = new System.Windows.Forms.TextBox();
            this.pwd_box = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pwd_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // log_btn
            // 
            this.log_btn.Location = new System.Drawing.Point(183, 230);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(141, 34);
            this.log_btn.TabIndex = 0;
            this.log_btn.Text = "Вход";
            this.log_btn.UseVisualStyleBackColor = true;
            this.log_btn.Click += new System.EventHandler(this.log_btn_1Click);
            // 
            // reg_btn
            // 
            this.reg_btn.Location = new System.Drawing.Point(183, 289);
            this.reg_btn.Name = "reg_btn";
            this.reg_btn.Size = new System.Drawing.Size(141, 34);
            this.reg_btn.TabIndex = 1;
            this.reg_btn.Text = "Регистрация";
            this.reg_btn.UseVisualStyleBackColor = true;
            this.reg_btn.Click += new System.EventHandler(this.reg_btn_Click);
            // 
            // log_box
            // 
            this.log_box.Location = new System.Drawing.Point(183, 127);
            this.log_box.Name = "log_box";
            this.log_box.Size = new System.Drawing.Size(141, 22);
            this.log_box.TabIndex = 2;
            // 
            // pwd_box
            // 
            this.pwd_box.Location = new System.Drawing.Point(183, 171);
            this.pwd_box.Name = "pwd_box";
            this.pwd_box.Size = new System.Drawing.Size(141, 22);
            this.pwd_box.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(204, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Авторизация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(128, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль:";
            // 
            // pwd_btn
            // 
            this.pwd_btn.Location = new System.Drawing.Point(340, 164);
            this.pwd_btn.Name = "pwd_btn";
            this.pwd_btn.Size = new System.Drawing.Size(145, 36);
            this.pwd_btn.TabIndex = 7;
            this.pwd_btn.Text = "Скрыть пароль";
            this.pwd_btn.UseVisualStyleBackColor = true;
            this.pwd_btn.Click += new System.EventHandler(this.pwd_btn_firstClick);
            // 
            // Avtoriz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 383);
            this.Controls.Add(this.pwd_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pwd_box);
            this.Controls.Add(this.log_box);
            this.Controls.Add(this.reg_btn);
            this.Controls.Add(this.log_btn);
            this.Name = "Avtoriz";
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button log_btn;
        private System.Windows.Forms.Button reg_btn;
        private System.Windows.Forms.TextBox log_box;
        private System.Windows.Forms.TextBox pwd_box;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button pwd_btn;
    }
}

