using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form07SumarString : Form
    {
        public Form07SumarString()
        {
            InitializeComponent();
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            string numeros = this.txtNumeros.Text;
            int suma = 0;

            //RECORREMOS TODO EL CONTENIDO DE TEXTONUMEROS
            for (int i = 0; i < numeros.Length; i++)
            {
                //RECUPERAMOS CADA CARACTER DEL TEXTO
                char caracter = numeros[i];
                //CONVERTIMOS CADA CARACTER A NUMEROS PARA PODER SUMARLOS
                //ESTA CONVERSION RECUPERA EL ASCCI NO NOS VALE
                //      int numero = caracter;
                //NECESITAMOS EL LITERAL DEL NUMERO "1"
                //      int numero = int.Parse(caracter.ToString());
                //EXISTE UNA CLASE PARA CONVERTIR ENTRE TIPOS DE DATO EN MOMENTOS ESPCIALES
                int numero = Convert.ToInt32(caracter.ToString());
                suma += numero;

            }

            this.label2.Text = "La suma de " + numeros + " es: " + suma;
        }
    }
}
