# Ejercicio-1.-Clases-Derivadas
Ejercicio de clases derivadas en C# y la implementación del método de tipo virtual 

Una universidad necesita una aplicación capaz de gestionar su personal. Existen dos tipos de
personal: el personal docente e investigador (PDI) y el personal de administración y servicios (PAS).

Los PDI se identifican a través de un número y están caracterizados por pertenecer a un
departamento y un área. Por ejemplo, el PDI 123 pertenece al Departamento de Ciencias de la
Computación y está dentro del Área de Lenguajes y Sistemas Informáticos.

Los PAS se identifican a través de un número y están caracterizados por pertenecer a una sección y
ocupar un cargo. Ejemplo: el PAS 456 pertenece a la sección de Biblioteca y ocupa el cargo de
Adjunto a Dirección.

Dentro de la gestión de la Universidad las tareas que se llevan a cabo son las siguientes:
 Contratar PAS/PDI.
 Jubilar PAS/PDI.
 Modificar datos de un PAS/PDI.
 Mostrar los datos de los PAS/PDI.
 Generar la nómina de todo el personal.

Las clases PAS y PID son clases derivadas de la clase Empleado (Permitiendo implementar
polimorfismo) y la clase Personal posee una lista del tipo: List<Personal>
  
