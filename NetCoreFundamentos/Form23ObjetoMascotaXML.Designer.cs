namespace NetCoreFundamentos
{
    partial class Form23ObjetoMascotaXML
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
            txtNombre = new TextBox();
            txtRaza = new TextBox();
            label2 = new Label();
            txtEdad = new TextBox();
            label3 = new Label();
            btnLeerClase = new Button();
            btnGuardar = new Button();
            btnExaminar = new Button();
            openFileDialog1 = new OpenFileDialog();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F);
            label1.Location = new Point(46, 28);
            label1.Name = "label1";
            label1.Size = new Size(81, 25);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 14.25F);
            txtNombre.Location = new Point(46, 62);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 33);
            txtNombre.TabIndex = 1;
            // 
            // txtRaza
            // 
            txtRaza.Font = new Font("Segoe UI", 14.25F);
            txtRaza.Location = new Point(46, 129);
            txtRaza.Name = "txtRaza";
            txtRaza.Size = new Size(100, 33);
            txtRaza.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F);
            label2.Location = new Point(46, 95);
            label2.Name = "label2";
            label2.Size = new Size(52, 25);
            label2.TabIndex = 2;
            label2.Text = "Raza";
            // 
            // txtEdad
            // 
            txtEdad.Font = new Font("Segoe UI", 14.25F);
            txtEdad.Location = new Point(46, 201);
            txtEdad.Name = "txtEdad";
            txtEdad.Size = new Size(100, 33);
            txtEdad.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F);
            label3.Location = new Point(46, 167);
            label3.Name = "label3";
            label3.Size = new Size(54, 25);
            label3.TabIndex = 4;
            label3.Text = "Edad";
            // 
            // btnLeerClase
            // 
            btnLeerClase.Font = new Font("Segoe UI", 14.25F);
            btnLeerClase.Location = new Point(243, 61);
            btnLeerClase.Name = "btnLeerClase";
            btnLeerClase.Size = new Size(127, 34);
            btnLeerClase.TabIndex = 6;
            btnLeerClase.Text = "Leer Clase";
            btnLeerClase.UseVisualStyleBackColor = true;
            btnLeerClase.Click += btnLeerClase_Click;
            // 
            // btnGuardar
            // 
            btnGuardar.Font = new Font("Segoe UI", 14.25F);
            btnGuardar.Location = new Point(243, 128);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(127, 33);
            btnGuardar.TabIndex = 7;
            btnGuardar.Text = "Guardar Clase";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnExaminar
            // 
            btnExaminar.Font = new Font("Segoe UI", 14.25F);
            btnExaminar.Location = new Point(243, 201);
            btnExaminar.Name = "btnExaminar";
            btnExaminar.Size = new Size(127, 33);
            btnExaminar.TabIndex = 8;
            btnExaminar.Text = "Examinar";
            btnExaminar.UseVisualStyleBackColor = true;
            btnExaminar.Click += btnExaminar_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(435, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(402, 324);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form23ObjetoMascotaXML
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 387);
            Controls.Add(pictureBox1);
            Controls.Add(btnExaminar);
            Controls.Add(btnGuardar);
            Controls.Add(btnLeerClase);
            Controls.Add(txtEdad);
            Controls.Add(label3);
            Controls.Add(txtRaza);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Name = "Form23ObjetoMascotaXML";
            Text = "Form23ObjetoMascotaXML";
            Load += Form23ObjetoMascotaXML_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNombre;
        private TextBox txtRaza;
        private Label label2;
        private TextBox txtEdad;
        private Label label3;
        private Button btnLeerClase;
        private Button btnGuardar;
        private Button btnExaminar;
        private OpenFileDialog openFileDialog1;
        private PictureBox pictureBox1;
    }
}