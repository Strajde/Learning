using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kalkulator_graf
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(liczba_1.Text);
            b = double.Parse(liczba_2.Text);
            double c = a * b;
            wynik.Text = c.ToString();
            label1.Text = "*";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dodawanie_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(liczba_1.Text);
            b = double.Parse(liczba_2.Text);
            double c = a + b;
            wynik.Text = c.ToString();
            label1.Text = "+";
        }

        private void odejmowanie_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(liczba_1.Text);
            b = double.Parse(liczba_2.Text);
            double c = a - b;
            wynik.Text = c.ToString();
            label1.Text = "-";
        }

        private void dzielenie_Click(object sender, EventArgs e)
        {
            double a, b;
            a = double.Parse(liczba_1.Text);
            b = double.Parse(liczba_2.Text);
            if (b == 0)
            {
                MessageBox.Show("Próba dzielenia przez 0 \n Wprowadź prawidłowe dane", "BŁĄD", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                wynik.Text = "";
                label1.Text = "";
            }
            else
            {
                double c = a / b;
                wynik.Text = c.ToString();
                label1.Text = "/";
            }
        }

        private void liczba_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void liczba_2_TextChanged(object sender, EventArgs e)
        {

        }

        private void wynik_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
