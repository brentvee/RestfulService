using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class DAT_VSBEREITMap : EntityTypeConfiguration<DAT_VSBEREIT>
    {
        public DAT_VSBEREITMap()
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

            this.Property(t => t.TX_INCOTERM2000)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.INCO_ZUSATZ)
                .IsRequired()
                .HasMaxLength(28);

            this.Property(t => t.VSB_TXD)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.VSB_TXX)
                .IsRequired()
                .HasMaxLength(128);

            this.Property(t => t.ABHOLREFERENZ)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ISO_WAEHRUNGWERT)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.LISTE_STAT_WAREN_NR)
                .HasMaxLength(250);

            this.Property(t => t.LISTE_KISTENARTEN)
                .HasMaxLength(250);

            this.Property(t => t.BEMERKUNG)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.ABHOL_ANSPRECH)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ABHOL_TELEFON1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ABHOL_TELEFON2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ABHOL_FAX)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ABHOL_EMAIL)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ABHOL_LADEZEITEN)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.ABHOL_BEMERKUNG)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ANSPRECH_ANSPRECH)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ANSPRECH_TELEFON1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ANSPRECH_TELEFON2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ANSPRECH_FAX)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ANSPRECH_EMAIL)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ANSPRECH_LADEZEITEN)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.ANSPRECH_BEMERKUNG)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ZIEL_ANSPRECH)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ZIEL_TELEFON1)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ZIEL_TELEFON2)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ZIEL_FAX)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ZIEL_EMAIL)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ZIEL_LADEZEITEN)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.ZIEL_BEMERKUNG)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DAT_VSBEREIT");
            this.Property(t => t.ZAEHLER).HasColumnName("ZAEHLER");
            this.Property(t => t.Z_AKUNDE).HasColumnName("Z_AKUNDE");
            this.Property(t => t.DAT_LASTMOD).HasColumnName("DAT_LASTMOD");
            this.Property(t => t.LISTE_KZ).HasColumnName("LISTE_KZ");
            this.Property(t => t.EDV1).HasColumnName("EDV1");
            this.Property(t => t.NPARM_RESERVE).HasColumnName("NPARM_RESERVE");
            this.Property(t => t.W_STATUS).HasColumnName("W_STATUS");
            this.Property(t => t.LOG_STATUS).HasColumnName("LOG_STATUS");
            this.Property(t => t.DAT_STATUS).HasColumnName("DAT_STATUS");
            this.Property(t => t.Z_LFT).HasColumnName("Z_LFT");
            this.Property(t => t.MANDANT).HasColumnName("MANDANT");
            this.Property(t => t.VS_HIER1).HasColumnName("VS_HIER1");
            this.Property(t => t.VS_HIER2).HasColumnName("VS_HIER2");
            this.Property(t => t.VS_HIER3).HasColumnName("VS_HIER3");
            this.Property(t => t.BS_HIER2).HasColumnName("BS_HIER2");
            this.Property(t => t.BS_HIER3).HasColumnName("BS_HIER3");
            this.Property(t => t.DAT_VSBEREIT1).HasColumnName("DAT_VSBEREIT");
            this.Property(t => t.DAT_ABHOLUNG).HasColumnName("DAT_ABHOLUNG");
            this.Property(t => t.W_ART_BELADUNG).HasColumnName("W_ART_BELADUNG");
            this.Property(t => t.W_ART_LAGERBEDINGUNG).HasColumnName("W_ART_LAGERBEDINGUNG");
            this.Property(t => t.TX_INCOTERM2000).HasColumnName("TX_INCOTERM2000");
            this.Property(t => t.INCO_ZUSATZ).HasColumnName("INCO_ZUSATZ");
            this.Property(t => t.VSB_TXD).HasColumnName("VSB_TXD");
            this.Property(t => t.VSB_TXX).HasColumnName("VSB_TXX");
            this.Property(t => t.ABHOLREFERENZ).HasColumnName("ABHOLREFERENZ");
            this.Property(t => t.LADERAUM1_MM).HasColumnName("LADERAUM1_MM");
            this.Property(t => t.LADERAUM2_MM).HasColumnName("LADERAUM2_MM");
            this.Property(t => t.LADERAUM3_MM).HasColumnName("LADERAUM3_MM");
            this.Property(t => t.WERT).HasColumnName("WERT");
            this.Property(t => t.ISO_WAEHRUNGWERT).HasColumnName("ISO_WAEHRUNGWERT");
            this.Property(t => t.KST_ANZ).HasColumnName("KST_ANZ");
            this.Property(t => t.KST_NETTO_KG).HasColumnName("KST_NETTO_KG");
            this.Property(t => t.KST_BRUTTO_KG).HasColumnName("KST_BRUTTO_KG");
            this.Property(t => t.KST_VOLUMEN_CBM).HasColumnName("KST_VOLUMEN_CBM");
            this.Property(t => t.KORREKTUR_KG).HasColumnName("KORREKTUR_KG");
            this.Property(t => t.VSB_TARA_KG).HasColumnName("VSB_TARA_KG");
            this.Property(t => t.VSB_ANZ_PACKSTUECKE).HasColumnName("VSB_ANZ_PACKSTUECKE");
            this.Property(t => t.ZAEHLER_INT).HasColumnName("ZAEHLER_INT");
            this.Property(t => t.LISTE_STAT_WAREN_NR).HasColumnName("LISTE_STAT_WAREN_NR");
            this.Property(t => t.LISTE_KOLLINR).HasColumnName("LISTE_KOLLINR");
            this.Property(t => t.LISTE_ABMESSUNGEN).HasColumnName("LISTE_ABMESSUNGEN");
            this.Property(t => t.LISTE_KISTENARTEN).HasColumnName("LISTE_KISTENARTEN");
            this.Property(t => t.BEMERKUNG).HasColumnName("BEMERKUNG");
            this.Property(t => t.Z_LFT_ABHOL).HasColumnName("Z_LFT_ABHOL");
            this.Property(t => t.ABHOL_ANSPRECH).HasColumnName("ABHOL_ANSPRECH");
            this.Property(t => t.ABHOL_TELEFON1).HasColumnName("ABHOL_TELEFON1");
            this.Property(t => t.ABHOL_TELEFON2).HasColumnName("ABHOL_TELEFON2");
            this.Property(t => t.ABHOL_FAX).HasColumnName("ABHOL_FAX");
            this.Property(t => t.ABHOL_EMAIL).HasColumnName("ABHOL_EMAIL");
            this.Property(t => t.ABHOL_LADEZEITEN).HasColumnName("ABHOL_LADEZEITEN");
            this.Property(t => t.ABHOL_BEMERKUNG).HasColumnName("ABHOL_BEMERKUNG");
            this.Property(t => t.Z_LFT_ANSPRECH).HasColumnName("Z_LFT_ANSPRECH");
            this.Property(t => t.ANSPRECH_ANSPRECH).HasColumnName("ANSPRECH_ANSPRECH");
            this.Property(t => t.ANSPRECH_TELEFON1).HasColumnName("ANSPRECH_TELEFON1");
            this.Property(t => t.ANSPRECH_TELEFON2).HasColumnName("ANSPRECH_TELEFON2");
            this.Property(t => t.ANSPRECH_FAX).HasColumnName("ANSPRECH_FAX");
            this.Property(t => t.ANSPRECH_EMAIL).HasColumnName("ANSPRECH_EMAIL");
            this.Property(t => t.ANSPRECH_LADEZEITEN).HasColumnName("ANSPRECH_LADEZEITEN");
            this.Property(t => t.ANSPRECH_BEMERKUNG).HasColumnName("ANSPRECH_BEMERKUNG");
            this.Property(t => t.Z_LFT_ZIEL).HasColumnName("Z_LFT_ZIEL");
            this.Property(t => t.ZIEL_ANSPRECH).HasColumnName("ZIEL_ANSPRECH");
            this.Property(t => t.ZIEL_TELEFON1).HasColumnName("ZIEL_TELEFON1");
            this.Property(t => t.ZIEL_TELEFON2).HasColumnName("ZIEL_TELEFON2");
            this.Property(t => t.ZIEL_FAX).HasColumnName("ZIEL_FAX");
            this.Property(t => t.ZIEL_EMAIL).HasColumnName("ZIEL_EMAIL");
            this.Property(t => t.ZIEL_LADEZEITEN).HasColumnName("ZIEL_LADEZEITEN");
            this.Property(t => t.ZIEL_BEMERKUNG).HasColumnName("ZIEL_BEMERKUNG");
        }
    }
}
