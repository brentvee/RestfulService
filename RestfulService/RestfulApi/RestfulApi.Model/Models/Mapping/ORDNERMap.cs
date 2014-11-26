using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class ORDNERMap : EntityTypeConfiguration<ORDNER>
    {
        public ORDNERMap()
        {
            // Primary Key
            this.HasKey(t => new { t.USERSHORT, t.ORDNERNAME, t.ZAEHLER, t.TABELLE });

            // Properties
            this.Property(t => t.USERSHORT)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ORDNERNAME)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ZAEHLER)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TABELLE)
                .IsRequired()
                .HasMaxLength(32);

            // Table & Column Mappings
            this.ToTable("ORDNER");
            this.Property(t => t.USERSHORT).HasColumnName("USERSHORT");
            this.Property(t => t.ORDNERNAME).HasColumnName("ORDNERNAME");
            this.Property(t => t.ZAEHLER).HasColumnName("ZAEHLER");
            this.Property(t => t.TABELLE).HasColumnName("TABELLE");
        }
    }
}
