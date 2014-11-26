using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class SAP_SPRACHEMap : EntityTypeConfiguration<SAP_SPRACHE>
    {
        public SAP_SPRACHEMap()
        {
            // Primary Key
            this.HasKey(t => t.SAP_KEY);

            // Properties
            this.Property(t => t.SAP_KEY)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.TXD)
                .HasMaxLength(20);

            this.Property(t => t.LISTE_KZ)
                .HasMaxLength(80);

            this.Property(t => t.EDV1)
                .HasMaxLength(50);

            this.Property(t => t.NPARM_RESERVE)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("SAP_SPRACHE");
            this.Property(t => t.SAP_KEY).HasColumnName("SAP_KEY");
            this.Property(t => t.TXD).HasColumnName("TXD");
            this.Property(t => t.DAT_LASTMOD).HasColumnName("DAT_LASTMOD");
            this.Property(t => t.LISTE_KZ).HasColumnName("LISTE_KZ");
            this.Property(t => t.EDV1).HasColumnName("EDV1");
            this.Property(t => t.NPARM_RESERVE).HasColumnName("NPARM_RESERVE");
        }
    }
}
