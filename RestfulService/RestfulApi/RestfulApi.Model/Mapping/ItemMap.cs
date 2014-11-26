/*
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulApi.Model.Mapping
{
	class ItemMap : EntityTypeConfiguration<Item>
	{
		public ItemMap()
		{
			this.ToTable("DAT_LOSTEILE");

			Property(o => o.Project).HasColumnName("VS_HIER1").HasMaxLength(32);
			Property(o => o.Barcode).HasColumnName("BARCODE").HasMaxLength(13);
			Property(o => o.Unit).HasColumnName("UNIT");
			Property(o => o.SysKks).HasColumnName("VS_HIER2").HasMaxLength(3);
			Property(o => o.UsysProduct).HasColumnName("DAT_LOSTEILE.VS_HIER3").HasMaxLength(4);
			Property(o => o.DrawingNo).HasColumnName("ZEICHNUNGS_NR").HasMaxLength(31);
			Property(o => o.DrawingPos).HasColumnName("ZEICHNUNGS_POS").HasMaxLength(30);
			Property(o => o.KksNo).HasColumnName("KKS_NR").HasMaxLength(50);
			Property(o => o.Description).HasColumnName("LT_TXX1").HasMaxLength(50);
			Property(o => o.DescriptionForeign).HasColumnName("LT_TXX2").HasMaxLength(50);
			Property(o => o.Quantity).HasColumnName("LT_MENGE");
			Property(o => o.QuantityIssued).HasColumnName("LT_GESMENGE");
			Property(o => o.QuantityOnStock).HasColumnName("LT_MENGE_BAUSTELLE");
			Property(o => o.Status).HasColumnName("N_STATUS.TXX");
			Property(o => o.StatusSince).HasColumnName("DAT_STATUS");
//Property(o => o.Supplier name).HasColumnName("DAT_LIEFERANTEN.NAME");
			Property(o => o.PackageNo).HasColumnName("Z_KISTEN");
			Property(o => o.Location).HasColumnName("W_STANDORT");
/*Property(o => o.Storage area).
			HasColumnName("DAT_LOSTEILE.LAGERORT1+' '+DAT_LOSTEILE.LAGERORT2+' '+DAT_LOSTEILE.LAGERORT3");#1#
Property(o => o.Storage area (box)).
			HasColumnName("DAT_KISTEN.LAGERORT1+' '+DAT_KISTEN.LAGERORT2+' '+DAT_KISTEN.LAGERORT3");
			Property(o => o.Weight).HasColumnName("NETTO_KG");
			Property(o => o.Dimensions)
				.HasColumnName(
					"DAT_LOSTEILE.ABMESS1_MM+' X '+DAT_LOSTEILE.ABMESS2_MM+' X '+DAT_LOSTEILE.ABMESS3_MM+' X '+DAT_LOSTEILE.ABMESS4_MM+DAT_LOSTEILE.ABMESS5_MM+DAT_LOSTEILE.ABMESS6_MM");
			Property(o => o.RemarksIncomingGoods).HasColumnName("DAT_LOSTEILE.BEMERKUNG_WE").HasMaxLength(250);
			Property(o => o.Definable5Value).HasColumnName("DAT_LOSTEILE.FREI05_TXX").HasMaxLength(50);
			Property(o => o.Definable10Value).HasColumnName("DAT_LOSTEILE.FREI10_TXX").HasMaxLength(50);

		}
	}
}
*/
