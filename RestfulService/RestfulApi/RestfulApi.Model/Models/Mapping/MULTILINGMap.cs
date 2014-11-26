using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class MULTILINGMap : EntityTypeConfiguration<MULTILING>
    {
        public MULTILINGMap()
        {
            // Primary Key
            this.HasKey(t => t.ZAEHLER);

            // Properties
            this.Property(t => t.ZAEHLER)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TXT)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.SAP_SPRACHE)
                .IsRequired()
                .HasMaxLength(3);

            // Table & Column Mappings
            this.ToTable("MULTILING");
            this.Property(t => t.ZAEHLER).HasColumnName("ZAEHLER");
            this.Property(t => t.NEW).HasColumnName("NEW");
            this.Property(t => t.WERT).HasColumnName("WERT");
            this.Property(t => t.TXT).HasColumnName("TXT");
            this.Property(t => t.SAP_SPRACHE).HasColumnName("SAP_SPRACHE");
            this.Property(t => t.DAT_LASTMOD).HasColumnName("DAT_LASTMOD");
        }
    }
}
