namespace NetCoreFundamentos
{
    partial class Form10ColeccionGrafica
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
            lstElementos = new ListBox();
            label2 = new Label();
            txtElemento = new TextBox();
            btnInsertar = new Button();
            btnEliminar = new Button();
            btnBorrar = new Button();
            lblItem = new Label();
            lblIndex = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 43);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 0;
            label1.Text = "ELEMENTOS";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(82, 76);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(215, 214);
            lstElementos.TabIndex = 1;
            lstElementos.SelectedIndexChanged += lstElementos_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(440, 43);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 2;
            label2.Text = "Nuevo Elemento";
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(440, 76);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(276, 23);
            txtElemento.TabIndex = 3;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.FromArgb(192, 255, 192);
            btnInsertar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertar.Location = new Point(461, 122);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(224, 36);
            btnInsertar.TabIndex = 4;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 255, 192);
            btnEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(461, 182);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(224, 36);
            btnEliminar.TabIndex = 5;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(255, 128, 128);
            btnBorrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(461, 242);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(224, 36);
            btnBorrar.TabIndex = 6;
            btnBorrar.Text = "Borrar Todo";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblItem.Location = new Point(95, 329);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(62, 21);
            lblItem.TabIndex = 7;
            lblItem.Text = "lblItem";
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblIndex.Location = new Point(95, 367);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(69, 21);
            lblIndex.TabIndex = 8;
            lblIndex.Text = "lblIndex";
            // 
            // Form10ColeccionGrafica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblIndex);
            Controls.Add(lblItem);
            Controls.Add(btnBorrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtElemento);
            Controls.Add(label2);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Name = "Form10ColeccionGrafica";
            Text = "Form10ColeccionGrafica";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox lstElementos;
        private Label label2;
        private TextBox txtElemento;
        private Button btnInsertar;
        private Button btnEliminar;
        private Button btnBorrar;
        private Label lblItem;
        private Label lblIndex;
    }
}