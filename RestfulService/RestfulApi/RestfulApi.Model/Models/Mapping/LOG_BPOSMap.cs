using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class LOG_BPOSMap : EntityTypeConfiguration<LOG_BPOS>
    {
        public LOG_BPOSMap()
        {
            // Primary Key
            this.HasKey(t => t.ZAEHLER);

            // Properties
            this.Property(t => t.ZAEHLER)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AKTEURNAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ZUSATZ)
                .HasMaxLength(200);

            this.Property(t => t.K_KENNZEICHEN)
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("LOG_BPOS");
            this.Property(t => t.ZAEHLER).HasColumnName("ZAEHLER");
            this.Property(t => t.Z_BPOS).HasColumnName("Z_BPOS");
            this.Property(t => t.DAT_LASTMOD).HasColumnName("DAT_LASTMOD");
            this.Property(t => t.AKTEURNAME).HasColumnName("AKTEURNAME");
            this.Property(t => t.ZUSATZ).HasColumnName("ZUSATZ");
            this.Property(t => t.W_TEXTE).HasColumnName("W_TEXTE");
            this.Property(t => t.W_STATUS).HasColumnName("W_STATUS");
            this.Property(t => t.K_KENNZEICHEN).HasColumnName("K_KENNZEICHEN");
            this.Property(t => t.W_ORTE).HasColumnName("W_ORTE");
        }
    }
}
