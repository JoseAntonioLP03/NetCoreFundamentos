namespace NetCoreFundamentos
{
    partial class Form04DateTime
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
            txtFecha = new TextBox();
            chckboxFormato = new CheckBox();
            rdbDias = new RadioButton();
            rdbMeses = new RadioButton();
            rdbAnyos = new RadioButton();
            label2 = new Label();
            txtIncremento = new TextBox();
            btnIncrementar = new Button();
            txtFinal = new TextBox();
            label3 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(51, 36);
            label1.Name = "label1";
            label1.Size = new Size(107, 21);
            label1.TabIndex = 0;
            label1.Text = "Fecha Actual";
            // 
            // txtFecha
            // 
            txtFecha.Location = new Point(54, 69);
            txtFecha.Name = "txtFecha";
            txtFecha.Size = new Size(420, 23);
            txtFecha.TabIndex = 1;
            // 
            // chckboxFormato
            // 
            chckboxFormato.AutoSize = true;
            chckboxFormato.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            chckboxFormato.Location = new Point(60, 114);
            chckboxFormato.Name = "chckboxFormato";
            chckboxFormato.Size = new Size(133, 21);
            chckboxFormato.TabIndex = 2;
            chckboxFormato.Text = "Cambiar Formato";
            chckboxFormato.UseVisualStyleBackColor = true;
            chckboxFormato.CheckedChanged += chckboxFormato_CheckedChanged;
            // 
            // rdbDias
            // 
            rdbDias.AutoSize = true;
            rdbDias.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rdbDias.Location = new Point(59, 142);
            rdbDias.Name = "rdbDias";
            rdbDias.Size = new Size(51, 21);
            rdbDias.TabIndex = 3;
            rdbDias.TabStop = true;
            rdbDias.Text = "Dias";
            rdbDias.UseVisualStyleBackColor = true;
            // 
            // rdbMeses
            // 
            rdbMeses.AutoSize = true;
            rdbMeses.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rdbMeses.Location = new Point(59, 167);
            rdbMeses.Name = "rdbMeses";
            rdbMeses.Size = new Size(64, 21);
            rdbMeses.TabIndex = 4;
            rdbMeses.TabStop = true;
            rdbMeses.Text = "Meses";
            rdbMeses.UseVisualStyleBackColor = true;
            // 
            // rdbAnyos
            // 
            rdbAnyos.AutoSize = true;
            rdbAnyos.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            rdbAnyos.Location = new Point(60, 192);
            rdbAnyos.Name = "rdbAnyos";
            rdbAnyos.Size = new Size(64, 21);
            rdbAnyos.TabIndex = 5;
            rdbAnyos.TabStop = true;
            rdbAnyos.Text = "Anyos";
            rdbAnyos.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(263, 137);
            label2.Name = "label2";
            label2.Size = new Size(98, 21);
            label2.TabIndex = 6;
            label2.Text = "Incremento";
            // 
            // txtIncremento
            // 
            txtIncremento.Location = new Point(367, 135);
            txtIncremento.Name = "txtIncremento";
            txtIncremento.Size = new Size(107, 23);
            txtIncremento.TabIndex = 7;
            // 
            // btnIncrementar
            // 
            btnIncrementar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIncrementar.Location = new Point(270, 180);
            btnIncrementar.Name = "btnIncrementar";
            btnIncrementar.Size = new Size(204, 31);
            btnIncrementar.TabIndex = 8;
            btnIncrementar.Text = "Incrementar";
            btnIncrementar.UseVisualStyleBackColor = true;
            btnIncrementar.Click += btnIncrementar_Click;
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(60, 267);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(420, 23);
            txtFinal.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(57, 234);
            label3.Name = "label3";
            label3.Size = new Size(95, 21);
            label3.TabIndex = 9;
            label3.Text = "Fecha Final";
            // 
            // Form04DateTime
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtFinal);
            Controls.Add(label3);
            Controls.Add(btnIncrementar);
            Controls.Add(txtIncremento);
            Controls.Add(label2);
            Controls.Add(rdbAnyos);
            Controls.Add(rdbMeses);
            Controls.Add(rdbDias);
            Controls.Add(chckboxFormato);
            Controls.Add(txtFecha);
            Controls.Add(label1);
            Name = "Form04DateTime";
            Text = "Form04DateTime";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtFecha;
        private CheckBox chckboxFormato;
        private RadioButton rdbDias;
        private RadioButton rdbMeses;
        private RadioButton rdbAnyos;
        private Label label2;
        private TextBox txtIncremento;
        private Button btnIncrementar;
        private TextBox txtFinal;
        private Label label3;
    }
}