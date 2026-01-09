namespace NetCoreFundamentos
{
    partial class Form21Files
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
            txtContenido = new TextBox();
            btnNuevo = new Button();
            btnLeer = new Button();
            btnWrite = new Button();
            txtNombre = new TextBox();
            label2 = new Label();
            label3 = new Label();
            lstNombres = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F);
            label1.Location = new Point(25, 36);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 0;
            label1.Text = "Contenido File";
            label1.Click += label1_Click;
            // 
            // txtContenido
            // 
            txtContenido.Font = new Font("Segoe UI", 11.25F);
            txtContenido.Location = new Point(25, 85);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(218, 300);
            txtContenido.TabIndex = 1;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 11.25F);
            btnNuevo.Location = new Point(284, 198);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(174, 34);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo Nombre";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnLeer
            // 
            btnLeer.Font = new Font("Segoe UI", 11.25F);
            btnLeer.Location = new Point(284, 252);
            btnLeer.Name = "btnLeer";
            btnLeer.Size = new Size(174, 34);
            btnLeer.TabIndex = 3;
            btnLeer.Text = "Leer File";
            btnLeer.UseVisualStyleBackColor = true;
            btnLeer.Click += btnLeer_Click;
            // 
            // btnWrite
            // 
            btnWrite.Font = new Font("Segoe UI", 11.25F);
            btnWrite.Location = new Point(284, 303);
            btnWrite.Name = "btnWrite";
            btnWrite.Size = new Size(174, 34);
            btnWrite.TabIndex = 4;
            btnWrite.Text = "Write File";
            btnWrite.UseVisualStyleBackColor = true;
            btnWrite.Click += btnWrite_Click;
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Segoe UI", 11.25F);
            txtNombre.Location = new Point(284, 118);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(174, 27);
            txtNombre.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F);
            label2.Location = new Point(284, 85);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 6;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F);
            label3.Location = new Point(513, 36);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 7;
            label3.Text = "Nombres";
            // 
            // lstNombres
            // 
            lstNombres.Font = new Font("Segoe UI", 11.25F);
            lstNombres.FormattingEnabled = true;
            lstNombres.Location = new Point(513, 85);
            lstNombres.Name = "lstNombres";
            lstNombres.Size = new Size(216, 284);
            lstNombres.TabIndex = 8;
            // 
            // Form21Files
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lstNombres);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(btnWrite);
            Controls.Add(btnLeer);
            Controls.Add(btnNuevo);
            Controls.Add(txtContenido);
            Controls.Add(label1);
            Name = "Form21Files";
            Text = "Form21Files";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtContenido;
        private Button btnNuevo;
        private Button btnLeer;
        private Button btnWrite;
        private TextBox txtNombre;
        private Label label2;
        private Label label3;
        private ListBox lstNombres;
    }
}