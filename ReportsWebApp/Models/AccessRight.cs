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
    
    public partial class AccessRight
    {
        public int Id { get; set; }
        public bool GroupReport { get; set; }
        public bool PlanReport { get; set; }
        public bool Database { get; set; }
        public bool ManageUsers { get; set; }
        public string AspNetUserId { get; set; }
    
        public virtual AspNetUser AspNetUser { get; set; }
    }
}
