using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
//IMPORTADOS
using System.Text;
using System.Diagnostics;

namespace NetCoreFundamentos
{
    public partial class Form05StringBuilder : Form
    {
        public Form05StringBuilder()
        {
            InitializeComponent();
        }

        private void btnString_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            string cadena = this.txtTexto.Text;
            int longitud = cadena.Length;
            //COMENZAMOS EL PROCESO
            krono.Start();
            for(int i = 0; i < longitud; i++)
            {
                //SIEMPRE RECUPERAMOS LA ULTIMA LETRA
                char letra = cadena[longitud - 1];
                //ELIMINAMOS LA ULTIMA LETRA
                cadena = cadena.Remove(longitud - 1, 1);
                //INSERTAMOS LA LETRA EN LA POSICION i DEL BUCLE
                cadena = cadena.Insert(i, letra.ToString());
            }
            //FINALIZAMOS EL PROCESO
            krono.Stop();
            //EL OBJETO StopWatch CONTIENE UNA SERIE DE PROPIEDADES
            //PARA COMPROBAR EL TIEMPO ENTRE EL PROCESI
            this.lblTiempo.Text = "Segundos: " + krono.Elapsed.Seconds + ", Milisegundos: " + krono.Elapsed.Milliseconds;
            this.txtTexto.Text = cadena;
        }

        private void btnStrBuilder_Click(object sender, EventArgs e)
        {
            Stopwatch krono = new Stopwatch();
            //VAMOS A UTILIZAR LA CLASE STRING BUILDER
            StringBuilder cadena = new StringBuilder();
            int longitud = cadena.Length;
            //COMENZAMOS EL PROCESO
            krono.Start();
            for (int i = 0; i < longitud; i++)
            {
                //SIEMPRE RECUPERAMOS LA ULTIMA LETRA
                char letra = cadena[longitud - 1];
                //ELIMINAMOS LA ULTIMA LETRA
                cadena = cadena.Remove(longitud - 1, 1);
                //INSERTAMOS LA LAETRA EN LA POSICION i DEL BUCLE
                cadena = cadena.Insert(i, letra.ToString());
            }
            //FINALIZAMOS EL PROCESO
            krono.Stop();
            //EL OBJETO StopWatch CONTIENE UNA SERIE DE PROPIEDADES
            //PARA COMPROBAR EL TIEMPO ENTRE EL PROCESI
            this.lblTiempo.Text = "Segundos: " + krono.Elapsed.Seconds + ", Milisegundos: " + krono.Elapsed.Milliseconds;
            this.txtTexto.Text = cadena.ToString();
        }
    }
}
