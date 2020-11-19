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
    public partial class Form2 : Form
    {
        public static string [] sql = new string[14];
        string txt = "";
        public static string pic;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            sql[2] = radioButton1.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            if (comboBox1.SelectedIndex == 0)
            {
                comboBox2.Items.Add("郑州市");
                comboBox2.Items.Add("濮阳市");
                comboBox2.Items.Add("信阳市");
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                comboBox2.Items.Add("唐山市");
                comboBox2.Items.Add("保定市");
                comboBox2.Items.Add("邯郸市");
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                comboBox2.Items.Add("济南市");
                comboBox2.Items.Add("菏泽市");
                comboBox2.Items.Add("聊城市");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            sql[4] = comboBox1.Text + comboBox2.Text;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            sql[7]=checkBox3.Text;
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            sql[9] = checkBox5.Text;
            txt = checkBox5.Text;
            xuanze();
        }
        public void xuanze()
        {
            MessageBox.Show("你居然不喜欢"+txt+"!!!");
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            sql[10] = checkBox6.Text;
            txt = checkBox6.Text;
            xuanze();
        }
        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            sql[11] = checkBox7.Text;
            txt = checkBox7.Text;
            xuanze();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            sql[12] = checkBox8.Text;
            txt = checkBox8.Text;
            xuanze();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == textBox3.Text)
            {
                sql[0] = textBox2.Text;
                sql[1] = textBox1.Text;
                MessageBox.Show("注册成功！");

                this.Close();
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            sql[2] = radioButton2.Text;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            sql[2] = radioButton3.Text;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            sql[3] = dateTimePicker1.Text;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            sql[5] = checkBox1.Text;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            sql[6] = checkBox2.Text;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            sql[8] = checkBox4.Text;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "jpg图片|*.JPG|gif图片|*.GIF|png图片|*.PNG|jpeg图片|*.JPEG";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                //pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);

                pictureBox1.Load(openFileDialog1.FileName);
                pic = pictureBox1.ImageLocation;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
