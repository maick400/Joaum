using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace Joaum2.Clases
{ 
    
   public  class Colores

    {
        Joaum2.Data.Conexion conexion;
        int id;
        string color;
        string hexDecimal;

        public int Id { get => id; set => id = value; }
        public string COLOR { get => color; set => color = value; }
        public string HexDecimal { get => hexDecimal; set => hexDecimal = value; }

        public DataTable addListado()
        {
            conexion = new Data.Conexion();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "colorPaleta";
            return conexion.listar(cmd);



        }
    }
}
