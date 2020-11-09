using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static traveling_sales.Graph;

namespace traveling_sales
{
    public partial class Form2 : Form
    {
        public List<Button> verts; //List of buttons for coordinates (x,y)
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            verts =  new List<Button>();
            verts.Add(button1);
            verts.Add(button2);
            verts.Add(button3);
            verts.Add(button4);
            verts.Add(button5);
            verts.Add(button6);
            verts.Add(button7);
            verts.Add(button8);
            verts.Add(button9);
            verts.Add(button10);
            verts.Add(button11);
            verts.Add(button12);
            verts.Add(button13);
            verts.Add(button14);
            verts.Add(button15);

            //Vertex x = new Vertex();
            //x.x = button1.Location.X;
        }

        public void DrawLinePointF(PaintEventArgs e)
        {

            // Create pen.
            Pen blackPen = new Pen(Color.Black, 3);

            // Create points that define line.
            PointF point1 = new PointF(100.0F, 100.0F);
            PointF point2 = new PointF(500.0F, 100.0F);

            // Draw line to screen.
            e.Graphics.DrawLine(blackPen, point1, point2);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f = new Form3(this.verts); // This is bad
            f.Show();
        }
    }
}
