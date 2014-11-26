using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class DAT_TBEHAELTERMap : EntityTypeConfiguration<DAT_TBEHAELTER>
    {
        public DAT_TBEHAELTERMap()
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

            this.Property(t => t.VS_HIER1)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.NEUTRAL05)
                .HasMaxLength(3);

            this.Property(t => t.NEUTRAL10)
                .HasMaxLength(10);

            this.Property(t => t.NEUTRAL20)
                .HasMaxLength(20);

            this.Property(t => t.NEUTRAL30)
                .HasMaxLength(30);

            this.Property(t => t.BEMERKUNG)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("DAT_TBEHAELTER");
            this.Property(t => t.ZAEHLER).HasColumnName("ZAEHLER");
            this.Property(t => t.Z_AKUNDE).HasColumnName("Z_AKUNDE");
            this.Property(t => t.DAT_LASTMOD).HasColumnName("DAT_LASTMOD");
            this.Property(t => t.LISTE_KZ).HasColumnName("LISTE_KZ");
            this.Property(t => t.EDV1).HasColumnName("EDV1");
            this.Property(t => t.NPARM_RESERVE).HasColumnName("NPARM_RESERVE");
            this.Property(t => t.W_STATUS).HasColumnName("W_STATUS");
            this.Property(t => t.LOG_Status).HasColumnName("LOG_Status");
            this.Property(t => t.DAT_STATUS).HasColumnName("DAT_STATUS");
            this.Property(t => t.VS_HIER1).HasColumnName("VS_HIER1");
            this.Property(t => t.Z_LFT).HasColumnName("Z_LFT");
            this.Property(t => t.Z_VSBEREIT).HasColumnName("Z_VSBEREIT");
            this.Property(t => t.W_ART).HasColumnName("W_ART");
            this.Property(t => t.ABMESS1_MM).HasColumnName("ABMESS1_MM");
            this.Property(t => t.ABMESS2_MM).HasColumnName("ABMESS2_MM");
            this.Property(t => t.ABMESS3_MM).HasColumnName("ABMESS3_MM");
            this.Property(t => t.BRUTTO_KG).HasColumnName("BRUTTO_KG");
            this.Property(t => t.NETTO_KG).HasColumnName("NETTO_KG");
            this.Property(t => t.TARA_KG).HasColumnName("TARA_KG");
            this.Property(t => t.NEUTRAL05).HasColumnName("NEUTRAL05");
            this.Property(t => t.NEUTRAL10).HasColumnName("NEUTRAL10");
            this.Property(t => t.NEUTRAL20).HasColumnName("NEUTRAL20");
            this.Property(t => t.NEUTRAL30).HasColumnName("NEUTRAL30");
            this.Property(t => t.BEMERKUNG).HasColumnName("BEMERKUNG");
        }
    }
}
