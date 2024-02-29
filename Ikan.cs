using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPBO
{
    internal class Ikan
    {
        public string nama;
        public string warna;
        public string habitat;
        public string jenisPerairan;
        public string reproduksi;
        public int jumlahSirip;

        public Ikan(string nama, string warna, string habitat, string jenisPerairan, string reproduksi, int jumlahSirip)
        {
            this.nama = nama;
            this.warna = warna;
            this.habitat = habitat;
            this.jenisPerairan = jenisPerairan;
            this.reproduksi = reproduksi;
            this.jumlahSirip = jumlahSirip;
        }
    }
}
