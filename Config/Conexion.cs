
namespace GestionEmpleados.Config
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.SqlClient;
    using System.Data;
    using System.Drawing;
   


    internal class Conexion
    {
        private SqlConnection nConexion = new SqlConnection("Server=.; DataBase = GestionEmpleados; User = sa; password = 300809");

        public SqlConnection AbrirConexion()
        {
            if (nConexion.State == ConnectionState.Closed)
                nConexion.Open();
            return nConexion;
        }
        public SqlConnection CerrarConexcion()
        {
            if (nConexion.State == ConnectionState.Open)
                nConexion.Close();
            return nConexion;
        }

    }
}
