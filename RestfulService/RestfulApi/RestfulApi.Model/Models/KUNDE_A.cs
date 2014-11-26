using System;
using System.Collections.Generic;

namespace RestfulApi.Model.Models
{
    public partial class KUNDE_A
    {
        public short ZAEHLER { get; set; }
        public Nullable<System.DateTime> DAT_LASTMOD { get; set; }
        public string LISTE_KZ { get; set; }
        public string EDV1 { get; set; }
        public string NPARM_RESERVE { get; set; }
        public Nullable<short> WERT { get; set; }
        public string SAP_SPRACHE { get; set; }
        public byte[] LOGO { get; set; }
        public string TXX { get; set; }
        public string SAP_LAND { get; set; }
        public string ADRESSE1 { get; set; }
        public string ADRESSE2 { get; set; }
        public string ADRESSE3 { get; set; }
        public string FUSS1 { get; set; }
        public string FUSS2 { get; set; }
        public string FUSS3 { get; set; }
        public string FUSS4 { get; set; }
        public string FUSS5 { get; set; }
        public string KISTENBARCODES { get; set; }
        public string LOSTEILBARCODES { get; set; }
        public string FREIKZ1_TXX { get; set; }
        public string FREIKZ2_TXX { get; set; }
        public Nullable<short> Z_MANDANT { get; set; }
        public string VSB_EMAIL { get; set; }
    }
}
