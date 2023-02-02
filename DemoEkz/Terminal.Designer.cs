namespace DemoEkz
{
    partial class Terminal
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
            this.surname_lable = new System.Windows.Forms.Label();
            this.name_lable = new System.Windows.Forms.Label();
            this.patron_lable = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.exit_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // surname_lable
            // 
            this.surname_lable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.surname_lable.Location = new System.Drawing.Point(599, 6);
            this.surname_lable.Name = "surname_lable";
            this.surname_lable.Size = new System.Drawing.Size(102, 23);
            this.surname_lable.TabIndex = 0;
            // 
            // name_lable
            // 
            this.name_lable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_lable.Location = new System.Drawing.Point(707, 6);
            this.name_lable.Name = "name_lable";
            this.name_lable.Size = new System.Drawing.Size(102, 23);
            this.name_lable.TabIndex = 1;
            // 
            // patron_lable
            // 
            this.patron_lable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.patron_lable.Location = new System.Drawing.Point(815, 6);
            this.patron_lable.Name = "patron_lable";
            this.patron_lable.Size = new System.Drawing.Size(102, 23);
            this.patron_lable.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1010, 263);
            this.dataGridView1.TabIndex = 3;
            // 
            // exit_btn
            // 
            this.exit_btn.Location = new System.Drawing.Point(924, 6);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(86, 34);
            this.exit_btn.TabIndex = 4;
            this.exit_btn.Text = "Выход";
            this.exit_btn.UseVisualStyleBackColor = true;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // Terminal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 599);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.patron_lable);
            this.Controls.Add(this.name_lable);
            this.Controls.Add(this.surname_lable);
            this.Name = "Terminal";
            this.Text = "Список товаров";
            this.Load += new System.EventHandler(this.Terminal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label surname_lable;
        private System.Windows.Forms.Label name_lable;
        private System.Windows.Forms.Label patron_lable;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button exit_btn;
    }
}