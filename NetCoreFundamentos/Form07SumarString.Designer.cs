namespace NetCoreFundamentos
{
    partial class Form07SumarString
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
            txtNumeros = new TextBox();
            btnSumar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(74, 54);
            label1.Name = "label1";
            label1.Size = new Size(196, 25);
            label1.TabIndex = 0;
            label1.Text = "Introduzca Números";
            // 
            // txtNumeros
            // 
            txtNumeros.Location = new Point(74, 90);
            txtNumeros.Name = "txtNumeros";
            txtNumeros.Size = new Size(196, 23);
            txtNumeros.TabIndex = 1;
            // 
            // btnSumar
            // 
            btnSumar.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSumar.Location = new Point(92, 123);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(159, 33);
            btnSumar.TabIndex = 2;
            btnSumar.Text = "Sumar Números";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Blue;
            label2.Location = new Point(76, 166);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 3;
            label2.Text = "Resultado: ";
            // 
            // Form07SumarString
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(btnSumar);
            Controls.Add(txtNumeros);
            Controls.Add(label1);
            Name = "Form07SumarString";
            Text = "Form07SumarString";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtNumeros;
        private Button btnSumar;
        private Label label2;
    }
}