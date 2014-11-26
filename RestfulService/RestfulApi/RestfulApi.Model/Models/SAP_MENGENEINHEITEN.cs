using System;
using System.Collections.Generic;

namespace RestfulApi.Model.Models
{
    public partial class SAP_MENGENEINHEITEN
    {
        public short ZAEHLER { get; set; }
        public Nullable<short> WERT { get; set; }
        public string SAP_SPRACHE { get; set; }
        public Nullable<System.DateTime> DAT_LASTMOD { get; set; }
        public string LISTE_KZ { get; set; }
        public string EDV1 { get; set; }
        public string NPARM_RESERVE { get; set; }
        public string SAP_KEY { get; set; }
        public string LISTE { get; set; }
        public string TXX { get; set; }
        public string KUERZEL { get; set; }
    }
}
