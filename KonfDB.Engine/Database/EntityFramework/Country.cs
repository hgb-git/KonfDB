//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KonfDB.Engine.Database.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Country
    {
        public Country()
        {
            this.Cities = new HashSet<City>();
        }
    
        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public string ISO2 { get; set; }
        public string ISO3 { get; set; }
    
        public virtual ICollection<City> Cities { get; set; }
    }
}
