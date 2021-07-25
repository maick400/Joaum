using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using System.Data.SqlClient;
using System.Data;


namespace Joaum2.Data
{
    public class Conexion
    {

      private  SqlConnection cn = new SqlConnection("Data Source=SQL5050.site4now.net;Initial Catalog=db_a77d2a_joaum;User Id=db_a77d2a_joaum_admin;Password=4006381172806Mm.");
        SqlCommand cmd;

    public DataTable listar(SqlCommand cmd)
        {
            cn.Open();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = cn;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            return dt;



        }

  

        public DataTable listarAny(string name)
        {
            cn.Open();
            cmd = new SqlCommand();
            cmd.Connection = cn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = name;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            cn.Close();
            return dt;
           
            
        }

    }


}
