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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void money_btn_Click(object sender, EventArgs e)
        {
            Form3 newform3 = new Form3();
            newform3.ShowDialog();
        }

        private void menu_btn_Click(object sender, EventArgs e)
        {
            Form4 newform4 = new Form4();
            newform4.ShowDialog();
        }

        private void state_btn_Click(object sender, EventArgs e)
        {
            StateForm newform5 = new StateForm();
            newform5.ShowDialog();
        }
    }
}
