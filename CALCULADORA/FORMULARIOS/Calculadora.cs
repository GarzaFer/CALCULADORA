namespace CalculadorA
{
    public partial class Calculadora : Form
    {
        public Calculadora()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void butCALCULAR_Click(object sender, EventArgs e)
        {
            try
            {
                int a = 0, b = 0, resultado = 0;
                a = Convert.ToInt32(txtVariableA.Text);
                b = int.Parse(txtVariableB.Text);

                if (rdbSUMA.Checked)

                    resultado = a + b;

                if (rdbRESTA.Checked)

                    resultado = a - b;

                if (rdbMULTIPLICACION.Checked)

                    resultado = a * b;

                if (rdbDIVISION.Checked)
                    resultado = a / b;

                MessageBox.Show("El resultado es: " + resultado.ToString(), "RESULTADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Reset();
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

        private void Reset()
        {
            txtVariableA.Text = "";
            txtVariableB.Clear();
            txtVariableA.Focus();
        }

    }
}
