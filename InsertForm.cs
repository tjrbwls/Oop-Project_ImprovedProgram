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
using MySql.Data.MySqlClient;

namespace OopProject
{
    public partial class InsertForm : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;DataBase=stock;Uid=root;Pwd=64081484;");
        public InsertForm()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string Query = " insert into stock (name, number) " + "value ('" + tb_name + "', '" + tb_number + "');";

            MySqlCommand SelectCommand = new MySqlCommand(Query, connection);

            MySqlDataReader myReader;

            try
            {
                connection.Open();

                myReader = SelectCommand.ExecuteReader();
                MessageBox.Show("재고가 리스트에 저장되었습니다");

                while (myReader.Read())
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
