using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PClasses
{
    public partial class frmHorista : Form
    {
        public frmHorista()
        {
            InitializeComponent();
        }

        private void btnInstanciar_Click(object sender, EventArgs e)
        {
            //instanciando o objeto na classe horista
            Horista objHorista = new Horista();

            //set
            objHorista.NomeEmpregado = txtNome.Text;
            objHorista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objHorista.SalarioHora = Convert.ToDouble(txtSalarioHora.Text);
            objHorista.NumeroHora = Convert.ToDouble(txtNumeroHoras.Text);
            objHorista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntrada.Text);
            objHorista.DiasFalta = Convert.ToInt32(txtFaltas.Text);

            //get
            MessageBox.Show("Matrícula: " + objHorista.Matricula + "\n" +
                "Nome: " + objHorista.NomeEmpregado + "\n" +
                "Data Entrada: " + objHorista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                "Salário Bruto: R$" + objHorista.SalarioBruto().ToString("N2") + "\n" +
                "Tempo Empresa (dias): " + objHorista.TempoTrabalho() + "\n" + objHorista.VerificaHome());

        }
    }
}
