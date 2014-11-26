using System;
using System.Collections.Generic;

namespace RestfulApi.Model.Models
{
    public partial class DAT_DUMMYVSBLT
    {
        public int ZAEHLER { get; set; }
        public short Z_AKUNDE { get; set; }
        public System.DateTime DAT_LASTMOD { get; set; }
        public string LISTE_KZ { get; set; }
        public string EDV1 { get; set; }
        public string NPARM_RESERVE { get; set; }
        public short W_STATUS { get; set; }
        public short W_ART { get; set; }
        public int Z_BPOS { get; set; }
        public string AKTEURNAME { get; set; }
        public System.DateTime DAT_XX { get; set; }
        public float XX_MENGE { get; set; }
        public short W_XX_MENGENEINHEIT { get; set; }
    }
}
