using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPBO
{
    internal class Burung
    {
        public string nama;
        public string habitat;
        public string jenisMakanan;
        public string perilaku;

        public Burung(string nama, string habitat, string jenisMakanan, string perilaku)
        {
            this.nama = nama;
            this.habitat = habitat;
            this.jenisMakanan = jenisMakanan;
            this.perilaku = perilaku;
        }
    }
}
