using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HegyCsucsClass
{
    internal class HegyCsucs
    {
        string hegycsucs;
        string hegyseg;
        int magassag;

        public HegyCsucs(string hegycsucs, string hegyseg, int magassag)
        {
            this.Hegycsucs = hegycsucs;
            this.Hegyseg = hegyseg;
            this.Magassag = magassag;
        }

        public string Hegycsucs { get => hegycsucs; set => hegycsucs = value; }
        public string Hegyseg { get => hegyseg; set => hegyseg = value; }
        public int Magassag { get => magassag; set => magassag = value; }
    }
}
