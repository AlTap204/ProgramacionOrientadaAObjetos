using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgramacionOrientadaAObjetos
{
    public partial class FormEncuesta : Form
    {
        public FormEncuesta()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Procesando Encuesta");
            richTextBox1.Text = "Welcome " + textBox1.Text + " " + textBox2.Text + " " + textBox3.Text + "\n Fecha de nacimiento" + dateTimePicker1;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
