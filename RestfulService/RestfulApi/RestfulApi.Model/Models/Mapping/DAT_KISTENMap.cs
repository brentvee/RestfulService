using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class DAT_KISTENMap : EntityTypeConfiguration<DAT_KISTEN>
    {
        public DAT_KISTENMap()
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
                .HasMaxLength(12);

            this.Property(t => t.VS_HIER2)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.VS_HIER3)
                .IsRequired()
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

            this.Property(t => t.KOLLINUMMER)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.LAGERORT1)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.LAGERORT2)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.LAGERORT3)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.KONS_NR)
                .HasMaxLength(12);

            this.Property(t => t.KONS_FERTIGTEXT)
                .HasMaxLength(80);

            this.Property(t => t.KONS_TEXT1)
                .HasMaxLength(25);

            this.Property(t => t.KONS_TEXT2)
                .HasMaxLength(25);

            this.Property(t => t.KONS_TEXT3)
                .HasMaxLength(25);

            this.Property(t => t.KONS_TEXT4)
                .HasMaxLength(25);

            this.Property(t => t.KONS_BAUART)
                .HasMaxLength(7);

            this.Property(t => t.INHALT_TXD)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.INHALT_TXX)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.INHALT_TXX2)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.SOLLVPART)
                .HasMaxLength(1);

            this.Property(t => t.NEUTRAL05)
                .HasMaxLength(3);

            this.Property(t => t.NEUTRAL10)
                .HasMaxLength(10);

            this.Property(t => t.NEUTRAL20)
                .HasMaxLength(20);

            this.Property(t => t.NEUTRAL30)
                .HasMaxLength(30);

            this.Property(t => t.ISO_WAEHRUNGWERT)
                .HasMaxLength(3);

            this.Property(t => t.GEFAHRGUT_KLASSE)
                .HasMaxLength(7);

            this.Property(t => t.GEFAHRGUT_UNNR)
                .HasMaxLength(4);

            this.Property(t => t.RECHNUM_VP)
                .HasMaxLength(16);

            this.Property(t => t.LAGERORT_BAUSTELLE)
                .HasMaxLength(64);

            this.Property(t => t.BEMERKUNG_BAUSTELLE)
                .HasMaxLength(80);

            this.Property(t => t.PKEY_AKUNDE)
                .HasMaxLength(50);

            this.Property(t => t.SAP_SPRACHE)
                .HasMaxLength(1);

            this.Property(t => t.BEMERKUNG)
                .HasMaxLength(250);

            this.Property(t => t.BARCODE_EXTERN)
                .HasMaxLength(250);

            this.Property(t => t.KONTO)
                .HasMaxLength(3);

            this.Property(t => t.FAKTRENUM)
                .HasMaxLength(16);

            this.Property(t => t.ABRECHNUNGSHINWEIS)
                .HasMaxLength(250);

            this.Property(t => t.ABTEILUNG)
                .HasMaxLength(32);

            this.Property(t => t.WE_NR)
                .HasMaxLength(32);

            this.Property(t => t.KOSTENSTELLE)
                .HasMaxLength(32);

            this.Property(t => t.KOLLINUMMER_INTERN)
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

            this.Property(t => t.TOKEN_BAU)
                .HasMaxLength(3);

            this.Property(t => t.TOKEN_AKUNDE)
                .HasMaxLength(3);

            this.Property(t => t.TOKEN_VP)
                .HasMaxLength(3);

            this.Property(t => t.RECHNUM_BAU)
                .HasMaxLength(16);

            this.Property(t => t.RECHNUM_AKUNDE)
                .HasMaxLength(16);

            this.Property(t => t.RECHNUM_ENDK)
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("DAT_KISTEN");
            this.Property(t => t.ZAEHLER).HasColumnName("ZAEHLER");
            this.Property(t => t.Z_AKUNDE).HasColumnName("Z_AKUNDE");
            this.Property(t => t.DAT_LASTMOD).HasColumnName("DAT_LASTMOD");
            this.Property(t => t.LISTE_KZ).HasColumnName("LISTE_KZ");
            this.Property(t => t.EDV1).HasColumnName("EDV1");
            this.Property(t => t.NPARM_RESERVE).HasColumnName("NPARM_RESERVE");
            this.Property(t => t.W_STATUS).HasColumnName("W_STATUS");
            this.Property(t => t.LOG_Status).HasColumnName("LOG_Status");
            this.Property(t => t.DAT_STATUS).HasColumnName("DAT_STATUS");
            this.Property(t => t.MANDANT).HasColumnName("MANDANT");
            this.Property(t => t.VS_HIER1).HasColumnName("VS_HIER1");
            this.Property(t => t.VS_HIER2).HasColumnName("VS_HIER2");
            this.Property(t => t.VS_HIER3).HasColumnName("VS_HIER3");
            this.Property(t => t.BS_HIER2).HasColumnName("BS_HIER2");
            this.Property(t => t.BS_HIER3).HasColumnName("BS_HIER3");
            this.Property(t => t.Z_LFT).HasColumnName("Z_LFT");
            this.Property(t => t.Z_SUMMARY).HasColumnName("Z_SUMMARY");
            this.Property(t => t.Z_CONTAINER).HasColumnName("Z_CONTAINER");
            this.Property(t => t.Z_HERSTELLER).HasColumnName("Z_HERSTELLER");
            this.Property(t => t.Z_VSAUFTRAG).HasColumnName("Z_VSAUFTRAG");
            this.Property(t => t.Z_VSBEREIT).HasColumnName("Z_VSBEREIT");
            this.Property(t => t.W_ART).HasColumnName("W_ART");
            this.Property(t => t.W_ART_TRANSPORT).HasColumnName("W_ART_TRANSPORT");
            this.Property(t => t.W_FAKTSTATUS).HasColumnName("W_FAKTSTATUS");
            this.Property(t => t.W_FAKTHERSTELLER).HasColumnName("W_FAKTHERSTELLER");
            this.Property(t => t.W_KATEGORIE).HasColumnName("W_KATEGORIE");
            this.Property(t => t.W_STANDORT).HasColumnName("W_STANDORT");
            this.Property(t => t.W_FERTIGORT).HasColumnName("W_FERTIGORT");
            this.Property(t => t.W_ORT_VP).HasColumnName("W_ORT_VP");
            this.Property(t => t.W_ART_BESTELLUNG).HasColumnName("W_ART_BESTELLUNG");
            this.Property(t => t.W_TEXTE).HasColumnName("W_TEXTE");
            this.Property(t => t.W_ART_LAGERBEDINGUNG).HasColumnName("W_ART_LAGERBEDINGUNG");
            this.Property(t => t.BARCODE).HasColumnName("BARCODE");
            this.Property(t => t.KOLLINUMMER).HasColumnName("KOLLINUMMER");
            this.Property(t => t.LAGERORT1).HasColumnName("LAGERORT1");
            this.Property(t => t.LAGERORT2).HasColumnName("LAGERORT2");
            this.Property(t => t.LAGERORT3).HasColumnName("LAGERORT3");
            this.Property(t => t.KONS_NR).HasColumnName("KONS_NR");
            this.Property(t => t.KONS_FERTIGTEXT).HasColumnName("KONS_FERTIGTEXT");
            this.Property(t => t.KONS_TEXT1).HasColumnName("KONS_TEXT1");
            this.Property(t => t.KONS_TEXT2).HasColumnName("KONS_TEXT2");
            this.Property(t => t.KONS_TEXT3).HasColumnName("KONS_TEXT3");
            this.Property(t => t.KONS_TEXT4).HasColumnName("KONS_TEXT4");
            this.Property(t => t.KONS_KORRMON).HasColumnName("KONS_KORRMON");
            this.Property(t => t.KONS_BAUART).HasColumnName("KONS_BAUART");
            this.Property(t => t.ABMESS1_MM).HasColumnName("ABMESS1_MM");
            this.Property(t => t.ABMESS2_MM).HasColumnName("ABMESS2_MM");
            this.Property(t => t.ABMESS3_MM).HasColumnName("ABMESS3_MM");
            this.Property(t => t.BRUTTO_KG).HasColumnName("BRUTTO_KG");
            this.Property(t => t.NETTO_KG).HasColumnName("NETTO_KG");
            this.Property(t => t.TARA_KG).HasColumnName("TARA_KG");
            this.Property(t => t.INHALT_TXD).HasColumnName("INHALT_TXD");
            this.Property(t => t.INHALT_TXX).HasColumnName("INHALT_TXX");
            this.Property(t => t.INHALT_TXX2).HasColumnName("INHALT_TXX2");
            this.Property(t => t.SOLLVPART).HasColumnName("SOLLVPART");
            this.Property(t => t.DAT_SOLLVP).HasColumnName("DAT_SOLLVP");
            this.Property(t => t.DAT_KONSTRUKTION).HasColumnName("DAT_KONSTRUKTION");
            this.Property(t => t.DAT_FERTIGUNG).HasColumnName("DAT_FERTIGUNG");
            this.Property(t => t.DAT_ABRUF).HasColumnName("DAT_ABRUF");
            this.Property(t => t.DAT_EINGANGZV).HasColumnName("DAT_EINGANGZV");
            this.Property(t => t.DAT_VERSAND).HasColumnName("DAT_VERSAND");
            this.Property(t => t.DAT_FAKTURIERT).HasColumnName("DAT_FAKTURIERT");
            this.Property(t => t.NEUTRAL05).HasColumnName("NEUTRAL05");
            this.Property(t => t.NEUTRAL10).HasColumnName("NEUTRAL10");
            this.Property(t => t.NEUTRAL20).HasColumnName("NEUTRAL20");
            this.Property(t => t.NEUTRAL30).HasColumnName("NEUTRAL30");
            this.Property(t => t.WERT).HasColumnName("WERT");
            this.Property(t => t.ISO_WAEHRUNGWERT).HasColumnName("ISO_WAEHRUNGWERT");
            this.Property(t => t.GEFAHRGUT_KLASSE).HasColumnName("GEFAHRGUT_KLASSE");
            this.Property(t => t.GEFAHRGUT_UNNR).HasColumnName("GEFAHRGUT_UNNR");
            this.Property(t => t.RECHNUM_VP).HasColumnName("RECHNUM_VP");
            this.Property(t => t.LIEFERSCHEIN_BAU).HasColumnName("LIEFERSCHEIN_BAU");
            this.Property(t => t.LAGERORT_BAUSTELLE).HasColumnName("LAGERORT_BAUSTELLE");
            this.Property(t => t.BEMERKUNG_BAUSTELLE).HasColumnName("BEMERKUNG_BAUSTELLE");
            this.Property(t => t.PKEY_BOXCAD).HasColumnName("PKEY_BOXCAD");
            this.Property(t => t.PKEY_AKUNDE).HasColumnName("PKEY_AKUNDE");
            this.Property(t => t.PROZ_WERT).HasColumnName("PROZ_WERT");
            this.Property(t => t.DAT_EINGANG_BAUSTELLE).HasColumnName("DAT_EINGANG_BAUSTELLE");
            this.Property(t => t.W_STATUS_BAUSTELLE).HasColumnName("W_STATUS_BAUSTELLE");
            this.Property(t => t.ANZ_VERLADUNGEN).HasColumnName("ANZ_VERLADUNGEN");
            this.Property(t => t.LT_ANZ).HasColumnName("LT_ANZ");
            this.Property(t => t.SAP_SPRACHE).HasColumnName("SAP_SPRACHE");
            this.Property(t => t.BEMERKUNG).HasColumnName("BEMERKUNG");
            this.Property(t => t.BARCODE_EXTERN).HasColumnName("BARCODE_EXTERN");
            this.Property(t => t.KONTO).HasColumnName("KONTO");
            this.Property(t => t.FAKTRENUM).HasColumnName("FAKTRENUM");
            this.Property(t => t.ANZ_KARTONS).HasColumnName("ANZ_KARTONS");
            this.Property(t => t.ABRECHNUNGSHINWEIS).HasColumnName("ABRECHNUNGSHINWEIS");
            this.Property(t => t.ABTEILUNG).HasColumnName("ABTEILUNG");
            this.Property(t => t.WE_NR).HasColumnName("WE_NR");
            this.Property(t => t.KOSTENSTELLE).HasColumnName("KOSTENSTELLE");
            this.Property(t => t.DAT_LAGERZEITRAUM_VON).HasColumnName("DAT_LAGERZEITRAUM_VON");
            this.Property(t => t.DAT_LAGERZEITRAUM_BIS).HasColumnName("DAT_LAGERZEITRAUM_BIS");
            this.Property(t => t.DAT_LAGERABGERECHNET_VON).HasColumnName("DAT_LAGERABGERECHNET_VON");
            this.Property(t => t.DAT_LAGERABGERECHNET_BIS).HasColumnName("DAT_LAGERABGERECHNET_BIS");
            this.Property(t => t.KOLLINUMMER_INTERN).HasColumnName("KOLLINUMMER_INTERN");
            this.Property(t => t.Z_LFT_ZIEL).HasColumnName("Z_LFT_ZIEL");
            this.Property(t => t.ZIEL_ANSPRECH).HasColumnName("ZIEL_ANSPRECH");
            this.Property(t => t.ZIEL_TELEFON1).HasColumnName("ZIEL_TELEFON1");
            this.Property(t => t.ZIEL_TELEFON2).HasColumnName("ZIEL_TELEFON2");
            this.Property(t => t.ZIEL_FAX).HasColumnName("ZIEL_FAX");
            this.Property(t => t.ZIEL_EMAIL).HasColumnName("ZIEL_EMAIL");
            this.Property(t => t.ZIEL_LADEZEITEN).HasColumnName("ZIEL_LADEZEITEN");
            this.Property(t => t.ZIEL_BEMERKUNG).HasColumnName("ZIEL_BEMERKUNG");
            this.Property(t => t.TOKEN_BAU).HasColumnName("TOKEN_BAU");
            this.Property(t => t.TOKEN_AKUNDE).HasColumnName("TOKEN_AKUNDE");
            this.Property(t => t.TOKEN_VP).HasColumnName("TOKEN_VP");
            this.Property(t => t.DAT_FAKTURIERT_BAU).HasColumnName("DAT_FAKTURIERT_BAU");
            this.Property(t => t.DAT_FAKTURIERT_AKUNDE).HasColumnName("DAT_FAKTURIERT_AKUNDE");
            this.Property(t => t.DAT_FAKTURIERT_VP).HasColumnName("DAT_FAKTURIERT_VP");
            this.Property(t => t.DAT_FAKTURIERT_ENDK).HasColumnName("DAT_FAKTURIERT_ENDK");
            this.Property(t => t.RECHNUM_BAU).HasColumnName("RECHNUM_BAU");
            this.Property(t => t.RECHNUM_AKUNDE).HasColumnName("RECHNUM_AKUNDE");
            this.Property(t => t.RECHNUM_ENDK).HasColumnName("RECHNUM_ENDK");
            this.Property(t => t.W_FAKTSTATUS_BAU).HasColumnName("W_FAKTSTATUS_BAU");
            this.Property(t => t.W_FAKTSTATUS_AKUNDE).HasColumnName("W_FAKTSTATUS_AKUNDE");
            this.Property(t => t.W_FAKTSTATUS_VP).HasColumnName("W_FAKTSTATUS_VP");
            this.Property(t => t.W_FAKTSTATUS_ENDK).HasColumnName("W_FAKTSTATUS_ENDK");
            this.Property(t => t.W_ORT_BAU).HasColumnName("W_ORT_BAU");
            this.Property(t => t.LIEFERSCHEIN_AKUNDE).HasColumnName("LIEFERSCHEIN_AKUNDE");
            this.Property(t => t.LIEFERSCHEIN_VP).HasColumnName("LIEFERSCHEIN_VP");
            this.Property(t => t.LIEFERSCHEIN_ENDK).HasColumnName("LIEFERSCHEIN_ENDK");
            this.Property(t => t.ANZ_PRO_BUND).HasColumnName("ANZ_PRO_BUND");
        }
    }
}
