using System.Data.Entity;
using RestfulApi.Model.Models;
using RestfulApi.Model.Models.Mapping;

namespace RestfulApi.Model
{
	public class RestfulDbContext : DbContext
	{
		static RestfulDbContext()
        {
            Database.SetInitializer<RestfulDbContext>(null);
        }

		public RestfulDbContext()
			: base("Name=RestfulDbContext")
        {
        }

        public DbSet<DAT_BESTELLUNGEN> DAT_BESTELLUNGEN { get; set; }
        public DbSet<DAT_BPOS> DAT_BPOS { get; set; }
        public DbSet<DAT_DUMMYVSBLT> DAT_DUMMYVSBLT { get; set; }
        public DbSet<DAT_KISTEN> DAT_KISTEN { get; set; }
        public DbSet<DAT_LIEFERANTEN> DAT_LIEFERANTEN { get; set; }
        public DbSet<DAT_LOSTEILE> DAT_LOSTEILE { get; set; }
        public DbSet<DAT_MATERIALSTAMM> DAT_MATERIALSTAMM { get; set; }
        public DbSet<DAT_TBEHAELTER> DAT_TBEHAELTER { get; set; }
        public DbSet<DAT_VSBEREIT> DAT_VSBEREIT { get; set; }
        public DbSet<dtproperty> dtproperties { get; set; }
        public DbSet<INCOTERMS2000> INCOTERMS2000 { get; set; }
        public DbSet<INIT_REPORT> INIT_REPORT { get; set; }
        public DbSet<ISO_WAEHRUNGEN> ISO_WAEHRUNGEN { get; set; }
        public DbSet<KUNDE_A> KUNDE_A { get; set; }
        public DbSet<LOG_BESTELLUNGEN> LOG_BESTELLUNGEN { get; set; }
        public DbSet<LOG_BPOS> LOG_BPOS { get; set; }
        public DbSet<LOG_ERRORS> LOG_ERRORS { get; set; }
        public DbSet<LOG_KISTEN> LOG_KISTEN { get; set; }
        public DbSet<LOG_LIEFERANTEN> LOG_LIEFERANTEN { get; set; }
        public DbSet<LOG_LOSTEILE> LOG_LOSTEILE { get; set; }
        public DbSet<LOG_MATERIALSTAMM> LOG_MATERIALSTAMM { get; set; }
        public DbSet<LOG_VS_HIER1> LOG_VS_HIER1 { get; set; }
        public DbSet<LOG_VSBEREIT> LOG_VSBEREIT { get; set; }
        public DbSet<MULTILING> MULTILINGs { get; set; }
        public DbSet<N_ARBEITSGANG> N_ARBEITSGANG { get; set; }
        public DbSet<N_ARTEN> N_ARTEN { get; set; }
        public DbSet<N_AUSWAHLFELDER> N_AUSWAHLFELDER { get; set; }
        public DbSet<N_KENNZEICHEN> N_KENNZEICHEN { get; set; }
        public DbSet<N_ORTE> N_ORTE { get; set; }
        public DbSet<N_STATUS> N_STATUS { get; set; }
        public DbSet<ORDNER> ORDNERs { get; set; }
        public DbSet<SAP_LAENDER> SAP_LAENDER { get; set; }
        public DbSet<SAP_MENGENEINHEITEN> SAP_MENGENEINHEITEN { get; set; }
        public DbSet<SAP_SPRACHE> SAP_SPRACHE { get; set; }
        public DbSet<STAT_WAREN_NR> STAT_WAREN_NR { get; set; }
        public DbSet<VS_HIER1> VS_HIER1 { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new DAT_BESTELLUNGENMap());
            modelBuilder.Configurations.Add(new DAT_BPOSMap());
            modelBuilder.Configurations.Add(new DAT_DUMMYVSBLTMap());
            modelBuilder.Configurations.Add(new DAT_KISTENMap());
            modelBuilder.Configurations.Add(new DAT_LIEFERANTENMap());
            modelBuilder.Configurations.Add(new DAT_LOSTEILEMap());
            modelBuilder.Configurations.Add(new DAT_MATERIALSTAMMMap());
            modelBuilder.Configurations.Add(new DAT_TBEHAELTERMap());
            modelBuilder.Configurations.Add(new DAT_VSBEREITMap());
            modelBuilder.Configurations.Add(new dtpropertyMap());
            modelBuilder.Configurations.Add(new INCOTERMS2000Map());
            modelBuilder.Configurations.Add(new INIT_REPORTMap());
            modelBuilder.Configurations.Add(new ISO_WAEHRUNGENMap());
            modelBuilder.Configurations.Add(new KUNDE_AMap());
            modelBuilder.Configurations.Add(new LOG_BESTELLUNGENMap());
            modelBuilder.Configurations.Add(new LOG_BPOSMap());
            modelBuilder.Configurations.Add(new LOG_ERRORSMap());
            modelBuilder.Configurations.Add(new LOG_KISTENMap());
            modelBuilder.Configurations.Add(new LOG_LIEFERANTENMap());
            modelBuilder.Configurations.Add(new LOG_LOSTEILEMap());
            modelBuilder.Configurations.Add(new LOG_MATERIALSTAMMMap());
            modelBuilder.Configurations.Add(new LOG_VS_HIER1Map());
            modelBuilder.Configurations.Add(new LOG_VSBEREITMap());
            modelBuilder.Configurations.Add(new MULTILINGMap());
            modelBuilder.Configurations.Add(new N_ARBEITSGANGMap());
            modelBuilder.Configurations.Add(new N_ARTENMap());
            modelBuilder.Configurations.Add(new N_AUSWAHLFELDERMap());
            modelBuilder.Configurations.Add(new N_KENNZEICHENMap());
            modelBuilder.Configurations.Add(new N_ORTEMap());
            modelBuilder.Configurations.Add(new N_STATUSMap());
            modelBuilder.Configurations.Add(new ORDNERMap());
            modelBuilder.Configurations.Add(new SAP_LAENDERMap());
            modelBuilder.Configurations.Add(new SAP_MENGENEINHEITENMap());
            modelBuilder.Configurations.Add(new SAP_SPRACHEMap());
            modelBuilder.Configurations.Add(new STAT_WAREN_NRMap());
            modelBuilder.Configurations.Add(new VS_HIER1Map());
        }
	}
}
