using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreFundamentos
{
    public partial class Form18SumarCheckbox : Form
    {
        List<CheckBox> checkboxes;

        public Form18SumarCheckbox()
        {
            InitializeComponent();
            this.checkboxes = new List<CheckBox>();
            
            foreach (CheckBox chk in this.panel1.Controls)
            {
                this.checkboxes.Add(chk);
                chk.CheckedChanged += SumarNumeros;
            }
        }

        private void SumarNumeros(object? sender, EventArgs e)
        {
            int suma = 0;
            
            foreach (CheckBox checkbox in this.checkboxes)
            {
                if (checkbox.Checked)
                {
                    int numero = int.Parse(checkbox.Text);
                    suma += numero;  
                }
            }
            
            this.txtSuma.Text = suma.ToString();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            
            foreach (CheckBox checkbox in this.checkboxes)
            {
                int aleat = random.Next(1, 50);
                checkbox.Text = aleat.ToString();
                checkbox.Checked = false;
            }
            
            this.txtSuma.Text = "0";
        }
    }
}
