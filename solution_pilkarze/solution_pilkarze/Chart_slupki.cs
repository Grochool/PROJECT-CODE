using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace solution_pilkarze
{
    public partial class Chart_slupki : Form
    {
        private int best;
        private int worst;

        public Chart_slupki(int best, int worst)
        {
            this.best = best;
            this.worst = worst;

            InitializeComponent();

            chart1.Series["Bramki"].Points.AddXY("best",best);
            chart1.Series["Bramki"].Points.AddXY("worst",worst);
        }
    }
}
