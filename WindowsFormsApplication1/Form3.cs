using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form3 : Form
    {

        Form4 修改密码 = new Form4();
        public Form3()
        {
            InitializeComponent();
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            openFileDialog1.Filter = "(*.*)|*.*";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName != "")
            {
                richTextBox1.LoadFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fontDialog1.ShowDialog();
            if (richTextBox1.SelectedText != "")
            {
                richTextBox1.SelectionFont = fontDialog1.Font;
            }
        }

        private void saveFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "RTF File(*.rtf)|*.RTF|TXT FILE(*.txt)|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "RTF File(*.rtf)|*.RTF|TXT FILE(*.txt)|*.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(saveFileDialog1.FileName, RichTextBoxStreamType.PlainText);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Load(Form2.pic);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "性别："+Form2.sql[2];
            label2.Text = "生日：" + Form2.sql[3];
            住址.Text = "住址：" + Form2.sql[4];
            label4.Text = "喜欢：" + Form2.sql[5] + Form2.sql[6] + Form2.sql[7] + Form2.sql[8];
            label5.Text = "讨厌：" + Form2.sql[9] + Form2.sql[10] + Form2.sql[11] + Form2.sql[12];



            user.Text = "用户： " + Form2.sql[0];
            pictureBox1.Load(Form2.pic);
            
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 修改密码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            修改密码.ShowDialog();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void 住址_Click(object sender, EventArgs e)
        {

        }
    }
}
