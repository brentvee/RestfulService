using System;
using System.Collections.Generic;

namespace RestfulApi.Model.Models
{
    public partial class DAT_VSBEREIT
    {
        public int ZAEHLER { get; set; }
        public short Z_AKUNDE { get; set; }
        public System.DateTime DAT_LASTMOD { get; set; }
        public string LISTE_KZ { get; set; }
        public string EDV1 { get; set; }
        public string NPARM_RESERVE { get; set; }
        public short W_STATUS { get; set; }
        public int LOG_STATUS { get; set; }
        public Nullable<System.DateTime> DAT_STATUS { get; set; }
        public int Z_LFT { get; set; }
        public string MANDANT { get; set; }
        public string VS_HIER1 { get; set; }
        public string VS_HIER2 { get; set; }
        public string VS_HIER3 { get; set; }
        public string BS_HIER2 { get; set; }
        public string BS_HIER3 { get; set; }
        public Nullable<System.DateTime> DAT_VSBEREIT1 { get; set; }
        public Nullable<System.DateTime> DAT_ABHOLUNG { get; set; }
        public short W_ART_BELADUNG { get; set; }
        public short W_ART_LAGERBEDINGUNG { get; set; }
        public string TX_INCOTERM2000 { get; set; }
        public string INCO_ZUSATZ { get; set; }
        public string VSB_TXD { get; set; }
        public string VSB_TXX { get; set; }
        public string ABHOLREFERENZ { get; set; }
        public int LADERAUM1_MM { get; set; }
        public int LADERAUM2_MM { get; set; }
        public int LADERAUM3_MM { get; set; }
        public double WERT { get; set; }
        public string ISO_WAEHRUNGWERT { get; set; }
        public short KST_ANZ { get; set; }
        public double KST_NETTO_KG { get; set; }
        public double KST_BRUTTO_KG { get; set; }
        public double KST_VOLUMEN_CBM { get; set; }
        public double KORREKTUR_KG { get; set; }
        public double VSB_TARA_KG { get; set; }
        public short VSB_ANZ_PACKSTUECKE { get; set; }
        public int ZAEHLER_INT { get; set; }
        public string LISTE_STAT_WAREN_NR { get; set; }
        public string LISTE_KOLLINR { get; set; }
        public string LISTE_ABMESSUNGEN { get; set; }
        public string LISTE_KISTENARTEN { get; set; }
        public string BEMERKUNG { get; set; }
        public int Z_LFT_ABHOL { get; set; }
        public string ABHOL_ANSPRECH { get; set; }
        public string ABHOL_TELEFON1 { get; set; }
        public string ABHOL_TELEFON2 { get; set; }
        public string ABHOL_FAX { get; set; }
        public string ABHOL_EMAIL { get; set; }
        public string ABHOL_LADEZEITEN { get; set; }
        public string ABHOL_BEMERKUNG { get; set; }
        public int Z_LFT_ANSPRECH { get; set; }
        public string ANSPRECH_ANSPRECH { get; set; }
        public string ANSPRECH_TELEFON1 { get; set; }
        public string ANSPRECH_TELEFON2 { get; set; }
        public string ANSPRECH_FAX { get; set; }
        public string ANSPRECH_EMAIL { get; set; }
        public string ANSPRECH_LADEZEITEN { get; set; }
        public string ANSPRECH_BEMERKUNG { get; set; }
        public int Z_LFT_ZIEL { get; set; }
        public string ZIEL_ANSPRECH { get; set; }
        public string ZIEL_TELEFON1 { get; set; }
        public string ZIEL_TELEFON2 { get; set; }
        public string ZIEL_FAX { get; set; }
        public string ZIEL_EMAIL { get; set; }
        public string ZIEL_LADEZEITEN { get; set; }
        public string ZIEL_BEMERKUNG { get; set; }
    }
}
