//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Finaly
{
    using System;
    using System.Collections.Generic;
    
    public partial class deal_to_card
    {
        public int DealtocardID { get; set; }
        public int idofcard { get; set; }
        public int idofdeal { get; set; }
    
        public virtual Cards Cards { get; set; }
        public virtual Deals Deals { get; set; }
    }
}
