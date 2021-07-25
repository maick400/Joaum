using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Joaum2.Data;

namespace Joaum2.Clases
{
    class Categoria
    {
        int Id;
        string nombre;

        public int Id1 { get => Id; set => Id = value; }
        public string Nombre { get => nombre; set => nombre = value; }

        Conexion Conex;


        public DataTable ListarCategorias()
        {
            Conex = new Conexion();
            return Conex.listarAny("ListarCategoria");
        }





    }

   


}
