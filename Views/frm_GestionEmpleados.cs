using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionEmpleados.Controllers;
using GestionEmpleados.Models;
using GestionEmpleados.Views;

namespace GestionEmpleados.Views
{
    
    public partial class frm_GestionEmpleados : Form
    {
        EmpleadosController empleadosController = new EmpleadosController();
        public int codigoEmpleado = 0;
        public frm_GestionEmpleados()
        {
            InitializeComponent();
        }
      


        private void frm_GestionEmpleados_Load(object sender, EventArgs e)
        {
            cargarLista();
        }

        public void cargarLista()
        {
            //lst_Empleados.DataSource = null;
            //lst_Empleados.Items.Clear();
            lst_Empleados.DataSource = empleadosController.todos();
            lst_Empleados.DisplayMember = "nombres";
            lst_Empleados.ValueMember = "empleado_id";
           
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {

            txt_Nombre.Text = "";
            txt_Apellido.Text = "";
            txt_Correo.Text = "";
            txt_Telefono.Text = "";
            codigoEmpleado = 0;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            EmpleadoModel empleado = new EmpleadoModel
            {
                empleado_id = codigoEmpleado,
                nombre = txt_Nombre.Text,
                apellido = txt_Apellido.Text,
                email = txt_Correo.Text,
                telefono = txt_Telefono.Text
            };
            try
            {
                if (codigoEmpleado == 0)
                {
                    respuesta = empleadosController.insertar(empleado);
                }
                else
                {
                    respuesta = empleadosController.actualizar(empleado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Se guardo con exito");
            codigoEmpleado = 0;
            txt_Nombre.Enabled = false;
            txt_Apellido.Enabled = false;
            txt_Telefono.Enabled = false;
            txt_Correo.Enabled = false;
            txt_Nombre.Text = "";
            txt_Apellido.Text = "";
            txt_Correo.Text = "";
            txt_Telefono.Text = "";
            cargarLista();


        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            EmpleadoModel empleadoModel = new EmpleadoModel { empleado_id = codigoEmpleado };
            DialogResult result = MessageBox.Show("Desea Eliminar al Empleado", "Formulario de Gestión de Empleados", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (empleadosController.eliminar(empleadoModel) == "ok")
                {
                    MessageBox.Show("Se elimino con exito");
                }
                else
                {
                    MessageBox.Show("Ocurrio un error al eliminar");
                }
            }
            else
            {
                MessageBox.Show("El usuario cancelo la eliminacion");

            }
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            txt_Nombre.Enabled = true;
            txt_Apellido.Enabled = true;
            txt_Telefono.Enabled = true;
            txt_Correo.Enabled = true;
            codigoEmpleado = Convert.ToInt16(lst_Empleados.SelectedValue);
        }

        private void lst_Empleados_DoubleClick(object sender, EventArgs e)
        {
            // Obtén el objeto seleccionado
            EmpleadoModel empleadoSeleccionado = (EmpleadoModel)lst_Empleados.SelectedItem;

            // Asigna los valores a los campos de texto
            if (empleadoSeleccionado != null)
            {
                codigoEmpleado = empleadoSeleccionado.empleado_id;
                txt_Nombre.Text = empleadoSeleccionado.nombre;
                txt_Apellido.Text = empleadoSeleccionado.apellido;
                txt_Correo.Text = empleadoSeleccionado.email;
                txt_Telefono.Text = empleadoSeleccionado.telefono;
            }
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GestionDepartamentos gestionDepartamentos = new GestionDepartamentos();
            gestionDepartamentos.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
    
}
