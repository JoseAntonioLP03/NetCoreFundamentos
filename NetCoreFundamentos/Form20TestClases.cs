using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ProyectoClases;

namespace NetCoreFundamentos
{
    public partial class Form20TestClases : Form
    {
        public Form20TestClases()
        {
            InitializeComponent();
        }

        private void btnCrearPersona_Click(object sender, EventArgs e)
        {
            Persona person = new Persona();
            person.Nombre = "Jose Antonio";
            person.Apellidos = "López Pachón";
            person.Edad = 20;
            person[0] = "Vamos 1";
            person[1] = "Vamos 2";

            person.Genero = TipoGenero.Masculino;
            person.Nacionalidad = Pais.España;
            this.lstClases.Items.Add("Genero:" + person.Genero + ", Nacionalidad: " + person.Nacionalidad);
            this.lstClases.Items.Add("Nombre:" + person.Nombre + ", Apellidos: " + person.Apellidos + " , Edad: " + person.Edad);

            this.lstClases.Items.Add(person.GetNombreCompleto(true));

            Persona Direccion = new Persona();
            person.Domicilio.Calle = "Avenida Enero";
            person.Domicilio.Ciudad = "Valdemoro";
            person.Domicilio.CodigoPostal = 28342;
            this.lstClases.Items.Add("Direccion: " + person.Domicilio.Calle + ", " + person.Domicilio.Ciudad + ", " + person.Domicilio.CodigoPostal);

        }

        private void btnEmpleado_Click(object sender, EventArgs e)
        {
            //Empleado emp = new Empleado("Nombre","Apellidos");
            Empleado emp = new Empleado();
            emp.Nombre = "Becario";
            emp.Apellidos = "Becario";
            this.lstClases.Items.Add("Vacas Empleado: " + emp.GetDiasVacaciones());
            this.lstClases.Items.Add("Empleado: " + emp.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + emp.GetSalarioMinimo()+"€");

            Director dire = new Director();
            dire.Nombre = "Dire";
            dire.Apellidos = "Dire";
            this.lstClases.Items.Add("Vacas Director: " + emp.GetDiasVacaciones());
            this.lstClases.Items.Add("Empleado: " + dire.GetNombreCompleto());
            this.lstClases.Items.Add("Salario: " + dire.GetSalarioMinimo() + "€");


        }
    }
}
