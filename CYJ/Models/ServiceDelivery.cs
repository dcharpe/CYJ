//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CYJ.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServiceDelivery
    {
        public int id { get; set; }
        public string teamName { get; set; }
        public string workstreamName { get; set; }
        public string categoryName { get; set; }
        public string subcategoryName { get; set; }
        public string goalName { get; set; }
        public Nullable<int> goalValue { get; set; }
    }
}
