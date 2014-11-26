using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class N_KENNZEICHENMap : EntityTypeConfiguration<N_KENNZEICHEN>
    {
        public N_KENNZEICHENMap()
        {
            // Primary Key
            this.HasKey(t => t.ZAEHLER);

            // Properties
            this.Property(t => t.ZAEHLER)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.KEY)
                .HasMaxLength(3);

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
                .HasMaxLength(30);

            this.Property(t => t.KUERZEL)
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("N_KENNZEICHEN");
            this.Property(t => t.ZAEHLER).HasColumnName("ZAEHLER");
            this.Property(t => t.KEY).HasColumnName("KEY");
            this.Property(t => t.SAP_SPRACHE).HasColumnName("SAP_SPRACHE");
            this.Property(t => t.DAT_LASTMOD).HasColumnName("DAT_LASTMOD");
            this.Property(t => t.LISTE_KZ).HasColumnName("LISTE_KZ");
            this.Property(t => t.EDV1).HasColumnName("EDV1");
            this.Property(t => t.NPARM_RESERVE).HasColumnName("NPARM_RESERVE");
            this.Property(t => t.LISTE).HasColumnName("LISTE");
            this.Property(t => t.TXX).HasColumnName("TXX");
            this.Property(t => t.KUERZEL).HasColumnName("KUERZEL");
        }
    }
}
