namespace PTriangulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double A, B, C;

        private void txtLadoA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLadoB_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLadoC_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtLadoA.Clear();
            txtLadoB.Text = "";
            txtLadoC.Text = String.Empty;
            txtLadoA.Focus();
        }

        private async void btnCalcular_Click(object sender, EventArgs e)
        {
            if (Double.TryParse(txtLadoA.Text, out A) && Double.TryParse(txtLadoB.Text, out B) && Double.TryParse(txtLadoC.Text, out C));
            {
                if (A < (B + C) && A > Math.Abs(B - C) && B < (A + C) && B > Math.Abs(A - C) && C < (A + B))
                {
                    if (A == B && B == C)
                    {
                        MessageBox.Show("Triangulo Equilátero");
                    }
                    else if ((A == B && B != C) || (A == C && C != B) || (B == C && C != A))
                    {
                        MessageBox.Show("Triângulo Isóceles");   
                    }
                    else
                    {
                        MessageBox.Show("Triângulo Escaleno");
                                        
                    }
                }
            }
        }
    }
}