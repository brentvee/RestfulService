using System;
using System.Collections.Generic;

namespace RestfulApi.Model.Models
{
    public partial class LOG_ERRORS
    {
        public int zaehler { get; set; }
        public string BARCODE { get; set; }
        public Nullable<System.DateTime> DAT_ERROR { get; set; }
        public string AKTEURNAME { get; set; }
        public string ZUSATZ { get; set; }
        public Nullable<short> W_TEXTE { get; set; }
        public string EDV1 { get; set; }
        public string FUNKBASIS { get; set; }
        public Nullable<short> ERRTYPE { get; set; }
        public Nullable<int> SCANNERID { get; set; }
        public Nullable<short> W_ARBEITSGANG { get; set; }
        public short ERLEDIGT { get; set; }
        public System.DateTime dat_lastmod { get; set; }
        public int Z_USER_ERLEDIGT { get; set; }
        public string BEMERKUNG_ERLEDIGT { get; set; }
        public Nullable<System.DateTime> DAT_ERLEDIGT { get; set; }
    }
}
