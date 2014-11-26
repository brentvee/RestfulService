using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class DAT_DUMMYVSBLTMap : EntityTypeConfiguration<DAT_DUMMYVSBLT>
    {
        public DAT_DUMMYVSBLTMap()
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

            this.Property(t => t.AKTEURNAME)
                .IsRequired()
                .HasMaxLength(16);

            // Table & Column Mappings
            this.ToTable("DAT_DUMMYVSBLT");
            this.Property(t => t.ZAEHLER).HasColumnName("ZAEHLER");
            this.Property(t => t.Z_AKUNDE).HasColumnName("Z_AKUNDE");
            this.Property(t => t.DAT_LASTMOD).HasColumnName("DAT_LASTMOD");
            this.Property(t => t.LISTE_KZ).HasColumnName("LISTE_KZ");
            this.Property(t => t.EDV1).HasColumnName("EDV1");
            this.Property(t => t.NPARM_RESERVE).HasColumnName("NPARM_RESERVE");
            this.Property(t => t.W_STATUS).HasColumnName("W_STATUS");
            this.Property(t => t.W_ART).HasColumnName("W_ART");
            this.Property(t => t.Z_BPOS).HasColumnName("Z_BPOS");
            this.Property(t => t.AKTEURNAME).HasColumnName("AKTEURNAME");
            this.Property(t => t.DAT_XX).HasColumnName("DAT_XX");
            this.Property(t => t.XX_MENGE).HasColumnName("XX_MENGE");
            this.Property(t => t.W_XX_MENGENEINHEIT).HasColumnName("W_XX_MENGENEINHEIT");
        }
    }
}
