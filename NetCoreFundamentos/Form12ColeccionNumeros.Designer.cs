namespace NetCoreFundamentos
{
    partial class Form12ColeccionNumeros
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
            lstNumeros = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnGenerar = new Button();
            btnMostrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(76, 32);
            label1.Name = "label1";
            label1.Size = new Size(80, 21);
            label1.TabIndex = 0;
            label1.Text = "Números";
            // 
            // lstNumeros
            // 
            lstNumeros.FormattingEnabled = true;
            lstNumeros.Location = new Point(78, 59);
            lstNumeros.Name = "lstNumeros";
            lstNumeros.Size = new Size(251, 319);
            lstNumeros.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label2.Location = new Point(458, 252);
            label2.Name = "label2";
            label2.Size = new Size(54, 21);
            label2.TabIndex = 2;
            label2.Text = "Suma:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(458, 288);
            label3.Name = "label3";
            label3.Size = new Size(53, 21);
            label3.TabIndex = 3;
            label3.Text = "Pares:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(458, 326);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 4;
            label4.Text = "Impares:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(537, 249);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(537, 285);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(537, 326);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 7;
            // 
            // btnGenerar
            // 
            btnGenerar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnGenerar.Location = new Point(469, 59);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(206, 45);
            btnGenerar.TabIndex = 8;
            btnGenerar.Text = "Generar Números";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold);
            btnMostrar.Location = new Point(469, 131);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(206, 45);
            btnMostrar.TabIndex = 9;
            btnMostrar.Text = "Mostrar Datos";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // Form12ColeccionNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnMostrar);
            Controls.Add(btnGenerar);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstNumeros);
            Controls.Add(label1);
            Name = "Form12ColeccionNumeros";
            Text = "Form12ColeccionNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstNumeros;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnGenerar;
        private Button btnMostrar;
    }
}