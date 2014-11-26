using System;
using System.Collections.Generic;

namespace RestfulApi.Model.Models
{
    public partial class LOG_VS_HIER1
    {
        public int ZAEHLER { get; set; }
        public int Z_VS_HIER1 { get; set; }
        public Nullable<System.DateTime> DAT_LASTMOD { get; set; }
        public Nullable<short> W_STATUS { get; set; }
        public string k_KENNZEICHEN { get; set; }
        public Nullable<short> W_ORTE { get; set; }
        public Nullable<short> W_TEXTE { get; set; }
        public string ZUSATZ { get; set; }
        public string AKTEURNAME { get; set; }
    }
}
