using Nakov.TurtleGraphics;
using System.Text;

namespace LSystem
{
    public partial class Form1 : Form
    {
        private readonly float _angle;
        private readonly int _length;
        private readonly StringBuilder _rule;

        public Form1((int applies, int angle, int length, StringBuilder rule) function)
        {
            InitializeComponent();
            Activated += Form2_Activated;
            //openFileDialog1.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";
            //saveFileDialog1.Filter = "Images|*.png;*.bmp;*.jpg";
            _angle = function.angle;
            _length = function.length;
            _rule = function.rule;
        }

        private void Form2_Activated(object? sender, EventArgs e)
        {
            Turtle.Init();
            Turtle.PenSize = 2;
            Turtle.PenColor = Color.DarkGreen;
            Turtle.ShowTurtle = false;
            Turtle.PenUp();
            Turtle.MoveTo(0, -300);
            Turtle.PenDown();

            var stack = new Stack<(float X, float Y, float curAngle)>();
            for (int j = 0; j < _rule.Length; j++)
            {
                char currentChar = _rule[j];
                switch (currentChar)
                {
                    case '+':
                        Turtle.Rotate(_angle);
                        break;
                    case '-':
                        Turtle.Rotate(-_angle);
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
                        Turtle.Forward(_length);
                        break;
                }
            }

            /*using (Bitmap bmp = new Bitmap(this.Width, this.Height))
            {
                DrawToBitmap(bmp, new Rectangle(Point.Empty, bmp.Size));
                bmp.Save(@"C:\Users\Admin\Desktop\lsystems.png", ImageFormat.Png);
            }*/
        }
    }
}