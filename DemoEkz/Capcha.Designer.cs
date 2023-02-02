namespace DemoEkz
{
    partial class Capcha
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
            this.update_btn = new System.Windows.Forms.Button();
            this.capcha_box = new System.Windows.Forms.TextBox();
            this.capcha_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // update_btn
            // 
            this.update_btn.Location = new System.Drawing.Point(226, 84);
            this.update_btn.Name = "update_btn";
            this.update_btn.Size = new System.Drawing.Size(113, 23);
            this.update_btn.TabIndex = 0;
            this.update_btn.Text = "Обновить";
            this.update_btn.UseVisualStyleBackColor = true;
            this.update_btn.Click += new System.EventHandler(this.update_btn_Click);
            // 
            // capcha_box
            // 
            this.capcha_box.Location = new System.Drawing.Point(61, 133);
            this.capcha_box.Name = "capcha_box";
            this.capcha_box.Size = new System.Drawing.Size(145, 22);
            this.capcha_box.TabIndex = 1;
            // 
            // capcha_btn
            // 
            this.capcha_btn.Location = new System.Drawing.Point(61, 181);
            this.capcha_btn.Name = "capcha_btn";
            this.capcha_btn.Size = new System.Drawing.Size(110, 23);
            this.capcha_btn.TabIndex = 2;
            this.capcha_btn.Text = "Ввод";
            this.capcha_btn.UseVisualStyleBackColor = true;
            this.capcha_btn.Click += new System.EventHandler(this.capcha_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(61, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(145, 78);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Capcha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 243);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.capcha_btn);
            this.Controls.Add(this.capcha_box);
            this.Controls.Add(this.update_btn);
            this.Name = "Capcha";
            this.Text = "CAPCHA";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button update_btn;
        private System.Windows.Forms.TextBox capcha_box;
        private System.Windows.Forms.Button capcha_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}