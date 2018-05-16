using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution_pilkarze
{
    interface Interface
    {
        void awans(Liga liga);
        void spadek(Liga liga);
        void roznica(Liga liga);
        void zwyciestwapowsredniej(Liga liga);
        void iloscbramek(List<Liga> list);
        void straconebramkinamecz(Liga liga);

    }
}
