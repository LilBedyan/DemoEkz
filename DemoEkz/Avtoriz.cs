using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Timers;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace DemoEkz
{
    public partial class Avtoriz : Form
    {
        DBConn dataBase = new DBConn();
        public Avtoriz()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            pwd_btn.Click += new EventHandler(pwd_btn_firstClick);
            log_btn.Click += new EventHandler(log_btn_1Click);
        }

        private void Avtoriz_Load(object sender, EventArgs e)
        {
            pwd_box.MaxLength = 15;
            log_box.MaxLength = 50;
        }

        private void log_btn_1Click(object sender, EventArgs e)
        {
            var loginUser = log_box.Text;
            var passUser = pwd_box.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"SELECT UserLogin, UserPassword FROM [User] WHERE UserLogin ='{loginUser}' and UserPassword = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                Terminal form = new Terminal();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует", "Аккаунта не существует", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            log_btn.Click -= new EventHandler(log_btn_1Click);
            log_btn.Click += new EventHandler(log_btn_2Click);
        }

        private void log_btn_2Click(object sender, EventArgs e)
        {
            var loginUser = log_box.Text;
            var passUser = pwd_box.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"SELECT UserLogin, UserPassword FROM [User] WHERE UserLogin ='{loginUser}' and UserPassword = '{passUser}'";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                // MessageBox.Show("Авторизация завершена успешно", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Capcha form = new Capcha();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Такого аккаунта не существует или неверно введена CAPCHA", "Аккаунта не существует", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            log_btn.Click -= new EventHandler(log_btn_2Click);
            log_btn.Click += new EventHandler(log_btn_3Click);
        }


        private void log_btn_3Click(object sender, EventArgs e)
        {
                var loginUser = log_box.Text;
                var passUser = pwd_box.Text;

                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();

                string querystring = $"SELECT UserLogin, UserPassword FROM [User] WHERE UserLogin ='{loginUser}' and UserPassword = '{passUser}'";

                SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

                adapter.SelectCommand = command;
                adapter.Fill(table);

                if (table.Rows.Count == 1)
                {
                    // MessageBox.Show("Авторизация завершена успешно", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Terminal form = new Terminal();
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Такого аккаунта не существует или неверно введена CAPCHA", "Аккаунта не существует", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    //timer1.Interval = 10000; //Миллисекунды
                    //timer1.Tick += timer_Tick;
                    //timer1.Start();
                    log_btn.Enabled = false;
                }

                log_btn.Click -= new EventHandler(log_btn_3Click);
        }

        //void timer_Tick(object sender, System.EventArgs e)
        //{
        //    log_btn.Enabled = true;
        //    timer1.Stop();
        //}

        private void pwd_btn_firstClick(object sender, EventArgs e)
        {
            pwd_box.UseSystemPasswordChar = true;
            pwd_btn.Text = "Показать пароль";
            pwd_btn.Click -= new EventHandler(pwd_btn_firstClick);
            pwd_btn.Click += new EventHandler(pwd_btn_secondClick);
        }

        private void pwd_btn_secondClick(object sender, EventArgs e)
        {
            pwd_box.UseSystemPasswordChar = false;
            pwd_btn.Text = "Скрыть пароль";
            pwd_btn.Click += new EventHandler(pwd_btn_firstClick);
            pwd_btn.Click -= new EventHandler(pwd_btn_secondClick);
        }

        private void reg_btn_Click(object sender, EventArgs e)
        {
            Registr form = new Registr();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}