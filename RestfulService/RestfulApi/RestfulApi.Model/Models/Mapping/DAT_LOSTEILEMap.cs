using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class DAT_LOSTEILEMap : EntityTypeConfiguration<DAT_LOSTEILE>
    {
        public DAT_LOSTEILEMap()
        {
            // Primary Key
            this.HasKey(t => t.ZAEHLER);

            // Properties
            this.Property(t => t.ZAEHLER)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LISTE_KZ)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.EDV1)
                .HasMaxLength(50);

            this.Property(t => t.NPARM_RESERVE)
                .HasMaxLength(20);

            this.Property(t => t.MANDANT)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.VS_HIER1)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.VS_HIER2)
                .HasMaxLength(3);

            this.Property(t => t.VS_HIER3)
                .HasMaxLength(4);

            this.Property(t => t.BS_HIER2)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.BS_HIER3)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.BARCODE)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.LT_NR)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LT_TXD)
                .HasMaxLength(50);

            this.Property(t => t.LT_TXX1)
                .HasMaxLength(50);

            this.Property(t => t.LT_TXX2)
                .HasMaxLength(50);

            this.Property(t => t.LT_TXX3)
                .HasMaxLength(50);

            this.Property(t => t.ISO_WAEHRUNGWERT)
                .HasMaxLength(3);

            this.Property(t => t.ABMESS1_MM)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ABMESS2_MM)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ABMESS3_MM)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ABMESS4_MM)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ABMESS5_MM)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ABMESS6_MM)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.GEFAHRGUT_KLASSE)
                .HasMaxLength(7);

            this.Property(t => t.GEFAHRGUT_UNNR)
                .HasMaxLength(4);

            this.Property(t => t.EXPORT_ECCN)
                .HasMaxLength(14);

            this.Property(t => t.EXPORT_ALNR)
                .HasMaxLength(14);

            this.Property(t => t.ZEICHNUNGS_NR)
                .HasMaxLength(31);

            this.Property(t => t.ZEICHNUNGS_POS)
                .HasMaxLength(30);

            this.Property(t => t.ZEICHNUNGS_TXX)
                .HasMaxLength(30);

            this.Property(t => t.BAUGRUPPE_NR)
                .HasMaxLength(20);

            this.Property(t => t.BAUGRUPPE_TXD)
                .HasMaxLength(50);

            this.Property(t => t.BAUGRUPPE_TXX)
                .HasMaxLength(50);

            this.Property(t => t.BAUGRUPPE_POS)
                .HasMaxLength(6);

            this.Property(t => t.MATERIAL_NR)
                .HasMaxLength(20);

            this.Property(t => t.MATERIAL_TXD)
                .HasMaxLength(40);

            this.Property(t => t.MATERIAL_TXX)
                .HasMaxLength(50);

            this.Property(t => t.Versauf_Nr)
                .HasMaxLength(6);

            this.Property(t => t.Versauf_PosNr)
                .HasMaxLength(6);

            this.Property(t => t.BKUNDE_TXX1)
                .HasMaxLength(60);

            this.Property(t => t.BKUNDE_TXX2)
                .HasMaxLength(50);

            this.Property(t => t.LAGERORT1)
                .HasMaxLength(3);

            this.Property(t => t.LAGERORT2)
                .HasMaxLength(3);

            this.Property(t => t.LAGERORT3)
                .HasMaxLength(3);

            this.Property(t => t.STAT_WAREN_NR)
                .HasMaxLength(15);

            this.Property(t => t.SAP_URSPRUNGSLAND)
                .HasMaxLength(3);

            this.Property(t => t.PAPPKARTON)
                .HasMaxLength(13);

            this.Property(t => t.NEUTRAL05)
                .HasMaxLength(3);

            this.Property(t => t.NEUTRAL10)
                .HasMaxLength(10);

            this.Property(t => t.NEUTRAL20)
                .HasMaxLength(20);

            this.Property(t => t.NEUTRAL30)
                .HasMaxLength(30);

            this.Property(t => t.LAGERORT_BAUSTELLE)
                .HasMaxLength(64);

            this.Property(t => t.BEMERKUNG_BAUSTELLE)
                .HasMaxLength(40);

            this.Property(t => t.PKEY_AKUNDE)
                .HasMaxLength(50);

            this.Property(t => t.BARCODE_EXTERN)
                .HasMaxLength(250);

            this.Property(t => t.BEMERKUNG)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.BEMERKUNG_D)
                .HasMaxLength(250);

            this.Property(t => t.BEMERKUNG_E)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.BEMERKUNG_WE)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.BEMERKUNG_SCHADEN)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.BEMERKUNG_TECHNISCHERFEHLER)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.ORT_VSBereit)
                .HasMaxLength(20);

            this.Property(t => t.KKS_NR)
                .HasMaxLength(50);

            this.Property(t => t.WERKSTOFF)
                .HasMaxLength(50);

            this.Property(t => t.PUL)
                .HasMaxLength(3);

            this.Property(t => t.TAG)
                .HasMaxLength(30);

            this.Property(t => t.UNIT)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.ERFASSID)
                .HasMaxLength(8);

            this.Property(t => t.HERSTELLER_TXX)
                .HasMaxLength(30);

            this.Property(t => t.LOS)
                .HasMaxLength(2);

            this.Property(t => t.NORM)
                .HasMaxLength(50);

            this.Property(t => t.ABNAHME)
                .HasMaxLength(50);

            this.Property(t => t.FREI01_TXX)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FREI02_TXX)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FREI03_TXX)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FREI04_TXX)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FREI05_TXX)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FREI06_TXX)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FREI07_TXX)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FREI08_TXX)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FREI09_TXX)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FREI10_TXX)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ZIEL_ANSPRECH)
                .HasMaxLength(50);

            this.Property(t => t.ZIEL_TELEFON1)
                .HasMaxLength(50);

            this.Property(t => t.ZIEL_TELEFON2)
                .HasMaxLength(50);

            this.Property(t => t.ZIEL_FAX)
                .HasMaxLength(50);

            this.Property(t => t.ZIEL_EMAIL)
                .HasMaxLength(50);

            this.Property(t => t.ZIEL_LADEZEITEN)
                .HasMaxLength(250);

            this.Property(t => t.ZIEL_BEMERKUNG)
                .HasMaxLength(50);

            this.Property(t => t.ERFASSER_WE)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BEMERKUNG_VERZUG)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.BEMERKUNG_EXPEDITING)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.MONTAGE_EH)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.VSHIER2_KORR)
                .HasMaxLength(3);

            this.Property(t => t.VSHIER3_KORR)
                .HasMaxLength(4);

            this.Property(t => t.ZEICHNR_KORR)
                .HasMaxLength(31);

            this.Property(t => t.ZEICHNPOS_KORR)
                .HasMaxLength(30);

            this.Property(t => t.KKSNR_KORR)
                .HasMaxLength(50);

            this.Property(t => t.KOMPONENTEN_NR)
                .HasMaxLength(50);

            this.Property(t => t.SCHMELZE)
                .HasMaxLength(10);

            this.Property(t => t.HERSTELL_LAENGE)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DAT_LOSTEILE");
            this.Property(t => t.ZAEHLER).HasColumnName("ZAEHLER");
            this.Property(t => t.Z_AKUNDE).HasColumnName("Z_AKUNDE");
            this.Property(t => t.DAT_LASTMOD).HasColumnName("DAT_LASTMOD");
            this.Property(t => t.LISTE_KZ).HasColumnName("LISTE_KZ");
            this.Property(t => t.EDV1).HasColumnName("EDV1");
            this.Property(t => t.NPARM_RESERVE).HasColumnName("NPARM_RESERVE");
            this.Property(t => t.W_STATUS).HasColumnName("W_STATUS");
            this.Property(t => t.W_STATUSETI).HasColumnName("W_STATUSETI");
            this.Property(t => t.LOG_Status).HasColumnName("LOG_Status");
            this.Property(t => t.LOG_StatusEti).HasColumnName("LOG_StatusEti");
            this.Property(t => t.DAT_STATUS).HasColumnName("DAT_STATUS");
            this.Property(t => t.DAT_STATUSETI).HasColumnName("DAT_STATUSETI");
            this.Property(t => t.MANDANT).HasColumnName("MANDANT");
            this.Property(t => t.VS_HIER1).HasColumnName("VS_HIER1");
            this.Property(t => t.VS_HIER2).HasColumnName("VS_HIER2");
            this.Property(t => t.VS_HIER3).HasColumnName("VS_HIER3");
            this.Property(t => t.BS_HIER2).HasColumnName("BS_HIER2");
            this.Property(t => t.BS_HIER3).HasColumnName("BS_HIER3");
            this.Property(t => t.Z_KISTEN).HasColumnName("Z_KISTEN");
            this.Property(t => t.Z_LFT).HasColumnName("Z_LFT");
            this.Property(t => t.Z_BEST).HasColumnName("Z_BEST");
            this.Property(t => t.Z_BPOS).HasColumnName("Z_BPOS");
            this.Property(t => t.Z_VS_HIER2).HasColumnName("Z_VS_HIER2");
            this.Property(t => t.Z_VS_HIER3).HasColumnName("Z_VS_HIER3");
            this.Property(t => t.Z_LOSTEILE).HasColumnName("Z_LOSTEILE");
            this.Property(t => t.Z_HERSTELLER).HasColumnName("Z_HERSTELLER");
            this.Property(t => t.W_ART_LAGERBEDINGUNG).HasColumnName("W_ART_LAGERBEDINGUNG");
            this.Property(t => t.W_TEXTE).HasColumnName("W_TEXTE");
            this.Property(t => t.W_STANDORT).HasColumnName("W_STANDORT");
            this.Property(t => t.W_FERTIGORT).HasColumnName("W_FERTIGORT");
            this.Property(t => t.BARCODE).HasColumnName("BARCODE");
            this.Property(t => t.LT_NR).HasColumnName("LT_NR");
            this.Property(t => t.LT_TXD).HasColumnName("LT_TXD");
            this.Property(t => t.LT_TXX1).HasColumnName("LT_TXX1");
            this.Property(t => t.LT_TXX2).HasColumnName("LT_TXX2");
            this.Property(t => t.LT_TXX3).HasColumnName("LT_TXX3");
            this.Property(t => t.LT_MENGE).HasColumnName("LT_MENGE");
            this.Property(t => t.LT_GESMENGE).HasColumnName("LT_GESMENGE");
            this.Property(t => t.W_LT_MENGENEINHEIT).HasColumnName("W_LT_MENGENEINHEIT");
            this.Property(t => t.WERT).HasColumnName("WERT");
            this.Property(t => t.ISO_WAEHRUNGWERT).HasColumnName("ISO_WAEHRUNGWERT");
            this.Property(t => t.BRUTTO_KG).HasColumnName("BRUTTO_KG");
            this.Property(t => t.NETTO_KG).HasColumnName("NETTO_KG");
            this.Property(t => t.ABMESS1_MM).HasColumnName("ABMESS1_MM");
            this.Property(t => t.ABMESS2_MM).HasColumnName("ABMESS2_MM");
            this.Property(t => t.ABMESS3_MM).HasColumnName("ABMESS3_MM");
            this.Property(t => t.ABMESS4_MM).HasColumnName("ABMESS4_MM");
            this.Property(t => t.ABMESS5_MM).HasColumnName("ABMESS5_MM");
            this.Property(t => t.ABMESS6_MM).HasColumnName("ABMESS6_MM");
            this.Property(t => t.GEFAHRGUT_KLASSE).HasColumnName("GEFAHRGUT_KLASSE");
            this.Property(t => t.GEFAHRGUT_UNNR).HasColumnName("GEFAHRGUT_UNNR");
            this.Property(t => t.EXPORT_ECCN).HasColumnName("EXPORT_ECCN");
            this.Property(t => t.EXPORT_ALNR).HasColumnName("EXPORT_ALNR");
            this.Property(t => t.ZEICHNUNGS_NR).HasColumnName("ZEICHNUNGS_NR");
            this.Property(t => t.ZEICHNUNGS_POS).HasColumnName("ZEICHNUNGS_POS");
            this.Property(t => t.ZEICHNUNGS_TXX).HasColumnName("ZEICHNUNGS_TXX");
            this.Property(t => t.BAUGRUPPE_NR).HasColumnName("BAUGRUPPE_NR");
            this.Property(t => t.BAUGRUPPE_TXD).HasColumnName("BAUGRUPPE_TXD");
            this.Property(t => t.BAUGRUPPE_TXX).HasColumnName("BAUGRUPPE_TXX");
            this.Property(t => t.BAUGRUPPE_POS).HasColumnName("BAUGRUPPE_POS");
            this.Property(t => t.MATERIAL_NR).HasColumnName("MATERIAL_NR");
            this.Property(t => t.MATERIAL_TXD).HasColumnName("MATERIAL_TXD");
            this.Property(t => t.MATERIAL_TXX).HasColumnName("MATERIAL_TXX");
            this.Property(t => t.Versauf_Nr).HasColumnName("Versauf_Nr");
            this.Property(t => t.Versauf_PosNr).HasColumnName("Versauf_PosNr");
            this.Property(t => t.BKUNDE_TXX1).HasColumnName("BKUNDE_TXX1");
            this.Property(t => t.BKUNDE_TXX2).HasColumnName("BKUNDE_TXX2");
            this.Property(t => t.LAGERORT1).HasColumnName("LAGERORT1");
            this.Property(t => t.LAGERORT2).HasColumnName("LAGERORT2");
            this.Property(t => t.LAGERORT3).HasColumnName("LAGERORT3");
            this.Property(t => t.STAT_WAREN_NR).HasColumnName("STAT_WAREN_NR");
            this.Property(t => t.SAP_URSPRUNGSLAND).HasColumnName("SAP_URSPRUNGSLAND");
            this.Property(t => t.PAPPKARTON).HasColumnName("PAPPKARTON");
            this.Property(t => t.NEUTRAL05).HasColumnName("NEUTRAL05");
            this.Property(t => t.NEUTRAL10).HasColumnName("NEUTRAL10");
            this.Property(t => t.NEUTRAL20).HasColumnName("NEUTRAL20");
            this.Property(t => t.NEUTRAL30).HasColumnName("NEUTRAL30");
            this.Property(t => t.DAT_EINGANG_BAUSTELLE).HasColumnName("DAT_EINGANG_BAUSTELLE");
            this.Property(t => t.W_STATUS_BAUSTELLE).HasColumnName("W_STATUS_BAUSTELLE");
            this.Property(t => t.LAGERORT_BAUSTELLE).HasColumnName("LAGERORT_BAUSTELLE");
            this.Property(t => t.BEMERKUNG_BAUSTELLE).HasColumnName("BEMERKUNG_BAUSTELLE");
            this.Property(t => t.LT_MENGE_BAUSTELLE).HasColumnName("LT_MENGE_BAUSTELLE");
            this.Property(t => t.LT_MENGE_IST).HasColumnName("LT_MENGE_IST");
            this.Property(t => t.PKEY_AKUNDE).HasColumnName("PKEY_AKUNDE");
            this.Property(t => t.PROZ_WERT).HasColumnName("PROZ_WERT");
            this.Property(t => t.BARCODE_EXTERN).HasColumnName("BARCODE_EXTERN");
            this.Property(t => t.BEMERKUNG).HasColumnName("BEMERKUNG");
            this.Property(t => t.BEMERKUNG_D).HasColumnName("BEMERKUNG_D");
            this.Property(t => t.BEMERKUNG_E).HasColumnName("BEMERKUNG_E");
            this.Property(t => t.BEMERKUNG_WE).HasColumnName("BEMERKUNG_WE");
            this.Property(t => t.BEMERKUNG_SCHADEN).HasColumnName("BEMERKUNG_SCHADEN");
            this.Property(t => t.BEMERKUNG_TECHNISCHERFEHLER).HasColumnName("BEMERKUNG_TECHNISCHERFEHLER");
            this.Property(t => t.DAT_STATUS_WE).HasColumnName("DAT_STATUS_WE");
            this.Property(t => t.DAT_INSPEKTION).HasColumnName("DAT_INSPEKTION");
            this.Property(t => t.DAT_SOLLVP).HasColumnName("DAT_SOLLVP");
            this.Property(t => t.DAT_VSBereit).HasColumnName("DAT_VSBereit");
            this.Property(t => t.ORT_VSBereit).HasColumnName("ORT_VSBereit");
            this.Property(t => t.KKS_NR).HasColumnName("KKS_NR");
            this.Property(t => t.WERKSTOFF).HasColumnName("WERKSTOFF");
            this.Property(t => t.PUL).HasColumnName("PUL");
            this.Property(t => t.TAG).HasColumnName("TAG");
            this.Property(t => t.UNIT).HasColumnName("UNIT");
            this.Property(t => t.ERFASSID).HasColumnName("ERFASSID");
            this.Property(t => t.HERSTELLER_TXX).HasColumnName("HERSTELLER_TXX");
            this.Property(t => t.LOS).HasColumnName("LOS");
            this.Property(t => t.NORM).HasColumnName("NORM");
            this.Property(t => t.ABNAHME).HasColumnName("ABNAHME");
            this.Property(t => t.FREI01_TXX).HasColumnName("FREI01_TXX");
            this.Property(t => t.FREI02_TXX).HasColumnName("FREI02_TXX");
            this.Property(t => t.FREI03_TXX).HasColumnName("FREI03_TXX");
            this.Property(t => t.FREI04_TXX).HasColumnName("FREI04_TXX");
            this.Property(t => t.FREI05_TXX).HasColumnName("FREI05_TXX");
            this.Property(t => t.FREI06_TXX).HasColumnName("FREI06_TXX");
            this.Property(t => t.FREI07_TXX).HasColumnName("FREI07_TXX");
            this.Property(t => t.FREI08_TXX).HasColumnName("FREI08_TXX");
            this.Property(t => t.FREI09_TXX).HasColumnName("FREI09_TXX");
            this.Property(t => t.FREI10_TXX).HasColumnName("FREI10_TXX");
            this.Property(t => t.Z_LFT_ZIEL).HasColumnName("Z_LFT_ZIEL");
            this.Property(t => t.ZIEL_ANSPRECH).HasColumnName("ZIEL_ANSPRECH");
            this.Property(t => t.ZIEL_TELEFON1).HasColumnName("ZIEL_TELEFON1");
            this.Property(t => t.ZIEL_TELEFON2).HasColumnName("ZIEL_TELEFON2");
            this.Property(t => t.ZIEL_FAX).HasColumnName("ZIEL_FAX");
            this.Property(t => t.ZIEL_EMAIL).HasColumnName("ZIEL_EMAIL");
            this.Property(t => t.ZIEL_LADEZEITEN).HasColumnName("ZIEL_LADEZEITEN");
            this.Property(t => t.ZIEL_BEMERKUNG).HasColumnName("ZIEL_BEMERKUNG");
            this.Property(t => t.ERFASSER_WE).HasColumnName("ERFASSER_WE");
            this.Property(t => t.DAT_WIEDERVORLAGE).HasColumnName("DAT_WIEDERVORLAGE");
            this.Property(t => t.DAT_LIEFER_PLAN).HasColumnName("DAT_LIEFER_PLAN");
            this.Property(t => t.BEMERKUNG_VERZUG).HasColumnName("BEMERKUNG_VERZUG");
            this.Property(t => t.BEMERKUNG_EXPEDITING).HasColumnName("BEMERKUNG_EXPEDITING");
            this.Property(t => t.MONTAGE_EH).HasColumnName("MONTAGE_EH");
            this.Property(t => t.VERZUGSDAUER_WO).HasColumnName("VERZUGSDAUER_WO");
            this.Property(t => t.LISTE_DATEIEN).HasColumnName("LISTE_DATEIEN");
            this.Property(t => t.VSHIER2_KORR).HasColumnName("VSHIER2_KORR");
            this.Property(t => t.VSHIER3_KORR).HasColumnName("VSHIER3_KORR");
            this.Property(t => t.ZEICHNR_KORR).HasColumnName("ZEICHNR_KORR");
            this.Property(t => t.ZEICHNPOS_KORR).HasColumnName("ZEICHNPOS_KORR");
            this.Property(t => t.KKSNR_KORR).HasColumnName("KKSNR_KORR");
            this.Property(t => t.LISTE_KUNDENAUFTRAG).HasColumnName("LISTE_KUNDENAUFTRAG");
            this.Property(t => t.LISTE_BPOS).HasColumnName("LISTE_BPOS");
            this.Property(t => t.KOMPONENTEN_NR).HasColumnName("KOMPONENTEN_NR");
            this.Property(t => t.SCHMELZE).HasColumnName("SCHMELZE");
            this.Property(t => t.HERSTELL_LAENGE).HasColumnName("HERSTELL_LAENGE");
            this.Property(t => t.PACKLISTENINFO).HasColumnName("PACKLISTENINFO");
        }
    }
}
