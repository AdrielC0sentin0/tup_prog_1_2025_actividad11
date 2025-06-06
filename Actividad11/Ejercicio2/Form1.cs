namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        double [] valores = new double[100];
        int contador = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble(textBox1.Text);
            valores[contador] = valor;
            contador ++;
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double acumulador = 0;
            for (int i = 0; i < contador; i++)
            {
                acumulador += valores[i];
            }
            double promedio = acumulador / contador;
            textBox2.Text = $"El resultado es: {promedio:f2}";
        }
    }
}
