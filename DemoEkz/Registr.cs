using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEkz
{
    public partial class Registr : Form
    {

        DBConn dataBase = new DBConn();
        public Registr()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void zareg_btn_Click(object sender, EventArgs e)
        {
            var surname = Surname_box.Text;
            var name = Name_box.Text;
            var patronymic = Patron_box.Text;
            var login = log_box.Text;
            var password = pwd_box.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"INSERT INTO [User] (UserSurname, UserName, UserPatronymic, UserLogin, UserPassword, UserRole) VALUES ('{surname}', '{name}', '{patronymic}', '{login}', '{password}', 3)";

            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            dataBase.openConnection();
            if (checkUser())
            {
                return;
            }
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт успешно создан", "Успех");
                Avtoriz form_avtoriz = new Avtoriz();
                this.Hide();
                form_avtoriz.ShowDialog();
            }
            else
            {
                MessageBox.Show("Аккаунт не создан");
            }
            dataBase.closeConnection();

        }

        private Boolean checkUser()
        {
            DBConn dataBase = new DBConn();
            var surname = Surname_box.Text;
            var name = Name_box.Text;
            var patronymic = Patron_box.Text;
            var login = log_box.Text;
            var password = pwd_box.Text;

            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"SELECT UserSurname, UserName, UserPatronymic, UserLogin, UserPassword FROM [User] WHERE UserSurname = '{surname}' and UserName = '{name}' and UserPatronymic = '{patronymic}' and UserLogin = '{login}' and UserPassword = '{password}'";
            SqlCommand command = new SqlCommand(querystring, dataBase.getConnection());

            dataAdapter.SelectCommand = command;
            dataAdapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользовательн уже существует");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
