using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_11_ejercicio_1
{
    public class Personal
    {
        private List<Personal> Lista_de_Empleados;
        public Personal() 
        {
            Lista_de_Empleados = new List<Personal>();
        }
        public List<Personal> lista_de_empleados
        {
            get { return Lista_de_Empleados; }
            set { lista_de_empleados = value; }
        }

        public virtual void imprimir() { }
        public virtual void imprimir_tipo() { }
    }
}
