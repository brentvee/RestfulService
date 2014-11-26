using System;
using System.Collections.Generic;

namespace RestfulApi.Model.Models
{
    public partial class SAP_SPRACHE
    {
        public string SAP_KEY { get; set; }
        public string TXD { get; set; }
        public Nullable<System.DateTime> DAT_LASTMOD { get; set; }
        public string LISTE_KZ { get; set; }
        public string EDV1 { get; set; }
        public string NPARM_RESERVE { get; set; }
    }
}
