using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace firstWinFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_login_Click(object sender, EventArgs e)
        {
            string userName = this.textBox_username.Text;
            string password = this.textBox_password.Text;

            MessageBox.Show(this, "您输入的用户名为[" + userName + "],密码为[" + password + "]");
            return;
        }

        private void button_cancel_Click(object sender, EventArgs e)
        {
            this.textBox_username.Text = "";
            this.textBox_password.Text = "";
            MessageBox.Show(this, "您点击了取消按钮");
            return;
        }


    }
}
