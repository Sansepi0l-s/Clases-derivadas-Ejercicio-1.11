using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_11_ejercicio_1
{
    public class PDI : Empleado
    {
        private string area;
        private string departamento;
        private string tipo = "PDI";
        public PDI()
        {

        }
        public PDI(string area, string departamento, string nombre, string apellido, int codigo, string tipo) : base(nombre,apellido,codigo)
        {
            this.area = area;
            this.departamento = departamento;
            this.tipo = tipo;
        }
        public string Departamento
        {
            get { return departamento; }
            set { departamento = value; }
        }
        public string Area
        {
            get { return area; }
            set { area = value; }
        }
        public string Tipo { set { tipo = value; } get { return tipo; } }
        public override void imprimir()
        {
            base.imprimir();
            Console.WriteLine("Departamento: " + Departamento + "\nArea: " + Area 
                +"\nTipo: "+Tipo);
        }
        public override void imprimir_tipo()
        {
            base.imprimir_tipo();
            Console.Write(" -->" + Tipo);
        }
    }
}
