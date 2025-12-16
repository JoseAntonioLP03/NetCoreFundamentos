using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form08ValidarISBN : Form
    {
        public Form08ValidarISBN()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            string cadenaIsbn = this.txtISBN.Text;
            int suma = 0;

            for (int i = 0; i < cadenaIsbn.Length; i++)
            {
                char caracter = cadenaIsbn[i];
                if (char.IsDigit(caracter))
                {
                    int digito = int.Parse(caracter.ToString());
                    suma += digito * (i + 1);
                }
            }
            if (suma % 11 == 0)
            {
                this.lblResultado.Text = "El ISBN es correcto";
            }
            else
            {
                this.lblResultado.Text = "El ISBN no es correcto";
            }
        }
    }
}
