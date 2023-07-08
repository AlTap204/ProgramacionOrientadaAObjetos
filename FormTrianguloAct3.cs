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
    public partial class FormTrianguloAct3 : Form
    {
        public FormTrianguloAct3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Holaaa");
            //MessageBox.Show(textBox1.Text + " " + textBox2.Text);
            //MessageBox.Show(textBox1.Text + textBox2.Text);
            try{
                int lado1 = Convert.ToInt32(textBox1.Text);
                int lado2 = Convert.ToInt32(textBox2.Text);
                int lado3 = Convert.ToInt32(textBox3.Text);
                MessageBox.Show((lado1 + lado2 + lado3).ToString());
            }catch(Exception Error){
                MessageBox.Show("Error", "Errorsito", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        }
    }
}
