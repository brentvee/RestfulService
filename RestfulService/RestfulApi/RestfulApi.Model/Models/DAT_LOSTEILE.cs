using System;
using System.Collections.Generic;

namespace RestfulApi.Model.Models
{
    public partial class DAT_LOSTEILE
    {
        public int ZAEHLER { get; set; }
        public short Z_AKUNDE { get; set; }
        public System.DateTime DAT_LASTMOD { get; set; }
        public string LISTE_KZ { get; set; }
        public string EDV1 { get; set; }
        public string NPARM_RESERVE { get; set; }
        public short W_STATUS { get; set; }
        public short W_STATUSETI { get; set; }
        public int LOG_Status { get; set; }
        public int LOG_StatusEti { get; set; }
        public System.DateTime DAT_STATUS { get; set; }
        public System.DateTime DAT_STATUSETI { get; set; }
        public string MANDANT { get; set; }
        public string VS_HIER1 { get; set; }
        public string VS_HIER2 { get; set; }
        public string VS_HIER3 { get; set; }
        public string BS_HIER2 { get; set; }
        public string BS_HIER3 { get; set; }
        public int Z_KISTEN { get; set; }
        public int Z_LFT { get; set; }
        public int Z_BEST { get; set; }
        public int Z_BPOS { get; set; }
        public int Z_VS_HIER2 { get; set; }
        public int Z_VS_HIER3 { get; set; }
        public int Z_LOSTEILE { get; set; }
        public int Z_HERSTELLER { get; set; }
        public int W_ART_LAGERBEDINGUNG { get; set; }
        public int W_TEXTE { get; set; }
        public short W_STANDORT { get; set; }
        public short W_FERTIGORT { get; set; }
        public string BARCODE { get; set; }
        public string LT_NR { get; set; }
        public string LT_TXD { get; set; }
        public string LT_TXX1 { get; set; }
        public string LT_TXX2 { get; set; }
        public string LT_TXX3 { get; set; }
        public float LT_MENGE { get; set; }
        public Nullable<float> LT_GESMENGE { get; set; }
        public short W_LT_MENGENEINHEIT { get; set; }
        public Nullable<decimal> WERT { get; set; }
        public string ISO_WAEHRUNGWERT { get; set; }
        public float BRUTTO_KG { get; set; }
        public float NETTO_KG { get; set; }
        public string ABMESS1_MM { get; set; }
        public string ABMESS2_MM { get; set; }
        public string ABMESS3_MM { get; set; }
        public string ABMESS4_MM { get; set; }
        public string ABMESS5_MM { get; set; }
        public string ABMESS6_MM { get; set; }
        public string GEFAHRGUT_KLASSE { get; set; }
        public string GEFAHRGUT_UNNR { get; set; }
        public string EXPORT_ECCN { get; set; }
        public string EXPORT_ALNR { get; set; }
        public string ZEICHNUNGS_NR { get; set; }
        public string ZEICHNUNGS_POS { get; set; }
        public string ZEICHNUNGS_TXX { get; set; }
        public string BAUGRUPPE_NR { get; set; }
        public string BAUGRUPPE_TXD { get; set; }
        public string BAUGRUPPE_TXX { get; set; }
        public string BAUGRUPPE_POS { get; set; }
        public string MATERIAL_NR { get; set; }
        public string MATERIAL_TXD { get; set; }
        public string MATERIAL_TXX { get; set; }
        public string Versauf_Nr { get; set; }
        public string Versauf_PosNr { get; set; }
        public string BKUNDE_TXX1 { get; set; }
        public string BKUNDE_TXX2 { get; set; }
        public string LAGERORT1 { get; set; }
        public string LAGERORT2 { get; set; }
        public string LAGERORT3 { get; set; }
        public string STAT_WAREN_NR { get; set; }
        public string SAP_URSPRUNGSLAND { get; set; }
        public string PAPPKARTON { get; set; }
        public string NEUTRAL05 { get; set; }
        public string NEUTRAL10 { get; set; }
        public string NEUTRAL20 { get; set; }
        public string NEUTRAL30 { get; set; }
        public Nullable<System.DateTime> DAT_EINGANG_BAUSTELLE { get; set; }
        public int W_STATUS_BAUSTELLE { get; set; }
        public string LAGERORT_BAUSTELLE { get; set; }
        public string BEMERKUNG_BAUSTELLE { get; set; }
        public float LT_MENGE_BAUSTELLE { get; set; }
        public float LT_MENGE_IST { get; set; }
        public string PKEY_AKUNDE { get; set; }
        public float PROZ_WERT { get; set; }
        public string BARCODE_EXTERN { get; set; }
        public string BEMERKUNG { get; set; }
        public string BEMERKUNG_D { get; set; }
        public string BEMERKUNG_E { get; set; }
        public string BEMERKUNG_WE { get; set; }
        public string BEMERKUNG_SCHADEN { get; set; }
        public string BEMERKUNG_TECHNISCHERFEHLER { get; set; }
        public Nullable<System.DateTime> DAT_STATUS_WE { get; set; }
        public Nullable<System.DateTime> DAT_INSPEKTION { get; set; }
        public Nullable<System.DateTime> DAT_SOLLVP { get; set; }
        public Nullable<System.DateTime> DAT_VSBereit { get; set; }
        public string ORT_VSBereit { get; set; }
        public string KKS_NR { get; set; }
        public string WERKSTOFF { get; set; }
        public byte[] PUL { get; set; }
        public string TAG { get; set; }
        public string UNIT { get; set; }
        public string ERFASSID { get; set; }
        public string HERSTELLER_TXX { get; set; }
        public string LOS { get; set; }
        public string NORM { get; set; }
        public string ABNAHME { get; set; }
        public string FREI01_TXX { get; set; }
        public string FREI02_TXX { get; set; }
        public string FREI03_TXX { get; set; }
        public string FREI04_TXX { get; set; }
        public string FREI05_TXX { get; set; }
        public string FREI06_TXX { get; set; }
        public string FREI07_TXX { get; set; }
        public string FREI08_TXX { get; set; }
        public string FREI09_TXX { get; set; }
        public string FREI10_TXX { get; set; }
        public int Z_LFT_ZIEL { get; set; }
        public string ZIEL_ANSPRECH { get; set; }
        public string ZIEL_TELEFON1 { get; set; }
        public string ZIEL_TELEFON2 { get; set; }
        public string ZIEL_FAX { get; set; }
        public string ZIEL_EMAIL { get; set; }
        public string ZIEL_LADEZEITEN { get; set; }
        public string ZIEL_BEMERKUNG { get; set; }
        public string ERFASSER_WE { get; set; }
        public Nullable<System.DateTime> DAT_WIEDERVORLAGE { get; set; }
        public Nullable<System.DateTime> DAT_LIEFER_PLAN { get; set; }
        public string BEMERKUNG_VERZUG { get; set; }
        public string BEMERKUNG_EXPEDITING { get; set; }
        public string MONTAGE_EH { get; set; }
        public short VERZUGSDAUER_WO { get; set; }
        public string LISTE_DATEIEN { get; set; }
        public string VSHIER2_KORR { get; set; }
        public string VSHIER3_KORR { get; set; }
        public string ZEICHNR_KORR { get; set; }
        public string ZEICHNPOS_KORR { get; set; }
        public string KKSNR_KORR { get; set; }
        public string LISTE_KUNDENAUFTRAG { get; set; }
        public string LISTE_BPOS { get; set; }
        public string KOMPONENTEN_NR { get; set; }
        public string SCHMELZE { get; set; }
        public string HERSTELL_LAENGE { get; set; }
        public string PACKLISTENINFO { get; set; }
    }
}