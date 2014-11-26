using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class INIT_REPORTMap : EntityTypeConfiguration<INIT_REPORT>
    {
        public INIT_REPORTMap()
        {
            // Primary Key
            this.HasKey(t => t.ZAEHLER);

            // Properties
            this.Property(t => t.ZAEHLER)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LISTE_KZ)
                .HasMaxLength(80);

            this.Property(t => t.NPARM_RESERVE)
                .HasMaxLength(20);

            this.Property(t => t.EDV1)
                .HasMaxLength(50);

            this.Property(t => t.APPID)
                .HasMaxLength(16);

            this.Property(t => t.SAP_SPRACHE)
                .HasMaxLength(1);

            this.Property(t => t.REPORTFILENAME)
                .HasMaxLength(100);

            this.Property(t => t.MENUTITEL)
                .HasMaxLength(50);

            this.Property(t => t.MENUTEXT)
                .HasMaxLength(50);

            this.Property(t => t.R_TXX)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("INIT_REPORT");
            this.Property(t => t.ZAEHLER).HasColumnName("ZAEHLER");
            this.Property(t => t.DAT_LASTMOD).HasColumnName("DAT_LASTMOD");
            this.Property(t => t.LISTE_KZ).HasColumnName("LISTE_KZ");
            this.Property(t => t.Z_AKUNDE).HasColumnName("Z_AKUNDE");
            this.Property(t => t.NPARM_RESERVE).HasColumnName("NPARM_RESERVE");
            this.Property(t => t.EDV1).HasColumnName("EDV1");
            this.Property(t => t.APPID).HasColumnName("APPID");
            this.Property(t => t.WERT).HasColumnName("WERT");
            this.Property(t => t.SAP_SPRACHE).HasColumnName("SAP_SPRACHE");
            this.Property(t => t.Z_GRUPPE).HasColumnName("Z_GRUPPE");
            this.Property(t => t.TXT_SELECT).HasColumnName("TXT_SELECT");
            this.Property(t => t.REPORTFILENAME).HasColumnName("REPORTFILENAME");
            this.Property(t => t.MENUTITEL).HasColumnName("MENUTITEL");
            this.Property(t => t.MENUTEXT).HasColumnName("MENUTEXT");
            this.Property(t => t.R_TXX).HasColumnName("R_TXX");
        }
    }
}
