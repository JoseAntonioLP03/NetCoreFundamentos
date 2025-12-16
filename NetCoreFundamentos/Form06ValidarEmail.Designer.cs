namespace NetCoreFundamentos
{
    partial class Form06ValidarEmail
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
            txtEmail = new TextBox();
            btnValidar = new Button();
            lblErrores = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(32, 24);
            label1.Name = "label1";
            label1.Size = new Size(173, 30);
            label1.TabIndex = 0;
            label1.Text = "VALIDAR EMAIL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(42, 80);
            label2.Name = "label2";
            label2.Size = new Size(134, 21);
            label2.TabIndex = 1;
            label2.Text = "Introduzca Email:";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(42, 117);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(335, 23);
            txtEmail.TabIndex = 2;
            // 
            // btnValidar
            // 
            btnValidar.BackColor = Color.DarkGreen;
            btnValidar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnValidar.ForeColor = SystemColors.ButtonHighlight;
            btnValidar.Location = new Point(42, 192);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(122, 32);
            btnValidar.TabIndex = 3;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = false;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblErrores
            // 
            lblErrores.AutoSize = true;
            lblErrores.Font = new Font("Segoe Fluent Icons", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblErrores.ForeColor = Color.Red;
            lblErrores.Location = new Point(42, 143);
            lblErrores.Name = "lblErrores";
            lblErrores.Size = new Size(11, 16);
            lblErrores.TabIndex = 4;
            lblErrores.Text = "-";
            // 
            // Form06ValidarEmail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblErrores);
            Controls.Add(btnValidar);
            Controls.Add(txtEmail);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form06ValidarEmail";
            Text = "Form06ValidarEmail";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtEmail;
        private Button btnValidar;
        private Label lblErrores;
    }
}