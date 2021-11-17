using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8._0
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public string[,] A = new string[3, 3];
        public string[,] B = new string[3, 3];
        public string[,] C = new string[3, 3];
        public Form2(string [,] A,string [,] B,string[,] C) {
            InitializeComponent();
             this.A = A;
             this.B = B;
             this.C = C;
        }

        private void Skladanie_Click(object sender, EventArgs e)

        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    C[i, j] = Convert.ToString(Convert.ToInt32(A[i, j]) + Convert.ToInt32(B[i, j]));

                }


            }











            Form1 fr = new Form1(A,B,C);
            fr.Show();
            Close();

            fr = null;
        
        }

        private void DobutokMCh_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
               {
                    C[i, j] = Convert.ToString(Convert.ToInt32(A[i, j]) * Convert.ToInt32( Dobutok.Text) );

                }
            }

            Form1 fr = new Form1(A, B, C);
            fr.Show();
            Close();

            fr = null;



        }

        private void Vidnim_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    C[i, j] = Convert.ToString(Convert.ToInt32(A[i, j]) - Convert.ToInt32(B[i, j]));

                }
            }


            Form1 fr = new Form1( A, B, C);
            fr.Show();
            Close();

            fr = null;


        }

        private void DobutokMM_Click(object sender, EventArgs e)
        {

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    C[i, j] = Convert.ToString(Convert.ToInt32(A[i, j]) * Convert.ToInt32(B[i, j]));

                }
            }


            Form1 fr = new Form1(A, B, C);
            fr.Show();
            Close();

            fr = null;




        }
    }
}
