using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
       
        public Form1()
        {
            InitializeComponent();
        }

        List<string> numbers = new List<string>();
        List<string> aux = new List<string>();

        int opSoma = 0;
        int opSub = 0;
        int opMult = 0;
        int opDiv = 0;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            string n = btn1.Text;
            numbers.Add(n);
            lblVisor.Text += n.ToString();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string n = btn2.Text;
            numbers.Add(n);
            lblVisor.Text += n.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string n = btn3.Text;
            numbers.Add(n);
            lblVisor.Text += n.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string n = btn4.Text;
            numbers.Add(n);
            lblVisor.Text += n.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            string n = btn5.Text;
            numbers.Add(n);
            lblVisor.Text += n.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            string n = btn6.Text;
            numbers.Add(n);
            lblVisor.Text += n.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            string n = btn7.Text;
            numbers.Add(n);
            lblVisor.Text += n.ToString();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            string n = btn8.Text;
            numbers.Add(n);
            lblVisor.Text += n.ToString();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            string n = btn9.Text;
            numbers.Add(n);
            lblVisor.Text += n.ToString();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            string n = btn0.Text;
            numbers.Add(n);
            lblVisor.Text += n.ToString();
        }

        private void btnE_Click(object sender, EventArgs e)
        {

            if(opSoma == 1)
            {
                string n1 = "";

                foreach (var i in aux)
                {
                    n1 += i.ToString();
                }

                string n2 = "";

                foreach(var i in numbers)
                {
                    n2 += i.ToString();
                }

                double dn1 = double.Parse(n1);
                double dn2 = double.Parse(n2);
                double soma = dn1 + dn2;

                lblVisor.Text = soma.ToString();
            }

            if (opDiv == 1)
            {
                string n1 = "";

                foreach (var i in aux)
                {
                    n1 += i.ToString();
                }

                string n2 = "";

                foreach (var i in numbers)
                {
                    n2 += i.ToString();
                }

                double dn1 = double.Parse(n1);
                double dn2 = double.Parse(n2);
                double result = dn1 / dn2;

                lblVisor.Text = result.ToString();
            }

            if (opMult == 1)
            {
                string n1 = "";

                foreach (var i in aux)
                {
                    n1 += i.ToString();
                }

                string n2 = "";

                foreach (var i in numbers)
                {
                    n2 += i.ToString();
                }

                double dn1 = double.Parse(n1);
                double dn2 = double.Parse(n2);
                double result = dn1 * dn2;

                lblVisor.Text = result.ToString();
            }

            if (opSub == 1)
            {
                string n1 = "";

                foreach (var i in aux)
                {
                    n1 += i.ToString();
                }

                string n2 = "";

                foreach (var i in numbers)
                {
                    n2 += i.ToString();
                }

                double dn1 = double.Parse(n1);
                double dn2 = double.Parse(n2);
                double result = dn1 - dn2;

                lblVisor.Text = result.ToString();
            }


        }

        private void btnAc_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            aux.Clear();

            
            
            opDiv = 0;
            opMult = 0;
            opSub = 0;
            opSoma = 0;

            lblVisor.Text = ""; 
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            opDiv++;

            lblVisor.Text = "";

            foreach (string num in numbers)
            {
                aux.Add(num);
            }

            numbers.Clear();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            opMult++;

            lblVisor.Text = "";

            foreach (string num in numbers)
            {
                aux.Add(num);
            }

            numbers.Clear();
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            opSub++;

            lblVisor.Text = "";

            foreach (string num in numbers)
            {
                aux.Add(num);
            }

            numbers.Clear();
        }

        private void btnSun_Click(object sender, EventArgs e)
        {
            opSoma++;

            lblVisor.Text = "";

            foreach (string num in numbers)
            {
                aux.Add(num);
            }

            numbers.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
