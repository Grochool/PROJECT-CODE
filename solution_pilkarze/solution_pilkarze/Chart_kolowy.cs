using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solution_pilkarze
{
    public partial class Chart_kolowy : Form
    {
        private int above;
        private int below;

        public Chart_kolowy(int above, int below)
        {
            this.above = above;
            this.below = below;

            InitializeComponent();


            chart1.Series["Zwyciestwa"].Points.Add(above);
            chart1.Series["Zwyciestwa"].Points.Add(below);

            chart1.Series["Zwyciestwa"].Points[0].Color = System.Drawing.Color.Green;
            chart1.Series["Zwyciestwa"].Points[1].Color = System.Drawing.Color.Red;



        }
    }
}
