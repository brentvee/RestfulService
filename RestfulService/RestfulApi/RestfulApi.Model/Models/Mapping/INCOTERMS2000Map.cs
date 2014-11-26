using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class INCOTERMS2000Map : EntityTypeConfiguration<INCOTERMS2000>
    {
        public INCOTERMS2000Map()
        {
            // Primary Key
            this.HasKey(t => t.ZAEHLER);

            // Properties
            this.Property(t => t.ZAEHLER)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.INCOTERM2000)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.LISTE_KZ)
                .HasMaxLength(80);

            this.Property(t => t.EDV1)
                .HasMaxLength(50);

            this.Property(t => t.NPARM_RESERVE)
                .HasMaxLength(10);

            this.Property(t => t.TXX)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.LISTE)
                .HasMaxLength(250);

            this.Property(t => t.TXXSHORT)
                .HasMaxLength(20);

            this.Property(t => t.SAP_SPRACHE)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("INCOTERMS2000");
            this.Property(t => t.ZAEHLER).HasColumnName("ZAEHLER");
            this.Property(t => t.INCOTERM2000).HasColumnName("INCOTERM2000");
            this.Property(t => t.DAT_LASTMOD).HasColumnName("DAT_LASTMOD");
            this.Property(t => t.LISTE_KZ).HasColumnName("LISTE_KZ");
            this.Property(t => t.EDV1).HasColumnName("EDV1");
            this.Property(t => t.NPARM_RESERVE).HasColumnName("NPARM_RESERVE");
            this.Property(t => t.TXX).HasColumnName("TXX");
            this.Property(t => t.LISTE).HasColumnName("LISTE");
            this.Property(t => t.TXXSHORT).HasColumnName("TXXSHORT");
            this.Property(t => t.SAP_SPRACHE).HasColumnName("SAP_SPRACHE");
        }
    }
}
