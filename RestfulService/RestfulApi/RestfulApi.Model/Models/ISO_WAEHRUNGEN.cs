using System;
using System.Collections.Generic;

namespace RestfulApi.Model.Models
{
    public partial class ISO_WAEHRUNGEN
    {
        public int ZAEHLER { get; set; }
        public Nullable<short> WERT { get; set; }
        public Nullable<System.DateTime> DAT_LASTMOD { get; set; }
        public string LISTE_KZ { get; set; }
        public string EDV1 { get; set; }
        public string NPARM_RESERVE { get; set; }
        public string SAP_KEY { get; set; }
        public string TxD { get; set; }
        public string TxE { get; set; }
        public string TxX { get; set; }
        public string LISTE { get; set; }
        public string SPRACHE { get; set; }
        public string AUSWEICHSPRACHE { get; set; }
        public string TxDshort { get; set; }
        public string TxEshort { get; set; }
        public string TxXshort { get; set; }
    }
}
