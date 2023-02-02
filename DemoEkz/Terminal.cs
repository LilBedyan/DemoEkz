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
    enum RowState 
    {
        Existed,
        New,
        Modified,
        ModifiedNew,
        Deleted
    }

    public partial class Terminal : Form
    {
        DBConn dataBase = new DBConn();
        int selectedRow;
        private string result = "";

        public Terminal()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void CreateColumns()
        {
        }

        private void ReadSingleRow(DataGridView dqw, IDataRecord record)
        {
            dqw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetString(5), record.GetInt32(6), RowState.ModifiedNew);
        }

        private void RefreshDataGrid(DataGridView dqw)
        {
            dqw.Rows.Clear();
            string queryString = $"SELECT * FROM [User]";

            SqlCommand command = new SqlCommand(queryString, dataBase.getConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dqw, reader);
            }
            reader.Close();
        }

        private void Terminal_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefreshDataGrid(dataGridView1);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Avtoriz form_avtoriz = new Avtoriz();
            this.Hide();
            form_avtoriz.ShowDialog();
            this.Show();
        }
    }
}
