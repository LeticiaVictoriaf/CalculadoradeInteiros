namespace CalculadoradeInteiros
{
    public partial class Form1 : Form

    {
        public int resultado, numTemp;
        public string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void DigitaNumero(int num)
        {
            numTemp = (numTemp * 10) + num;
            display.Text = numTemp.ToString();

        }

        private void DigitaOperacao(string operador)
        {
            if (operacao.Length > 0)
            {
                CalculaResultado();
            } else
            {
                resultado = numTemp;
            }
            resultado = numTemp;
            numTemp = 0;
            operacao = operador;
        }
         private void CalculaResultado()
        {
            switch (operacao)
            {
                case "+":
                    resultado = resultado + numTemp;
                    break;

                case "-":
                    resultado = resultado - numTemp;
                    break;

                case "*":
                    resultado = resultado * numTemp;
                    break;

                case "/":
                    resultado = resultado / numTemp;
                    break;



            }
            display.Text = resultado.ToString();
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
            DigitaNumero(2);
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
            CalculaResultado();
            resultado = 0;
            numTemp = 0;
            operacao = "";

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Display_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
