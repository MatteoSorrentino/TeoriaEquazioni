using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquazioniLibrary
{
    public static class Equazioni
    {
        public static bool IsDetermined(double a)
        {
            bool risp = true;

            if (a == 0)
            {
                risp = false;
            }

            return risp;
        }

        public static bool IsIndetermined(double a, double b)
        {
            bool risp = false;

            if (a == 0 && b == 0)
            {
                risp = true;
            }

            return risp;
        }

        public static bool IsIncostisted(double a, double b)
        {
            bool risp = false;

            if (a == 0 && b != 0)
            {
                risp = true;
            }

            return risp;
        }

        public static bool IsDegree2(double a)
        {
            bool risp = true;

            if (a == 0)
            {
                risp = false;
            }

            return risp;
        }



    }
}
