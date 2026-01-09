namespace NetCoreFundamentos
{
    partial class Form22MascotasFiles
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
            Nombre = new Label();
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            label2 = new Label();
            btnRead = new Button();
            btnWrite = new Button();
            Macotas = new Label();
            lstMascotas = new ListBox();
            btnNueva = new Button();
            SuspendLayout();
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(40, 31);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 0;
            Nombre.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(40, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(129, 27);
            txtNombre.TabIndex = 1;
            // 
            // txtRaza
            // 
            txtRaza.Location = new Point(40, 143);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(129, 27);
            txtRaza.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(40, 111);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 2;
            label2.Text = "Raza";
            // 
            // btnRead
            // 
            btnRead.Location = new Point(40, 258);
            btnRead.Name = "btnRead";
            btnRead.Size = new Size(129, 34);
            btnRead.TabIndex = 5;
            btnRead.Text = "Read File";
            btnRead.UseVisualStyleBackColor = true;
            btnRead.Click += btnRead_Click;
            // 
            // btnWrite
            // 
            btnWrite.Location = new Point(40, 310);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(129, 34);
            btnWrite.TabIndex = 6;
            btnWrite.Text = "Write File";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // Macotas
            // 
            Macotas.AutoSize = true;
            Macotas.Location = new Point(284, 31);
            Macotas.Name = "Macotas";
            Macotas.Size = new Size(65, 20);
            Macotas.TabIndex = 7;
            Macotas.Text = "Macotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(284, 63);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(241, 284);
            lstMascotas.TabIndex = 8;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // btnNueva
            // 
            btnNueva.Location = new Point(40, 205);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(129, 34);
            btnNueva.TabIndex = 9;
            btnNueva.Text = "NuevaMascota";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // Form22MascotasFiles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(674, 463);
            Controls.Add(btnNueva);
            Controls.Add(lstMascotas);
            Controls.Add(Macotas);
            Controls.Add(btnWrite);
            Controls.Add(btnRead);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(Nombre);
            Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form22MascotasFiles";
            Text = "Form22MascotasFiles";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Nombre;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private Label label2;
        private Button btnRead;
        private Button btnWrite;
        private Label Macotas;
        private ListBox lstMascotas;
        private Button btnNueva;
    }
}