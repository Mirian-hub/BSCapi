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
    
    public partial class ShellSettingValueTable
    {
        public int ShellSettingValueID { get; set; }
        public int ShellUserID { get; set; }
        public int ShellSettingID { get; set; }
        public string ShellSettingValue { get; set; }
    
        public virtual ShellSettingTable ShellSettingTable { get; set; }
        public virtual ShellUserTable ShellUserTable { get; set; }
    }
}
