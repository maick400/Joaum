using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Data;
    using System.Data.SqlClient;

using Joaum2.Data;
   




namespace Joaum2.Clases
{
    public class Prenda
    {
        private int id;
        private string codigo;
      
        private int genero;
        private int[] Tallastock;
        private decimal precio;
        private int unidad;
        private int tela;
        private int categoria;
        private byte[] imagenes;
        private string material;
        private string[] Colores;
        private string Descripcion;

        public int ID { get { return id; } set { id = value; } }
        public int GENERO { get => genero; set => genero = value; }
        public decimal PRECIO { get => precio; set => precio = value; }
        public int UNIDAD { get => unidad; set => unidad = value; }
        public int TELA { get => tela; set => tela = value; }
        public byte[] IMAGENES { get => imagenes; set => imagenes = value; }
        public int CATEGORIA { get => categoria; set => categoria = value; }
        public string MATERIAL { get => material; set => material = value; }

        public string CODIGO { get { return codigo; } set { codigo = value; } }

        public string[] Colores1 { get => Colores; set => Colores = value; }
        public string Descripcion1 { get => Descripcion; set => Descripcion = value; }
        public int[] Tallastock1 { get => Tallastock; set => Tallastock = value; }

        Conexion conex =new Conexion();

        public DataTable ListarPrendas()
        {
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "listarPrendas0";
            cmd.Parameters.Add("@inNombre", SqlDbType.VarChar, 100); cmd.Parameters[0].Value = "";
            cmd.Parameters.Add("@inCategoria", SqlDbType.VarChar, 100); cmd.Parameters[1].Value = "";
            cmd.Parameters.Add("@inTela", SqlDbType.VarChar, 100); cmd.Parameters[2].Value = "";
            cmd.Parameters.Add("@inGenero", SqlDbType.VarChar, 100); cmd.Parameters[3].Value = "";
            cmd.Parameters.Add("@inTI", SqlDbType.Int); cmd.Parameters[4].Value = 1;
            cmd.Parameters.Add("@inTF", SqlDbType.Int); cmd.Parameters[5].Value = 1;
            return conex.listar(cmd);
        }
















    }
}
