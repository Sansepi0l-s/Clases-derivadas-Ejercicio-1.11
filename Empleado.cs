using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_11_ejercicio_1
{
    public class Empleado : Personal
    {
        public Empleado()
        {

        }
        private string nombre;
        private string apellido;
        private int codigo;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public Empleado(string nombre, string apellido, int code)
        {
            Nombre = nombre;
            Apellido = apellido;
            Codigo = code;
        }
        public override void imprimir()
        {
            base.imprimir();
            Console.WriteLine("Nombre: " + Nombre + "\nApellido: " + Apellido + "\nCodigo: " + codigo);
        }
        public override void imprimir_tipo()
        {
            base.imprimir_tipo();
            Console.Write("-->>{0} {1}", Nombre, Apellido);
        }
    }
}
