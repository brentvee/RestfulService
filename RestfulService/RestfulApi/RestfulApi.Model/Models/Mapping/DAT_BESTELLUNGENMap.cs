using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class DAT_BESTELLUNGENMap : EntityTypeConfiguration<DAT_BESTELLUNGEN>
    {
        public DAT_BESTELLUNGENMap()
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

            this.Property(t => t.LFT_ANSPRECH)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LFT_TELEFON1)
                .HasMaxLength(50);

            this.Property(t => t.LFT_TELEFON2)
                .HasMaxLength(50);

            this.Property(t => t.LFT_FAX)
                .HasMaxLength(50);

            this.Property(t => t.LFT_EMAIL)
                .HasMaxLength(50);

            this.Property(t => t.LFT_BEMERKUNG)
                .HasMaxLength(50);

            this.Property(t => t.MANDANT)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.VS_HIER1)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.BS_HIER2)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.VS_HIER2)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.NEUTRAL05)
                .HasMaxLength(5);

            this.Property(t => t.NEUTRAL10)
                .HasMaxLength(10);

            this.Property(t => t.NEUTRAL20)
                .HasMaxLength(20);

            this.Property(t => t.NEUTRAL30)
                .HasMaxLength(30);

            this.Property(t => t.KONTO)
                .HasMaxLength(3);

            this.Property(t => t.KOMMISSION)
                .HasMaxLength(20);

            this.Property(t => t.ISO_WAEHRUNGWERT)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.ANSPRECH_AKUNDE)
                .HasMaxLength(50);

            this.Property(t => t.TX_INCOTERM2000)
                .IsRequired()
                .HasMaxLength(3);

            this.Property(t => t.INCO_ZUSATZ)
                .HasMaxLength(28);

            this.Property(t => t.PKEY_AKUNDE)
                .HasMaxLength(50);

            this.Property(t => t.BESTELLNRFREI)
                .HasMaxLength(32);

            this.Property(t => t.EMAIL_AKUNDE)
                .HasMaxLength(250);

            // Table & Column Mappings
            this.ToTable("DAT_BESTELLUNGEN");
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
            this.Property(t => t.LFT_ANSPRECH).HasColumnName("LFT_ANSPRECH");
            this.Property(t => t.LFT_TELEFON1).HasColumnName("LFT_TELEFON1");
            this.Property(t => t.LFT_TELEFON2).HasColumnName("LFT_TELEFON2");
            this.Property(t => t.LFT_FAX).HasColumnName("LFT_FAX");
            this.Property(t => t.LFT_EMAIL).HasColumnName("LFT_EMAIL");
            this.Property(t => t.LFT_BEMERKUNG).HasColumnName("LFT_BEMERKUNG");
            this.Property(t => t.MANDANT).HasColumnName("MANDANT");
            this.Property(t => t.VS_HIER1).HasColumnName("VS_HIER1");
            this.Property(t => t.BS_HIER2).HasColumnName("BS_HIER2");
            this.Property(t => t.VS_HIER2).HasColumnName("VS_HIER2");
            this.Property(t => t.NEUTRAL05).HasColumnName("NEUTRAL05");
            this.Property(t => t.NEUTRAL10).HasColumnName("NEUTRAL10");
            this.Property(t => t.NEUTRAL20).HasColumnName("NEUTRAL20");
            this.Property(t => t.NEUTRAL30).HasColumnName("NEUTRAL30");
            this.Property(t => t.KONTO).HasColumnName("KONTO");
            this.Property(t => t.NPARM_INET_ID).HasColumnName("NPARM_INET_ID");
            this.Property(t => t.NPARM_LT_NR).HasColumnName("NPARM_LT_NR");
            this.Property(t => t.KOMMISSION).HasColumnName("KOMMISSION");
            this.Property(t => t.WERT).HasColumnName("WERT");
            this.Property(t => t.ISO_WAEHRUNGWERT).HasColumnName("ISO_WAEHRUNGWERT");
            this.Property(t => t.ANSPRECH_AKUNDE).HasColumnName("ANSPRECH_AKUNDE");
            this.Property(t => t.TX_INCOTERM2000).HasColumnName("TX_INCOTERM2000");
            this.Property(t => t.INCO_ZUSATZ).HasColumnName("INCO_ZUSATZ");
            this.Property(t => t.W_ART_BESTELLUNG).HasColumnName("W_ART_BESTELLUNG");
            this.Property(t => t.PKEY_AKUNDE).HasColumnName("PKEY_AKUNDE");
            this.Property(t => t.PROZ_WERT).HasColumnName("PROZ_WERT");
            this.Property(t => t.W_TEXTE).HasColumnName("W_TEXTE");
            this.Property(t => t.BESTELLNRFREI).HasColumnName("BESTELLNRFREI");
            this.Property(t => t.EMAIL_AKUNDE).HasColumnName("EMAIL_AKUNDE");
            this.Property(t => t.DAT_BELEG).HasColumnName("DAT_BELEG");
            this.Property(t => t.Z_USER_EK).HasColumnName("Z_USER_EK");
        }
    }
}
