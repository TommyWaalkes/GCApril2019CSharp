//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APIHosting.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Cowboy
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public Nullable<int> Victories { get; set; }
        public Nullable<int> Loses { get; set; }
        public string HorseChoice { get; set; }
        public string FavoriteSaloon { get; set; }
        public Nullable<int> Cattle { get; set; }
        public Nullable<int> HatSize { get; set; }
    }
}
