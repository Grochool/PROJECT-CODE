using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace solution_pilkarze
{
    class Druzyna
    {
        private String nazwa_Druzyny;
        private int rozegraneMecze;
        private int zwyciestwa;
        private int porazki;
        private int bramki;
        private int punkty;
        private String liga;
        private int remisy;

        public Druzyna()
        {

        }

        public string Nazwa_Druzyny
        {
            get
            {
                return nazwa_Druzyny;
            }

            set
            {
                nazwa_Druzyny = value;
            }
        }

        public int RozegraneMecze
        {
            get
            {
                return rozegraneMecze;
            }

            set
            {
                rozegraneMecze = value;
            }
        }

        public int Zwyciestwa
        {
            get
            {
                return zwyciestwa;
            }

            set
            {
                zwyciestwa = value;
            }
        }

        public int Porazki
        {
            get
            {
                return porazki;
            }

            set
            {
                porazki = value;
            }
        }

        public int Bramki
        {
            get
            {
                return bramki;
            }

            set
            {
                bramki = value;
            }
        }

        public int Punkty
        {
            get
            {
                return punkty;
            }

            set
            {
                punkty = value;
            }
        }

        public string Liga
        {
            get
            {
                return liga;
            }

            set
            {
                liga = value;
            }
        }

        public int Remisy
        {
            get
            {
                return remisy;
            }

            set
            {
                remisy = value;
            }
        }
    }
}
