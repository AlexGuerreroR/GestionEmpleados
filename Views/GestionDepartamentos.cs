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
    public partial class GestionDepartamentos : Form
    {
        DepartamentosController departamentosController = new DepartamentosController();
        public int codigoDepartamento = 0;
        public GestionDepartamentos()
        {
            InitializeComponent();
        }

        private void GestionDepartamentos_Load(object sender, EventArgs e)
        {
            cargarLista();
        }

        public void cargarLista()
        {
            //lst_Empleados.DataSource = null;
            //lst_Empleados.Items.Clear();
            lst_Departamentos.DataSource = departamentosController.todos();
            lst_Departamentos.DisplayMember = "nombres";
            lst_Departamentos.ValueMember = "departamento_id";

        }

        private void btn_Regresar_Click(object sender, EventArgs e)
        {
           
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            txt_Nombre.Text = "";
            txt_Ubicacion.Text = "";
            txt_JefeDepartamento.Text = "";
            txt_extension.Text = "";
            codigoDepartamento = 0;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string respuesta = "";
            DepartamentosModel departamento = new DepartamentosModel
            {
                departamento_id = codigoDepartamento,
                nombre = txt_Nombre.Text,
                ubicacion = txt_Ubicacion.Text,
                jefe_departamento = txt_JefeDepartamento.Text,
                extension = txt_extension.Text
            };
            try
            {
                if (codigoDepartamento == 0)
                {
                    respuesta = departamentosController.insertar(departamento);
                }
                else
                {
                    respuesta = departamentosController.actualizar(departamento);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            MessageBox.Show("Se guardo con exito");
            codigoDepartamento = 0;
            txt_Nombre.Enabled = false;
            txt_Ubicacion.Enabled = false;
            txt_JefeDepartamento.Enabled = false;
            txt_extension.Enabled = false;
            txt_Nombre.Text = "";
            txt_Ubicacion.Text = "";
            txt_JefeDepartamento.Text = "";
            txt_extension.Text = "";
            cargarLista();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            DepartamentosModel departamentosModel = new DepartamentosModel { departamento_id = codigoDepartamento };
            DialogResult result = MessageBox.Show("Desea Eliminar al Departamento", "Formulario de Gestión de Departamentos", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (departamentosController.eliminar(departamentosModel) == "ok")
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
            txt_Ubicacion.Enabled = true;
            txt_JefeDepartamento.Enabled = true;
            txt_extension.Enabled = true;
            codigoDepartamento = Convert.ToInt16(lst_Departamentos.SelectedValue);
        }

        private void lst_Departamentos_DoubleClick(object sender, EventArgs e)
        {
            // Obtén el objeto seleccionado
            DepartamentosModel departamentoSeleccionado = (DepartamentosModel)lst_Departamentos.SelectedItem;

            // Asigna los valores a los campos de texto
            if (departamentoSeleccionado != null)
            {
                codigoDepartamento = departamentoSeleccionado.departamento_id;
                txt_Nombre.Text = departamentoSeleccionado.nombre;
                txt_Ubicacion.Text = departamentoSeleccionado.ubicacion;
                txt_JefeDepartamento.Text = departamentoSeleccionado.jefe_departamento;
                txt_extension.Text = departamentoSeleccionado.extension;
            }
        }
    }
}
