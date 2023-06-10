using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace OopProject
{
    public partial class UpdateForm : Form
    {
        MySqlConnection connection = new MySqlConnection("Server=localhost;DataBase=stock;Uid=root;Pwd=64081484;");
        public UpdateForm()
        {
            InitializeComponent();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string Query = "update stock set name = '" + tb_name.Text + "', number = '" + tb_number.Text + "';";

            MySqlCommand selectCommand = new MySqlCommand(Query, connection);

            MySqlDataReader myReader;
            try
            {
                connection.Open();

                myReader = selectCommand.ExecuteReader();
                MessageBox.Show("잘 수정되었습니다");

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
