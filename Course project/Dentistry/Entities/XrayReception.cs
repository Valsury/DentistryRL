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
    
    public partial class XrayReception
    {
        public int IdXrayReception { get; set; }
        public Nullable<int> IdTooth { get; set; }
        public Nullable<int> IdClient { get; set; }
        public Nullable<int> IdDoctor { get; set; }
        public byte[] PreviewXray { get; set; }
        public Nullable<System.DateTime> DateOfXray { get; set; }
    
        public virtual Client Client { get; set; }
        public virtual Doctor Doctor { get; set; }
        public virtual Tooth Tooth { get; set; }
    }
}