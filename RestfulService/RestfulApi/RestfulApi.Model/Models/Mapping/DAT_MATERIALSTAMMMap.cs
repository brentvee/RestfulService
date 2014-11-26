using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class DAT_MATERIALSTAMMMap : EntityTypeConfiguration<DAT_MATERIALSTAMM>
    {
        public DAT_MATERIALSTAMMMap()
        {
            // Primary Key
            this.HasKey(t => t.ZAEHLER);

            // Properties
            this.Property(t => t.ZAEHLER)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LISTE_KZ)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.EDV1)
                .HasMaxLength(50);

            this.Property(t => t.NPARM_RESERVE)
                .HasMaxLength(20);

            this.Property(t => t.LT_FREMDIDENT)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LT_TXX1)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.SAP_SPRACHE1)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.LT_TXX2)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.SAP_SPRACHE2)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.LT_TXX3)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.SAP_SPRACHE3)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.LT_TXX4)
                .IsRequired()
                .HasMaxLength(40);

            this.Property(t => t.SAP_SPRACHE4)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.ISO_WAEHRUNGWERT)
                .IsRequired()
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
                .IsRequired()
                .HasMaxLength(7);

            this.Property(t => t.GEFAHRGUT_UNNR)
                .IsRequired()
                .HasMaxLength(132);

            this.Property(t => t.STAT_WAREN_NR)
                .IsRequired()
                .HasMaxLength(15);

            this.Property(t => t.SAP_URSPRUNGSLAND)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.WERKSTOFF)
                .IsRequired()
                .HasMaxLength(48);

            this.Property(t => t.NORM)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ABNAHME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BEMERKUNG)
                .IsRequired()
                .HasMaxLength(250);

            this.Property(t => t.W_ART_LAGERBEDINGUNG)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("DAT_MATERIALSTAMM");
            this.Property(t => t.ZAEHLER).HasColumnName("ZAEHLER");
            this.Property(t => t.Z_AKUNDE).HasColumnName("Z_AKUNDE");
            this.Property(t => t.DAT_LASTMOD).HasColumnName("DAT_LASTMOD");
            this.Property(t => t.W_STATUS).HasColumnName("W_STATUS");
            this.Property(t => t.LISTE_KZ).HasColumnName("LISTE_KZ");
            this.Property(t => t.LOG_STATUS).HasColumnName("LOG_STATUS");
            this.Property(t => t.EDV1).HasColumnName("EDV1");
            this.Property(t => t.NPARM_RESERVE).HasColumnName("NPARM_RESERVE");
            this.Property(t => t.DAT_STATUS).HasColumnName("DAT_STATUS");
            this.Property(t => t.Z_LFT).HasColumnName("Z_LFT");
            this.Property(t => t.LT_FREMDIDENT).HasColumnName("LT_FREMDIDENT");
            this.Property(t => t.LT_TXX1).HasColumnName("LT_TXX1");
            this.Property(t => t.SAP_SPRACHE1).HasColumnName("SAP_SPRACHE1");
            this.Property(t => t.LT_TXX2).HasColumnName("LT_TXX2");
            this.Property(t => t.SAP_SPRACHE2).HasColumnName("SAP_SPRACHE2");
            this.Property(t => t.LT_TXX3).HasColumnName("LT_TXX3");
            this.Property(t => t.SAP_SPRACHE3).HasColumnName("SAP_SPRACHE3");
            this.Property(t => t.LT_TXX4).HasColumnName("LT_TXX4");
            this.Property(t => t.SAP_SPRACHE4).HasColumnName("SAP_SPRACHE4");
            this.Property(t => t.LT_MENGE).HasColumnName("LT_MENGE");
            this.Property(t => t.W_LT_MENGENEINHEIT).HasColumnName("W_LT_MENGENEINHEIT");
            this.Property(t => t.WERT).HasColumnName("WERT");
            this.Property(t => t.ISO_WAEHRUNGWERT).HasColumnName("ISO_WAEHRUNGWERT");
            this.Property(t => t.NETTO_KG).HasColumnName("NETTO_KG");
            this.Property(t => t.ABMESS1_MM).HasColumnName("ABMESS1_MM");
            this.Property(t => t.ABMESS2_MM).HasColumnName("ABMESS2_MM");
            this.Property(t => t.ABMESS3_MM).HasColumnName("ABMESS3_MM");
            this.Property(t => t.ABMESS4_MM).HasColumnName("ABMESS4_MM");
            this.Property(t => t.ABMESS5_MM).HasColumnName("ABMESS5_MM");
            this.Property(t => t.ABMESS6_MM).HasColumnName("ABMESS6_MM");
            this.Property(t => t.GEFAHRGUT_KLASSE).HasColumnName("GEFAHRGUT_KLASSE");
            this.Property(t => t.GEFAHRGUT_UNNR).HasColumnName("GEFAHRGUT_UNNR");
            this.Property(t => t.STAT_WAREN_NR).HasColumnName("STAT_WAREN_NR");
            this.Property(t => t.SAP_URSPRUNGSLAND).HasColumnName("SAP_URSPRUNGSLAND");
            this.Property(t => t.WERKSTOFF).HasColumnName("WERKSTOFF");
            this.Property(t => t.NORM).HasColumnName("NORM");
            this.Property(t => t.ABNAHME).HasColumnName("ABNAHME");
            this.Property(t => t.BEMERKUNG).HasColumnName("BEMERKUNG");
            this.Property(t => t.W_ART_LAGERBEDINGUNG).HasColumnName("W_ART_LAGERBEDINGUNG");
        }
    }
}
