namespace WindowsFormsApplication1
{
    partial class Form3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.项目ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.网站ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.团队项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改密码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.编辑ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.撤销ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重做ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.项目ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.刷新ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.住址 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.编辑ToolStripMenuItem,
            this.项目ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(459, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.退出ToolStripMenuItem,
            this.修改密码ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.项目ToolStripMenuItem1,
            this.网站ToolStripMenuItem,
            this.团队项目ToolStripMenuItem});
            this.新建ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新建ToolStripMenuItem.Image")));
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 项目ToolStripMenuItem1
            // 
            this.项目ToolStripMenuItem1.Name = "项目ToolStripMenuItem1";
            this.项目ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.项目ToolStripMenuItem1.Size = new System.Drawing.Size(166, 24);
            this.项目ToolStripMenuItem1.Text = "项目";
            // 
            // 网站ToolStripMenuItem
            // 
            this.网站ToolStripMenuItem.Name = "网站ToolStripMenuItem";
            this.网站ToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.网站ToolStripMenuItem.Text = "网站";
            // 
            // 团队项目ToolStripMenuItem
            // 
            this.团队项目ToolStripMenuItem.Name = "团队项目ToolStripMenuItem";
            this.团队项目ToolStripMenuItem.Size = new System.Drawing.Size(166, 24);
            this.团队项目ToolStripMenuItem.Text = "团队项目";
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打开ToolStripMenuItem.Image")));
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.打开ToolStripMenuItem.Text = "打开(&O)";
            this.打开ToolStripMenuItem.Click += new System.EventHandler(this.打开ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("保存ToolStripMenuItem.Image")));
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 修改密码ToolStripMenuItem
            // 
            this.修改密码ToolStripMenuItem.Name = "修改密码ToolStripMenuItem";
            this.修改密码ToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.修改密码ToolStripMenuItem.Text = "修改密码";
            this.修改密码ToolStripMenuItem.Click += new System.EventHandler(this.修改密码ToolStripMenuItem_Click);
            // 
            // 编辑ToolStripMenuItem
            // 
            this.编辑ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.撤销ToolStripMenuItem,
            this.重做ToolStripMenuItem});
            this.编辑ToolStripMenuItem.Name = "编辑ToolStripMenuItem";
            this.编辑ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.编辑ToolStripMenuItem.Text = "编辑";
            // 
            // 撤销ToolStripMenuItem
            // 
            this.撤销ToolStripMenuItem.Name = "撤销ToolStripMenuItem";
            this.撤销ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.撤销ToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.撤销ToolStripMenuItem.Text = "撤销";
            // 
            // 重做ToolStripMenuItem
            // 
            this.重做ToolStripMenuItem.Name = "重做ToolStripMenuItem";
            this.重做ToolStripMenuItem.Size = new System.Drawing.Size(163, 24);
            this.重做ToolStripMenuItem.Text = "重做";
            // 
            // 项目ToolStripMenuItem
            // 
            this.项目ToolStripMenuItem.Name = "项目ToolStripMenuItem";
            this.项目ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.项目ToolStripMenuItem.Text = "项目";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.刷新ToolStripMenuItem,
            this.新建ToolStripMenuItem1,
            this.保存ToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 76);
            // 
            // 刷新ToolStripMenuItem
            // 
            this.刷新ToolStripMenuItem.Name = "刷新ToolStripMenuItem";
            this.刷新ToolStripMenuItem.Size = new System.Drawing.Size(108, 24);
            this.刷新ToolStripMenuItem.Text = "刷新";
            // 
            // 新建ToolStripMenuItem1
            // 
            this.新建ToolStripMenuItem1.Name = "新建ToolStripMenuItem1";
            this.新建ToolStripMenuItem1.Size = new System.Drawing.Size(108, 24);
            this.新建ToolStripMenuItem1.Text = "新建";
            // 
            // 保存ToolStripMenuItem1
            // 
            this.保存ToolStripMenuItem1.Name = "保存ToolStripMenuItem1";
            this.保存ToolStripMenuItem1.Size = new System.Drawing.Size(108, 24);
            this.保存ToolStripMenuItem1.Text = "保存";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(12, 68);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(277, 424);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(314, 345);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 45);
            this.button1.TabIndex = 4;
            this.button1.Text = "颜色";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(314, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 45);
            this.button2.TabIndex = 4;
            this.button2.Text = "字体";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(314, 447);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "保存";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(314, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(120, 117);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Location = new System.Drawing.Point(12, 41);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(52, 15);
            this.user.TabIndex = 7;
            this.user.Text = "用户：";
            this.user.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(311, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 8;
            this.label1.Text = "性别";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(311, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "生日";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // 住址
            // 
            this.住址.AutoSize = true;
            this.住址.Location = new System.Drawing.Point(311, 250);
            this.住址.Name = "住址";
            this.住址.Size = new System.Drawing.Size(37, 15);
            this.住址.TabIndex = 8;
            this.住址.Text = "住址";
            this.住址.Click += new System.EventHandler(this.住址_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(311, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "爱好";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "不喜欢";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 516);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.住址);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.user);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 项目ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 网站ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 团队项目ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 打开ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 编辑ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 项目ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 刷新ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 保存ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 撤销ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重做ToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.ToolStripMenuItem 修改密码ToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label 住址;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}