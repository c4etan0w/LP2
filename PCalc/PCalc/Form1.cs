namespace PCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtResultado_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (double.Parse(txtNum1.Text) + double.Parse(txtNum2.Text)).ToString();
        }

        private void btnSubtrai_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (double.Parse(txtNum1.Text) - double.Parse(txtNum2.Text)).ToString();
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            txtResultado.Text = (double.Parse(txtNum1.Text) * double.Parse(txtNum2.Text)).ToString();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            Double Num1, Num2, resultado;

            if (Double.TryParse(txtNum1.Text, out Num1) && Double.TryParse(txtNum2.Text, out Num2))
            {
                if (Num2 != 0) 
                {
                    resultado = Num1 / Num2;
                    txtResultado.Text = resultado.ToString("N");
                }
                else
                {
                    MessageBox.Show("Não divida por Zero");
                    txtNum2.Focus();

                }
            }
            else
            {
                MessageBox.Show("Insira apenas números");
                txtNum1.Focus();
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpar os dados
            txtNum1.Clear();
            txtNum2.Text = "";
            txtResultado.Text = String.Empty;

            txtNum1.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}