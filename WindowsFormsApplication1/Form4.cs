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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((textBox2.Text != "") && (textBox3.Text != "") && (textBox4.Text != ""))
            {
                if (textBox2.Text == Form2.sql[1])
                {
                    if (textBox3.Text == textBox4.Text)
                    {
                        Form2.sql[1] = textBox3.Text;
                        MessageBox.Show("密码修改成功");
                    }
                    else
                    {
                        MessageBox.Show("新密码与确认密码输入不一致，请重新输入");
                    }
                }
                else 
                {
                    MessageBox.Show("原密码输入有误");
                }
            }
            else 
            {
                MessageBox.Show("密码不得为空值");
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            textBox1.Text = Form2.sql[0];
        }
    }
}
