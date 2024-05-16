namespace AppForm
{
    partial class FormPrincipal
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
            btnSumar = new Button();
            btnRestar = new Button();
            btnDividir = new Button();
            btnMultiplicar = new Button();
            lblOperandoA = new Label();
            txtOperandoA = new TextBox();
            txtOperandoB = new TextBox();
            lblOperandoB = new Label();
            btnConectar = new Button();
            SuspendLayout();
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(28, 233);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(204, 23);
            btnSumar.TabIndex = 0;
            btnSumar.Text = "Sumar";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(28, 277);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(204, 23);
            btnRestar.TabIndex = 1;
            btnRestar.Text = "Restar";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnDividir
            // 
            btnDividir.Location = new Point(28, 320);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(204, 23);
            btnDividir.TabIndex = 2;
            btnDividir.Text = "Dividir";
            btnDividir.UseVisualStyleBackColor = true;
            btnDividir.Click += btnDividir_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.Location = new Point(28, 367);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(204, 23);
            btnMultiplicar.TabIndex = 3;
            btnMultiplicar.Text = "Multiplicar";
            btnMultiplicar.UseVisualStyleBackColor = true;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // lblOperandoA
            // 
            lblOperandoA.AutoSize = true;
            lblOperandoA.Location = new Point(96, 54);
            lblOperandoA.Name = "lblOperandoA";
            lblOperandoA.Size = new Size(71, 15);
            lblOperandoA.TabIndex = 4;
            lblOperandoA.Text = "Operando A";
            // 
            // txtOperandoA
            // 
            txtOperandoA.Location = new Point(28, 72);
            txtOperandoA.Name = "txtOperandoA";
            txtOperandoA.Size = new Size(204, 23);
            txtOperandoA.TabIndex = 5;
            // 
            // txtOperandoB
            // 
            txtOperandoB.Location = new Point(28, 147);
            txtOperandoB.Name = "txtOperandoB";
            txtOperandoB.Size = new Size(204, 23);
            txtOperandoB.TabIndex = 7;
            // 
            // lblOperandoB
            // 
            lblOperandoB.AutoSize = true;
            lblOperandoB.Location = new Point(97, 129);
            lblOperandoB.Name = "lblOperandoB";
            lblOperandoB.Size = new Size(70, 15);
            lblOperandoB.TabIndex = 6;
            lblOperandoB.Text = "Operando B";
            // 
            // btnConectar
            // 
            btnConectar.Location = new Point(177, 12);
            btnConectar.Name = "btnConectar";
            btnConectar.Size = new Size(85, 23);
            btnConectar.TabIndex = 9;
            btnConectar.Text = "Conectar";
            btnConectar.UseVisualStyleBackColor = true;
            btnConectar.Click += btnConectar_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 450);
            Controls.Add(btnConectar);
            Controls.Add(txtOperandoB);
            Controls.Add(lblOperandoB);
            Controls.Add(txtOperandoA);
            Controls.Add(lblOperandoA);
            Controls.Add(btnMultiplicar);
            Controls.Add(btnDividir);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Name = "FormPrincipal";
            Text = "Calculadora";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSumar;
        private Button btnRestar;
        private Button btnDividir;
        private Button btnMultiplicar;
        private Label lblOperandoA;
        private TextBox txtOperandoA;
        private TextBox txtOperandoB;
        private Label lblOperandoB;
        private Button btnConectar;
    }
}