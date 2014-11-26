using System;
using System.Collections.Generic;

namespace RestfulApi.Model.Models
{
    public partial class DAT_MATERIALSTAMM
    {
        public int ZAEHLER { get; set; }
        public short Z_AKUNDE { get; set; }
        public System.DateTime DAT_LASTMOD { get; set; }
        public Nullable<short> W_STATUS { get; set; }
        public string LISTE_KZ { get; set; }
        public Nullable<int> LOG_STATUS { get; set; }
        public string EDV1 { get; set; }
        public string NPARM_RESERVE { get; set; }
        public System.DateTime DAT_STATUS { get; set; }
        public int Z_LFT { get; set; }
        public string LT_FREMDIDENT { get; set; }
        public string LT_TXX1 { get; set; }
        public string SAP_SPRACHE1 { get; set; }
        public string LT_TXX2 { get; set; }
        public string SAP_SPRACHE2 { get; set; }
        public string LT_TXX3 { get; set; }
        public string SAP_SPRACHE3 { get; set; }
        public string LT_TXX4 { get; set; }
        public string SAP_SPRACHE4 { get; set; }
        public double LT_MENGE { get; set; }
        public short W_LT_MENGENEINHEIT { get; set; }
        public double WERT { get; set; }
        public string ISO_WAEHRUNGWERT { get; set; }
        public double NETTO_KG { get; set; }
        public string ABMESS1_MM { get; set; }
        public string ABMESS2_MM { get; set; }
        public string ABMESS3_MM { get; set; }
        public string ABMESS4_MM { get; set; }
        public string ABMESS5_MM { get; set; }
        public string ABMESS6_MM { get; set; }
        public string GEFAHRGUT_KLASSE { get; set; }
        public string GEFAHRGUT_UNNR { get; set; }
        public string STAT_WAREN_NR { get; set; }
        public string SAP_URSPRUNGSLAND { get; set; }
        public string WERKSTOFF { get; set; }
        public string NORM { get; set; }
        public string ABNAHME { get; set; }
        public string BEMERKUNG { get; set; }
        public string W_ART_LAGERBEDINGUNG { get; set; }
    }
}
