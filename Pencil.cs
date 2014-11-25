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
    class Pencil : Tool
    {
        protected Color color = Color.Red;

       // Form1 PencilForm = new Form1();
        public void draw(int x, int y)
        {
            //if (Program.formInstance.pancil_mode == true)
            {
                Graphics g = Graphics.FromHwnd(Program.formInstance.pictureBox1.Handle);
                Program.formInstance.x_MouseMove = x;
                Program.formInstance.y_MouseMove = y;
                Pen MyPen = new Pen(color, Program.formInstance.i);
                if (Program.formInstance.OffOn == true)
                {
                    g.DrawLine(MyPen, Program.formInstance.x_MouseDown_1, Program.formInstance.y_MouseDown_1, Program.formInstance.x_MouseMove, Program.formInstance.y_MouseMove);
                    Program.formInstance.x_MouseDown_1 = Program.formInstance.x_MouseMove;
                    Program.formInstance.y_MouseDown_1 = Program.formInstance.y_MouseMove;
                }
            }
        }
    }
}



