using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace PCopa0030482211042
{
    class Estadio
    {
        public int Id { get; set; }

        public int Nome { get; set; }


        public DataTable Listar()
        {
            SqlDataAdapter daPais;

            DataTable dtPais = new DataTable();

            try
            {
                daPais = new SqlDataAdapter("SELECT * FROM ESTADIO ORDER BY NOME", frmPrincipal.conexao);
                daPais.Fill(dtPais);
                daPais.FillSchema(dtPais, SchemaType.Source);
            }

            catch (Exception)
            {
                throw;
            }
            return dtPais;

        }
    }
}
