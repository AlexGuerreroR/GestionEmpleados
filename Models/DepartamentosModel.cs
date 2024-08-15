using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using GestionEmpleados.Config;


namespace GestionEmpleados.Models
{
    internal class DepartamentosModel
    {
        public int departamento_id { get; set; }
        public string nombre { get; set; }
        public string ubicacion { get; set; }
        public String jefe_departamento{ get; set; }
        public string extension { get; set; }

        public string nombres { get; set; }



        List<DepartamentosModel> listaDepartamentos = new List<DepartamentosModel>();
        private Conexion nConexion = new Conexion();
        SqlCommand cmd = new SqlCommand();

        public List<DepartamentosModel> todos() //select * from Departamentos
        {
            string cadena = "select nombre, ubicacion, jefe_departamento, extension, departamento_id from Departamentos";
            SqlDataAdapter adapter = new SqlDataAdapter(cadena, nConexion.AbrirConexion());
            DataTable tabla = new DataTable();
            adapter.Fill(tabla);
            foreach (DataRow departamento in tabla.Rows)
            {
                DepartamentosModel ndepartamento = new DepartamentosModel
                {
                    departamento_id = Convert.ToInt32(departamento["departamento_id"]),
                    nombre = departamento["nombre"].ToString(),
                    ubicacion = departamento["ubicacion"].ToString(),
                    jefe_departamento = departamento["jefe_departamento"].ToString(),
                    extension = departamento["extension"].ToString(),
                    nombres = $"{departamento["nombre"]}  {departamento["ubicacion"]}  {departamento["jefe_departamento"]}  {departamento["extension"]}"
                };
                listaDepartamentos.Add(ndepartamento);
            }

            nConexion.CerrarConexcion();
            return listaDepartamentos;
        }

        public DepartamentosModel uno(DepartamentosModel departamento) //select * from Departamento where departamento_id
        {
            string cadena = "select *  from  Departamentos where departamento_id =" + departamento.departamento_id;
            cmd = new SqlCommand(cadena, nConexion.AbrirConexion());
            SqlDataReader lector = cmd.ExecuteReader();
            lector.Read();
            DepartamentosModel ndepartamento = new DepartamentosModel
            {
                departamento_id = Convert.ToInt32(lector["departamento_id"]),
                nombre = lector["nombre"].ToString(),
                ubicacion = lector["ubicacion"].ToString(),
                jefe_departamento = lector["jefe_departamento"].ToString(),
                extension = lector["extension"].ToString()
            };
            nConexion.CerrarConexcion();
            return ndepartamento;
        }


      

        public string insertar(DepartamentosModel departamento) 
        {
            try
            {
                cmd.Connection = nConexion.AbrirConexion();
                cmd.CommandText = "insert into Departamentos values('" + departamento.nombre + "','" + departamento.ubicacion + "','" + departamento.jefe_departamento + "','" + departamento.extension + "')";
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

        public string actualizar(DepartamentosModel departamento)
        {

            try
            {
                cmd.Connection = nConexion.AbrirConexion();
                cmd.CommandText = "update Departamentos set nombre = '" + departamento.nombre + "', ubicacion = '" + departamento.ubicacion + "', jefe_departamento = '" + departamento.jefe_departamento + "', extension  = '" + departamento.extension  + "' where departamento_id = " + departamento.departamento_id;
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


        public string eliminar(DepartamentosModel departamento)
        {

            try
            {
                cmd.Connection = nConexion.AbrirConexion();
                cmd.CommandText = "delete from Departamentos where departamento_id = " + departamento.departamento_id;
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
