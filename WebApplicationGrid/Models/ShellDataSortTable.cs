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
    
    public partial class ShellDataSortTable
    {
        public int ShellDataID { get; set; }
        public int ShellDataSortID { get; set; }
        public string ShellDataSortKey { get; set; }
        public string ShellDataSortName { get; set; }
        public string ShellDataSortFormat { get; set; }
    
        public virtual ShellDataSortTable ShellDataSortTable1 { get; set; }
        public virtual ShellDataSortTable ShellDataSortTable2 { get; set; }
        public virtual ShellDataTable ShellDataTable { get; set; }
    }
}