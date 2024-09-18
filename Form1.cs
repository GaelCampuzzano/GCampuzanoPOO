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
            int resultado = op.Suma(num1, num2);
        }

        class Operaciones
        {
            public int Suma(int x, int y)
            {
                int totalsuma = x + y;
                return totalsuma;
            }
        }
    }
}
