namespace POO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var num1 = 7;
            var num2 = 5;
            Operaciones op = new Operaciones();

            int Suma = op.Suma(num1, num2);
            int Resta = op.Resta(num1, num2);
            int Multiplicacion = op.Multiplicacion(num1, num2);
            string Division = op.Division(num1, num2);
        }

        class Operaciones
        {
            public int Suma(int x, int y)
            {
                return x + y;
            }

            public int Resta(int x, int y)
            {
                return x - y;
            }

            public int Multiplicacion(int x, int y)
            {
                return x * y;
            }

            public string Division(int x, int y)
            {
                if (y == 0)
                {
                    return "Error: División por cero";
                }
                return (x / y).ToString();
            }
        }
    }
}