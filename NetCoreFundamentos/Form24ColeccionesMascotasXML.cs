using ProyectoClases.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace NetCoreFundamentos
{
    public partial class Form24ColeccionesMascotasXML : Form
    {
        XmlSerializer serializer;
        ColeccionMascotas mascotasList;
        public Form24ColeccionesMascotasXML()
        {
            InitializeComponent();
            this.serializer = new XmlSerializer(typeof(ColeccionMascotas));
            this.mascotasList = new ColeccionMascotas();
        }

        private void DibujarMascotas()
        {
            this.lstMascotas.Items.Clear();
            foreach (Mascota mascota in this.mascotasList)
            {
                this.lstMascotas.Items.Add(mascota.Nombre);
            }
        }

        private void btnNueva_Click(object sender, EventArgs e)
        {
            Mascota mascota = new Mascota();
            mascota.Nombre = this.txtNombre.Text;
            mascota.Raza = this.txtRaza.Text;
            mascota.Edad = int.Parse(this.txtEdad.Text);
            this.mascotasList.Add(mascota);
            this.DibujarMascotas();
            this.txtNombre.Clear();
            this.txtRaza.Clear();
            this.txtEdad.Clear();
        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            using (StreamWriter writer = new StreamWriter("listamascotas.xml"))
            {
                this.serializer.Serialize(writer, this.mascotasList);
                await writer.FlushAsync();
                writer.Close();
            }
        }

        private void btnLeerMascotas_Click(object sender, EventArgs e)
        {
            using (StreamReader reader = new StreamReader("listamascotas.xml"))
            {
                this.mascotasList = (ColeccionMascotas)this.serializer.Deserialize(reader);
                reader.Close();
                this.DibujarMascotas();
            }
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            //ABRIR EL OPENFILE PARA SELECCIONAR LA IMAGEN
            this.openFileDialog1.ShowDialog();
            //RECUPERAMOS LA RUTA DE LA IMAGEN
            string path = this.openFileDialog1.FileName;
            //DIBUJAMOS LA IMAGEN EN EL FORM
            this.pictureBox1.Image = Image.FromFile(path);
        }
    }
}
