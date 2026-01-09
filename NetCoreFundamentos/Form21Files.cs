using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using ProyectoClases.Helpers;

namespace NetCoreFundamentos
{
    public partial class Form21Files : Form
    {
        public string Path { get; set; }

        HelpersFiles helper;
        public Form21Files()
        {
            InitializeComponent();
            this.helper = new HelpersFiles();

            //CUANDO HABLAMOS DE RUTAS O CARACTERES ESPECIALES DENTRO DE STRING TENEMOS 2 FORMAS DE ESCRIBIR DICHOS CARACTERES
            //ej: 1) C:\carpeta\1.txt
            //UTILIZAR DOBLE BARRA
            //this.path = "C:\\carpeta\\1.txt";
            //2) UTILIZAR @ ANTES DEL STRING Y FUERA DE EL (RECOMENDADA)
            //this.Path = @"C:\carpeta\1.txt";

            this.Path = "file1.txt";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            this.lstNombres.Items.Add(this.txtNombre.Text);
            this.txtNombre.SelectAll();
            this.txtNombre.Focus();
        }

        public string GetNombresListBox()
        {
            string data = "";
            foreach(string name in this.lstNombres.Items)
            {
                data += name + ",";
            }
            data = data.Trim(',');
            return data;
        }

        //Escritura de ficheros async
        private async void btnWrite_Click(object sender, EventArgs e)
        {
            string content = this.GetNombresListBox();
            await this.helper.WriteFileAsync(this.Path, content);
            MessageBox.Show("Datos Almacenados");
        }

        //Lectura de ficheros async
        private async void btnLeer_Click(object sender, EventArgs e)
        {
            string content = await this.helper.ReadFileAsync(this.Path);
            this.txtContenido.Text = content;
            string[] nombres = content.Split(',');
            this.lstNombres.Items.Clear();
            foreach(string name in nombres)
            {
                this.lstNombres.Items.Add(name);
            }
        }

    }
}
