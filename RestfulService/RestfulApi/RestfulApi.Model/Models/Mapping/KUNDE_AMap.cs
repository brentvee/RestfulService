using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class KUNDE_AMap : EntityTypeConfiguration<KUNDE_A>
    {
        public KUNDE_AMap()
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

            this.Property(t => t.SAP_SPRACHE)
                .HasMaxLength(1);

            this.Property(t => t.TXX)
                .HasMaxLength(30);

            this.Property(t => t.SAP_LAND)
                .HasMaxLength(3);

            this.Property(t => t.KISTENBARCODES)
                .HasMaxLength(250);

            this.Property(t => t.LOSTEILBARCODES)
                .HasMaxLength(250);

            this.Property(t => t.FREIKZ1_TXX)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FREIKZ2_TXX)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VSB_EMAIL)
                .IsRequired()
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("KUNDE_A");
            this.Property(t => t.ZAEHLER).HasColumnName("ZAEHLER");
            this.Property(t => t.DAT_LASTMOD).HasColumnName("DAT_LASTMOD");
            this.Property(t => t.LISTE_KZ).HasColumnName("LISTE_KZ");
            this.Property(t => t.EDV1).HasColumnName("EDV1");
            this.Property(t => t.NPARM_RESERVE).HasColumnName("NPARM_RESERVE");
            this.Property(t => t.WERT).HasColumnName("WERT");
            this.Property(t => t.SAP_SPRACHE).HasColumnName("SAP_SPRACHE");
            this.Property(t => t.LOGO).HasColumnName("LOGO");
            this.Property(t => t.TXX).HasColumnName("TXX");
            this.Property(t => t.SAP_LAND).HasColumnName("SAP_LAND");
            this.Property(t => t.ADRESSE1).HasColumnName("ADRESSE1");
            this.Property(t => t.ADRESSE2).HasColumnName("ADRESSE2");
            this.Property(t => t.ADRESSE3).HasColumnName("ADRESSE3");
            this.Property(t => t.FUSS1).HasColumnName("FUSS1");
            this.Property(t => t.FUSS2).HasColumnName("FUSS2");
            this.Property(t => t.FUSS3).HasColumnName("FUSS3");
            this.Property(t => t.FUSS4).HasColumnName("FUSS4");
            this.Property(t => t.FUSS5).HasColumnName("FUSS5");
            this.Property(t => t.KISTENBARCODES).HasColumnName("KISTENBARCODES");
            this.Property(t => t.LOSTEILBARCODES).HasColumnName("LOSTEILBARCODES");
            this.Property(t => t.FREIKZ1_TXX).HasColumnName("FREIKZ1_TXX");
            this.Property(t => t.FREIKZ2_TXX).HasColumnName("FREIKZ2_TXX");
            this.Property(t => t.Z_MANDANT).HasColumnName("Z_MANDANT");
            this.Property(t => t.VSB_EMAIL).HasColumnName("VSB_EMAIL");
        }
    }
}
