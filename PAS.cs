using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_11_ejercicio_1
{
    class PAS : Empleado
    {
        private string seccion;
        private string cargo;
        private string tipo = "PAS";

        public PAS() { }

        public string Seccion
        {
            get { return seccion; }
            set { seccion = value; }
        }
        public string Cargo
        {
            get { return cargo; }
            set { cargo = value; }
        }
        public string Tipo { set { tipo = value; } get { return tipo; } }
        public PAS(string seccion, string cargo, string nombre, string apellido, int codigo, string tipo) : base(nombre,apellido,codigo)
        {
            Seccion = seccion;
            Cargo = cargo;
            Tipo = tipo;
        }
        public override void imprimir()
        {
            base.imprimir();
            Console.WriteLine("Seccion: " + Seccion);
            Console.WriteLine("Cargo: " + Cargo);
            Console.WriteLine("Tipo: " + Tipo);
        }
        public override void imprimir_tipo()
        {
            base.imprimir_tipo();
            Console.Write(" -->"+ Tipo);
        }
    }
}
