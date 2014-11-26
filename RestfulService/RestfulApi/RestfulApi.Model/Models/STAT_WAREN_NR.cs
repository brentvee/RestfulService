using System;
using System.Collections.Generic;

namespace RestfulApi.Model.Models
{
    public partial class STAT_WAREN_NR
    {
        public int ZAEHLER { get; set; }
        public string STAT_WAREN_NR1 { get; set; }
        public Nullable<System.DateTime> DAT_LASTMOD { get; set; }
        public string LISTE_KZ { get; set; }
        public string EDV1 { get; set; }
        public string NPARM_RESERVE { get; set; }
        public string TXX { get; set; }
        public string LISTE { get; set; }
        public string TXXSHORT { get; set; }
        public string SAP_SPRACHE { get; set; }
    }
}
