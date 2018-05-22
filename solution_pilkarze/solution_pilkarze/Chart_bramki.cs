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
    public partial class Chart_bramki : Form
    {
        private string[] ligi;
        private int[] bramki;
        public Chart_bramki(string[] ligi, int[] bramki)
        {
            this.ligi = ligi;
            this.bramki = bramki;
            InitializeComponent();

            chart1.Series["Bramki"].Points.AddXY(ligi[0], bramki[0]);
            chart1.Series["Bramki"].Points.AddXY(ligi[1], bramki[1]);
            chart1.Series["Bramki"].Points.AddXY(ligi[2], bramki[2]);
            chart1.Series["Bramki"].Points.AddXY(ligi[3], bramki[3]);
            chart1.Series["Bramki"].Points.AddXY(ligi[4], bramki[4]);

            chart1.Series["Bramki"].Points[0].Color = System.Drawing.Color.Red;
            chart1.Series["Bramki"].Points[1].Color = System.Drawing.Color.Green;
            chart1.Series["Bramki"].Points[2].Color = System.Drawing.Color.Blue;
            chart1.Series["Bramki"].Points[3].Color = System.Drawing.Color.Magenta;
            chart1.Series["Bramki"].Points[4].Color = System.Drawing.Color.Cyan;
        }
    }
}
