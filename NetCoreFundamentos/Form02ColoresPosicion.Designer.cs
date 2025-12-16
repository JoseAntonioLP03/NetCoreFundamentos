namespace NetCoreFundamentos
{
    partial class Form02ColoresPosicion
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
            txtPosicionX = new TextBox();
            txtPosicionY = new TextBox();
            label2 = new Label();
            btnCambiarPosicion = new Button();
            label3 = new Label();
            txtRojo = new TextBox();
            txtVerde = new TextBox();
            label4 = new Label();
            txtAzul = new TextBox();
            label5 = new Label();
            btnCambiarFondo = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label1.Location = new Point(123, 51);
            label1.Name = "label1";
            label1.Size = new Size(93, 21);
            label1.TabIndex = 0;
            label1.Text = "Posicion X:";
            // 
            // txtPosicionX
            // 
            txtPosicionX.Location = new Point(126, 76);
            txtPosicionX.Name = "txtPosicionX";
            txtPosicionX.Size = new Size(100, 23);
            txtPosicionX.TabIndex = 1;
            // 
            // txtPosicionY
            // 
            txtPosicionY.Location = new Point(126, 138);
            txtPosicionY.Name = "txtPosicionY";
            txtPosicionY.Size = new Size(100, 23);
            txtPosicionY.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label2.Location = new Point(123, 113);
            label2.Name = "label2";
            label2.Size = new Size(93, 21);
            label2.TabIndex = 2;
            label2.Text = "Posicion Y:";
            // 
            // btnCambiarPosicion
            // 
            btnCambiarPosicion.Location = new Point(130, 180);
            btnCambiarPosicion.Name = "btnCambiarPosicion";
            btnCambiarPosicion.Size = new Size(96, 44);
            btnCambiarPosicion.TabIndex = 4;
            btnCambiarPosicion.Text = "Cambiar Posicion";
            btnCambiarPosicion.UseVisualStyleBackColor = true;
            btnCambiarPosicion.Click += btnCambiarPosicion_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label3.Location = new Point(263, 44);
            label3.Name = "label3";
            label3.Size = new Size(45, 21);
            label3.TabIndex = 5;
            label3.Text = "Rojo";
            // 
            // txtRojo
            // 
            txtRojo.Location = new Point(316, 43);
            txtRojo.Name = "txtRojo";
            txtRojo.Size = new Size(100, 23);
            txtRojo.TabIndex = 6;
            // 
            // txtVerde
            // 
            txtVerde.Location = new Point(316, 81);
            txtVerde.Name = "txtVerde";
            txtVerde.Size = new Size(100, 23);
            txtVerde.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label4.Location = new Point(263, 82);
            label4.Name = "label4";
            label4.Size = new Size(54, 21);
            label4.TabIndex = 7;
            label4.Text = "Verde";
            // 
            // txtAzul
            // 
            txtAzul.Location = new Point(316, 125);
            txtAzul.Name = "txtAzul";
            txtAzul.Size = new Size(100, 23);
            txtAzul.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            label5.Location = new Point(263, 126);
            label5.Name = "label5";
            label5.Size = new Size(44, 21);
            label5.TabIndex = 9;
            label5.Text = "Azul";
            // 
            // btnCambiarFondo
            // 
            btnCambiarFondo.Location = new Point(324, 181);
            btnCambiarFondo.Name = "btnCambiarFondo";
            btnCambiarFondo.Size = new Size(80, 43);
            btnCambiarFondo.TabIndex = 11;
            btnCambiarFondo.Text = "Cambiar Fondo";
            btnCambiarFondo.UseVisualStyleBackColor = true;
            btnCambiarFondo.Click += btnCambiarFondo_Click;
            // 
            // Form02ColoresPosicion
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCambiarFondo);
            Controls.Add(txtAzul);
            Controls.Add(label5);
            Controls.Add(txtVerde);
            Controls.Add(label4);
            Controls.Add(txtRojo);
            Controls.Add(label3);
            Controls.Add(btnCambiarPosicion);
            Controls.Add(txtPosicionY);
            Controls.Add(label2);
            Controls.Add(txtPosicionX);
            Controls.Add(label1);
            Name = "Form02ColoresPosicion";
            Text = "Form02ColoresPosicion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPosicionX;
        private TextBox txtPosicionY;
        private Label label2;
        private Button btnCambiarPosicion;
        private Label label3;
        private TextBox txtRojo;
        private TextBox txtVerde;
        private Label label4;
        private TextBox txtAzul;
        private Label label5;
        private Button btnCambiarFondo;
    }
}