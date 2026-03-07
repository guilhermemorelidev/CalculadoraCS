namespace WinFormsApp
{
    partial class FrmCaulculos
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCaulculos));
            btnCalcular = new Button();
            txtValor1 = new TextBox();
            lbValor2 = new Label();
            lbValor1 = new Label();
            txtValor2 = new TextBox();
            lbIdade = new Label();
            btnGerar = new Button();
            txtIdade = new TextBox();
            btnMulti = new Button();
            BtnSubtrair = new Button();
            btnDividir = new Button();
            lbAltura = new Label();
            lbPeso = new Label();
            txtPeso = new TextBox();
            txtAltura = new TextBox();
            btnImc = new Button();
            SuspendLayout();
            // 
            // btnCalcular
            // 
            btnCalcular.Location = new Point(70, 183);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(79, 24);
            btnCalcular.TabIndex = 0;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = true;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // txtValor1
            // 
            txtValor1.Location = new Point(70, 116);
            txtValor1.Name = "txtValor1";
            txtValor1.Size = new Size(164, 23);
            txtValor1.TabIndex = 1;
            txtValor1.TextChanged += txtValor1_TextChanged;
            // 
            // lbValor2
            // 
            lbValor2.AutoSize = true;
            lbValor2.ForeColor = Color.White;
            lbValor2.Location = new Point(19, 119);
            lbValor2.Name = "lbValor2";
            lbValor2.Size = new Size(42, 15);
            lbValor2.TabIndex = 2;
            lbValor2.Text = "Valor 1";
            lbValor2.Click += lbValor2_Click;
            // 
            // lbValor1
            // 
            lbValor1.AutoSize = true;
            lbValor1.ForeColor = Color.White;
            lbValor1.Location = new Point(19, 148);
            lbValor1.Name = "lbValor1";
            lbValor1.Size = new Size(42, 15);
            lbValor1.TabIndex = 4;
            lbValor1.Text = "Valor 2";
            lbValor1.Click += lbValor1_Click;
            // 
            // txtValor2
            // 
            txtValor2.Location = new Point(70, 145);
            txtValor2.Name = "txtValor2";
            txtValor2.ScrollBars = ScrollBars.Vertical;
            txtValor2.Size = new Size(164, 23);
            txtValor2.TabIndex = 3;
            txtValor2.TextChanged += txtValor2_TextChanged;
            // 
            // lbIdade
            // 
            lbIdade.AutoSize = true;
            lbIdade.ForeColor = Color.White;
            lbIdade.Location = new Point(25, 43);
            lbIdade.Name = "lbIdade";
            lbIdade.Size = new Size(36, 15);
            lbIdade.TabIndex = 5;
            lbIdade.Text = "Idade";
            lbIdade.Click += lbIdade_Click;
            // 
            // btnGerar
            // 
            btnGerar.Location = new Point(240, 35);
            btnGerar.Name = "btnGerar";
            btnGerar.Size = new Size(75, 23);
            btnGerar.TabIndex = 6;
            btnGerar.Text = "Gerar";
            btnGerar.UseVisualStyleBackColor = true;
            btnGerar.Click += btnGerar_Click;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(70, 35);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(164, 23);
            txtIdade.TabIndex = 7;
            txtIdade.TextChanged += txtIdade_TextChanged;
            // 
            // btnMulti
            // 
            btnMulti.Location = new Point(70, 213);
            btnMulti.Name = "btnMulti";
            btnMulti.Size = new Size(79, 24);
            btnMulti.TabIndex = 8;
            btnMulti.Text = "Multiplicar";
            btnMulti.UseVisualStyleBackColor = true;
            btnMulti.Click += button1_Click;
            // 
            // BtnSubtrair
            // 
            BtnSubtrair.Location = new Point(155, 183);
            BtnSubtrair.Name = "BtnSubtrair";
            BtnSubtrair.Size = new Size(79, 24);
            BtnSubtrair.TabIndex = 9;
            BtnSubtrair.Text = "Subtrair";
            BtnSubtrair.UseVisualStyleBackColor = true;
            BtnSubtrair.Click += BtnSubtrair_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(155, 213);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(79, 24);
            btnDividir.TabIndex = 10;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // lbAltura
            // 
            lbAltura.AutoSize = true;
            lbAltura.BackColor = Color.FromArgb(26, 26, 26);
            lbAltura.ForeColor = Color.White;
            lbAltura.Location = new Point(256, 148);
            lbAltura.Name = "lbAltura";
            lbAltura.Size = new Size(39, 15);
            lbAltura.TabIndex = 11;
            lbAltura.Text = "Altura";
            // 
            // lbPeso
            // 
            lbPeso.AutoSize = true;
            lbPeso.ForeColor = Color.White;
            lbPeso.Location = new Point(263, 119);
            lbPeso.Name = "lbPeso";
            lbPeso.Size = new Size(32, 15);
            lbPeso.TabIndex = 12;
            lbPeso.Text = "Peso";
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(301, 116);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(164, 23);
            txtPeso.TabIndex = 13;
            txtPeso.TextChanged += txtPeso_TextChanged;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(301, 145);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(164, 23);
            txtAltura.TabIndex = 14;
            txtAltura.TextChanged += txtAltura_TextChanged;
            // 
            // btnImc
            // 
            btnImc.Location = new Point(342, 183);
            btnImc.Name = "btnImc";
            btnImc.Size = new Size(79, 24);
            btnImc.TabIndex = 15;
            btnImc.Text = "IMC";
            btnImc.UseVisualStyleBackColor = true;
            btnImc.Click += btnImc_Click;
            // 
            // FrmCaulculos
            // 
            BackColor = Color.FromArgb(26, 26, 26);
            ClientSize = new Size(491, 269);
            Controls.Add(btnImc);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(lbPeso);
            Controls.Add(lbAltura);
            Controls.Add(btnDividir);
            Controls.Add(BtnSubtrair);
            Controls.Add(btnMulti);
            Controls.Add(txtIdade);
            Controls.Add(btnGerar);
            Controls.Add(lbIdade);
            Controls.Add(lbValor1);
            Controls.Add(txtValor2);
            Controls.Add(lbValor2);
            Controls.Add(txtValor1);
            Controls.Add(btnCalcular);
            ForeColor = SystemColors.ControlText;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "FrmCaulculos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora ";
            Load += FrmCaulculos_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCalcular;
        private TextBox txtValor1;
        private Label lbValor2;
        private Label lbValor1;
        private TextBox txtValor2;
        private Label lbIdade;
        private Button btnGerar;
        private TextBox txtIdade;
        private Button btnMulti;
        private Button BtnSubtrair;
        private Button btnDividir;
        private Label lbAltura;
        private Label lbPeso;
        private TextBox txtPeso;
        private TextBox txtAltura;
        private Button btnImc;
    }
}
