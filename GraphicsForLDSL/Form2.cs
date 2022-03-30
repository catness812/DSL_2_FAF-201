using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nakov.TurtleGraphics;

namespace GraphicsForLDSL
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Draw_Click(object sender, EventArgs e)
        {
            Turtle.Rotate(15);
            Turtle.Forward(100);
            Turtle.Rotate(15);
            Turtle.Forward(100);
            Turtle.Rotate(15);
            Turtle.Forward(150);
        }
    }
}
