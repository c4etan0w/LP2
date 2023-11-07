using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace PNotas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {
            double[,] notas = new double[2, 10];
            string stringona;
            string[] resultados = { "A", "A", "C", "D", "E", "B", "A", "B", "C", "E" };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    stringona = Interaction.InputBox("Aluno " + (i + 1).ToString() + " Insira o que assinalou na questão " + (j + 1).ToString(), "Entrada de Dados" );
                    stringona = stringona.ToUpper();

                    if (stringona == "A" || stringona == "B" || stringona == "C" || stringona == "D" || stringona == "E")
                    {
                        if (stringona == resultados[j])
                        {
                            lbxNotas.Items.Add("O Aluno " + (i + 1) + " ACERTOU questão " + (j + 1).ToString() + ", Assinalou alternativa " + stringona + " Era " + resultados[j]);
                        }
                        else
                            lbxNotas.Items.Add("O Aluno " + (i + 1) + " ERROU questão " + (j + 1).ToString() + ", Assinalou alternativa " + stringona + " Era " + resultados[j]);
                    }
                    else
                    {
                        MessageBox.Show("INSIRA UMA ALTERNATIVA VÁLIDA!");
                        j--;
                    }

                }
            }
        }
    }
}
        
