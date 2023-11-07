using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Psalario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerifica_Click(object sender, EventArgs e)
        {
            double SalarioLiquido = 0;
            double SalarioBruto = 0;
            double NumeroFilhos = 0;
            double DescontoINSS = 0;
            double DescontoIRPF = 0;
            double SalarioFamilia = 0;

            if (!double.TryParse(mskbxSalBruto.Text, out SalarioBruto)
                || !double.TryParse(nupdFilhos.Text, out NumeroFilhos))
            {
                MessageBox.Show("Salário bruto e número de filhos precisam ser informados.");
            }
            else
            {
                if (SalarioBruto <= 0)
                    MessageBox.Show("Salário bruto deve ser maior do que 0.");

                else
                {
                    //Cálculo do INSS
                    if (SalarioBruto <= 800.47)
                    {
                        mskbxAliINSS.Text = "7,65%";
                        DescontoINSS = 0.0765 * SalarioBruto;
                    }
                    else if (SalarioBruto <= 1050)
                    {
                        mskbxAliINSS.Text = "8,65%";
                        DescontoINSS = 0.0865 * SalarioBruto;
                    }
                    else if (SalarioBruto <= 1400.77)
                    {
                        mskbxAliINSS.Text = "9,00%";
                        DescontoINSS = 0.0900 * SalarioBruto;
                    }
                    else if (SalarioBruto <= 2801.56)
                    {
                        mskbxAliINSS.Text = "11,00%";
                        DescontoINSS = 0.11 * SalarioBruto;
                    }
                    else
                    {
                        mskbxAliINSS.Text = "Teto";
                        DescontoINSS = 308.17;
                    }

                    mskbxDescINSS.Text = DescontoINSS.ToString("N2");

                    //Imposto de Renda

                    if (SalarioBruto <= 1257.12)
                        mskbxAliIRPF.Text = "0";

                    else if (SalarioBruto <= 2512.08)
                    {
                        mskbxAliIRPF.Text = "15%";
                        DescontoIRPF = SalarioBruto * 0.15;
                    }
                    else
                    {
                        mskbxAliIRPF.Text = "27,5%";
                        DescontoIRPF = SalarioBruto * 0.275;
                    }
                    mskbxDescIRPF.Text = DescontoIRPF.ToString("N2");

                    //salario familia
                    if (NumeroFilhos > 0)
                    {

                        if (SalarioBruto <= 435.52)
                            SalarioFamilia = 22.33 * NumeroFilhos;
                        else if (SalarioBruto <= 654.61)
                            SalarioFamilia = 15.74 * NumeroFilhos;
                        else
                            SalarioFamilia = 0;
                    }
                    mskbxsalarioFam.Text = SalarioFamilia.ToString("N2");

                    SalarioLiquido = SalarioBruto + SalarioFamilia - DescontoIRPF - DescontoINSS;

                    mskbxSalarioLiq.Text = SalarioLiquido.ToString("N2");

                  lbldados.Text = "Os descontos do Salário " + (rbtnMasculino.Checked ? "do Sr." : "da Sra.") + txtNomeFunc.Text +
                  " que é " + (rbtnCasado.Checked ? "Casado(a)" : "Solteiro(a)") + "  e que tem " +
                  Convert.ToString(NumeroFilhos) + " filho(s) são:";
                }
            }
        }

        private void txtDescIRPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalFunc_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalLiq_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtINSS_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtIRPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDescINSS_TextChanged(object sender, EventArgs e)
        {

        }

        private void nupdFilhos_ValueChanged(object sender, EventArgs e)
        {

        }

        private void lblINSS_Click(object sender, EventArgs e)
        {

        }
    }
}
