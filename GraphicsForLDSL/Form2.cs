using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicsForLDSL
{
    public partial class Form2 : Form
    {
        private float angle = 45;
        private int length = 30;
        private string rule = "ffff[+ff[+f[+X][-X]X][-f[+X][-X]X]f[+X][-X]X]" +
            "[-ff[+f[+X][-X]X][-f[+X][-X]X]f[+X][-X]X]ff[+f[+X][-X]X][-f[+X]" +
            "[-X]X]f[+X][-X]X";
        public Form2()
        {
            InitializeComponent();
            Activated += Form2_Activated;
            //openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            //saveFileDialog1.Filter = "Images|*.png;*.bmp;*.jpg";
        }

        private void Form2_Activated(object? sender, EventArgs e)
        {
            Turtle.Init();
            Turtle.PenSize = 2;
            Turtle.PenColor = Color.DarkGreen;
            Turtle.ShowTurtle = false;


            var stack = new Stack<(float X, float Y, float curAngle)>();
            for (int j = 0; j < rule.Length; j++)
            {
                char currentChar = rule[j];
                switch (currentChar)
                {
                    case '+':
                        Turtle.Rotate(angle);
                        break;
                    case '-':
                        Turtle.Rotate(-angle);
                        break;
                    case '[':
                        stack.Push((Turtle.X, Turtle.Y, Turtle.Angle));
                        break;
                    case ']':
                        (float x, float y, float curAngle) = stack.Pop();
                        Turtle.X = x;
                        Turtle.Y = y;
                        Turtle.Angle = curAngle;
                        break;
                    default:
                        Turtle.Forward(length);
                        break;

                }
            }

            using (Bitmap bmp = new Bitmap(this.Width, this.Height))
            {
                DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
                bmp.Save(@"C:\Users\Admin\Desktop\lsystems.png", ImageFormat.Png);
            }


        }

    }
    
}
