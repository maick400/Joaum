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
    class Material
    {
        Conexion conexion;
        int id;
        string material;

        public string MATERIAL { get => material; set => material = value; }
        public int ID { get => id; set => id = value; }



        public DataTable Listar()
        {
            conexion = new Conexion();
            return conexion.listarAny("ListarMaterial");

        }


    }
}
