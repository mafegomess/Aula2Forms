using AulasWindowsForms.Utilitario;

namespace AulasWindowsForms
{
    public partial class FrmRestoDivisao : Form
    {
        public FrmRestoDivisao()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void BtnDivisao_Click(object sender, EventArgs e)
        {
            try { 
            int dividendo = Convert.ToInt32(txtDividendo.Text);
            int divisor = Convert.ToInt32(txtDivisor.Text);
            if (divisor == 0)
                {
                    throw new DivideByZeroException();
                }
            Calculadora calculadora = new Calculadora();
            int resto = calculadora.Resto(dividendo, divisor);
            txtResto.Text = resto.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("O valor inserido n�o � v�lido, insira um n�mero inteiro.", "Erro", MessageBoxButtons.OK);
            }
            catch (DivideByZeroException)
            {
                MessageBox.Show("O Divisor n�o pode ser 0.", "Erro", MessageBoxButtons.OK);
            }
        }
    }
}
