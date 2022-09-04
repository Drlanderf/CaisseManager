using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonClassLibrary
{
    public static class Compteur
    {
        private static int Cmpt { get; set; } = 1;

        public static int getCmpt()
        {
            return Cmpt;
        }
        public static void setCmpt(int cmpt)
        {
            Cmpt = cmpt;
        }
        public static void incCmpt()
        {
            setCmpt(Cmpt + 1);
        }
    }
}
