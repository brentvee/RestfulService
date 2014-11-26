using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class N_ORTEMap : EntityTypeConfiguration<N_ORTE>
    {
        public N_ORTEMap()
        {
            // Primary Key
            this.HasKey(t => t.ZAEHLER);

            // Properties
            this.Property(t => t.ZAEHLER)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SAP_SPRACHE)
                .HasMaxLength(1);

            this.Property(t => t.LISTE_KZ)
                .HasMaxLength(80);

            this.Property(t => t.EDV1)
                .HasMaxLength(50);

            this.Property(t => t.NPARM_RESERVE)
                .HasMaxLength(20);

            this.Property(t => t.LISTE)
                .HasMaxLength(250);

            this.Property(t => t.TXX)
                .HasMaxLength(20);

            this.Property(t => t.KUERZEL)
                .HasMaxLength(10);

            this.Property(t => t.FUNKBASIS)
                .HasMaxLength(1);

            this.Property(t => t.SAP_LAND)
                .HasMaxLength(3);

            this.Property(t => t.DAT_LFT_SCHLUESSEL)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("N_ORTE");
            this.Property(t => t.ZAEHLER).HasColumnName("ZAEHLER");
            this.Property(t => t.WERT).HasColumnName("WERT");
            this.Property(t => t.SAP_SPRACHE).HasColumnName("SAP_SPRACHE");
            this.Property(t => t.DAT_LASTMOD).HasColumnName("DAT_LASTMOD");
            this.Property(t => t.LISTE_KZ).HasColumnName("LISTE_KZ");
            this.Property(t => t.EDV1).HasColumnName("EDV1");
            this.Property(t => t.NPARM_RESERVE).HasColumnName("NPARM_RESERVE");
            this.Property(t => t.LISTE).HasColumnName("LISTE");
            this.Property(t => t.TXX).HasColumnName("TXX");
            this.Property(t => t.KUERZEL).HasColumnName("KUERZEL");
            this.Property(t => t.FUNKBASIS).HasColumnName("FUNKBASIS");
            this.Property(t => t.SAP_LAND).HasColumnName("SAP_LAND");
            this.Property(t => t.DAT_LFT_SCHLUESSEL).HasColumnName("DAT_LFT_SCHLUESSEL");
        }
    }
}