using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OopProject
{
    public partial class StateForm : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;DataBase=stock;Uid=root;Pwd=64081484;");
        public StateForm()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.RowCount == 0)
            {
                MessageBox.Show("수정할 재고를 먼저 선택하세요");
                return;
            }
            else
            {
                UpdateForm newUpdateForm = new UpdateForm();
                newUpdateForm.ShowDialog();
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if(dataGridView1.RowCount == 0)
            {
                MessageBox.Show("삭제할 재고를 먼저 선택하세요");
                return;
            }
            else
            {
                string Query = "delete from stock where name = '" + tb_name + "';";
                MySqlCommand SelectCommand = new MySqlCommand(Query, connection);

                MySqlDataReader myReader;

                try
                {
                    connection.Open();

                    myReader = SelectCommand.ExecuteReader();
                    MessageBox.Show("재고가 삭제되었습니다");
                    while (myReader.Read())
                    {

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            InsertForm newInsertForm = new InsertForm();
            newInsertForm.ShowDialog();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            if(tb_name.Text == "")
            {
                string selectQuery = "SELECT * from stock";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader table = cmd.ExecuteReader();

                while(table.Read())
                {
                    dataGridView1.Rows.Add(table["name"], table["number"]);
                }
                connection.Close();
            }
            else
            {
                string selectQuery = "SELECT * from stock where name = '" + tb_name.Text + "'";
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(selectQuery, connection);
                MySqlDataReader table = cmd.ExecuteReader();

                ArrayList Test = new ArrayList();
                while (table.Read())
                {
                    Test.Add(table["name"]);
                    dataGridView1.Rows.Add(table["name"], table["number"]);
                }

                tb_number.Text = Test[1].ToString();

                connection.Close();
            }
        }
    }
}
