using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace RestfulApi.Model.Models.Mapping
{
    public class VS_HIER1Map : EntityTypeConfiguration<VS_HIER1>
    {
        public VS_HIER1Map()
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

            this.Property(t => t.MANDANT)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(3);

            this.Property(t => t.TXX)
                .IsRequired()
                .HasMaxLength(32);

            this.Property(t => t.BKUNDE)
                .HasMaxLength(35);

            this.Property(t => t.BKUNDEN_BESTNR)
                .HasMaxLength(35);

            this.Property(t => t.MARKIERUNGBEZ)
                .HasMaxLength(40);

            this.Property(t => t.SAP_LANDBuero)
                .HasMaxLength(3);

            this.Property(t => t.SAP_LANDWempf)
                .HasMaxLength(3);

            this.Property(t => t.SAP_LANDWempf2)
                .HasMaxLength(3);

            this.Property(t => t.SAP_LANDRempf)
                .HasMaxLength(3);

            this.Property(t => t.SAP_SPRACHEBAdresse)
                .HasMaxLength(1);

            this.Property(t => t.SAP_SPRACHEWempf)
                .HasMaxLength(1);

            this.Property(t => t.SAP_SPRACHEWempf2)
                .HasMaxLength(1);

            this.Property(t => t.SAP_SPRACHERempf)
                .HasMaxLength(1);

            this.Property(t => t.STATION_1)
                .HasMaxLength(60);

            this.Property(t => t.STATION_2)
                .HasMaxLength(60);

            this.Property(t => t.STATION_3)
                .HasMaxLength(60);

            this.Property(t => t.SAP_LANDStat1)
                .HasMaxLength(3);

            this.Property(t => t.SAP_LANDStat2)
                .HasMaxLength(3);

            this.Property(t => t.SAP_LANDStat3)
                .HasMaxLength(3);

            this.Property(t => t.SAP_SPRACHEStat1)
                .HasMaxLength(1);

            this.Property(t => t.SAP_SPRACHEStat2)
                .HasMaxLength(1);

            this.Property(t => t.SAP_SPRACHEStat3)
                .HasMaxLength(1);

            this.Property(t => t.VPOS1)
                .HasMaxLength(10);

            this.Property(t => t.VPOS2)
                .HasMaxLength(10);

            this.Property(t => t.VPOS3)
                .HasMaxLength(10);

            this.Property(t => t.PROJ_TXX)
                .HasMaxLength(50);

            this.Property(t => t.HAUPTMATERIAL)
                .HasMaxLength(50);

            this.Property(t => t.PACKLISTENFILENAME)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Proj_TxX2)
                .HasMaxLength(10);

            this.Property(t => t.TX_VERANTWORTLICH)
                .HasMaxLength(250);

            this.Property(t => t.TX_VERTRIEBSBEREICH)
                .HasMaxLength(12);

            this.Property(t => t.LISTE)
                .HasMaxLength(250);

            this.Property(t => t.FREI01_BEZ)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FREI02_BEZ)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FREI03_BEZ)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FREI04_BEZ)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FREI05_BEZ)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FREI06_BEZ)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FREI07_BEZ)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FREI08_BEZ)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FREI09_BEZ)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.FREI10_BEZ)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LISTE_UNITS)
                .IsRequired()
                .HasMaxLength(26);

            this.Property(t => t.FILENAME_LOSTEILETI)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VS_HIER1");
            this.Property(t => t.ZAEHLER).HasColumnName("ZAEHLER");
            this.Property(t => t.z_akunde).HasColumnName("z_akunde");
            this.Property(t => t.DAT_LASTMOD).HasColumnName("DAT_LASTMOD");
            this.Property(t => t.LISTE_KZ).HasColumnName("LISTE_KZ");
            this.Property(t => t.EDV1).HasColumnName("EDV1");
            this.Property(t => t.NPARM_RESERVE).HasColumnName("NPARM_RESERVE");
            this.Property(t => t.W_STATUS).HasColumnName("W_STATUS");
            this.Property(t => t.LOG_STATUS).HasColumnName("LOG_STATUS");
            this.Property(t => t.DAT_STATUS).HasColumnName("DAT_STATUS");
            this.Property(t => t.MANDANT).HasColumnName("MANDANT");
            this.Property(t => t.TXX).HasColumnName("TXX");
            this.Property(t => t.BKUNDE).HasColumnName("BKUNDE");
            this.Property(t => t.BKUNDEN_BESTNR).HasColumnName("BKUNDEN_BESTNR");
            this.Property(t => t.MARKIERUNGBEZ).HasColumnName("MARKIERUNGBEZ");
            this.Property(t => t.MGROESSE).HasColumnName("MGROESSE");
            this.Property(t => t.SAP_LANDBuero).HasColumnName("SAP_LANDBuero");
            this.Property(t => t.SAP_LANDWempf).HasColumnName("SAP_LANDWempf");
            this.Property(t => t.SAP_LANDWempf2).HasColumnName("SAP_LANDWempf2");
            this.Property(t => t.SAP_LANDRempf).HasColumnName("SAP_LANDRempf");
            this.Property(t => t.SAP_SPRACHEBAdresse).HasColumnName("SAP_SPRACHEBAdresse");
            this.Property(t => t.SAP_SPRACHEWempf).HasColumnName("SAP_SPRACHEWempf");
            this.Property(t => t.SAP_SPRACHEWempf2).HasColumnName("SAP_SPRACHEWempf2");
            this.Property(t => t.SAP_SPRACHERempf).HasColumnName("SAP_SPRACHERempf");
            this.Property(t => t.BUEROADRESSE).HasColumnName("BUEROADRESSE");
            this.Property(t => t.Wempf).HasColumnName("Wempf");
            this.Property(t => t.WEMPF2).HasColumnName("WEMPF2");
            this.Property(t => t.Rempf).HasColumnName("Rempf");
            this.Property(t => t.MARKIERUNG).HasColumnName("MARKIERUNG");
            this.Property(t => t.LIZENZ).HasColumnName("LIZENZ");
            this.Property(t => t.Akkreditiv).HasColumnName("Akkreditiv");
            this.Property(t => t.WARENBESCHREIBUNG).HasColumnName("WARENBESCHREIBUNG");
            this.Property(t => t.SONSTIGES).HasColumnName("SONSTIGES");
            this.Property(t => t.INTERNINFO).HasColumnName("INTERNINFO");
            this.Property(t => t.MARKIERUNGBOX).HasColumnName("MARKIERUNGBOX");
            this.Property(t => t.Verpackungsvorschrift).HasColumnName("Verpackungsvorschrift");
            this.Property(t => t.Versandvorschrift).HasColumnName("Versandvorschrift");
            this.Property(t => t.ANZAHL_CONTAINER).HasColumnName("ANZAHL_CONTAINER");
            this.Property(t => t.STATION_1).HasColumnName("STATION_1");
            this.Property(t => t.STATION_2).HasColumnName("STATION_2");
            this.Property(t => t.STATION_3).HasColumnName("STATION_3");
            this.Property(t => t.SAP_LANDStat1).HasColumnName("SAP_LANDStat1");
            this.Property(t => t.SAP_LANDStat2).HasColumnName("SAP_LANDStat2");
            this.Property(t => t.SAP_LANDStat3).HasColumnName("SAP_LANDStat3");
            this.Property(t => t.SAP_SPRACHEStat1).HasColumnName("SAP_SPRACHEStat1");
            this.Property(t => t.SAP_SPRACHEStat2).HasColumnName("SAP_SPRACHEStat2");
            this.Property(t => t.SAP_SPRACHEStat3).HasColumnName("SAP_SPRACHEStat3");
            this.Property(t => t.VPOS1).HasColumnName("VPOS1");
            this.Property(t => t.VPOS2).HasColumnName("VPOS2");
            this.Property(t => t.VPOS3).HasColumnName("VPOS3");
            this.Property(t => t.PROJ_TXX).HasColumnName("PROJ_TXX");
            this.Property(t => t.HAUPTMATERIAL).HasColumnName("HAUPTMATERIAL");
            this.Property(t => t.PACKLISTENTEXT).HasColumnName("PACKLISTENTEXT");
            this.Property(t => t.PACKLISTENFILENAME).HasColumnName("PACKLISTENFILENAME");
            this.Property(t => t.Proj_TxX2).HasColumnName("Proj_TxX2");
            this.Property(t => t.DAT_LIEFER_PLAN).HasColumnName("DAT_LIEFER_PLAN");
            this.Property(t => t.TX_VERANTWORTLICH).HasColumnName("TX_VERANTWORTLICH");
            this.Property(t => t.PRIORITAET).HasColumnName("PRIORITAET");
            this.Property(t => t.TX_VERTRIEBSBEREICH).HasColumnName("TX_VERTRIEBSBEREICH");
            this.Property(t => t.LISTE).HasColumnName("LISTE");
            this.Property(t => t.Z_USER_VERTRIEB).HasColumnName("Z_USER_VERTRIEB");
            this.Property(t => t.FREI01_BEZ).HasColumnName("FREI01_BEZ");
            this.Property(t => t.FREI02_BEZ).HasColumnName("FREI02_BEZ");
            this.Property(t => t.FREI03_BEZ).HasColumnName("FREI03_BEZ");
            this.Property(t => t.FREI04_BEZ).HasColumnName("FREI04_BEZ");
            this.Property(t => t.FREI05_BEZ).HasColumnName("FREI05_BEZ");
            this.Property(t => t.FREI06_BEZ).HasColumnName("FREI06_BEZ");
            this.Property(t => t.FREI07_BEZ).HasColumnName("FREI07_BEZ");
            this.Property(t => t.FREI08_BEZ).HasColumnName("FREI08_BEZ");
            this.Property(t => t.FREI09_BEZ).HasColumnName("FREI09_BEZ");
            this.Property(t => t.FREI10_BEZ).HasColumnName("FREI10_BEZ");
            this.Property(t => t.LISTE_UNITS).HasColumnName("LISTE_UNITS");
            this.Property(t => t.FILENAME_LOSTEILETI).HasColumnName("FILENAME_LOSTEILETI");
        }
    }
}
