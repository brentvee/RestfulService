using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class LOG_VS_HIER1Map : EntityTypeConfiguration<LOG_VS_HIER1>
    {
        public LOG_VS_HIER1Map()
        {
            // Primary Key
            this.HasKey(t => t.ZAEHLER);

            // Properties
            this.Property(t => t.ZAEHLER)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.k_KENNZEICHEN)
                .HasMaxLength(3);

            this.Property(t => t.ZUSATZ)
                .HasMaxLength(200);

            this.Property(t => t.AKTEURNAME)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("LOG_VS_HIER1");
            this.Property(t => t.ZAEHLER).HasColumnName("ZAEHLER");
            this.Property(t => t.Z_VS_HIER1).HasColumnName("Z_VS_HIER1");
            this.Property(t => t.DAT_LASTMOD).HasColumnName("DAT_LASTMOD");
            this.Property(t => t.W_STATUS).HasColumnName("W_STATUS");
            this.Property(t => t.k_KENNZEICHEN).HasColumnName("k_KENNZEICHEN");
            this.Property(t => t.W_ORTE).HasColumnName("W_ORTE");
            this.Property(t => t.W_TEXTE).HasColumnName("W_TEXTE");
            this.Property(t => t.ZUSATZ).HasColumnName("ZUSATZ");
            this.Property(t => t.AKTEURNAME).HasColumnName("AKTEURNAME");
        }
    }
}
