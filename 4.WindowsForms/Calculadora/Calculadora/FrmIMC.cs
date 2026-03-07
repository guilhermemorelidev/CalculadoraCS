namespace Calculadora
{
    public partial class FrmIMC : Form
    {
        public FrmIMC()
        {
            InitializeComponent();
        }

        private void lbPeso_Click(object sender, EventArgs e)
        {

        }

        private void btnImc_Click(object sender, EventArgs e)
        {
            string imcClasse = "";
            float altura = float.Parse(txtAltura.Text);
            float peso = float.Parse(txtPeso.Text);
            float imc = peso / (altura * altura);
            MessageBox.Show(imc.ToString("F2"), "Calcular IMC", MessageBoxButtons.OK, MessageBoxIcon.Information);
            switch (imc)
            {
                case <= 18.5f:
                    imcClasse = ("Você está abaixo do peso");
                    break;
                case <= 24.9f:
                    imcClasse = ("Você está no peso ideal parabéns");
                    break;
                case <= 29.9f:
                    imcClasse = ("Você está acima do peso");
                    break;
                case <= 34.9f:
                    imcClasse = ("Você está com obesidade grau 1");
                    break;
                case <= 39.9f:
                    imcClasse = ("Você está com obesidade severa");
                    break;
                case >= 40:
                    imcClasse = ("Você está com obesidade morbida");
                    break;
            }
        }

    }
}
