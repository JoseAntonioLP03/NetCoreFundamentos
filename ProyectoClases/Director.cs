using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace ProyectoClases
{
    public class Director:Empleado
    {
        public override int GetDiasVacaciones()
        {
            int vacasEmpleado = base.GetDiasVacaciones();
            Debug.WriteLine("GetVacaciones() DIRECTOR");
            return vacasEmpleado +8;
        }
        public Director()
        {
            Debug.WriteLine("Constructor Director");
            this.SalarioMinimo += 200;
        }

    }
}
