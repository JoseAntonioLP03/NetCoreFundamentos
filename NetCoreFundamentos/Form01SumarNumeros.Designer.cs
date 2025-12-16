namespace NetCoreFundamentos
{
    partial class Form01SumarNumeros
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
            lblResultado = new Label();
            txtNumero1 = new TextBox();
            txtNumero2 = new TextBox();
            btnSumar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(78, 30);
            label1.Name = "label1";
            label1.Size = new Size(86, 21);
            label1.TabIndex = 0;
            label1.Text = "Numero1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(80, 80);
            label2.Name = "label2";
            label2.Size = new Size(90, 21);
            label2.TabIndex = 1;
            label2.Text = "Numero 2:";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            lblResultado.Location = new Point(248, 80);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(87, 21);
            lblResultado.TabIndex = 2;
            lblResultado.Text = "Resultado:";
            // 
            // txtNumero1
            // 
            txtNumero1.Location = new Point(81, 54);
            txtNumero1.Name = "txtNumero1";
            txtNumero1.Size = new Size(100, 23);
            txtNumero1.TabIndex = 3;
            // 
            // txtNumero2
            // 
            txtNumero2.Location = new Point(81, 104);
            txtNumero2.Name = "txtNumero2";
            txtNumero2.Size = new Size(100, 23);
            txtNumero2.TabIndex = 4;
            // 
            // btnSumar
            // 
            btnSumar.BackColor = SystemColors.MenuHighlight;
            btnSumar.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSumar.ForeColor = SystemColors.Control;
            btnSumar.Location = new Point(83, 133);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(96, 36);
            btnSumar.TabIndex = 5;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = false;
            btnSumar.Click += btnSumar_Click;
            // 
            // Form01SumarNumeros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 315);
            Controls.Add(btnSumar);
            Controls.Add(txtNumero2);
            Controls.Add(txtNumero1);
            Controls.Add(lblResultado);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form01SumarNumeros";
            Text = "Form01SumarNumeros";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblResultado;
        private TextBox txtNumero1;
        private TextBox txtNumero2;
        private Button btnSumar;
    }
}