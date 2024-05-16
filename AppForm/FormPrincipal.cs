using Entidades;
namespace AppForm
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int resultado = Calculadora.Sumar(txtOperandoA.Text, txtOperandoB.Text);
            MessageBox.Show(resultado.ToString(), "Resultado");
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            int resultado = Calculadora.Restar(txtOperandoA.Text, txtOperandoB.Text);
            MessageBox.Show(resultado.ToString(), "Resultado");
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            try
            {
                int resultado = Calculadora.Dividir(txtOperandoA.Text, txtOperandoB.Text);
                MessageBox.Show(resultado.ToString(), "Resultado");
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Error: No se puede dividir por cero");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
            }

        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            int resultado = Calculadora.Multiplicar(txtOperandoA.Text, txtOperandoB.Text);
            MessageBox.Show(resultado.ToString(),"Resultado");
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            try 
            {
                string respueta = Conexion.ConectarABaseDeDato(true);
                MessageBox.Show("Estado de conexion: " + respueta.ToString(),"Conectando a base de datos");
            }
            catch (ErrorDeConexionException ex) 
            {
                MessageBox.Show(ex.Message);
            }
            
            
        }
    }
}