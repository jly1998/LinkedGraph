namespace Graph
{
    partial class Graph
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox_vexnum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_matrix = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_algraph = new System.Windows.Forms.TextBox();
            this.textBox_DFS = new System.Windows.Forms.TextBox();
            this.textBox_BFS = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttondfs = new System.Windows.Forms.Button();
            this.buttonbfs = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_vexnum
            // 
            this.textBox_vexnum.Location = new System.Drawing.Point(29, 44);
            this.textBox_vexnum.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_vexnum.Name = "textBox_vexnum";
            this.textBox_vexnum.Size = new System.Drawing.Size(285, 28);
            this.textBox_vexnum.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(29, 582);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 34);
            this.button1.TabIndex = 1;
            this.button1.Text = "确认输入";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "请输入图的顶点数n(1-100)：";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // textBox_matrix
            // 
            this.textBox_matrix.Location = new System.Drawing.Point(29, 150);
            this.textBox_matrix.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_matrix.Multiline = true;
            this.textBox_matrix.Name = "textBox_matrix";
            this.textBox_matrix.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_matrix.Size = new System.Drawing.Size(285, 409);
            this.textBox_matrix.TabIndex = 3;
            this.textBox_matrix.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 110);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(206, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "请输入图相应的邻接矩阵";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // textBox_algraph
            // 
            this.textBox_algraph.Location = new System.Drawing.Point(25, 44);
            this.textBox_algraph.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_algraph.Multiline = true;
            this.textBox_algraph.Name = "textBox_algraph";
            this.textBox_algraph.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_algraph.Size = new System.Drawing.Size(313, 515);
            this.textBox_algraph.TabIndex = 6;
            this.textBox_algraph.TextChanged += new System.EventHandler(this.TextBox_algraph_TextChanged);
            // 
            // textBox_DFS
            // 
            this.textBox_DFS.Location = new System.Drawing.Point(30, 44);
            this.textBox_DFS.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_DFS.Name = "textBox_DFS";
            this.textBox_DFS.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_DFS.Size = new System.Drawing.Size(393, 28);
            this.textBox_DFS.TabIndex = 7;
            this.textBox_DFS.TextChanged += new System.EventHandler(this.textBox_DFS_TextChanged);
            // 
            // textBox_BFS
            // 
            this.textBox_BFS.Location = new System.Drawing.Point(30, 41);
            this.textBox_BFS.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_BFS.Name = "textBox_BFS";
            this.textBox_BFS.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox_BFS.Size = new System.Drawing.Size(393, 28);
            this.textBox_BFS.TabIndex = 10;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(226, 582);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 34);
            this.button2.TabIndex = 11;
            this.button2.Text = "重置\r\n";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBox_vexnum);
            this.panel1.Controls.Add(this.textBox_matrix);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(349, 651);
            this.panel1.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(215, 18);
            this.label6.TabIndex = 5;
            this.label6.Text = "0/1 通过空格分割 n行n列";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_algraph);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(367, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 651);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "邻接链表";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.buttondfs);
            this.groupBox2.Controls.Add(this.textBox_DFS);
            this.groupBox2.Location = new System.Drawing.Point(739, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 322);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "深度优先-栈";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.buttonbfs);
            this.groupBox3.Controls.Add(this.textBox_BFS);
            this.groupBox3.Location = new System.Drawing.Point(739, 340);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(449, 323);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "广度优先-队列";
            // 
            // buttondfs
            // 
            this.buttondfs.Location = new System.Drawing.Point(295, 80);
            this.buttondfs.Margin = new System.Windows.Forms.Padding(4);
            this.buttondfs.Name = "buttondfs";
            this.buttondfs.Size = new System.Drawing.Size(128, 31);
            this.buttondfs.TabIndex = 12;
            this.buttondfs.Text = "深度优先遍历";
            this.buttondfs.UseVisualStyleBackColor = true;
            this.buttondfs.Click += new System.EventHandler(this.buttondfs_Click);
            // 
            // buttonbfs
            // 
            this.buttonbfs.Location = new System.Drawing.Point(295, 77);
            this.buttonbfs.Margin = new System.Windows.Forms.Padding(4);
            this.buttonbfs.Name = "buttonbfs";
            this.buttonbfs.Size = new System.Drawing.Size(128, 31);
            this.buttonbfs.TabIndex = 13;
            this.buttonbfs.Text = "广度优先遍历";
            this.buttonbfs.UseVisualStyleBackColor = true;
            this.buttonbfs.Click += new System.EventHandler(this.buttonbfs_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(30, 119);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox1.Size = new System.Drawing.Size(393, 178);
            this.textBox1.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "栈中情况";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "队列中情况";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(30, 116);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBox2.Size = new System.Drawing.Size(393, 178);
            this.textBox2.TabIndex = 14;
            // 
            // Graph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Graph";
            this.Text = "Graph";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public bool IsNumber(string str)
        {
            bool yes = true;
            char ch;
            int t = 0, len;
            len = str.Length;
            if (string.IsNullOrEmpty(str)) yes = false;
            else
            {
                for(int i=0;i<len;i++)
                {
                    ch = char.Parse(str.Substring(i, 1));
                    if (ch == '.') t++;
                    if(!char.IsDigit(ch) && ch!= '.')
                    {
                        yes = false;
                        break;
                    }
                }
            }
            return yes;
        }

        private System.Windows.Forms.TextBox textBox_vexnum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_matrix;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_algraph;
        private System.Windows.Forms.TextBox textBox_DFS;
        private System.Windows.Forms.TextBox textBox_BFS;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttondfs;
        private System.Windows.Forms.Button buttonbfs;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
    }
}

