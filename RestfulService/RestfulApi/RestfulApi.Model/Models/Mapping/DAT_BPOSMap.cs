using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class DAT_BPOSMap : EntityTypeConfiguration<DAT_BPOS>
    {
        public DAT_BPOSMap()
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

            this.Property(t => t.BP_TXD)
                .HasMaxLength(50);

            this.Property(t => t.BP_TXX)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BP_TXX1)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.BP_TXX2)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.BP_TXX3)
                .IsRequired()
                .HasMaxLength(60);

            this.Property(t => t.ISO_WAEHRUNGWERT)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.VS_GEWICHT_KG)
                .HasMaxLength(12);

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

            this.Property(t => t.ABMESS1)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ABMESS2)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ABMESS3)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ABMESS4)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ABMESS5)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ABMESS6)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ZEICHNUNGS_NR)
                .HasMaxLength(31);

            this.Property(t => t.ZEICHNUNGS_POS)
                .HasMaxLength(30);

            this.Property(t => t.ZEICHNUNGS_TXX)
                .HasMaxLength(30);

            this.Property(t => t.NETZPLAN_NR)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.NETZPLAN_POS)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.NETZPLAN_TXX)
                .IsRequired()
                .HasMaxLength(80);

            this.Property(t => t.TX_INCOTERM2000)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.INCO_ZUSATZ)
                .IsRequired()
                .HasMaxLength(28);

            this.Property(t => t.BAUGRUPPE_NR)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.BAUGRUPPE_POS)
                .HasMaxLength(5);

            this.Property(t => t.MATERIAL_NR)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.TPLATZ_NR)
                .HasMaxLength(30);

            this.Property(t => t.TPLATZ_POS)
                .HasMaxLength(4);

            this.Property(t => t.GEFAHRGUT_KLASSE)
                .HasMaxLength(7);

            this.Property(t => t.GEFAHRGUT_UNNR)
                .HasMaxLength(137);

            this.Property(t => t.EMR_TAG)
                .HasMaxLength(30);

            this.Property(t => t.EMR_TEILE)
                .HasMaxLength(11);

            this.Property(t => t.ROHRTEILE)
                .HasMaxLength(8);

            this.Property(t => t.TON)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.PRUEFKOMMENTAR)
                .HasMaxLength(250);

            this.Property(t => t.CLIENTCODE)
                .HasMaxLength(20);

            this.Property(t => t.PRPS_POSID)
                .HasMaxLength(24);

            this.Property(t => t.KOMMISSION)
                .HasMaxLength(20);

            this.Property(t => t.WERKSTOFF)
                .HasMaxLength(48);

            this.Property(t => t.KENNWERTE)
                .HasMaxLength(31);

            this.Property(t => t.KKS_NR)
                .HasMaxLength(31);

            this.Property(t => t.STAT_WAREN_NR)
                .HasMaxLength(15);

            this.Property(t => t.BESTAETIGUNG_LFT)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.PKEY_AKUNDE)
                .HasMaxLength(50);

            this.Property(t => t.NORM)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ABNAHME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LISTE_UNITS)
                .IsRequired()
                .HasMaxLength(26);

            this.Property(t => t.BEMERKUNG_VERZUG)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.BEMERKUNG_EXPEDITING)
                .HasMaxLength(250);

            this.Property(t => t.LISTE_AUFTRAGSNR)
                .IsRequired();

            // Table & Column Mappings
            this.ToTable("DAT_BPOS");
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
            this.Property(t => t.Z_IMPORT).HasColumnName("Z_IMPORT");
            this.Property(t => t.Z_LFT).HasColumnName("Z_LFT");
            this.Property(t => t.Z_BEST).HasColumnName("Z_BEST");
            this.Property(t => t.Z_VS_HIER2).HasColumnName("Z_VS_HIER2");
            this.Property(t => t.Z_VS_HIER3).HasColumnName("Z_VS_HIER3");
            this.Property(t => t.BP_TXD).HasColumnName("BP_TXD");
            this.Property(t => t.BP_TXX).HasColumnName("BP_TXX");
            this.Property(t => t.BP_TXX1).HasColumnName("BP_TXX1");
            this.Property(t => t.BP_TXX2).HasColumnName("BP_TXX2");
            this.Property(t => t.BP_TXX3).HasColumnName("BP_TXX3");
            this.Property(t => t.BP_MENGE).HasColumnName("BP_MENGE");
            this.Property(t => t.VS_MENGE).HasColumnName("VS_MENGE");
            this.Property(t => t.BP_MENGE2).HasColumnName("BP_MENGE2");
            this.Property(t => t.W_BP_MENGENEINHEIT).HasColumnName("W_BP_MENGENEINHEIT");
            this.Property(t => t.W_BP_MENGENEINHEIT2).HasColumnName("W_BP_MENGENEINHEIT2");
            this.Property(t => t.WERT).HasColumnName("WERT");
            this.Property(t => t.ISO_WAEHRUNGWERT).HasColumnName("ISO_WAEHRUNGWERT");
            this.Property(t => t.GEWICHT_KG).HasColumnName("GEWICHT_KG");
            this.Property(t => t.VS_GEWICHT_KG).HasColumnName("VS_GEWICHT_KG");
            this.Property(t => t.DAT_LIEFER_PLAN).HasColumnName("DAT_LIEFER_PLAN");
            this.Property(t => t.DAT_LIEFER_ERWARTET).HasColumnName("DAT_LIEFER_ERWARTET");
            this.Property(t => t.DAT_LIEFER_PLAN2).HasColumnName("DAT_LIEFER_PLAN2");
            this.Property(t => t.DAT_ABNAHME_PLAN).HasColumnName("DAT_ABNAHME_PLAN");
            this.Property(t => t.DAT_ABNAHME_ERWARTET).HasColumnName("DAT_ABNAHME_ERWARTET");
            this.Property(t => t.Z_LFT_ABHOL).HasColumnName("Z_LFT_ABHOL");
            this.Property(t => t.ABHOL_ANSPRECH).HasColumnName("ABHOL_ANSPRECH");
            this.Property(t => t.ABHOL_TELEFON1).HasColumnName("ABHOL_TELEFON1");
            this.Property(t => t.ABHOL_TELEFON2).HasColumnName("ABHOL_TELEFON2");
            this.Property(t => t.ABHOL_FAX).HasColumnName("ABHOL_FAX");
            this.Property(t => t.ABHOL_EMAIL).HasColumnName("ABHOL_EMAIL");
            this.Property(t => t.ABHOL_LADEZEITEN).HasColumnName("ABHOL_LADEZEITEN");
            this.Property(t => t.ABHOL_BEMERKUNG).HasColumnName("ABHOL_BEMERKUNG");
            this.Property(t => t.Z_LFT_ZIEL).HasColumnName("Z_LFT_ZIEL");
            this.Property(t => t.ZIEL_ANSPRECH).HasColumnName("ZIEL_ANSPRECH");
            this.Property(t => t.ZIEL_TELEFON1).HasColumnName("ZIEL_TELEFON1");
            this.Property(t => t.ZIEL_TELEFON2).HasColumnName("ZIEL_TELEFON2");
            this.Property(t => t.ZIEL_FAX).HasColumnName("ZIEL_FAX");
            this.Property(t => t.ZIEL_EMAIL).HasColumnName("ZIEL_EMAIL");
            this.Property(t => t.ZIEL_LADEZEITEN).HasColumnName("ZIEL_LADEZEITEN");
            this.Property(t => t.ZIEL_BEMERKUNG).HasColumnName("ZIEL_BEMERKUNG");
            this.Property(t => t.Z_USER).HasColumnName("Z_USER");
            this.Property(t => t.Z_USER_TK_BESTELLUNG).HasColumnName("Z_USER_TK_BESTELLUNG");
            this.Property(t => t.Z_USER_TK_CONFIRM).HasColumnName("Z_USER_TK_CONFIRM");
            this.Property(t => t.ABMESS1).HasColumnName("ABMESS1");
            this.Property(t => t.ABMESS2).HasColumnName("ABMESS2");
            this.Property(t => t.ABMESS3).HasColumnName("ABMESS3");
            this.Property(t => t.ABMESS4).HasColumnName("ABMESS4");
            this.Property(t => t.ABMESS5).HasColumnName("ABMESS5");
            this.Property(t => t.ABMESS6).HasColumnName("ABMESS6");
            this.Property(t => t.ZEICHNUNGS_NR).HasColumnName("ZEICHNUNGS_NR");
            this.Property(t => t.ZEICHNUNGS_POS).HasColumnName("ZEICHNUNGS_POS");
            this.Property(t => t.ZEICHNUNGS_TXX).HasColumnName("ZEICHNUNGS_TXX");
            this.Property(t => t.NETZPLAN_NR).HasColumnName("NETZPLAN_NR");
            this.Property(t => t.NETZPLAN_POS).HasColumnName("NETZPLAN_POS");
            this.Property(t => t.NETZPLAN_TXX).HasColumnName("NETZPLAN_TXX");
            this.Property(t => t.TX_INCOTERM2000).HasColumnName("TX_INCOTERM2000");
            this.Property(t => t.INCO_ZUSATZ).HasColumnName("INCO_ZUSATZ");
            this.Property(t => t.BAUGRUPPE_NR).HasColumnName("BAUGRUPPE_NR");
            this.Property(t => t.BAUGRUPPE_POS).HasColumnName("BAUGRUPPE_POS");
            this.Property(t => t.MATERIAL_NR).HasColumnName("MATERIAL_NR");
            this.Property(t => t.TPLATZ_NR).HasColumnName("TPLATZ_NR");
            this.Property(t => t.TPLATZ_POS).HasColumnName("TPLATZ_POS");
            this.Property(t => t.GEFAHRGUT_KLASSE).HasColumnName("GEFAHRGUT_KLASSE");
            this.Property(t => t.GEFAHRGUT_UNNR).HasColumnName("GEFAHRGUT_UNNR");
            this.Property(t => t.EMR_TAG).HasColumnName("EMR_TAG");
            this.Property(t => t.EMR_TEILE).HasColumnName("EMR_TEILE");
            this.Property(t => t.ROHRTEILE).HasColumnName("ROHRTEILE");
            this.Property(t => t.TON).HasColumnName("TON");
            this.Property(t => t.PRUEFKOMMENTAR).HasColumnName("PRUEFKOMMENTAR");
            this.Property(t => t.CLIENTCODE).HasColumnName("CLIENTCODE");
            this.Property(t => t.PRPS_POSID).HasColumnName("PRPS_POSID");
            this.Property(t => t.KOMMISSION).HasColumnName("KOMMISSION");
            this.Property(t => t.NPARM_LT_NR).HasColumnName("NPARM_LT_NR");
            this.Property(t => t.WERKSTOFF).HasColumnName("WERKSTOFF");
            this.Property(t => t.KENNWERTE).HasColumnName("KENNWERTE");
            this.Property(t => t.KKS_NR).HasColumnName("KKS_NR");
            this.Property(t => t.STAT_WAREN_NR).HasColumnName("STAT_WAREN_NR");
            this.Property(t => t.BESTAETIGUNG_LFT).HasColumnName("BESTAETIGUNG_LFT");
            this.Property(t => t.PKEY_AKUNDE).HasColumnName("PKEY_AKUNDE");
            this.Property(t => t.PROZ_WERT).HasColumnName("PROZ_WERT");
            this.Property(t => t.W_TEXTE).HasColumnName("W_TEXTE");
            this.Property(t => t.NORM).HasColumnName("NORM");
            this.Property(t => t.ABNAHME).HasColumnName("ABNAHME");
            this.Property(t => t.LISTE_UNITS).HasColumnName("LISTE_UNITS");
            this.Property(t => t.ABW_ADRESSE).HasColumnName("ABW_ADRESSE");
            this.Property(t => t.EK_TXX).HasColumnName("EK_TXX");
            this.Property(t => t.DAT_WIEDERVORLAGE).HasColumnName("DAT_WIEDERVORLAGE");
            this.Property(t => t.BEMERKUNG_VERZUG).HasColumnName("BEMERKUNG_VERZUG");
            this.Property(t => t.BEMERKUNG_EXPEDITING).HasColumnName("BEMERKUNG_EXPEDITING");
            this.Property(t => t.VERZUGSDAUER_WO).HasColumnName("VERZUGSDAUER_WO");
            this.Property(t => t.LISTE_DATEIEN).HasColumnName("LISTE_DATEIEN");
            this.Property(t => t.LISTE_AUFTRAGSNR).HasColumnName("LISTE_AUFTRAGSNR");
        }
    }
}
