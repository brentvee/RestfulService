using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class LOG_ERRORSMap : EntityTypeConfiguration<LOG_ERRORS>
    {
        public LOG_ERRORSMap()
        {
            // Primary Key
            this.HasKey(t => t.zaehler);

            // Properties
            this.Property(t => t.zaehler)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BARCODE)
                .HasMaxLength(16);

            this.Property(t => t.AKTEURNAME)
                .HasMaxLength(50);

            this.Property(t => t.ZUSATZ)
                .HasMaxLength(200);

            this.Property(t => t.EDV1)
                .HasMaxLength(50);

            this.Property(t => t.FUNKBASIS)
                .HasMaxLength(1);

            this.Property(t => t.BEMERKUNG_ERLEDIGT)
                .IsRequired()
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("LOG_ERRORS");
            this.Property(t => t.zaehler).HasColumnName("zaehler");
            this.Property(t => t.BARCODE).HasColumnName("BARCODE");
            this.Property(t => t.DAT_ERROR).HasColumnName("DAT_ERROR");
            this.Property(t => t.AKTEURNAME).HasColumnName("AKTEURNAME");
            this.Property(t => t.ZUSATZ).HasColumnName("ZUSATZ");
            this.Property(t => t.W_TEXTE).HasColumnName("W_TEXTE");
            this.Property(t => t.EDV1).HasColumnName("EDV1");
            this.Property(t => t.FUNKBASIS).HasColumnName("FUNKBASIS");
            this.Property(t => t.ERRTYPE).HasColumnName("ERRTYPE");
            this.Property(t => t.SCANNERID).HasColumnName("SCANNERID");
            this.Property(t => t.W_ARBEITSGANG).HasColumnName("W_ARBEITSGANG");
            this.Property(t => t.ERLEDIGT).HasColumnName("ERLEDIGT");
            this.Property(t => t.dat_lastmod).HasColumnName("dat_lastmod");
            this.Property(t => t.Z_USER_ERLEDIGT).HasColumnName("Z_USER_ERLEDIGT");
            this.Property(t => t.BEMERKUNG_ERLEDIGT).HasColumnName("BEMERKUNG_ERLEDIGT");
            this.Property(t => t.DAT_ERLEDIGT).HasColumnName("DAT_ERLEDIGT");
        }
    }
}
