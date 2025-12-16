using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form12ColeccionNumeros : Form
    {
        List<int> numeros;

        public Form12ColeccionNumeros()
        {
            InitializeComponent();
            this.numeros = new List<int>();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.lstNumeros.Items.Clear();
            this.numeros.Clear();
            
            Random random = new Random();
            
            for (int i = 0; i < 10; i++)
            {
                int numero = random.Next(1, 100);
                this.numeros.Add(numero);
                this.lstNumeros.Items.Add(numero);
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int sumaTotal = 0;
            int sumaPares = 0;
            int sumaImpares = 0;
            
            foreach (int numero in this.numeros)
            {
                sumaTotal += numero;
                
                if (numero % 2 == 0)
                {
                    sumaPares += numero;
                }
                else
                {
                    sumaImpares += numero;
                }
            }
            
            this.textBox1.Text = sumaTotal.ToString();
            this.textBox2.Text = sumaPares.ToString();
            this.textBox3.Text = sumaImpares.ToString();
        }
    }
}
