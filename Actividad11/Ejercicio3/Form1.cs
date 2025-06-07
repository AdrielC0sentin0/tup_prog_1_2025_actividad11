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
        int Buscar(int valorBuscar)
        {
            int id = -1;
            int n = 0;
            while (n < contador && id == -1)
            {
                if (valores[n] == valorBuscar)
                {
                    id = n;
                }
                n++;
            }
            return id;
        }
        int Ordenar()
        {
            int id = -1;
            for (int pivote = 0; pivote < contador - 1; pivote++)
            {
                for (int comp = pivote + 1; comp < contador; comp++)
                {
                    if (valores[pivote] > valores[comp])
                    {
                        Intercambiar(valores, pivote, comp);
                    }
                }
            }

            return id;
        }
        void Intercambiar(double[] valores, int a, int b)
        {
            double aux = valores[a];
            valores[a] = valores[b];
            valores[b] = aux;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int buscarvalor = Convert.ToInt32(tbBuscar.Text);
            int id = Buscar(buscarvalor);

            if (id > -1)
            {
                tbResultado.Text = $"Valor encontrado en la posición {id}.";
            }
            else
            {
                tbResultado.Text = "Valor no buscado";
            }
        }

        private void btnOrdenamiento_Click(object sender, EventArgs e)
        {
            Ordenar();

            tbResultado.Clear();
            for (int n = 0; n < contador; n++)
            {
                tbResultado.AppendText($"{valores[n],5:f2}\r\n");
            }
        }
    }

}
