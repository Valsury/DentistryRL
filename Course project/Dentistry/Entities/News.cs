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
    
    public partial class News
    {
        public string IdNews { get; set; }
        public string HeaderNews { get; set; }
        public string TextNews { get; set; }
        public System.DateTime CreationDateNews { get; set; }
        public byte[] PhotoNews { get; set; }
        public int IdAuthor { get; set; }
    
        public virtual Author Author { get; set; }
    }
}
