namespace WinFormsApp
{
    public partial class FrmCaulculos : Form
    {
        public FrmCaulculos()
        {
            InitializeComponent();
        }

        private void FrmCaulculos_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(txtValor1.Text);
            int v2 = Convert.ToInt32(txtValor2.Text);

            MessageBox.Show((v1 + v2).ToString(), "Calculo", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void txtValor2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtValor1_TextChanged(object sender, EventArgs e)
        {
        }

        private void lbValor2_Click(object sender, EventArgs e)
        {

        }

        private void lbValor1_Click(object sender, EventArgs e)
        {

        }

        private void lbIdade_Click(object sender, EventArgs e)
        {

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"eu tenho {txtIdade.Text} anos", "Minha idade");


        }

        private void txtIdade_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(txtValor1.Text);
            int v2 = Convert.ToInt32(txtValor2.Text);
            MessageBox.Show((v1 * v2).ToString(), "multiplicação", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void txtMulti_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMulti2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSubtrair_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(txtValor1.Text);
            int v2 = Convert.ToInt32(txtValor2.Text);
            MessageBox.Show((v1 - v2).ToString(), "Subtração", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            int v1 = Convert.ToInt32(txtValor1.Text);
            int v2 = Convert.ToInt32(txtValor2.Text);
            MessageBox.Show((v1 / v2).ToString(), "Divisão", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        public float MetodoImc(float peso, float altura)
        {

        }

        private void btnImc_Click(object sender, EventArgs e)
        {
            string imcClasse;
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
                    imcClasse =("Você está no peso ideal parabéns");
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

        private void txtPeso_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtAltura_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
