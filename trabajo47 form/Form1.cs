namespace trabajo47_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int sumas = 0;
        int suma_par = 0;
        int num_mayor = 0;
        int contador = 0;

        private void suma_Click(object sender, EventArgs e)
        {

            var nro = int.Parse(Num1.Text);

            contador++;

            sumas += nro;
            if (espar(nro))
            {
                suma_par += nro;
            }

            if (num_mayor < nro)
            {
                num_mayor = nro;
            }

            borrartext();

            if (contador == 10)
            {
                MessageBox.Show($"la suma es: {sumas}");
                MessageBox.Show($"la suma de los pares es:{suma_par}");
                MessageBox.Show($"El mayor numero ingresado fue: {num_mayor}");
            }


            bool espar(int nro)
            {
                return nro % 2 == 0;
            }



        }

        private void borrartext()
        {
            Num1.Clear();
            Num1.Focus();
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            sumas = 0;
            suma_par = 0;
            num_mayor = 0;
            contador = 0;
        }
    }
}