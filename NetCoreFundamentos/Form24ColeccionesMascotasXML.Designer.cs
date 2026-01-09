namespace NetCoreFundamentos
{
    partial class Form24ColeccionesMascotasXML
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
            txtEdad = new TextBox();
            label4 = new Label();
            txtRaza = new TextBox();
            label2 = new Label();
            txtNombre = new TextBox();
            label1 = new Label();
            label3 = new Label();
            lstMascotas = new ListBox();
            btnGuardar = new Button();
            btnLeerMascotas = new Button();
            btnNueva = new Button();
            pictureBox1 = new PictureBox();
            btnExaminar = new Button();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Segoe UI", 14.25F);
            txtEdad.Location = new Point(35, 219);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 33);
            txtEdad.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F);
            label4.Location = new Point(35, 185);
            label4.Name = "label4";
            label4.Size = new Size(54, 25);
            label4.TabIndex = 10;
            label4.Text = "Edad";
            // 
            // txtRaza
            // 
            txtRaza.Font = new Font("Segoe UI", 14.25F);
            txtRaza.Location = new Point(35, 147);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 33);
            txtRaza.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(35, 113);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 8;
            label2.Text = "Raza";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14.25F);
            txtNombre.Location = new Point(35, 80);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 33);
            txtNombre.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(35, 46);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 6;
            label1.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(231, 46);
            label3.Name = "label3";
            label3.Size = new Size(91, 25);
            label3.TabIndex = 12;
            label3.Text = "Mascotas";
            // 
            // lstMascotas
            // 
            lstMascotas.FormattingEnabled = true;
            lstMascotas.Location = new Point(231, 80);
            lstMascotas.Name = "lstMascotas";
            lstMascotas.Size = new Size(230, 259);
            lstMascotas.TabIndex = 13;
            lstMascotas.SelectedIndexChanged += lstMascotas_SelectedIndexChanged;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 14.25F);
            btnGuardar.Location = new Point(519, 147);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(175, 33);
            btnGuardar.TabIndex = 15;
            btnGuardar.Text = "Guardar Mascotas";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnLeerMascotas
            // 
            btnLeerMascotas.Font = new Font("Segoe UI", 14.25F);
            btnLeerMascotas.Location = new Point(519, 80);
            btnLeerMascotas.Name = "btnLeerMascotas";
            btnLeerMascotas.Size = new Size(156, 34);
            btnLeerMascotas.TabIndex = 14;
            btnLeerMascotas.Text = "Leer Mascotas";
            btnLeerMascotas.UseVisualStyleBackColor = true;
            btnLeerMascotas.Click += btnLeerMascotas_Click;
            // 
            // btnNueva
            // 
            btnNueva.Font = new Font("Segoe UI", 14.25F);
            btnNueva.Location = new Point(35, 295);
            btnNueva.Name = "btnNueva";
            btnNueva.Size = new Size(156, 34);
            btnNueva.TabIndex = 16;
            btnNueva.Text = "Nueva Mascota";
            btnNueva.UseVisualStyleBackColor = true;
            btnNueva.Click += btnNueva_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(649, 202);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(139, 195);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 17;
            pictureBox1.TabStop = false;
            // 
            // btnExaminar
            // 
            btnExaminar.Font = new Font("Segoe UI", 14.25F);
            btnExaminar.Location = new Point(499, 219);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(110, 124);
            btnExaminar.TabIndex = 18;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form24ColeccionesMascotasXML
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnExaminar);
            Controls.Add(pictureBox1);
            Controls.Add(btnNueva);
            Controls.Add(btnGuardar);
            Controls.Add(btnLeerMascotas);
            Controls.Add(lstMascotas);
            Controls.Add(label3);
            Controls.Add(txtEdad);
            Controls.Add(label4);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form24ColeccionesMascotasXML";
            Text = "Form24ColeccionesMascotasXML";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEdad;
        private Label label4;
        private TextBox txtRaza;
        private Label label2;
        private TextBox txtNombre;
        private Label label1;
        private Label label3;
        private ListBox lstMascotas;
        private Button btnGuardar;
        private Button btnLeerMascotas;
        private Button btnNueva;
        private PictureBox pictureBox1;
        private Button btnExaminar;
        private OpenFileDialog openFileDialog1;
    }
}