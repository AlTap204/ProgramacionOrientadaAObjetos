using System;
using System.Windows.Forms;

namespace ProgramacionOrientadaAObjetos
{
    public partial class FormCatalogo : Form
    {
        public FormCatalogo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != ""
                && textBox2.Text != ""
                && textBox3.Text != ""
                && textBox4.Text != "")
            {
                dataGridView1.Rows.Add(textBox1.Text, textBox2.Text,
                   "$ " + textBox3.Text, textBox4.Text);
            }
            else
            {
                MessageBox.Show("Faltan datos para continuar",
                    "info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
      
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
