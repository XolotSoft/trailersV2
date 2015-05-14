using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Traileros
{
    class BaseDatos
    {
        private SqlCommand cmd;
        private SqlDataAdapter da;
        public DataSet ds = new DataSet();

        public bool insertar(string sql)
        {
            cmd = new SqlCommand(sql, Conexion.conectar());
            int i = cmd.ExecuteNonQuery();
            Conexion.desconectar();
            if (i > 0) return true; else return false;
        }

        public void buscar(string sql)
        {
            cmd = new SqlCommand(sql, Conexion.conectar());
            da = new SqlDataAdapter(cmd);
            da.Fill(ds);
            Conexion.desconectar();
        }
    }
}
