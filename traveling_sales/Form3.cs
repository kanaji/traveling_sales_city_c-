using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace traveling_sales
{
    public partial class Form3 : Form
    {
        public List<Button> verts { get; set; }

        public Form3(List<Button>temp)
        {
            InitializeComponent();
            verts = temp;
            //****************** GRAPH INTIALIZE *****************************
            Graph graph = new Graph();

            // trzeba usunąć argumenty, gdyż graf jest z góry ustalony
            graph = GraphMethods.CreateFullGraph(verts);


            //************ NEAREST NEIGHBOUR *********************************
            NearestNeighbour nn = new NearestNeighbour();
            nn.graph = graph;

            label1.Text = "Nearest Nieghbour\n";

            int k = 0;
            foreach (Vertex v in nn.NearestNeighbourOptimization())
            {
                label1.Text += k.ToString()+".  ";
                label1.Text += v.index.ToString() + "\n";
                k++;
            }
            label1.Text += '\n';
            label1.Text += "Distance:" + nn.minDistance.ToString();
            label1.Text += '\n';




        }

        private void Form3_Load(object sender, EventArgs e)
        {

            

        }


    }
}
