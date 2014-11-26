/*
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulApi.Model
{
	public class Item
	{
		
		public string Project { get; set; }
		public string Barcode { get; set; }
		public char Unit { get; set; }
		[Description("Sys/KKS")]
		public string SysKks { get; set; }
		[Description("Usys/Product")]
		public string UsysProduct { get; set; }
		[Description("Drawing No")]
		public string DrawingNo { get; set; }
		[Description("Drawing Pos")]
		public string DrawingPos { get; set; }
		[Description("KKS No")]
		public string KksNo { get; set; }

		public string Description { get; set; }
		[Description("Description Foreign")]
		public string DescriptionForeign { get; set; }

		public double Quantity { get; set; }
		public double QuantityIssued { get; set; }
		public double QuantityOnStock { get; set; }
		public DateTime StatusSince { get; set; }
		public int PackageNo { get; set; }
		public Int16 Location { get; set; }
		public double Weight { get; set; }
		public string RemarksIncomingGoods { get; set; }
		public string Definable10Value { get; set; }
		public string Definable5Value;

		public Supplier Supplier { get; set; }

		public string LAGERORT1 { get; set; }
		public string LAGERORT2 { get; set; }
		public string LAGERORT3 { get; set; }

		public string StorageArea
		{
			get { return string.Format("{0} {1} {2}", LAGERORT1, LAGERORT2, LAGERORT3); }
		}
	}


}
*/
