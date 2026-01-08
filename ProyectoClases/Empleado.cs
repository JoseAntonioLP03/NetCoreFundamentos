using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Empleado:Persona
    {
        public virtual int GetDiasVacaciones()
        {
            Debug.WriteLine("GetVacaciones() EMPLEADO");
            return 22;
        }
        protected int SalarioMinimo { get; set; }
        public Empleado()
        {
            Debug.WriteLine("Constructor EMPLEADO vacio");
            this.SalarioMinimo = 1000;
        }
        public int GetSalarioMinimo()
        {
            return this.SalarioMinimo;
        }
        public Empleado(string nombre, string apellidos)
        {
            this.Nombre = nombre;
            this.Apellidos = apellidos;
            Debug.WriteLine("Constructor EMPLEADO con 2 parámetros");

        }
    }
}
