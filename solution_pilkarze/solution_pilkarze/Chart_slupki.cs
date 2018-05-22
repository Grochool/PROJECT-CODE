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
    public partial class Chart_slupki : Form
    {
        private int best;
        private int worst;

        public Chart_slupki(int best, int worst)
        {
            best = this.best;
            worst = this.worst;
            InitializeComponent();
        }
    }
}
