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
    class Pais
    {
        public int Id { get; set; }

        public int Nome { get; set; }


        public DataTable Listar()
{
    SqlDataAdapter daEstadio;

    DataTable dtEstadio = new DataTable();

    try
    {
        daEstadio = new SqlDataAdapter("SELECT * FROM PAIS ORDER BY NOME", frmPrincipal.conexao);
        daEstadio.Fill(dtEstadio);
        daEstadio.FillSchema(dtEstadio, SchemaType.Source);
    }

            catch(Exception)
    {
        throw;
    }
                return dtEstadio;

            





    }

    }

    }