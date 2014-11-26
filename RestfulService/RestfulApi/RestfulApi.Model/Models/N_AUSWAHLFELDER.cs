using System;
using System.Collections.Generic;

namespace RestfulApi.Model.Models
{
    public partial class N_AUSWAHLFELDER
    {
        public int ZAEHLER { get; set; }
        public string APPID { get; set; }
        public Nullable<int> WERT { get; set; }
        public string SAP_SPRACHE { get; set; }
        public Nullable<System.DateTime> DAT_LASTMOD { get; set; }
        public string LISTE_KZ { get; set; }
        public string EDV1 { get; set; }
        public string NPARM_RESERVE { get; set; }
        public string TXX { get; set; }
        public string DBTAB { get; set; }
        public string DBSELECT { get; set; }
        public string VERKNUEPFUNG { get; set; }
        public string V_BESCHREIBUNG { get; set; }
        public string FORMAT { get; set; }
        public Nullable<int> Z_GRUPPE { get; set; }
    }
}
