//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReportsWebApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Transportation
    {
        public int Id { get; set; }
        public System.DateTime DateTimeDeparture { get; set; }
        public int PlanId { get; set; }
    
        public virtual Plan Plan { get; set; }
    }
}
