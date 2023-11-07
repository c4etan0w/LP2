using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Pmatrizes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLer1_Click(object sender, EventArgs e)
        {
            int[] vetor = new int[20];
            string aux;
            for (int i = 0; i < 20; i++)
            {
                aux = Interaction.InputBox("Digite Número", "Entrada de Dados");
                if (!Int32.TryParse(aux, out vetor[i]))
                {
                    MessageBox.Show("Dado Inválido");
                    i--;
                }
            }
                aux = "";
                for (var i=19; i >=0; i--)
            {
                aux = aux + vetor [i] + "\n";
            }
            MessageBox.Show(aux);
            
            }

        private void btnMedia_Click(object sender, EventArgs e)
        {
            double[,] Notas = new double[20, 3];
            double media = 0;
            string stringona;

            for (int i = 0; i < 20; i++)
                for (int j = 0; j < 3; j++)
                {
                    stringona = Interaction.InputBox("Digite a nota " + (j + 1) + " do aluno " + (i + 1), "Entrada de Dados");

                    if (! double.TryParse(stringona, out Notas[i,j]))
                    {
                        MessageBox.Show("Nota Inválida \nDigite Novamente");
                        i--;
                    }
                    else
                    {
                        if (!(Notas[i, j] >= 0) && (Notas[i, j] <= 10))
                        {
                            MessageBox.Show("Nota Inválida \nDigite Novamente");
                            j--;
                        }
                        else
                        {
                            media = (Notas[i,0] + Notas[i,1] + Notas[i,2]) / 3;
                            MessageBox.Show("Aluno " + (i + 1) + " Média: " + media.ToString("N2"));
                        }
                    }
                }
        }

        private void btnLer2_Click(object sender, EventArgs e)
        {
            double faturamento = 0;
            double[] qtd = new double[10];
            double[] vlr = new double[10];
            string auxiliar = " ";
            for (var i = 0; i < 10; i++)
            {
                auxiliar = Interaction.InputBox("Digite quantidade " + (i + 1), "Entrada de Quantidades");
                if (!Double.TryParse(auxiliar, out qtd[i]))
                {
                    MessageBox.Show("Quantidade inválida");
                    i--;
                }
                else
                {
                    while (vlr[i] <= 0)
                    {
                        auxiliar = " ";
                        auxiliar = Interaction.InputBox("Digite o valor da mercadoria " + (i + 1), "Entrada de Preços");
                        if (!Double.TryParse(auxiliar, out vlr[i]))
                        {
                            MessageBox.Show("Preço inválido");
                        }
                    }
                    faturamento += qtd[1] * vlr[1];
                   
                    {
                        MessageBox.Show(faturamento.ToString("N2"));
                    }
                }
            }
        }

        private void btnVariavel_Click(object sender, EventArgs e)
        {
            string[] Alunos = {"Viviane", "André", "Hélio", "Denise", "Junior", "Leonardo", "Jose", "Nelma", "Tobby" };
            Int32 I, Total = 0;
            Int32 N = Alunos.Length;
            for (I = 0; I < N - 1; I++)
            {
                Total += Alunos[I].Length;
                MessageBox.Show(Total.ToString("N2"));
            }
        }

        private void btnArray_Click(object sender, EventArgs e)
        {
            List<string> Nomes = new List<string>()
            {"Ana", "André", "Débora", "Fátima", "João", "Janete", "Otávio", "Marcelo", "Pedro", "Thais"};

            Nomes.Remove("Otávio");

            for (int i = 0; i < Nomes.Count; i++)
            {
                MessageBox.Show(Nomes[i]);
            }
        }
        private void btnNPessoas_Click(object sender, EventArgs e)
        {
            double valid = 0;
            string RaEsc;
            int Ra;

            RaEsc = Interaction.InputBox("Digite o seu RA ", "Entrada de dados");

            if (double.TryParse(RaEsc, out valid))
            {
                RaEsc = RaEsc.Substring(RaEsc.Length - 1, 1);
            }
            else
            {
                MessageBox.Show("RA inválido!");
            }
            int.TryParse(RaEsc, out Ra);

            if (Ra == 0)
            {
                Ra = 10;
            }
            string[] nomes = new string[Ra];
            string[] auxiliar = new string[Ra];
            int[] compr = new int[Ra];

            for (var i = 0; i < Ra; i++)
            {
                nomes[i] = Interaction.InputBox("Digite o nome completo " + (i + 1), "Entrada de dados");
                if (double.TryParse(nomes[i], out valid))
                {
                    MessageBox.Show("Somente Letras!");
                    i--;
                }
                else
                {
                    auxiliar[i] = nomes[i].Replace(" ", "");
                    compr[i] = auxiliar[i].Length;
                    MessageBox.Show("O nome: " + nomes[i] + " tem " + compr[i] + " caracteres");
                }
            }
        }
    }
}
