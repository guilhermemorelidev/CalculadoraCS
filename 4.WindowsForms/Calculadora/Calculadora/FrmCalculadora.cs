namespace Calculadora
{
    public partial class FrmCalculadora : Form
    {
        public FrmCalculadora()
        {
            InitializeComponent();
        }

        double numero1 = 0, numero2 = 0;
        string operacao = "";

        private void Apagar_Click(object sender, EventArgs e)
        {

        }
        private void Botao_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;

            string valor = botao.Text;

            txtNumeros.Text += valor;
        }

        private void Operador_Click(object sender, EventArgs e)
        {
            Button botao = (Button)sender;
            numero1 = Convert.ToDouble(txtNumeros.Text);
            operacao = botao.Text;
            txtNumeros.Clear();
        }

        private void btnResultado_Click(object sender, EventArgs e)
        {
            numero2 = Convert.ToDouble(txtNumeros.Text);

            double resultado = 0;

            switch (operacao)
            {
                case "+":
                    resultado = numero1 + numero2;
                    break;
                case "-":
                    resultado = numero1 - numero2;
                    break;
                case "*":
                    resultado = numero1 * numero2;
                    break;
                case "/":
                    resultado = numero1 / numero2;
                    break;
            }
            txtNumeros.Text = resultado.ToString();
        }

        private void btnImc_Click(object sender, EventArgs e)
        {

        }
    }
}
