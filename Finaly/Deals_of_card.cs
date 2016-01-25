
namespace Finaly
{
    using System;
    using System.Collections.Generic;

    public partial class Deals_of_card

    {

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]


        public string product { get; set; }
        public string station { get; set; }
        public int quantity { get; set; }
        public int totalprice { get; set; }
        public int bonus { get; set; }
        public Nullable<System.DateTime> data { get; set; }
        public Nullable<System.TimeSpan> time { get; set; }

    }

}