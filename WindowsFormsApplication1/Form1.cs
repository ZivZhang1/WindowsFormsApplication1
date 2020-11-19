using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Form2 注册 = new Form2();
        Form3 页面 = new Form3();
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string ID = User.Text;
            string PassWord = Pass.Text;
            if (ID  == "")
            {
                MessageBox.Show("用户名不能为空");
                User.BackColor = Color.Yellow;
            }
            else if (PassWord == "")
            {
                MessageBox.Show("密码不能为空");
                Pass.BackColor = Color.Yellow;
            }
            else if (ID == Form2.sql[0] && PassWord  == Form2.sql[1])
            {
                pictureBox1.Load(Form2.pic);
                MessageBox.Show("登录成功");
                this.Hide();
                页面.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误");
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Pass_TextChanged(object sender, EventArgs e)
        {
            TextBox txtbox = (TextBox)sender;

            if (txtbox.Text != "")
            {
                txtbox.BackColor = Color.Empty;
            }
        }

        private void User_TextChanged(object sender, EventArgs e)
        {
            TextBox txtbox = (TextBox)sender;

            if (txtbox.Text != "")
            {
                txtbox.BackColor = Color.Empty;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
            注册.Show();
        }
    }
}
