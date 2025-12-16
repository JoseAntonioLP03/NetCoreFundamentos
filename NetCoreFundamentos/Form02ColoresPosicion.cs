using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form02ColoresPosicion : Form
    {
        public Form02ColoresPosicion()
        {
            InitializeComponent();
        }

        private void btnCambiarPosicion_Click(object sender, EventArgs e)
        {
            int posicionX = int.Parse(this.txtPosicionX.Text);
            int posicionY = int.Parse(this.txtPosicionY.Text);
            this.btnCambiarPosicion.Location = new Point(posicionX,posicionY);

        }

        private void btnCambiarFondo_Click(object sender, EventArgs e)
        {
            int rojo = int.Parse(this.txtRojo.Text);
            int verde = int.Parse(this.txtVerde.Text);
            int azul = int.Parse(this.txtAzul.Text);
            this.btnCambiarFondo.BackColor = Color.FromArgb(rojo, verde, azul);
            if (rojo < 0 || rojo > 255)
            {
                MessageBox.Show("El valor de rojo debe estar comprendido entre 0 y 255");
            }
            else if (verde < 0 || verde > 255)
            {
                MessageBox.Show("El valor de verde debe estar comprendido entre 0 y 255");
            }
            else if (azul < 0 || azul > 255)
            {
                MessageBox.Show("El valor de azul debe estar comprendido entre 0 y 255");
            }
            else{
                this.BackColor = Color.FromArgb(rojo, verde, azul);
            }
        }
    }
}
