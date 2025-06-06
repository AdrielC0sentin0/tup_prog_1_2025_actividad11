namespace Actividad11
{
    public partial class Form1 : Form
    {
        double acumulador = 0;
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textBox1.Text);
            acumulador += valor;
            contador++;
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double promedio = acumulador / contador;

            textBox2.Text = $"Promedio: {promedio,10:f2}";
        }
    }
}
