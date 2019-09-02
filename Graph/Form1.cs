using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graph
{
    public partial class Graph : Form
    {
        MGraph mgraph = new MGraph();
        ALGraph algraph = new ALGraph();
        public Graph()
        {
            InitializeComponent();            
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            int vexnum;
            int[,] adjmatrix;
            string text_algraph;
         
            if (!string.IsNullOrEmpty(textBox_vexnum.Text))
            {
                vexnum = Convert.ToInt32(textBox_vexnum.Text);
                adjmatrix = new int[vexnum, vexnum];
                for (int i = 0; i < vexnum; i++)
                {
                    string[] strs = textBox_matrix.Lines[i].Split(' ');
                    for(int j=0; j<vexnum; j++)
                    {
                        adjmatrix[i,j] = Convert.ToInt32(strs[j]);                        
                    }
                }
                mgraph.creat(vexnum, adjmatrix);
                System.Diagnostics.Debug.WriteLine(vexnum);
                algraph.creat(vexnum, adjmatrix);
                text_algraph = algraph.Print();

                textBox_matrix.Enabled = false;
                textBox_vexnum.Enabled = false;

                textBox_algraph.Text = text_algraph;

                

            }
            
        }

        private void ListBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void TextBox_algraph_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox_algraph.Text = "";
            textBox_vexnum.Text = "";
            textBox_matrix.Text = "";
            textBox_BFS.Text = "";
            textBox_DFS.Text = "";
            textBox_vexnum.Enabled = true;
            textBox_matrix.Enabled = true;
        }

        private void textBox_DFS_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttondfs_Click(object sender, EventArgs e)
        {
            string text_dfs;
     
            text_dfs = mgraph.DFS();
            textBox_DFS.Text = text_dfs;
        }

        private void buttonbfs_Click(object sender, EventArgs e)
        {
            string text_bfs;
            text_bfs = mgraph.BFS();
            textBox_BFS.Text = text_bfs;
        }
    }
}
