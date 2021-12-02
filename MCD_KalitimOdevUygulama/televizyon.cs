using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCD_KalitimOdevUygulama
{
    public sealed class televizyon:urun
    {
        public bool smartTV { get; set; }
        public bool HDMI { get; set; }
        public string ekranBoyutu { get; set; }
    }
}
