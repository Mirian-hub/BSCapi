//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplicationGrid.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ShellSchedulerLanguageTable
    {
        public int ShellSchedulerID { get; set; }
        public int ShellSchedulerLanguageID { get; set; }
        public string ShellSchedulerNAME { get; set; }
    
        public virtual ShellLanguageTable ShellLanguageTable { get; set; }
        public virtual ShellSchedulerTable ShellSchedulerTable { get; set; }
    }
}