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
    public class Tela
    {
        Conexion conex;
        SqlCommand cmd;
        int Id;
        string Nombre;


        public int Id1 { get => Id; set => Id = value; }
        public string Nombre1 { get => Nombre; set => Nombre = value; }



        public DataTable ListarTelas()
        {
            conex = new Conexion();
            cmd = new SqlCommand();
            return conex.listarAny("ListarTela");

            

            
        }
    }
}
