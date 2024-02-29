using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPBO
{
    internal class Komputer
    {
        public string merk;
        public string prosesor;
        public string gpu;
        public int ram;
        public int ssd;

        public Komputer(string merk, string prosesor, string gpu, int ram, int ssd)
        {
            this.merk = merk;
            this.prosesor = prosesor;
            this.gpu = gpu;
            this.ram = ram;
            this.ssd = ssd;
        }
    }
}
