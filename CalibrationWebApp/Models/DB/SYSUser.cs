//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalibrationWebApp.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class SYSUser
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SYSUser()
        {
            this.SYSUserRoles = new HashSet<SYSUserRole>();
            this.EmployeeProfiles = new HashSet<EmployeeProfile>();
            this.InstrumentInventories = new HashSet<InstrumentInventory>();
        }
    
        public int SYSUserID { get; set; }
        public string LoginName { get; set; }
        public string PasswordHash { get; set; }
        public int RowCreatedSYSUSerID { get; set; }
        public Nullable<System.DateTime> RowCreatedDateTime { get; set; }
        public int RowModifiedSYSUserID { get; set; }
        public Nullable<System.DateTime> RowModifiedDateTime { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SYSUserRole> SYSUserRoles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<EmployeeProfile> EmployeeProfiles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<InstrumentInventory> InstrumentInventories { get; set; }
    }
}