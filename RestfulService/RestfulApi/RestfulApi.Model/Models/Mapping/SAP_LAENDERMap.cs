using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class SAP_LAENDERMap : EntityTypeConfiguration<SAP_LAENDER>
    {
        public SAP_LAENDERMap()
        {
            // Primary Key
            this.HasKey(t => t.ZAEHLER);

            // Properties
            this.Property(t => t.ZAEHLER)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LISTE_KZ)
                .HasMaxLength(80);

            this.Property(t => t.EDV1)
                .HasMaxLength(50);

            this.Property(t => t.NPARM_RESERVE)
                .HasMaxLength(20);

            this.Property(t => t.SAP_KEY)
                .HasMaxLength(3);

            this.Property(t => t.TxD)
                .HasMaxLength(50);

            this.Property(t => t.TxE)
                .HasMaxLength(50);

            this.Property(t => t.TxX)
                .HasMaxLength(50);

            this.Property(t => t.LISTE)
                .HasMaxLength(250);

            this.Property(t => t.SPRACHE)
                .HasMaxLength(1);

            this.Property(t => t.AUSWEICHSPRACHE)
                .HasMaxLength(1);

            this.Property(t => t.TxDshort)
                .HasMaxLength(20);

            this.Property(t => t.TxEshort)
                .HasMaxLength(20);

            this.Property(t => t.TxXshort)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("SAP_LAENDER");
            this.Property(t => t.ZAEHLER).HasColumnName("ZAEHLER");
            this.Property(t => t.WERT).HasColumnName("WERT");
            this.Property(t => t.DAT_LASTMOD).HasColumnName("DAT_LASTMOD");
            this.Property(t => t.LISTE_KZ).HasColumnName("LISTE_KZ");
            this.Property(t => t.EDV1).HasColumnName("EDV1");
            this.Property(t => t.NPARM_RESERVE).HasColumnName("NPARM_RESERVE");
            this.Property(t => t.SAP_KEY).HasColumnName("SAP_KEY");
            this.Property(t => t.TxD).HasColumnName("TxD");
            this.Property(t => t.TxE).HasColumnName("TxE");
            this.Property(t => t.TxX).HasColumnName("TxX");
            this.Property(t => t.LISTE).HasColumnName("LISTE");
            this.Property(t => t.SPRACHE).HasColumnName("SPRACHE");
            this.Property(t => t.AUSWEICHSPRACHE).HasColumnName("AUSWEICHSPRACHE");
            this.Property(t => t.TxDshort).HasColumnName("TxDshort");
            this.Property(t => t.TxEshort).HasColumnName("TxEshort");
            this.Property(t => t.TxXshort).HasColumnName("TxXshort");
            this.Property(t => t.ISO_KEY).HasColumnName("ISO_KEY");
        }
    }
}
