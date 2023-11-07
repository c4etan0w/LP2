using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PClasses
{
    class Mensalista : Empregado // especialização --> herança
    {
        //prop + 2 tab's --> cria a estrutura da propriedade
       
        public Double SalarioMensal { get; set; }



        //sobrescrevendo o método
        public override double SalarioBruto()
        {
            return SalarioMensal;
        }


    }
}
