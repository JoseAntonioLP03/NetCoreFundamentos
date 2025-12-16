using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form06ValidarEmail : Form
    {
        public Form06ValidarEmail()
        {
            InitializeComponent();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            this.lblErrores.Text = "";
            this.lblErrores.ForeColor = Color.Red;
            string email = this.txtEmail.Text;

            int PosicionArroba = email.IndexOf("@");
            int HaySegundoArroba = email.LastIndexOf("@");

            if (PosicionArroba == -1)
            {
                this.lblErrores.Text = ("El correo no es válido: no contiene '@'.");
                return;
            }

            if (PosicionArroba == 0 || PosicionArroba == email.Length - 1)
            {
                this.lblErrores.Text += ("El correo no es válido: '@' no puede estar al principio ni al final.");
                return;
            }

            if (PosicionArroba != HaySegundoArroba)
            {
                this.lblErrores.Text += ("El correo no es válido: hay más de un '@'.");
                return;
            }

            int PosicionPunto = email.IndexOf('.', PosicionArroba);
            if (PosicionPunto == -1 || PosicionPunto == PosicionArroba )
            {
                this.lblErrores.Text += ("El correo no es válido: debe haber un punto después de '@'.");
                return;
            }
            string dominio = email.Substring(PosicionPunto + 1); 
            int longitudDominio = dominio.Length;

            if (longitudDominio < 2 || longitudDominio > 3)
            {
                this.lblErrores.Text += ("El correo no es válido: el dominio debe tener entre 2 y 3 caracteres.");
                return;
            }

            this.lblErrores.ForeColor = Color.DarkGreen;
            this.lblErrores.Text += ("El correo es válido.");
        }
    }
}
