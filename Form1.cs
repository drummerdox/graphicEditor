using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace graphicEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int x_MouseDown_1;
        public int y_MouseDown_1;
        public bool OffOn = false;
        public int x_MouseMove;
        public int y_MouseMove;
        public bool pancil_mode = false;
        public bool rubber_mode = false;
        public int i = 3;
        private Tool tool;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            tool.setLastMousePosition(e.X, e.Y);

            //x_MouseDown_1 = e.X;
            //y_MouseDown_1 = e.Y;
            //OffOn = true;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            tool.setLastMousePosition(e.X, e.Y);

            //try
            //{
            //    tool.draw(e.X, e.Y);
            //}
            //catch(NullReferenceException ){
            //    }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            OffOn = false;
            tool.setLastMousePosition(e.X, e.Y);
            tool.complete();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tool = new Pencil();
            //pancil_mode = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //textBox1.Text = "3";
            i = Convert.ToInt32(textBox1.Text); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tool = new Rubber();
            //rubber_mode = true;
        }

    }
}