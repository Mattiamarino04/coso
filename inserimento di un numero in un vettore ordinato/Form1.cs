using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inserimento_di_un_numero_in_un_vettore_ordinato
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool inserito = false;
            int n = 100;
            int[] v = new int[] { 2, 5,10, 16, 23, 27, 32, 37, 42, 50 };
            int num = Convert.ToInt32(textBox1.Text);
            int[] v2 = new int[n];

            for (int i = 0; i < v.Length; i++)
            {
                if (v[i] > num)
                {
                    if(inserito==false)
                    {
                        v2[i] = num;
                        inserito = true;
                    }
                    else
                        v2[i+1] = v[i];
                }
                else v2[i] = v[i];
            }
            dataGridView1.RowCount = v2.Length;
            for (int i = 0; i < v.Length; i++)
                dataGridView1.Rows[i].Cells[0].Value = v2[i].ToString();

        }
    }
}
