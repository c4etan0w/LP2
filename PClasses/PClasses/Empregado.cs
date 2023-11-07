using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    abstract class Empregado
    {
        private int matricula; // atributo
        private string nomeEmpregado;
        private DateTime dataEntradaEmpresa;
        private char homeOffice;

        public int Matricula // propriedade
        {
            get { return matricula; }
            set { matricula = value; }
        }

        public String NomeEmpregado // propriedade
        {
            get { return nomeEmpregado; }
            set { nomeEmpregado = value; }
        }

        public DateTime DataEntradaEmpresa // propriedade
        {
            get { return dataEntradaEmpresa; }
            set { dataEntradaEmpresa = value; }
        }

        public Char HomeOffice // propriedade
        {
            get { return homeOffice; }
            set { homeOffice = value; }
        }

        // método sao ações/comportamentos
        public String VerificaHome() //método
        {
            if (homeOffice == 'S')
                return "Empregado trabalha em Home Office";
            else
                return "Empregado *NÃO* trabalha em Home Office";
        }
        //virtual --> pode ser sobrescrito

        public virtual int TempoTrabalho()
        {
            //representa um intervalo de tempo
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
             
            return (span.Days);
        }

        // deve ser implementado
        // Derived classes must implement this.

        public abstract double SalarioBruto(); // não preciso implementar


        public Empregado() // CONSTRUTOR --> NEW
        {


        }

    }

}
