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
    public partial class frmMensalista : Form
    {
        public frmMensalista()
        {
            InitializeComponent();
        }

        private void btnInstanciar1_Click(object sender, EventArgs e)
        {
            //Criar ou instanciar o objeto da classe
            Mensalista objMensalista = new Mensalista();

            //set
            objMensalista.Matricula = Convert.ToInt32(txtMatricula.Text);
            objMensalista.NomeEmpregado = txtNome.Text;
            objMensalista.DataEntradaEmpresa = Convert.ToDateTime(txtDataEntrada.Text);
            objMensalista.SalarioMensal = Convert.ToDouble(txtSalarioMensal.Text);
            if (rbtnSim.Checked)
                objMensalista.HomeOffice = 'S';
            else
                objMensalista.HomeOffice = 'N';

            //get
            MessageBox.Show("Matrícula: " + objMensalista.Matricula + "\n" +
                "Nome: " + objMensalista.NomeEmpregado + "\n" + 
                "Data Entrada: " + objMensalista.DataEntradaEmpresa.ToShortDateString() + "\n" +
                "Salário Bruto: R$" + objMensalista.SalarioBruto().ToString("N2") + "\n" +
                "Tempo Empresa (dias): " + objMensalista.TempoTrabalho() + "\n" + objMensalista.VerificaHome());
        }
    }
}
