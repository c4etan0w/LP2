﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    class Horista : Empregado
    // não posso herdar mais de uma classe. não existe herança múltipla

    {
        public double SalarioHora { get; set; }

        public double NumeroHora { get; set; }

        public int DiasFalta { get; set; }


        public override double SalarioBruto()
        {
            return (SalarioHora * NumeroHora);
        }

        //override significa sobreescrever
        public override int TempoTrabalho()
        {
            //o método retorna um tipo span
            TimeSpan span = DateTime.Today.Subtract(DataEntradaEmpresa);
            return (span.Days - DiasFalta);
        }
    }
}
