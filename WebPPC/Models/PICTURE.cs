//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebPPC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class PICTURE
    {
        public int id { get; set; }
        public int Property_id { get; set; }
        public string Name_Image { get; set; }
    
        public virtual PROPERTY PROPERTY { get; set; }
    }
}
