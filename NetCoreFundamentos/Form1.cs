namespace NetCoreFundamentos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnEjemplo_Click(object sender, EventArgs e)
        {
            //SOLO ESCRIBIMOS AQUI
            this.txtEjemplo.Location = new Point(10,30);
            this.txtEjemplo.Text = "Soy un texto nuevo!!!";
            this.txtEjemplo.Width = 220;
            this.txtEjemplo.BackColor = Color.Fuchsia;
            //STRING A PRIMITIVO
            int mayor = 17;
            short pequeño = (short) mayor;
            string dato = pequeño.ToString();
            dato = this.btnEjemplo.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    }
}
