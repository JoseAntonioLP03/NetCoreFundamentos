using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace NetCoreFundametos.FORMS
{
    partial class Form14Metodos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            textBox1 = new TextBox();
            btnDobleValor = new Button();
            btnDobleRef = new Button();
            label2 = new Label();
            btnObjetoRef = new Button();
            lblRaton = new Label();
            txtNumerosCordenadas = new TextBox();
            label3 = new Label();
            label4 = new Label();
            txtLetraasCordenadas = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(90, 50);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(94, 78);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // btnDobleValor
            // 
            btnDobleValor.Location = new Point(91, 170);
            btnDobleValor.Name = "btnDobleValor";
            btnDobleValor.RightToLeft = RightToLeft.Yes;
            btnDobleValor.Size = new Size(75, 23);
            btnDobleValor.TabIndex = 2;
            btnDobleValor.Text = "DobleValor";
            btnDobleValor.UseVisualStyleBackColor = true;
            btnDobleValor.Click += btnDobleValor_Click;
            // 
            // btnDobleRef
            // 
            btnDobleRef.Location = new Point(91, 231);
            btnDobleRef.Name = "btnDobleRef";
            btnDobleRef.Size = new Size(75, 23);
            btnDobleRef.TabIndex = 5;
            btnDobleRef.Text = "DobleRef";
            btnDobleRef.UseVisualStyleBackColor = true;
            btnDobleRef.Click += btnDobleRef_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 124);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.Yes;
            label2.Size = new Size(72, 15);
            label2.TabIndex = 3;
            label2.Text = "lblResultado";
            label2.Click += label2_Click;
            // 
            // btnObjetoRef
            // 
            btnObjetoRef.Location = new Point(91, 288);
            btnObjetoRef.Name = "btnObjetoRef";
            btnObjetoRef.Size = new Size(75, 23);
            btnObjetoRef.TabIndex = 8;
            btnObjetoRef.Text = "Objeto Ref";
            btnObjetoRef.UseVisualStyleBackColor = true;
            btnObjetoRef.Click += btnObjetoRef_Click;
            // 
            // lblRaton
            // 
            lblRaton.BackColor = Color.Yellow;
            lblRaton.Location = new Point(294, 50);
            lblRaton.Name = "lblRaton";
            lblRaton.Size = new Size(323, 63);
            lblRaton.TabIndex = 9;
            lblRaton.Text = "Cordenadas Raton";
            lblRaton.MouseMove += lblRaton_MouseMove;
            // 
            // txtNumerosCordenadas
            // 
            txtNumerosCordenadas.Location = new Point(294, 148);
            txtNumerosCordenadas.Name = "txtNumerosCordenadas";
            txtNumerosCordenadas.Size = new Size(97, 23);
            txtNumerosCordenadas.TabIndex = 10;
            txtNumerosCordenadas.KeyPress += txtNumerosCordenadas_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(294, 124);
            label3.Name = "label3";
            label3.Size = new Size(77, 15);
            label3.TabIndex = 11;
            label3.Text = "Solo Numero";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(294, 187);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 12;
            label4.Text = "Solo Letras";
            // 
            // txtLetraasCordenadas
            // 
            txtLetraasCordenadas.Location = new Point(294, 205);
            txtLetraasCordenadas.Name = "txtLetraasCordenadas";
            txtLetraasCordenadas.Size = new Size(97, 23);
            txtLetraasCordenadas.TabIndex = 13;
            txtLetraasCordenadas.KeyPress += txtLetraasCordenadas_KeyPress;
            // 
            // Form14Metodos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(909, 474);
            Controls.Add(txtLetraasCordenadas);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtNumerosCordenadas);
            Controls.Add(lblRaton);
            Controls.Add(btnObjetoRef);
            Controls.Add(btnDobleRef);
            Controls.Add(label2);
            Controls.Add(btnDobleValor);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "Form14Metodos";
            Text = "Form14Metodos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Button btnDobleValor;
        private Button btnDobleRef;
        private Label label2;
        private Button btnObjetoRef;
        private Label lblRaton;
        private TextBox txtNumerosCordenadas;
        private Label label3;
        private Label label4;
        private TextBox txtLetraasCordenadas;
    }
}