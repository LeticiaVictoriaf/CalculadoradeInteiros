namespace CalculadoradeInteiros
{
    public partial class Form1 : Form

    {
        public int resultado, numTemp;
        public string operacao;
        public Form1()
        {
            InitializeComponent();
        }

        private void DigitaNumero(int num)
        {
            numTemp = (num * 10) + num;

        }

        private void DigitaOperacao(string operador)
        {
            resultado = numTemp;
            numTemp = 0;
            operacao = operador;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DigitaNumero(3);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DigitaNumero(1);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            DigitaNumero(7);
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            DigitaNumero(3);
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            DigitaNumero(4);
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            DigitaNumero(5);
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            DigitaNumero(6);
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            DigitaNumero(8);
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            DigitaNumero(9);
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            DigitaNumero(0);
        }

        private void btn_Soma_Click(object sender, EventArgs e)
        {
            DigitaOperacao("+");
            resultado = numTemp + DigitaNumero
        }

        private void btn_Subtracao_Click(object sender, EventArgs e)
        {
            DigitaOperacao("-");
        }

        private void btn_Multiplicacao_Click(object sender, EventArgs e)
        {
            DigitaOperacao("x");
        }

        private void btn_Divisao_Click(object sender, EventArgs e)
        {
            DigitaOperacao("/");
        }

        private void btn_Igual_Click(object sender, EventArgs e)
        {
            DigitaOperacao("=");
        }
    }
}