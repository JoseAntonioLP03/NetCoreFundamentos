namespace NetCoreFundamentos
{
    partial class Form13TiendaProductos
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
            txtProducto = new TextBox();
            btnNuevo = new Button();
            btnEliminar = new Button();
            btnBorrar = new Button();
            listaTienda = new ListBox();
            label2 = new Label();
            label3 = new Label();
            listaAlmacen = new ListBox();
            btnSeleccionar = new Button();
            btnTodos = new Button();
            btnBajar = new Button();
            btnSubir = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 66);
            label1.Name = "label1";
            label1.Size = new Size(104, 30);
            label1.TabIndex = 0;
            label1.Text = "Producto";
            // 
            // txtProducto
            // 
            txtProducto.Location = new Point(58, 105);
            txtProducto.Name = "txtProducto";
            txtProducto.Size = new Size(172, 23);
            txtProducto.TabIndex = 1;
            // 
            // btnNuevo
            // 
            btnNuevo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNuevo.Location = new Point(68, 182);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(144, 36);
            btnNuevo.TabIndex = 2;
            btnNuevo.Text = "Nuevo";
            btnNuevo.UseVisualStyleBackColor = true;
            btnNuevo.Click += btnNuevo_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEliminar.Location = new Point(68, 232);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(144, 36);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBorrar.Location = new Point(68, 281);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(144, 36);
            btnBorrar.TabIndex = 4;
            btnBorrar.Text = "Borrar Todo";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // listaTienda
            // 
            listaTienda.BackColor = Color.FromArgb(192, 192, 255);
            listaTienda.FormattingEnabled = true;
            listaTienda.Location = new Point(258, 65);
            listaTienda.Name = "listaTienda";
            listaTienda.Size = new Size(175, 319);
            listaTienda.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(258, 36);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 6;
            label2.Text = "TIENDA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(557, 36);
            label3.Name = "label3";
            label3.Size = new Size(103, 25);
            label3.TabIndex = 8;
            label3.Text = "ALMACÉN";
            // 
            // listaAlmacen
            // 
            listaAlmacen.BackColor = Color.FromArgb(192, 255, 192);
            listaAlmacen.FormattingEnabled = true;
            listaAlmacen.Location = new Point(557, 65);
            listaAlmacen.Name = "listaAlmacen";
            listaAlmacen.Size = new Size(175, 319);
            listaAlmacen.TabIndex = 7;
            // 
            // btnSeleccionar
            // 
            btnSeleccionar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSeleccionar.Location = new Point(439, 116);
            btnSeleccionar.Name = "btnSeleccionar";
            btnSeleccionar.Size = new Size(112, 36);
            btnSeleccionar.TabIndex = 9;
            btnSeleccionar.Text = "Selección";
            btnSeleccionar.UseVisualStyleBackColor = true;
            btnSeleccionar.Click += btnSeleccionar_Click;
            // 
            // btnTodos
            // 
            btnTodos.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnTodos.Location = new Point(439, 172);
            btnTodos.Name = "btnTodos";
            btnTodos.Size = new Size(112, 36);
            btnTodos.TabIndex = 10;
            btnTodos.Text = "Todos";
            btnTodos.UseVisualStyleBackColor = true;
            btnTodos.Click += btnTodos_Click;
            // 
            // btnBajar
            // 
            btnBajar.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBajar.Location = new Point(738, 172);
            btnBajar.Name = "btnBajar";
            btnBajar.Size = new Size(112, 36);
            btnBajar.TabIndex = 12;
            btnBajar.Text = "Bajar";
            btnBajar.UseVisualStyleBackColor = true;
            btnBajar.Click += btnBajar_Click;
            // 
            // btnSubir
            // 
            btnSubir.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSubir.Location = new Point(738, 116);
            btnSubir.Name = "btnSubir";
            btnSubir.Size = new Size(112, 36);
            btnSubir.TabIndex = 11;
            btnSubir.Text = "Subir";
            btnSubir.UseVisualStyleBackColor = true;
            btnSubir.Click += btnSubir_Click;
            // 
            // Form13TiendaProductos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 413);
            Controls.Add(btnBajar);
            Controls.Add(btnSubir);
            Controls.Add(btnTodos);
            Controls.Add(btnSeleccionar);
            Controls.Add(label3);
            Controls.Add(listaAlmacen);
            Controls.Add(label2);
            Controls.Add(listaTienda);
            Controls.Add(btnBorrar);
            Controls.Add(btnEliminar);
            Controls.Add(btnNuevo);
            Controls.Add(txtProducto);
            Controls.Add(label1);
            Name = "Form13TiendaProductos";
            Text = "Form13TiendaProductos";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtProducto;
        private Button btnNuevo;
        private Button btnEliminar;
        private Button btnBorrar;
        private ListBox listaTienda;
        private Label label2;
        private Label label3;
        private ListBox listaAlmacen;
        private Button btnSeleccionar;
        private Button btnTodos;
        private Button btnBajar;
        private Button btnSubir;
    }
}