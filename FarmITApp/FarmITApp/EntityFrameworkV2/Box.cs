//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FarmITApp.EntityFrameworkV2
{
    using System;
    using System.Collections.Generic;
    
    public partial class Box
    {
        public Box()
        {
            this.Animal = new HashSet<Animal>();
        }
    
        public string IdBox { get; set; }
        public string IdBuilding { get; set; }
    
        public virtual ICollection<Animal> Animal { get; set; }
        public virtual Building Building { get; set; }
    }
}