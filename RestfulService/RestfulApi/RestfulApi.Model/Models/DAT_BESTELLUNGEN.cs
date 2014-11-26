using System;
using System.Collections.Generic;

namespace RestfulApi.Model.Models
{
    public partial class DAT_BESTELLUNGEN
    {
        public int ZAEHLER { get; set; }
        public short Z_AKUNDE { get; set; }
        public System.DateTime DAT_LASTMOD { get; set; }
        public string LISTE_KZ { get; set; }
        public string EDV1 { get; set; }
        public string NPARM_RESERVE { get; set; }
        public short W_STATUS { get; set; }
        public int LOG_Status { get; set; }
        public System.DateTime DAT_STATUS { get; set; }
        public int Z_LFT { get; set; }
        public string LFT_ANSPRECH { get; set; }
        public string LFT_TELEFON1 { get; set; }
        public string LFT_TELEFON2 { get; set; }
        public string LFT_FAX { get; set; }
        public string LFT_EMAIL { get; set; }
        public string LFT_BEMERKUNG { get; set; }
        public string MANDANT { get; set; }
        public string VS_HIER1 { get; set; }
        public string BS_HIER2 { get; set; }
        public string VS_HIER2 { get; set; }
        public string NEUTRAL05 { get; set; }
        public string NEUTRAL10 { get; set; }
        public string NEUTRAL20 { get; set; }
        public string NEUTRAL30 { get; set; }
        public string KONTO { get; set; }
        public Nullable<int> NPARM_INET_ID { get; set; }
        public Nullable<int> NPARM_LT_NR { get; set; }
        public string KOMMISSION { get; set; }
        public double WERT { get; set; }
        public string ISO_WAEHRUNGWERT { get; set; }
        public string ANSPRECH_AKUNDE { get; set; }
        public string TX_INCOTERM2000 { get; set; }
        public string INCO_ZUSATZ { get; set; }
        public Nullable<short> W_ART_BESTELLUNG { get; set; }
        public string PKEY_AKUNDE { get; set; }
        public Nullable<float> PROZ_WERT { get; set; }
        public Nullable<int> W_TEXTE { get; set; }
        public string BESTELLNRFREI { get; set; }
        public string EMAIL_AKUNDE { get; set; }
        public Nullable<System.DateTime> DAT_BELEG { get; set; }
        public Nullable<int> Z_USER_EK { get; set; }
    }
}
