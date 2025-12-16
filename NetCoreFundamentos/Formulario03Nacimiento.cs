using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Formulario03Nacimiento : Form
    {
        public Formulario03Nacimiento()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(this.txtDia.Text);
            int mes = int.Parse(this.txtMes.Text);
            int año = int.Parse(this.txtAño.Text);

            if(mes <= 1 && mes>=1)
            {
                mes = 13;
                año = año - 1;
            }
            else if(mes <=2 && mes >= 2)
            {
                mes = 14;
                año = año - 1;
            }

                int oper1 = (mes + 1) * 3 / 5;
            int oper2 = año / 4;
            int oper3 = año / 100;
            int oper4 = año / 400;

            int operLarga = dia + (mes * 2) + año + oper1 + oper2 - oper3 + oper4 + 2;

            int oper5 = operLarga / 7;
            int resultado = operLarga - (oper5 * 7);

            string diaSemana = "";
            if(resultado == 0)
            {
                diaSemana = "SABADO";
            }else if (resultado ==1)
            {
                diaSemana = "DOMINGO";
            }
            else if (resultado == 2)
            {
                diaSemana = "LUNES";
            }
            else if (resultado == 3)
            {
                diaSemana = "MARTES";
            }
            else if (resultado == 4)
            {
                diaSemana = "MIERCOLES";
            }
            else if (resultado == 5)
            {
                diaSemana = "JUEVES";
            }
            else if (resultado == 6)
            {
                diaSemana = "VIERNES";
            }else
            {
                diaSemana = "ERROR LOGICO";
            }
            this.lblDia.Text = "El día de la semana es: "+diaSemana;




        }
    }
}
