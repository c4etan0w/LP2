namespace PImc
{
    public partial class Form1 : Form
    {

        double peso, altura, imc;
        public Form1()
        {
            InitializeComponent();
        }

        private void lblPeso_Click(object sender, EventArgs e)
        {

        }

        private void lblAltura_Click(object sender, EventArgs e)
        {

        }

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtAltura.Text, out altura) &&
                Double.TryParse(txtPeso.Text, out peso))
            {
                if ((altura <= 0) || (peso <= 0))
                    MessageBox.Show("Valores tem que ser maiores do que Zero");
                else
                {
                    imc = peso / Math.Pow(altura, 2);

                    imc = Math.Round(imc, 1); //arredonda

                    txtIMC.Text = imc.ToString("N1");

                    if (imc < 18.5)
                        MessageBox.Show("Magreza");
                    else if (imc <= 24.9)
                        MessageBox.Show("Normal");
                    else if (imc <= 29.9)
                        MessageBox.Show("Sobrepeso");
                    else if (imc <= 39.9)
                        MessageBox.Show("Obesidade");
                    else
                        MessageBox.Show("Obesidade Grave");
                }
            }
            else
                MessageBox.Show("Valores Inválidos");
        }

        private void txtIMC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtAltura.Clear();
            txtPeso.Text = "";
            txtIMC.Text = String.Empty;
            txtPeso.Focus();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}