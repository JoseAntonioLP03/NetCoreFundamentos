using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form13TiendaProductos : Form
    {
        public Form13TiendaProductos()
        {
            InitializeComponent();
            this.listaTienda.SelectionMode = SelectionMode.MultiExtended;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string producto = this.txtProducto.Text;
            this.listaTienda.Items.Add(producto);
            this.txtProducto.Text = "";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int numProductos = this.listaTienda.SelectedIndices.Count - 1;
            for (int i = numProductos; i >= 0; i--)
            {
                int index = this.listaTienda.SelectedIndices[i];
                //ELIMINAMOS DE LA COLECCION 
                this.listaTienda.Items.RemoveAt(index);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            this.listaTienda.Items.Clear();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            //VAMOS A RECORRER LA COLECCION DE ITEMS SELECCIONADOS
            foreach (string producto in this.listaTienda.SelectedItems)
            {
                this.listaAlmacen.Items.Add(producto);
                this.listaTienda.Items.Remove(producto);
            }
        }                                                                                                                                                                                                                                                                                                    

        private void btnTodos_Click(object sender, EventArgs e)
        {
            //VAMOS A RECORRER LA COLECCION DE ITEMS 
            foreach (string producto in this.listaTienda.Items)
            {
                this.listaAlmacen.Items.Add(producto);
            }
        }

        private void btnSubir_Click(object sender, EventArgs e)
        {

        }

        private void btnBajar_Click(object sender, EventArgs e)
        {

        }
    }
}
