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
    
    public partial class Tooth
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Tooth()
        {
            this.ClientToothCollections = new HashSet<ClientToothCollection>();
        }
    
        public int IdTooth { get; set; }
        public byte[] PhotoTooth { get; set; }
        public string NameTooth { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ClientToothCollection> ClientToothCollections { get; set; }
    }
}