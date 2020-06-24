using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_11_ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Personal Personal = new Personal();
            int opc;
            do
            {
                Console.WriteLine("--1--Contratar PAS/PDI.");
                Console.WriteLine("--2--Jubilar PAS/PDI.");
                Console.WriteLine("--3--Modificar datos de un PAS/PDI.");
                Console.WriteLine("--4--Mostrar los datos de los PAS/PDI.");
                Console.WriteLine("--5--Generar la nómina de todo el personal.");
                Console.WriteLine("--6--Salir");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 1:
                        int opcion = 0;
                        do
                        {
                            Console.WriteLine("Ingrese el tipo de Empleado: ");
                            Console.WriteLine("--1--PAS");
                            Console.WriteLine("--2--PDI");
                            Console.WriteLine("--3--Salir de la seccion de ingreso--");
                            opcion = int.Parse(Console.ReadLine());
                            switch (opcion)
                            {
                                case 1:
                                    Console.Clear();
                                    PAS EmpleadoPas = new PAS();
                                    Console.WriteLine("--> PAS <--");
                                    Console.Write("Nombre: ");
                                    EmpleadoPas.Nombre = Console.ReadLine();
                                    Console.Write("Apellido: ");
                                    EmpleadoPas.Apellido = Console.ReadLine();
                                    Console.Write("Codigo: ");
                                    EmpleadoPas.Codigo = int.Parse(Console.ReadLine());
                                    Console.Write("Seccion: ");
                                    EmpleadoPas.Seccion = Console.ReadLine();
                                    Console.Write("Cargo: ");
                                    EmpleadoPas.Cargo = Console.ReadLine();
                                    Personal.lista_de_empleados.Add(EmpleadoPas);
                                    Console.WriteLine("--Empleado PAS agregado--");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 2:
                                    Console.Clear();
                                    PDI Empleadopdi = new PDI();
                                    Console.WriteLine("--> PDI <--");
                                    Console.Write("Nombre: ");
                                    Empleadopdi.Nombre = Console.ReadLine();
                                    Console.Write("Apellido: ");
                                    Empleadopdi.Apellido = Console.ReadLine();
                                    Console.Write("Codigo: ");
                                    Empleadopdi.Codigo = int.Parse(Console.ReadLine());
                                    Console.Write("Departamento: ");
                                    Empleadopdi.Departamento = Console.ReadLine();
                                    Console.Write("Area: ");
                                    Empleadopdi.Area = Console.ReadLine();
                                    Personal.lista_de_empleados.Add(Empleadopdi);
                                    Console.WriteLine("--Empleado PDI agregado--");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 3:
                                    Console.WriteLine("-->Salido");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Opcion invalida");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        } while (opcion != 3);
                        break;
                    case 2:   
                        int opcion2 = 0;
                        do
                        {
                            Console.WriteLine("Ingrese el tipo de Empleado que desea Jubilar: ");
                            Console.WriteLine("--1--PAS");
                            Console.WriteLine("--2--PDI");
                            Console.WriteLine("--3--Salir de la seccion de Jubilación--");
                            opcion2 = int.Parse(Console.ReadLine());
                            switch (opcion2)
                            {
                                case 1:
                                    Console.Clear();
                                    bool valid = false;
                                    string nomb;
                                    Console.WriteLine("--Empleados de tipo PAS--\n");
                                    foreach (Personal EmpleadoActual in Personal.lista_de_empleados)
                                    {
                                        if (EmpleadoActual is PAS)
                                        {
                                            PAS empleadPAS = (PAS)EmpleadoActual;
                                            empleadPAS.imprimir_tipo();
                                            Console.WriteLine();
                                            valid = true;
                                        }
                                    }
                                    if (valid == false)
                                    {
                                        Console.WriteLine("-->No existen empleados de tipo PAS");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    }
                                    Console.WriteLine("\n\nIngrese el nombre del empleado PAS que desea jubilar: ");
                                    nomb = Console.ReadLine();
                                    foreach(Personal EmpleadoAc in Personal.lista_de_empleados)
                                    {
                                        if (EmpleadoAc is PAS)
                                        {
                                            PAS empleadpas = (PAS)EmpleadoAc;
                                            if (empleadpas.Nombre == nomb)
                                            {
                                                Personal.lista_de_empleados.Remove(empleadpas);
                                                Console.WriteLine("-->Empleado Jubilado");
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("-->Este Nombre no existe en los empledos de tipo PAS");
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;
                                            }
                                        }
                                    }

                                    break;
                                case 2:
                                    Console.Clear();
                                    bool valid2 = false;
                                    string nomb2;
                                    Console.WriteLine("--Empleados de tipo PDI--\n");
                                    foreach (Personal EmpleadoActual2 in Personal.lista_de_empleados)
                                    {
                                        if (EmpleadoActual2 is PDI)
                                        {
                                            PDI empleadPDI = (PDI)EmpleadoActual2;
                                            empleadPDI.imprimir_tipo();
                                            valid2 = true;
                                        }
                                    }
                                    if (valid2 == false)
                                    {
                                        Console.WriteLine("-->No existen empleados de tipo PDI");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    }
                                    Console.WriteLine("\n\nIngrese el nombre del empleado PAS que desea jubilar: ");
                                    nomb2 = Console.ReadLine();
                                    foreach(Personal EmpleadoAc2 in Personal.lista_de_empleados)
                                    {
                                        if (EmpleadoAc2 is PDI)
                                        {
                                            PDI empleadpdi = (PDI)EmpleadoAc2;
                                            if (empleadpdi.Nombre == nomb2)
                                            {
                                                Personal.lista_de_empleados.Remove(empleadpdi);
                                                Console.WriteLine("-->Empleado Jubilado");
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("-->Este Nombre no existe en los empledos de tipo PDI");
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;
                                            }
                                        }
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("-->Salido");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Opcion invalida");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        } while (opcion2 != 3);
                        break;
                    case 3:
                        int opcion3 = 0;
                        do
                        {
                            Console.WriteLine("Ingrese el tipo de Empleado que desea Modificar: ");
                            Console.WriteLine("--1--PAS");
                            Console.WriteLine("--2--PDI");
                            Console.WriteLine("--3--Salir de la seccion de modificación--");
                            opcion3 = int.Parse(Console.ReadLine());
                            switch (opcion3)
                            {
                                case 1:
                                    Console.Clear();
                                    bool valid3 = false;
                                    string nomb3;
                                    Console.WriteLine("--Empleados de tipo PAS--\n");
                                    foreach (Personal EmpleadoActual3 in Personal.lista_de_empleados)
                                    {
                                        if (EmpleadoActual3 is PAS)
                                        {
                                            PAS empleadPAS2 = (PAS)EmpleadoActual3;
                                            empleadPAS2.imprimir_tipo();
                                            Console.WriteLine();
                                            valid3 = true;
                                        }
                                    }
                                    if (valid3 == false)
                                    {
                                        Console.WriteLine("-->No existen empleados de tipo PAS");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    }
                                    Console.WriteLine("\n\nIngrese el nombre del empleado PAS que desea modificar: ");
                                    nomb3 = Console.ReadLine();
                                    foreach(Personal EmpleadoAc3 in Personal.lista_de_empleados)
                                    {
                                        if (EmpleadoAc3 is PAS)
                                        {
                                            PAS empleadpas2 = (PAS)EmpleadoAc3;
                                            if (empleadpas2.Nombre == nomb3)
                                            {
                                                Console.Write("Nombre nuevo: ");
                                                empleadpas2.Nombre = Console.ReadLine();
                                                Console.Write("Apellido nuevo: ");
                                                empleadpas2.Apellido = Console.ReadLine();
                                                Console.Write("Codigo nuevo: ");
                                                empleadpas2.Codigo = int.Parse(Console.ReadLine());
                                                Console.Write("Seccion nueva: ");
                                                empleadpas2.Seccion = Console.ReadLine();
                                                Console.Write("Cargo nuevo: ");
                                                empleadpas2.Cargo = Console.ReadLine();
                                                Console.WriteLine("-->Empleado Modificado");
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("-->Este Nombre no existe en los empledos de tipo PAS");
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;
                                            }
                                        }
                                    }

                                    break;
                                case 2:
                                    Console.Clear();
                                    bool valid4 = false;
                                    string nomb4;
                                    Console.WriteLine("--Empleados de tipo PDI--\n");
                                    foreach (Personal EmpleadoActual4 in Personal.lista_de_empleados)
                                    {
                                        if (EmpleadoActual4 is PDI)
                                        {
                                            PDI empleadPDI2 = (PDI)EmpleadoActual4;
                                            empleadPDI2.imprimir_tipo();
                                            valid4 = true;
                                        }
                                    }
                                    if (valid4 == false)
                                    {
                                        Console.WriteLine("-->No existen empleados de tipo PDI");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    }
                                    Console.WriteLine("\n\nIngrese el nombre del empleado PAS que desea Modificar: ");
                                    nomb4 = Console.ReadLine();
                                    foreach(Personal EmpleadoAc4 in Personal.lista_de_empleados)
                                    {
                                        if (EmpleadoAc4 is PDI)
                                        {
                                            PDI empleadpdi2 = (PDI)EmpleadoAc4;
                                            if (empleadpdi2.Nombre == nomb4)
                                            {
                                                Console.Write("Nombre nuevo: ");
                                                empleadpdi2.Nombre = Console.ReadLine();
                                                Console.Write("Apellido nuevo: ");
                                                empleadpdi2.Apellido = Console.ReadLine();
                                                Console.Write("Codigo nuevo: ");
                                                empleadpdi2.Codigo = int.Parse(Console.ReadLine());
                                                Console.Write("Departamento nuevo: ");
                                                empleadpdi2.Departamento = Console.ReadLine();
                                                Console.Write("Area nueva: ");
                                                empleadpdi2.Area = Console.ReadLine();
                                                Console.WriteLine("-->Empleado Modificado");
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;
                                            }
                                            else
                                            {
                                                Console.WriteLine("-->Este Nombre no existe en los empledos de tipo PDI");
                                                Console.ReadKey();
                                                Console.Clear();
                                                break;
                                            }
                                        }
                                    }
                                    break;
                                case 3:
                                    Console.WriteLine("-->Salido");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Opcion invalida");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                            }
                        } while (opcion3 != 3);
                        break;
                    case 4:
                        int opcion4 = 0;
                        do
                        {
                            Console.WriteLine("Ingrese el tipo de personal que desea mostrar: ");
                            Console.WriteLine("--1--PAS");
                            Console.WriteLine("--2--PDI");
                            Console.WriteLine("--3--Salir de la seccion de Muestra--");
                            opcion4 = int.Parse(Console.ReadLine());
                            switch (opcion4)
                            {
                                case 1:
                                    Console.Clear();
                                    bool valid5 = false;
                                    Console.WriteLine("--Empleados de tipo PAS--\n");
                                    foreach (Personal EmpleadoActual5 in Personal.lista_de_empleados)
                                    {
                                        if (EmpleadoActual5 is PAS)
                                        {
                                            PAS empleadPAS3 = (PAS)EmpleadoActual5;
                                            empleadPAS3.imprimir();
                                            Console.WriteLine();
                                            valid5 = true;
                                            Console.WriteLine("---------------");
                                        }
                                    }
                                    if (valid5 == false)
                                    {
                                        Console.WriteLine("-->No existen empleados de tipo PAS");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    }
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 2:
                                    Console.Clear();
                                    bool valid6 = false;
                                    Console.WriteLine("--Empleados de tipo PDI--\n");
                                    foreach (Personal EmpleadoActual6 in Personal.lista_de_empleados)
                                    {
                                        if (EmpleadoActual6 is PDI)
                                        {
                                            PDI empleadPDI3 = (PDI)EmpleadoActual6;
                                            empleadPDI3.imprimir();
                                            valid6 = true;
                                        }
                                    }
                                    if (valid6 == false)
                                    {
                                        Console.WriteLine("-->No existen empleados de tipo PDI");
                                        Console.ReadKey();
                                        Console.Clear();
                                        break;
                                    }
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case 3:
                                    Console.WriteLine("-->Salido");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                default:
                                    Console.WriteLine("Opcion invalida");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break; 
                            }
                        } while (opcion4 != 3);
                        break;
                    case 5:
                        Console.Clear();
                        Console.WriteLine("--NOMINA--");
                        foreach (Personal EmpleadoActual7 in Personal.lista_de_empleados)
                        {
                            Console.WriteLine("------------------");
                            EmpleadoActual7.imprimir();
                        }
                        Console.WriteLine("--------------------");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        Console.WriteLine("Salido");
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            } while (opc != 6);
        }
    }
}
