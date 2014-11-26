using System;
using System.Collections.Generic;

namespace RestfulApi.Model.Models
{
    public partial class INIT_REPORT
    {
        public int ZAEHLER { get; set; }
        public Nullable<System.DateTime> DAT_LASTMOD { get; set; }
        public string LISTE_KZ { get; set; }
        public short Z_AKUNDE { get; set; }
        public string NPARM_RESERVE { get; set; }
        public string EDV1 { get; set; }
        public string APPID { get; set; }
        public Nullable<int> WERT { get; set; }
        public string SAP_SPRACHE { get; set; }
        public Nullable<short> Z_GRUPPE { get; set; }
        public string TXT_SELECT { get; set; }
        public string REPORTFILENAME { get; set; }
        public string MENUTITEL { get; set; }
        public string MENUTEXT { get; set; }
        public string R_TXX { get; set; }
    }
}
