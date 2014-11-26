using System;
using System.Collections.Generic;

namespace RestfulApi.Model.Models
{
    public partial class N_ORTE
    {
        public short ZAEHLER { get; set; }
        public Nullable<short> WERT { get; set; }
        public string SAP_SPRACHE { get; set; }
        public Nullable<System.DateTime> DAT_LASTMOD { get; set; }
        public string LISTE_KZ { get; set; }
        public string EDV1 { get; set; }
        public string NPARM_RESERVE { get; set; }
        public string LISTE { get; set; }
        public string TXX { get; set; }
        public string KUERZEL { get; set; }
        public string FUNKBASIS { get; set; }
        public string SAP_LAND { get; set; }
        public string DAT_LFT_SCHLUESSEL { get; set; }
    }
}
