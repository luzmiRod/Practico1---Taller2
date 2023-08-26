using System.Reflection.Metadata;

namespace Practico1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BEliminar_Click(object sender, EventArgs e)
        {
            textBoxResultado.Clear();
        }

        private void BGuardar_Click(object sender, EventArgs e)
        {
            textBoxResultado.Text = textBox1.Text + " " + textBox2.Text;
        }

        private void BSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}