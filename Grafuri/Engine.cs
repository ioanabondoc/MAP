using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Grafuri
{
    public static class Engine
    {
        public static int[,] ma;
        public static int n;

        public static void Load()
        {
            TextReader dL = new StreamReader(@"..\..\Graph.in");
            n = int.Parse(dL.ReadLine());
            //MessageBox.Show(n.ToString());
            ma = new int[n, n];
            string buffer;
            int x, y;
            while ((buffer = dL.ReadLine()) != null)
            {
                x = int.Parse(buffer.Split(' ')[0]);
                y = int.Parse(buffer.Split(' ')[1]);
                //MessageBox.Show(x.ToString()+" " +y.ToString());
                ma[x - 1, y - 1] = ma[y - 1, x - 1] = 1;
            }

        }
    }

}
