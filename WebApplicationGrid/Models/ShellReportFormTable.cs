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
    
    public partial class ShellReportFormTable
    {
        public int ShellReportFormID { get; set; }
        public int ShellReportFormSortID { get; set; }
        public string ShellReportFormKey { get; set; }
        public string ShellReportFormName { get; set; }
        public int ShellReportID { get; set; }
    
        public virtual ShellReportTable ShellReportTable { get; set; }
    }
}
