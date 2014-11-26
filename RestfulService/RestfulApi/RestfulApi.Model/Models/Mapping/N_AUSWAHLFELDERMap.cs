using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class N_AUSWAHLFELDERMap : EntityTypeConfiguration<N_AUSWAHLFELDER>
    {
        public N_AUSWAHLFELDERMap()
        {
            // Primary Key
            this.HasKey(t => t.ZAEHLER);

            // Properties
            this.Property(t => t.ZAEHLER)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.APPID)
                .HasMaxLength(16);

            this.Property(t => t.SAP_SPRACHE)
                .HasMaxLength(1);

            this.Property(t => t.LISTE_KZ)
                .HasMaxLength(80);

            this.Property(t => t.EDV1)
                .HasMaxLength(50);

            this.Property(t => t.NPARM_RESERVE)
                .HasMaxLength(20);

            this.Property(t => t.TXX)
                .HasMaxLength(30);

            this.Property(t => t.DBTAB)
                .HasMaxLength(30);

            this.Property(t => t.DBSELECT)
                .HasMaxLength(200);

            this.Property(t => t.VERKNUEPFUNG)
                .HasMaxLength(40);

            this.Property(t => t.V_BESCHREIBUNG)
                .HasMaxLength(200);

            this.Property(t => t.FORMAT)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("N_AUSWAHLFELDER");
            this.Property(t => t.ZAEHLER).HasColumnName("ZAEHLER");
            this.Property(t => t.APPID).HasColumnName("APPID");
            this.Property(t => t.WERT).HasColumnName("WERT");
            this.Property(t => t.SAP_SPRACHE).HasColumnName("SAP_SPRACHE");
            this.Property(t => t.DAT_LASTMOD).HasColumnName("DAT_LASTMOD");
            this.Property(t => t.LISTE_KZ).HasColumnName("LISTE_KZ");
            this.Property(t => t.EDV1).HasColumnName("EDV1");
            this.Property(t => t.NPARM_RESERVE).HasColumnName("NPARM_RESERVE");
            this.Property(t => t.TXX).HasColumnName("TXX");
            this.Property(t => t.DBTAB).HasColumnName("DBTAB");
            this.Property(t => t.DBSELECT).HasColumnName("DBSELECT");
            this.Property(t => t.VERKNUEPFUNG).HasColumnName("VERKNUEPFUNG");
            this.Property(t => t.V_BESCHREIBUNG).HasColumnName("V_BESCHREIBUNG");
            this.Property(t => t.FORMAT).HasColumnName("FORMAT");
            this.Property(t => t.Z_GRUPPE).HasColumnName("Z_GRUPPE");
        }
    }
}
