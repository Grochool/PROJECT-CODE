using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution_pilkarze
{
    interface Interface // Interfejs
    {
        void awans(Form1 liga);
        void spadek(Form1 liga);
        void roznica(Form1 liga);
        void zwyciestwapowsredniej(Form1 liga);
        void iloscbramek(List<Form1> list);
        void straconebramkinamecz(Form1 liga);

    }
}
