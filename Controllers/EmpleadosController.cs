

namespace GestionEmpleados.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using GestionEmpleados.Models;


    internal class EmpleadosController
    {
        private EmpleadoModel modelEmpleado = new EmpleadoModel();

        public List<EmpleadoModel> todos()
        {
            return modelEmpleado.todos();
        }
        
        public EmpleadoModel uno(EmpleadoModel empleado)
        {
            return modelEmpleado.uno(empleado);
        }

        public String  insertar(EmpleadoModel empleado)
        {
            return modelEmpleado.insertar(empleado);
        }

        public String actualizar(EmpleadoModel empleado)
        {
            return modelEmpleado.actualizar(empleado);
        }

        public String eliminar(EmpleadoModel empleado)
        {
            return modelEmpleado.eliminar(empleado);
        }

    }
}
