using System;
using System.Collections.Generic;

namespace RestfulApi.Model.Models
{
    public partial class LOG_VSBEREIT
    {
        public int ZAEHLER { get; set; }
        public Nullable<int> Z_VSBEREIT { get; set; }
        public Nullable<System.DateTime> DAT_LASTMOD { get; set; }
        public string AKTEURNAME { get; set; }
        public string ZUSATZ { get; set; }
        public Nullable<short> W_TEXTE { get; set; }
        public Nullable<short> W_STATUS { get; set; }
        public string K_KENNZEICHEN { get; set; }
        public Nullable<short> W_ORTE { get; set; }
    }
}
