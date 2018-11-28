using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafuri
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.Load();
            string t;
            int i, j;
            for (i = 0; i < Engine.n; i++)
            {
                t = "";
                for (j = 0; j < Engine.n; j++)
                    t += Engine.ma[i, j].ToString() + " ";

                listBox1.Items.Add(t);
            }
            
        }
        
        public void DFS(bool[] v,int nc,ref string t)
        {
            v[nc] = true;
            t += (nc + 1).ToString() +' ';
            //MessageBox.Show(t);
            for (int i = 0; i < Engine.n; i++)
                if (Engine.ma[nc, i] == 1 && v[i] == false)
                    DFS(v, i,ref t);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("  ");
            string t = "";
            bool[] v = new bool[Engine.n];//il pune fals automat
            for (int i = 0; i < Engine.n; i++)
                v[i] = false;
            DFS(v, 0,ref t);
            MessageBox.Show(t);
            listBox1.Items.Add(t);
        }

        public void BFS(Queue<int> qu,int nc,bool[] v)
        { //ceva nu merge
            while(qu.Count!=0)
            {
                nc = qu.Dequeue();
                for (int i = 0; i < Engine.n; i++)
                    if (Engine.ma[nc, i] == 1 && v[i] == false)
                    {
                        qu.Enqueue(i);
                        v[i] = true;
                    }
                v[nc] = true;
                listBox1.Items.Add( (nc+1).ToString() );
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool[] v = new bool[Engine.n];//il pune fals automat
            for (int i = 0; i < Engine.n; i++)
                v[i] = false;
            Queue<int> qu = new Queue<int>();
            qu.Enqueue(0);
            BFS(qu, 0, v);

        }
    }
}
