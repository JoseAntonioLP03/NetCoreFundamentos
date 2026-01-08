using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoClases
{
    internal interface IFactura
    {
        //SOLO TIENE ESTRUCTURA DE DECLARACION DE ELEMENTOS
        int PrecioBase { get; set; }
        int PrecioTotal { get; set; }
        void CalcularIva();
        void OdioHacienda(int mucho);
    }
}
