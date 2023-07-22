namespace ProgramacionOrientadaAObjetos
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.practica1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practicToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practicaDeFormulaGeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.practica4DeFibonacciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Viner Hand ITC", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Lime;
            this.label1.Location = new System.Drawing.Point(12, 315);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(416, 78);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu principal de las practicas realizadas en la\r\nmateria de Programacion Orienta" +
    "da a Objetos.\r\nSe presentara el ultimo sabado de clases :)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(13, 421);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Allison A Tapia Mena";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(713, 421);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "UNIKINO";
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.practica1ToolStripMenuItem,
            this.practicToolStripMenuItem,
            this.practicaDeFormulaGeneralToolStripMenuItem,
            this.practica4DeFibonacciToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(145, 29);
            this.toolStripMenuItem1.Text = "Menu principal";
            // 
            // practica1ToolStripMenuItem
            // 
            this.practica1ToolStripMenuItem.Name = "practica1ToolStripMenuItem";
            this.practica1ToolStripMenuItem.Size = new System.Drawing.Size(411, 34);
            this.practica1ToolStripMenuItem.Text = "Practica 1 de Triangulos";
            this.practica1ToolStripMenuItem.Click += new System.EventHandler(this.practica1ToolStripMenuItem_Click);
            // 
            // practicToolStripMenuItem
            // 
            this.practicToolStripMenuItem.Name = "practicToolStripMenuItem";
            this.practicToolStripMenuItem.Size = new System.Drawing.Size(411, 34);
            this.practicToolStripMenuItem.Text = "Practica 2 de Operaciones Aritmeticas";
            this.practicToolStripMenuItem.Click += new System.EventHandler(this.practicToolStripMenuItem_Click);
            // 
            // practicaDeFormulaGeneralToolStripMenuItem
            // 
            this.practicaDeFormulaGeneralToolStripMenuItem.Name = "practicaDeFormulaGeneralToolStripMenuItem";
            this.practicaDeFormulaGeneralToolStripMenuItem.Size = new System.Drawing.Size(411, 34);
            this.practicaDeFormulaGeneralToolStripMenuItem.Text = "Practica 3 de Formula General";
            this.practicaDeFormulaGeneralToolStripMenuItem.Click += new System.EventHandler(this.practicaDeFormulaGeneralToolStripMenuItem_Click);
            // 
            // practica4DeFibonacciToolStripMenuItem
            // 
            this.practica4DeFibonacciToolStripMenuItem.Name = "practica4DeFibonacciToolStripMenuItem";
            this.practica4DeFibonacciToolStripMenuItem.Size = new System.Drawing.Size(396, 34);
            this.practica4DeFibonacciToolStripMenuItem.Text = "Practica 4 de Fibonacci";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "FormInicio";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem practica1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practicToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practicaDeFormulaGeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem practica4DeFibonacciToolStripMenuItem;
    }
}

