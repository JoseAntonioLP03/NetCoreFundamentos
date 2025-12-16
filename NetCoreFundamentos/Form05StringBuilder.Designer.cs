namespace NetCoreFundamentos
{
    partial class Form05StringBuilder
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
            txtTexto = new TextBox();
            lblTiempo = new Label();
            btnString = new Button();
            btnStrBuilder = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 30);
            label1.Name = "label1";
            label1.Size = new Size(239, 25);
            label1.TabIndex = 0;
            label1.Text = "Copie Texto Para Trabajar";
            // 
            // txtTexto
            // 
            txtTexto.Location = new Point(63, 73);
            txtTexto.Multiline = true;
            txtTexto.Name = "txtTexto";
            txtTexto.Size = new Size(557, 244);
            txtTexto.TabIndex = 1;
            // 
            // lblTiempo
            // 
            lblTiempo.AutoSize = true;
            lblTiempo.ForeColor = Color.Red;
            lblTiempo.Location = new Point(63, 329);
            lblTiempo.Name = "lblTiempo";
            lblTiempo.Size = new Size(50, 15);
            lblTiempo.TabIndex = 2;
            lblTiempo.Text = "Tiempo:";
            // 
            // btnString
            // 
            btnString.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnString.Location = new Point(105, 373);
            btnString.Name = "btnString";
            btnString.Size = new Size(183, 45);
            btnString.TabIndex = 3;
            btnString.Text = "Invertir String";
            btnString.UseVisualStyleBackColor = true;
            btnString.Click += btnString_Click;
            // 
            // btnStrBuilder
            // 
            btnStrBuilder.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnStrBuilder.Location = new Point(369, 373);
            btnStrBuilder.Name = "btnStrBuilder";
            btnStrBuilder.Size = new Size(183, 45);
            btnStrBuilder.TabIndex = 4;
            btnStrBuilder.Text = "Invertir StringBuilder";
            btnStrBuilder.UseVisualStyleBackColor = true;
            btnStrBuilder.Click += btnStrBuilder_Click;
            // 
            // Form05StringBuilder
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStrBuilder);
            Controls.Add(btnString);
            Controls.Add(lblTiempo);
            Controls.Add(txtTexto);
            Controls.Add(label1);
            Name = "Form05StringBuilder";
            Text = "Form05StringBuilder";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTexto;
        private Label lblTiempo;
        private Button btnString;
        private Button btnStrBuilder;
    }
}