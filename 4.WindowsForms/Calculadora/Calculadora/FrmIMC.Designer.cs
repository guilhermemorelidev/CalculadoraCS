namespace Calculadora
{
    partial class FrmIMC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmIMC));
            btnImc = new Button();
            txtAltura = new TextBox();
            txtPeso = new TextBox();
            lbPeso = new Label();
            lbAltura = new Label();
            SuspendLayout();
            // 
            // btnImc
            // 
            btnImc.Location = new Point(34, 118);
            btnImc.Name = "btnImc";
            btnImc.Size = new Size(123, 24);
            btnImc.TabIndex = 20;
            btnImc.Text = "IMC";
            btnImc.UseVisualStyleBackColor = true;
            btnImc.Click += btnImc_Click;
            // 
            // txtAltura
            // 
            txtAltura.Location = new Point(72, 68);
            txtAltura.Name = "txtAltura";
            txtAltura.Size = new Size(52, 23);
            txtAltura.TabIndex = 19;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(72, 36);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(52, 23);
            txtPeso.TabIndex = 18;
            // 
            // lbPeso
            // 
            lbPeso.AutoSize = true;
            lbPeso.ForeColor = Color.White;
            lbPeso.Location = new Point(34, 39);
            lbPeso.Name = "lbPeso";
            lbPeso.Size = new Size(32, 15);
            lbPeso.TabIndex = 17;
            lbPeso.Text = "Peso";
            lbPeso.Click += lbPeso_Click;
            // 
            // lbAltura
            // 
            lbAltura.AutoSize = true;
            lbAltura.BackColor = Color.FromArgb(26, 26, 26);
            lbAltura.ForeColor = Color.White;
            lbAltura.Location = new Point(34, 71);
            lbAltura.Name = "lbAltura";
            lbAltura.Size = new Size(39, 15);
            lbAltura.TabIndex = 16;
            lbAltura.Text = "Altura";
            // 
            // FrmIMC
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            ClientSize = new Size(190, 185);
            Controls.Add(btnImc);
            Controls.Add(txtAltura);
            Controls.Add(txtPeso);
            Controls.Add(lbPeso);
            Controls.Add(lbAltura);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "FrmIMC";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormIMC";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnImc;
        private TextBox txtAltura;
        private TextBox txtPeso;
        private Label lbPeso;
        private Label lbAltura;
    }
}