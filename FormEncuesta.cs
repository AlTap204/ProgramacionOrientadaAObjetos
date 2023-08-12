using System;
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
            //podemos dar salto de linea/enter antes o despues de un +
            richTextBox1.Text = "Welcome " + textBox1.Text + " " + textBox2.Text
                + " " + textBox3.Text + "\n Fecha de nacimiento "
                + dateTimePicker1.Text + "\n Year of birth " + numericUpDown1.Text
                + " " + "\n Mi comida favorita es ... " + comboBox1.Text +
                "\n Favorite movie: " + comboBox2.Text +
                "\n ¿Te gusta programar? ";
            if (radioButton1.Checked == true)
            {
                richTextBox1.Text += "Guacala";
            }
            if (radioButton2.Checked == true)
            {
                richTextBox1.Text += "No se";
            }
            if (radioButton3.Checked == true)
            {
                richTextBox1.Text += "Me ofende la pregunta";
            }
            if (radioButton4.Checked == true)
            {
                richTextBox1.Text += "Todas las anteriores";
            }

            richTextBox1.Text += " " + "\n Complete la oracion: yo soy ...";
            if (checkBox1.Checked == true)
            {
                richTextBox1.Text += "\nSi";
            }
            if (checkBox2.Checked == true)
            {
                richTextBox1.Text += "\nPasa info para transferir";
            }
            if (checkBox3.Checked == true)
            {
                richTextBox1.Text += "\nAHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHHH";
            }
            if (checkBox4.Checked == true)
            {
                richTextBox1.Text += "\nJenny Rivera";
            }
            if (checkBox5.Checked == true)
            {
                richTextBox1.Text += "\nChayanne";
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormEncuesta_Load(object sender, EventArgs e)
        {
            comboBox2.Text = comboBox2.Items[2].ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Now;
            numericUpDown1.Value = 2023;
            comboBox1.Text = " ";
            comboBox2.Text = " ";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = false;
            radioButton4.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
            richTextBox1.Text = " ";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Jose";
            textBox2.Text = "Abril";
            textBox3.Text = "Garcia";
            dateTimePicker1.Value = new DateTime(1977, 05, 28);
            numericUpDown1.Value = 1977;
            comboBox1.Text = "Hamburguesa con papas";
            comboBox2.Text = comboBox2.Items[0].ToString();
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            radioButton3.Checked = true;
            radioButton4.Checked = false;
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
