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
    
    public partial class ShellSchedulerTable
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ShellSchedulerTable()
        {
            this.ShellSchedulerLanguageTables = new HashSet<ShellSchedulerLanguageTable>();
        }
    
        public int ShellSchedulerID { get; set; }
        public string ShellSchedulerKEY { get; set; }
        public string ShellSchedulerNAME { get; set; }
        public string ShellSchedulerNOTE { get; set; }
        public int ShellSchedulerTypeID { get; set; }
        public int ShellSchedulerStatusID { get; set; }
        public System.DateTime ShellSchedulerValidFROM { get; set; }
        public System.DateTime ShellSchedulerValidTO { get; set; }
        public int ShellSchedulerSORT { get; set; }
        public int ShellSchedulerGroupID { get; set; }
        public int ShellCollectorID { get; set; }
        public int ShellProccessorID { get; set; }
        public int ShellSynchronizerID { get; set; }
        public Nullable<int> ShellMessangerID { get; set; }
        public string ShellScedulerSource { get; set; }
        public string ShellScedulerDestination { get; set; }
        public string ShellSchedulerMail { get; set; }
        public int ShellWorkingMinute { get; set; }
        public string ShellWorkingWeekDays { get; set; }
        public int ShellWorkingStartHour { get; set; }
        public int ShellWorkingEndHour { get; set; }
    
        public virtual ShellSchedulerGroupTable ShellSchedulerGroupTable { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ShellSchedulerLanguageTable> ShellSchedulerLanguageTables { get; set; }
        public virtual ShellSchedulerStatusTable ShellSchedulerStatusTable { get; set; }
        public virtual ShellSchedulerTypeTable ShellSchedulerTypeTable { get; set; }
    }
}