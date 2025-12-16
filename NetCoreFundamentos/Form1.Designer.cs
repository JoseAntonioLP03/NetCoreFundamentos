namespace NetCoreFundamentos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblEjemplo = new Label();
            txtEjemplo = new TextBox();
            btnEjemplo = new Button();
            SuspendLayout();
            // 
            // lblEjemplo
            // 
            lblEjemplo.AutoSize = true;
            lblEjemplo.BackColor = SystemColors.ActiveBorder;
            lblEjemplo.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEjemplo.Location = new Point(289, 87);
            lblEjemplo.Name = "lblEjemplo";
            lblEjemplo.Size = new Size(177, 21);
            lblEjemplo.TabIndex = 0;
            lblEjemplo.Text = "Introduzca su nombre";
            lblEjemplo.Click += label1_Click;
            // 
            // txtEjemplo
            // 
            txtEjemplo.Location = new Point(289, 114);
            txtEjemplo.Name = "txtEjemplo";
            txtEjemplo.Size = new Size(177, 23);
            txtEjemplo.TabIndex = 1;
            // 
            // btnEjemplo
            // 
            btnEjemplo.BackColor = Color.Black;
            btnEjemplo.ForeColor = SystemColors.ButtonHighlight;
            btnEjemplo.Location = new Point(342, 143);
            btnEjemplo.Name = "btnEjemplo";
            btnEjemplo.Size = new Size(75, 23);
            btnEjemplo.TabIndex = 2;
            btnEjemplo.Text = "Pulsar";
            btnEjemplo.UseVisualStyleBackColor = false;
            btnEjemplo.Click += btnEjemplo_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEjemplo);
            Controls.Add(txtEjemplo);
            Controls.Add(lblEjemplo);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEjemplo;
        private TextBox txtEjemplo;
        private Button btnEjemplo;
    }
}
