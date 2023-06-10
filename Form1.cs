using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OopProject
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(tb_id.Text == "" || tb_password.Text == "")
            {
                MessageBox.Show("아이디와 비밀번호를 입력하세요");
            }
            else
            {
                if(tb_id.Text == "user626" && tb_password.Text == "1234")
                {
                    StateForm newStateForm = new StateForm();
                    newStateForm.ShowDialog();
                }
                else
                {
                    tb_id.Text = "";
                    tb_password.Text = "";
                    MessageBox.Show("아이디와 비밀번호를 확인해주세요");
                }
            }
        }
        private bool EmptyCheck()
        {
            if(String.IsNullOrEmpty(tb_id.Text))
            {
                labelMsg.Text = "사용자명을 입력해 주세요";
                tb_id.Focus();
                return false;
            }
            else if (String.IsNullOrEmpty(tb_password.Text))
            {
                labelMsg.Text = "비밀번호를 입력해 주새요";
                tb_password.Focus();
                return false;
            }
            return true;
        }

        private void tb_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btn_login_Click(sender, e);
                btn_login.Select();
            }
        }
    }
}
