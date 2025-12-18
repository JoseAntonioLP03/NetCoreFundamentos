using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form19TablaMultiplicar : Form
    {
        List<TextBox> cajas;
        List<Button> botones;

        public Form19TablaMultiplicar()
        {
            InitializeComponent();
            this.cajas = new List<TextBox>();
            this.botones = new List<Button>();

            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    this.cajas.Add((TextBox)control);
                }
                else if (control is Button)
                {
                    Button boton = (Button)control;
                    this.botones.Add(boton);
                    boton.Click += MultiplicarNumeros;
                }
            }
        }

        private void MultiplicarNumeros(object? sender, EventArgs e)
        {
            Button botonPulsado = (Button)sender;
            int numero = int.Parse(botonPulsado.Text);
            
            for (int i = 0; i < this.cajas.Count; i++)
            {
                int multiplicador = i + 1;
                int resultado = numero * multiplicador;
                this.cajas[i].Text = resultado.ToString();
            }
        }
    }
}
