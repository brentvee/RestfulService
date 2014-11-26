using System;
using System.Collections.Generic;

namespace RestfulApi.Model.Models
{
    public partial class DAT_TBEHAELTER
    {
        public int ZAEHLER { get; set; }
        public short Z_AKUNDE { get; set; }
        public System.DateTime DAT_LASTMOD { get; set; }
        public string LISTE_KZ { get; set; }
        public string EDV1 { get; set; }
        public string NPARM_RESERVE { get; set; }
        public short W_STATUS { get; set; }
        public int LOG_Status { get; set; }
        public Nullable<System.DateTime> DAT_STATUS { get; set; }
        public string VS_HIER1 { get; set; }
        public int Z_LFT { get; set; }
        public int Z_VSBEREIT { get; set; }
        public short W_ART { get; set; }
        public float ABMESS1_MM { get; set; }
        public float ABMESS2_MM { get; set; }
        public float ABMESS3_MM { get; set; }
        public float BRUTTO_KG { get; set; }
        public float NETTO_KG { get; set; }
        public float TARA_KG { get; set; }
        public string NEUTRAL05 { get; set; }
        public string NEUTRAL10 { get; set; }
        public string NEUTRAL20 { get; set; }
        public string NEUTRAL30 { get; set; }
        public string BEMERKUNG { get; set; }
    }
}
