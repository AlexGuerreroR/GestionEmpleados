

namespace GestionEmpleados.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Data.SqlClient;
    using System.Data;
    using GestionEmpleados.Config;

    internal class EmpleadoModel
    {
        public int empleado_id { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string nombres { get; set; }



        List<EmpleadoModel> listaEmpleados = new List<EmpleadoModel>();
        private Conexion nConexion = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public List<EmpleadoModel> todos() //select * from Empleados
        {
            string cadena = "select nombre, apellido, email, telefono, empleado_id from Empleados";
            SqlDataAdapter adapter = new SqlDataAdapter(cadena, nConexion.AbrirConexion());
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            foreach (DataRow empleado in tabla.Rows)
            {
                EmpleadoModel nEmpleado = new EmpleadoModel
                {
                    empleado_id = Convert.ToInt32(empleado["empleado_id"]),
                    nombre = empleado["nombre"].ToString(),
                    apellido = empleado["apellido"].ToString(),
                    email = empleado["email"].ToString(),
                    telefono = empleado["telefono"].ToString(),
                    nombres = $"{empleado["nombre"]}  {empleado["apellido"]}  {empleado["email"]}  {empleado["telefono"]}"
                };
                listaEmpleados.Add(nEmpleado);
            }

            nConexion.CerrarConexcion();
            return listaEmpleados;
        }

        public EmpleadoModel uno(EmpleadoModel empleado) //select * from Empleados where empleado_id = 1
        {
            string cadena = "select *  from  Empleados where empleado_id =" + empleado.empleado_id;
            cmd = new SqlCommand(cadena, nConexion.AbrirConexion());
            SqlDataReader lector = cmd.ExecuteReader();
            lector.Read();
            EmpleadoModel nEmpleado = new EmpleadoModel
            {
                empleado_id = Convert.ToInt32(lector["empleado_id"]),
                nombre = lector["nombre"].ToString(),
                apellido = lector["apellido"].ToString(),
                email = lector["email"].ToString(),
                telefono = lector["telefono"].ToString()
            };
            nConexion.CerrarConexcion();
            return nEmpleado;
        }


        public string insertar(EmpleadoModel empleado) //insert into Empleados values('nombre','apellido','email','telefono')
        {
            try
            {
                cmd.Connection = nConexion.AbrirConexion();
                cmd.CommandText = "insert into Empleados values('" + empleado.nombre + "','" + empleado.apellido + "','" + empleado.email + "','" + empleado.telefono + "')";
                cmd.ExecuteNonQuery();
                return "Registro insertado";
            }
            catch (Exception ex)
            {

                return "Error al insertar" + ex.Message;
            }
            finally
            {
                nConexion.CerrarConexcion();
            }       

        }

        public string actualizar(EmpleadoModel empleado)//update Empleados set nombre = 'nombre', apellido = 'apellido', email = 'email', telefono = 'telefono' where empleado_id = 1
        {

            try
            {
                cmd.Connection = nConexion.AbrirConexion();
                cmd.CommandText = "update Empleados set nombre = '" + empleado.nombre + "', apellido = '" + empleado.apellido + "', email = '" + empleado.email + "', telefono = '" + empleado.telefono + "' where empleado_id = " + empleado.empleado_id;
                cmd.ExecuteNonQuery();
                return "Registro actualizado";
            }
            catch (Exception ex)
            {

                return "Error al actualizar" + ex.Message;
            }
            finally
            {
                nConexion.CerrarConexcion();
            }
        }


        public string eliminar(EmpleadoModel empleado)//delete from Empleados where empleado_id = 1
        {

            try
            {
                cmd.Connection = nConexion.AbrirConexion();
                cmd.CommandText = "delete from Empleados where empleado_id = " + empleado.empleado_id;
                cmd.ExecuteNonQuery();
                return "ok";
            }
            catch (Exception ex)
            {

                return "Error al eliminar" + ex.Message;
            }
            finally
            {
                nConexion.CerrarConexcion();    


            }



        }
    }
}
