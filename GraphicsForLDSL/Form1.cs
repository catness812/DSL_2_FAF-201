using System.Data;
using System.Text;
using Nakov.TurtleGraphics;

namespace GraphicsForLDSL
{
    public partial class Form1 : Form
    {
        private int applies;
        private int angle;
        private int length;
        private string rule;

 
        public Form1(int applies, int angle, int length, string rule)
        {
            this.applies = applies;
            this.angle = angle;
            this.length = length;
            this.rule = rule;
            InitializeComponent();
            //Turtle.Init(this);
            // DrawLSystems();
        }

        private void DrawLSystems()
        {
            Turtle.ShowTurtle = true;
            Turtle.Forward(length);
            Turtle.ShowTurtle = false;
            Turtle.Angle = 0;
            var stack = new Stack<(string X, string Y, string curAngle)>();
            for (int i = 0; i < applies; i++)
            {
                for (int j = 0; j < rule.Length; j++)
                {
                    char currentChar = rule[j];
                    switch (currentChar)
                    {
                        case '+':

                            break;
                        case '-':

                            break;
                        case '[':

                            break;
                        case ']':

                            break;
                        default:
                            Turtle.Forward(length);
                            break;
                        
                    }
                }
            }

            Turtle.Dispose();
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            Turtle.Rotate(15);
            Turtle.Forward(100);
            Turtle.Rotate(15);
            Turtle.Forward(100);
            Turtle.Rotate(15);
            Turtle.Forward(150);
            DrawLSystems();
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
            }
            else
            {
                Turtle.ShowTurtle = true;
            }
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }
    }
}