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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        public string[,] A = new string[3, 3];
        public string[,] B = new string[3, 3];
        public string[,] C = { {"0","0","0" }, { "0", "0", "0" }, { "0", "0", "0" } };

        public Form1(string[,] A, string[,] B,string[,] C)
        {
            InitializeComponent();





            this.A = A;this.B = B;this.C = C;

            AB(A, B,C);
        
        }


        public void button1_Click(object sender, EventArgs e)
        {



            string[,] A = { { tBa00.Text, tBa10.Text, tBa20.Text }, { tBa01.Text, tBa11.Text, tBa21.Text }, { tBa02.Text, tBa12.Text, tBa22.Text } };
            string[,] B = { { tBb00.Text, tBb10.Text, tBb20.Text }, { tBb01.Text, tBb11.Text, tBb21.Text }, { tBb02.Text, tBb12.Text, tBb22.Text } };
            string[,] C = { { "0", "0", "0" }, { "0", "0", "0" }, { "0", "0", "0" } };

        Form2 f2 = new Form2(A,B,C);
            f2.Show();
            Hide();



        }


        public void AB(string[,] A,string[,] B ,string[,] C)
        {
            tBa00.Text = A[0, 0];tBa10.Text = A[0, 1];tBa20.Text = A[0, 2];
            tBa01.Text = A[1, 0];tBa11.Text = A[1, 1];tBa21.Text = A[1, 2];
            tBa02.Text = A[2, 0];tBa12.Text = A[2, 1];tBa22.Text = A[2, 2];

            tBb00.Text = B[0, 0]; tBb10.Text = B[0, 1]; tBb20.Text = B[0, 2];
            tBb01.Text = B[1, 0]; tBb11.Text = B[1, 1]; tBb21.Text = B[1, 2];
            tBb02.Text = B[2, 0]; tBb12.Text = B[2, 1]; tBb22.Text = B[2, 2];

            tBс00.Text = C[0, 0]; tBс10.Text = C[0, 1]; tBс20.Text = C[0, 2];
            tBс01.Text = C[1, 0]; tBс11.Text = C[1, 1]; tBс21.Text = C[1, 2];
            tBс02.Text = C[2, 0]; tBс12.Text = C[2, 1]; tBс22.Text = C[2, 2];
        }

   




    }




}
