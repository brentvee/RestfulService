using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class DAT_LIEFERANTENMap : EntityTypeConfiguration<DAT_LIEFERANTEN>
    {
        public DAT_LIEFERANTENMap()
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

            this.Property(t => t.SCHLUESSEL)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.NAME)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.NAME2)
                .HasMaxLength(35);

            this.Property(t => t.NAME3)
                .HasMaxLength(35);

            this.Property(t => t.NAME4)
                .HasMaxLength(35);

            this.Property(t => t.STRASSE)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.POSTFACH)
                .HasMaxLength(35);

            this.Property(t => t.PLZ)
                .HasMaxLength(9);

            this.Property(t => t.ORT)
                .IsRequired()
                .HasMaxLength(35);

            this.Property(t => t.PROVINZ)
                .HasMaxLength(50);

            this.Property(t => t.SAP_LAND)
                .HasMaxLength(3);

            this.Property(t => t.ANSPRECH)
                .HasMaxLength(50);

            this.Property(t => t.TELEFON1)
                .HasMaxLength(50);

            this.Property(t => t.TELEFON2)
                .HasMaxLength(50);

            this.Property(t => t.FAX)
                .HasMaxLength(50);

            this.Property(t => t.EMAIL)
                .HasMaxLength(50);

            this.Property(t => t.BEMERKUNG)
                .HasMaxLength(50);

            this.Property(t => t.SAP_SPRACHE)
                .HasMaxLength(1);

            this.Property(t => t.SAP_SPRACHE2)
                .HasMaxLength(1);

            this.Property(t => t.NEUTRAL05)
                .HasMaxLength(3);

            this.Property(t => t.NEUTRAL10)
                .HasMaxLength(10);

            this.Property(t => t.NEUTRAL20)
                .HasMaxLength(20);

            this.Property(t => t.NEUTRAL30)
                .HasMaxLength(30);

            this.Property(t => t.STEUERNUMMER)
                .HasMaxLength(15);

            this.Property(t => t.INETPASSWORT)
                .HasMaxLength(16);

            this.Property(t => t.INETPASSWORT2)
                .HasMaxLength(16);

            this.Property(t => t.PKEY_AKUNDE)
                .HasMaxLength(250);

            this.Property(t => t.ISO_WAEHRUNGWERT)
                .HasMaxLength(3);

            this.Property(t => t.LADEZEITEN)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("DAT_LIEFERANTEN");
            this.Property(t => t.ZAEHLER).HasColumnName("ZAEHLER");
            this.Property(t => t.Z_AKUNDE).HasColumnName("Z_AKUNDE");
            this.Property(t => t.DAT_LASTMOD).HasColumnName("DAT_LASTMOD");
            this.Property(t => t.LISTE_KZ).HasColumnName("LISTE_KZ");
            this.Property(t => t.EDV1).HasColumnName("EDV1");
            this.Property(t => t.NPARM_RESERVE).HasColumnName("NPARM_RESERVE");
            this.Property(t => t.W_STATUS).HasColumnName("W_STATUS");
            this.Property(t => t.LOG_Status).HasColumnName("LOG_Status");
            this.Property(t => t.DAT_STATUS).HasColumnName("DAT_STATUS");
            this.Property(t => t.Z_LFT).HasColumnName("Z_LFT");
            this.Property(t => t.W_ART).HasColumnName("W_ART");
            this.Property(t => t.SCHLUESSEL).HasColumnName("SCHLUESSEL");
            this.Property(t => t.NAME).HasColumnName("NAME");
            this.Property(t => t.NAME2).HasColumnName("NAME2");
            this.Property(t => t.NAME3).HasColumnName("NAME3");
            this.Property(t => t.NAME4).HasColumnName("NAME4");
            this.Property(t => t.STRASSE).HasColumnName("STRASSE");
            this.Property(t => t.POSTFACH).HasColumnName("POSTFACH");
            this.Property(t => t.PLZ).HasColumnName("PLZ");
            this.Property(t => t.ORT).HasColumnName("ORT");
            this.Property(t => t.PROVINZ).HasColumnName("PROVINZ");
            this.Property(t => t.SAP_LAND).HasColumnName("SAP_LAND");
            this.Property(t => t.ANSPRECH).HasColumnName("ANSPRECH");
            this.Property(t => t.TELEFON1).HasColumnName("TELEFON1");
            this.Property(t => t.TELEFON2).HasColumnName("TELEFON2");
            this.Property(t => t.FAX).HasColumnName("FAX");
            this.Property(t => t.EMAIL).HasColumnName("EMAIL");
            this.Property(t => t.BEMERKUNG).HasColumnName("BEMERKUNG");
            this.Property(t => t.SAP_SPRACHE).HasColumnName("SAP_SPRACHE");
            this.Property(t => t.SAP_SPRACHE2).HasColumnName("SAP_SPRACHE2");
            this.Property(t => t.NEUTRAL05).HasColumnName("NEUTRAL05");
            this.Property(t => t.NEUTRAL10).HasColumnName("NEUTRAL10");
            this.Property(t => t.NEUTRAL20).HasColumnName("NEUTRAL20");
            this.Property(t => t.NEUTRAL30).HasColumnName("NEUTRAL30");
            this.Property(t => t.STEUERNUMMER).HasColumnName("STEUERNUMMER");
            this.Property(t => t.INETPASSWORT).HasColumnName("INETPASSWORT");
            this.Property(t => t.INETPASSWORT2).HasColumnName("INETPASSWORT2");
            this.Property(t => t.PKEY_AKUNDE).HasColumnName("PKEY_AKUNDE");
            this.Property(t => t.PROZ_WERT).HasColumnName("PROZ_WERT");
            this.Property(t => t.WERT).HasColumnName("WERT");
            this.Property(t => t.ISO_WAEHRUNGWERT).HasColumnName("ISO_WAEHRUNGWERT");
            this.Property(t => t.LADEZEITEN).HasColumnName("LADEZEITEN");
            this.Property(t => t.Z_USER_EXPEDITING).HasColumnName("Z_USER_EXPEDITING");
        }
    }
}
