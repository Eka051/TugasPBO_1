using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TugasPBO
{
    public class mobilSedan
    {
        public string merk;
        public string warna;
        public string tipeTransimi;
        public int tahun;
        public mobilSedan(string merk, string warna, string tipeTransimi, int tahun)
        {
            this.merk = merk;
            this.warna = warna;
            this.tipeTransimi = tipeTransimi;
            this.tahun = tahun;
        }
    }
}
