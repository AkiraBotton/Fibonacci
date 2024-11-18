using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bntSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bntLimpar_Click(object sender, EventArgs e)
        {
            lsbFibonacci.Items.Clear();
        }

        private void bntMostrar_Click(object sender, EventArgs e)
        {
            lsbFibonacci.Items.Clear();

            int n1 = 1, n2 = 1, next;

            lsbFibonacci.Items.Add(n1);
            lsbFibonacci.Items.Add(n2);

            for (int i = 3; i <= 30; i++)
            {
                next = n1 + n2;
                lsbFibonacci.Items.Add(next);
                n1 = n2;
                n2 = next;
            }
        }
    }
}
