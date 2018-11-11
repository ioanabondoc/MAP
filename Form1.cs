using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Table[] t = new Table[5];
            for (int i = 0; i < 5; i++)
            {
                t[i] = new Table();
                t[i].type = tableStatus.standby;
                t[i].refresh();
                t[i].Location = new Point(5*i + i * t[i].Width, 10);
                t[i].Parent = this;
            }
            
        }
        

    }
}
