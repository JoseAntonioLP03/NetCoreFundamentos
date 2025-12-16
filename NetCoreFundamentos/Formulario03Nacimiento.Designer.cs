namespace NetCoreFundamentos
{
    partial class Formulario03Nacimiento
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
            label2 = new Label();
            label3 = new Label();
            txtDia = new TextBox();
            txtMes = new TextBox();
            txtAño = new TextBox();
            btnMostrar = new Button();
            lblDia = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(84, 80);
            label1.Name = "label1";
            label1.Size = new Size(32, 20);
            label1.TabIndex = 0;
            label1.Text = "Día";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(84, 114);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Mes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label3.Location = new Point(84, 146);
            label3.Name = "label3";
            label3.Size = new Size(38, 20);
            label3.TabIndex = 2;
            label3.Text = "Año";
            // 
            // txtDia
            // 
            txtDia.Location = new Point(135, 77);
            txtDia.Name = "txtDia";
            txtDia.Size = new Size(100, 23);
            txtDia.TabIndex = 3;
            // 
            // txtMes
            // 
            txtMes.Location = new Point(135, 111);
            txtMes.Name = "txtMes";
            txtMes.Size = new Size(100, 23);
            txtMes.TabIndex = 4;
            // 
            // txtAño
            // 
            txtAño.Location = new Point(135, 143);
            txtAño.Name = "txtAño";
            txtAño.Size = new Size(100, 23);
            txtAño.TabIndex = 5;
            // 
            // btnMostrar
            // 
            btnMostrar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMostrar.Location = new Point(104, 182);
            btnMostrar.Name = "btnMostrar";
            btnMostrar.Size = new Size(113, 27);
            btnMostrar.TabIndex = 6;
            btnMostrar.Text = "Mostrar Día";
            btnMostrar.UseVisualStyleBackColor = true;
            btnMostrar.Click += btnMostrar_Click;
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblDia.ForeColor = Color.Blue;
            lblDia.Location = new Point(84, 225);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(219, 21);
            lblDia.TabIndex = 7;
            lblDia.Text = "El día de la semana es LUNES";
            // 
            // Formulario03Nacimiento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblDia);
            Controls.Add(btnMostrar);
            Controls.Add(txtAño);
            Controls.Add(txtMes);
            Controls.Add(txtDia);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Formulario03Nacimiento";
            Text = "Formulario03Nacimiento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtDia;
        private TextBox txtMes;
        private TextBox txtAño;
        private Button btnMostrar;
        private Label lblDia;
    }
}