﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProgramacionOrientadaAObjetos
{
    public partial class FormIlusiones2 : Form
    {
        Pen[] colores = { new Pen(Color.Red), new Pen(Color.Yellow), new Pen(Color.Green), new Pen(Color.Blue), new Pen(Color.Fuchsia), new Pen(Color.Aqua), new Pen(Color.Sienna), new Pen(Color.Brown) };

        public FormIlusiones2()
        {
            InitializeComponent();
        }

        private void FormIlusiones2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            int w = pictureBox1.Width;
            int h = pictureBox1.Height;

            for (int i = 0; i < w / 2; i += 10)
            {
                e.Graphics.DrawLine(colores[0], 0, i, i, h / 2);
                e.Graphics.DrawLine(colores[0], i, 0, w / 2, i);

                e.Graphics.DrawLine(colores[0], w - i, 0, w / 2, i);
                e.Graphics.DrawLine(colores[0], w, i, w - i, h / 2);

                e.Graphics.DrawLine(colores[0], 0, h / 2 + i, w / 2 - i, h / 2);
                e.Graphics.DrawLine(colores[0], i, h, w / 2, h - i);

                e.Graphics.DrawLine(colores[0], w / 2, h / 2 + i, w / 2 + i, h);
                e.Graphics.DrawLine(colores[0], w, h / 2 + i, w / 2 + i, h / 2);
            }
        }
    }
}