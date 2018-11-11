using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public enum tableStatus { standby, cliented, commanded };
    public partial class Table : UserControl
    {
        public tableStatus type;
        public int nrc;
        public int val;
        public Table()
        {
            InitializeComponent();
            type = tableStatus.standby;
        }
        public void refresh()
        {
           
           // Form1.label1.Text = Engine.totalValue.ToString(); ??
            switch (type)
            {
                case tableStatus.standby:
                    {
                        this.BackColor = Color.Green;
                        nrc = 0;
                        val = 0;
                        button1.Enabled = true;
                        button2.Enabled = false;
                        button3.Enabled = false;
                        label1.Visible = false;
                        label2.Visible = false;
                  
                    }
                    break;
                case tableStatus.cliented:
                    {
                        this.BackColor = Color.Orange;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = false;
                        label1.Visible = true;
                        label2.Visible = false;
                        label1.Text = nrc.ToString();
                    }
                    break;
                case tableStatus.commanded:
                    {
                        this.BackColor = Color.Red;
                        button1.Enabled = true;
                        button2.Enabled = true;
                        button3.Enabled = true;
                        label1.Visible = true;
                        label2.Visible = true;
                        label1.Text = nrc.ToString();
                        label2.Text = val.ToString();
                    }
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(type==tableStatus.standby)
                this.type = tableStatus.cliented;
            nrc++;
            refresh();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            type = tableStatus.commanded;
            val += 20;
            refresh();
        }

        private void Table_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Engine.totalValue += val;
            val = 0;
            type = tableStatus.standby;
            refresh();
        }
    }
   

}
