
using System.Windows.Forms;

namespace FormComplejosG2_2024
{
    public partial class Form1 : Form
    {
        Complejo c1;
        Complejo c2;
        Complejo c3;

        public Form1()
        {
            InitializeComponent();
        }


        private void btnSuma_Click(object sender, System.EventArgs e)
        {
            c1 = new Complejo(float.Parse(txtbReal1.Text), float.Parse(txtbImaginario1.Text));
            c2 = new Complejo(float.Parse(txtbReal2.Text), float.Parse(txtbImaginario2.Text));
            c3 = c1 + c2;
            lbSuma.Text = c3.ToString();
            lbSigno.Text = "+";

        }

        private void btnMultiplicar_Click(object sender, System.EventArgs e)
        {
            c1 = new Complejo(float.Parse(txtbReal1.Text), float.Parse(txtbImaginario1.Text));
            c2 = new Complejo(float.Parse(txtbReal2.Text), float.Parse(txtbImaginario2.Text));
            c3= c1 * c2;
            lbSuma.Text = c3.ToString();
            lbSigno.Text = "x";
        }

        private void btnConjugar_Click(object sender, System.EventArgs e)
        {
            lbSuma.Text = (~c3).ToString();
        }

        private void btnRestar_Click(object sender, System.EventArgs e)
        {
            c1 = new Complejo(float.Parse(txtbReal1.Text), float.Parse(txtbImaginario1.Text));
            c2 = new Complejo(float.Parse(txtbReal2.Text), float.Parse(txtbImaginario2.Text));
            c3 = c1 - c2;
            lbSuma.Text = c3.ToString();
            lbSigno.Text = "-";
        }
    }
}
