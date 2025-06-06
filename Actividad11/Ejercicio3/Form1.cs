namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        double[] valores = new double[100];
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(tbValor.Text);
            valores[contador] = valor;
            contador++;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double acumulador = 0;
            for (int i = 0; i < contador; i++) 
            { 
                acumulador += valores[i];
            }
            double promedio = acumulador / contador;
            tbPromedio.Text = $"Promedio: {promedio:f2}";
            tbResultado.Text = $@"Promedio: {promedio:f2}";
        }
    }
}
