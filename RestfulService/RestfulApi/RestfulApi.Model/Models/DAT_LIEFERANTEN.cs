using System;
using System.Collections.Generic;

namespace RestfulApi.Model.Models
{
    public partial class DAT_LIEFERANTEN
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
        public short W_ART { get; set; }
        public string SCHLUESSEL { get; set; }
        public string NAME { get; set; }
        public string NAME2 { get; set; }
        public string NAME3 { get; set; }
        public string NAME4 { get; set; }
        public string STRASSE { get; set; }
        public string POSTFACH { get; set; }
        public string PLZ { get; set; }
        public string ORT { get; set; }
        public string PROVINZ { get; set; }
        public string SAP_LAND { get; set; }
        public string ANSPRECH { get; set; }
        public string TELEFON1 { get; set; }
        public string TELEFON2 { get; set; }
        public string FAX { get; set; }
        public string EMAIL { get; set; }
        public string BEMERKUNG { get; set; }
        public string SAP_SPRACHE { get; set; }
        public string SAP_SPRACHE2 { get; set; }
        public string NEUTRAL05 { get; set; }
        public string NEUTRAL10 { get; set; }
        public string NEUTRAL20 { get; set; }
        public string NEUTRAL30 { get; set; }
        public string STEUERNUMMER { get; set; }
        public string INETPASSWORT { get; set; }
        public string INETPASSWORT2 { get; set; }
        public string PKEY_AKUNDE { get; set; }
        public float PROZ_WERT { get; set; }
        public decimal WERT { get; set; }
        public string ISO_WAEHRUNGWERT { get; set; }
        public string LADEZEITEN { get; set; }
        public int Z_USER_EXPEDITING { get; set; }
    }
}
