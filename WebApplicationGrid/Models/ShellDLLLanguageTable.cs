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
    
    public partial class ShellDLLLanguageTable
    {
        public int ShellDLLID { get; set; }
        public int ShellDLLLanguageID { get; set; }
        public string ShellDLLNAME { get; set; }
    
        public virtual ShellDLLTable ShellDLLTable { get; set; }
        public virtual ShellLanguageTable ShellLanguageTable { get; set; }
    }
}