//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Dentistry.Entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class ClientToothCollection
    {
        public int IdClientToothCollection { get; set; }
        public Nullable<int> IdClient { get; set; }
        public Nullable<int> IdTooth { get; set; }
        public Nullable<int> IdToothStatus { get; set; }
        public Nullable<int> IdUser { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Tooth Tooth { get; set; }
        public virtual ToothStatu ToothStatu { get; set; }
        public virtual User User { get; set; }
    }
}