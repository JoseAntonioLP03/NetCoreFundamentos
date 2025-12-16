namespace NetCoreFundamentos
{
    partial class Form11ColeccionMultiple
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
            lblIndex = new Label();
            lblItem = new Label();
            btnSeleccionados = new Button();
            btnEliminar = new Button();
            btnInsertar = new Button();
            txtElemento = new TextBox();
            label2 = new Label();
            lstElementos = new ListBox();
            label1 = new Label();
            btnBorrar = new Button();
            SuspendLayout();
            // 
            // lblIndex
            // 
            lblIndex.AutoSize = true;
            lblIndex.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblIndex.Location = new Point(100, 377);
            lblIndex.Name = "lblIndex";
            lblIndex.Size = new Size(69, 21);
            lblIndex.TabIndex = 17;
            lblIndex.Text = "lblIndex";
            // 
            // lblItem
            // 
            lblItem.AutoSize = true;
            lblItem.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            lblItem.Location = new Point(100, 339);
            lblItem.Name = "lblItem";
            lblItem.Size = new Size(62, 21);
            lblItem.TabIndex = 16;
            lblItem.Text = "lblItem";
            // 
            // btnSeleccionados
            // 
            btnSeleccionados.BackColor = Color.FromArgb(255, 224, 192);
            btnSeleccionados.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeleccionados.Location = new Point(466, 252);
            btnSeleccionados.Name = "btnSeleccionados";
            btnSeleccionados.Size = new Size(224, 36);
            btnSeleccionados.TabIndex = 15;
            btnSeleccionados.Text = "Borrar Seleccionado";
            btnSeleccionados.UseVisualStyleBackColor = false;
            btnSeleccionados.Click += btnSeleccionados_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.FromArgb(255, 255, 192);
            btnEliminar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(466, 192);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(224, 36);
            btnEliminar.TabIndex = 14;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.FromArgb(192, 255, 192);
            btnInsertar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInsertar.Location = new Point(466, 132);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(224, 36);
            btnInsertar.TabIndex = 13;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // txtElemento
            // 
            txtElemento.Location = new Point(445, 86);
            txtElemento.Name = "txtElemento";
            txtElemento.Size = new Size(276, 23);
            txtElemento.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(445, 53);
            label2.Name = "label2";
            label2.Size = new Size(127, 21);
            label2.TabIndex = 11;
            label2.Text = "Nuevo Elemento";
            // 
            // lstElementos
            // 
            lstElementos.FormattingEnabled = true;
            lstElementos.Location = new Point(87, 86);
            lstElementos.Name = "lstElementos";
            lstElementos.Size = new Size(215, 214);
            lstElementos.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(79, 53);
            label1.Name = "label1";
            label1.Size = new Size(117, 25);
            label1.TabIndex = 9;
            label1.Text = "ELEMENTOS";
            // 
            // btnBorrar
            // 
            btnBorrar.BackColor = Color.FromArgb(255, 128, 128);
            btnBorrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(466, 313);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(224, 36);
            btnBorrar.TabIndex = 18;
            btnBorrar.Text = "Borrar Todos";
            btnBorrar.UseVisualStyleBackColor = false;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // Form11ColeccionMultiple
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBorrar);
            Controls.Add(lblIndex);
            Controls.Add(lblItem);
            Controls.Add(btnSeleccionados);
            Controls.Add(btnEliminar);
            Controls.Add(btnInsertar);
            Controls.Add(txtElemento);
            Controls.Add(label2);
            Controls.Add(lstElementos);
            Controls.Add(label1);
            Name = "Form11ColeccionMultiple";
            Text = "Form11ColeccionMultiple";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIndex;
        private Label lblItem;
        private Button btnSeleccionados;
        private Button btnEliminar;
        private Button btnInsertar;
        private TextBox txtElemento;
        private Label label2;
        private ListBox lstElementos;
        private Label label1;
        private Button btnBorrar;
    }
}