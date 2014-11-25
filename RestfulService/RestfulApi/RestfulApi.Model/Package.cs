﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestfulApi.Model
{
	public class Package
	{
		 [ ("Barcode", "DAT_KISTEN.BARCODE")
, ("Package No.", "DAT_KISTEN.KOLLINUMMER")
, ("Status", "N_STATUS.TXX")
, ("Project", "DAT_KISTEN.VS_HIER1")
, ("Location", "DAT_KISTEN.W_STANDORT")
, ("Type of package", "N_ARTEN.TXX")
, ("Content in other language", "DAT_KISTEN.INHALT_TXX")
, ("Content in project language", "DAT_KISTEN.INHALT_TXX2")
, ("Storage Area", "DAT_KISTEN.LAGERORT1+' '+DAT_KISTEN.LAGERORT2+' '+DAT_KISTEN.LAGERORT3")
, ("Date of loading", "DAT_VSBEREIT.DAT_ABHOLUNG")
, ("Storage conditions", "DAT_KISTEN.W_ART_LAGERBEDINGUNG") -- JOIN with DAT_ARTEN
, ("Height", "DAT_KISTEN.ABMESS3_MM")
, ("Width", "DAT_KISTEN.ABMESS2_MM")
, ("Netto", "DAT_KISTEN.NETTO_KG")
, ("Brutto", "DAT_KISTEN.BRUTTO_KG")
, ("Sys/kks", "DAT_KISTEN.VS_HIER2")
, ("Usys/product", "DAT_KISTEN.VS_HIER3")
, ("Supplier", "DAT_LIEFERANTEN.NAME")
, ("Order No.", "DAT_KISTEN.BS_HIER2")
, ("Order Pos.", "DAT_KISTEN.BS_HIER3")
, ("Number of items", "DAT_KISTEN.LT_ANZ")
]
	}
}
