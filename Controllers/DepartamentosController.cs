using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GestionEmpleados.Models;


namespace GestionEmpleados.Controllers
{
    internal class DepartamentosController
    {
        private DepartamentosModel departamentosModel = new DepartamentosModel();

        public List<DepartamentosModel> todos()
        {
            return departamentosModel.todos();
        }

        public DepartamentosModel uno(DepartamentosModel departamento)
        {
            return departamentosModel.uno(departamento);
        }

        public string insertar(DepartamentosModel departamento)
        {
            return departamentosModel.insertar(departamento);
        }

        public string actualizar(DepartamentosModel departamento)
        {
            return departamentosModel.actualizar(departamento);
        }

        public string eliminar(DepartamentosModel departamento)
        {
            return departamentosModel.eliminar(departamento);
        }

    }
}
