//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _540FinalProject.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class BRAIDER
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BRAIDER()
        {
            this.JOBEXECUTERs = new HashSet<JOBEXECUTER>();
            this.SKILLS = new HashSet<SKILL>();
        }
    
        public int IDBraider { get; set; }
        public string FnameBraider { get; set; }
        public string MnameBraider { get; set; }
        public string LnameBraider { get; set; }
        public string PhoneBraider { get; set; }
        public string CelBraider { get; set; }
        public string StreetBraider { get; set; }
        public string CountyBraider { get; set; }
        public Nullable<short> ZipCodeBraider { get; set; }
        public string EmailBraider { get; set; }
        public string IDUserBraider { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JOBEXECUTER> JOBEXECUTERs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SKILL> SKILLS { get; set; }

        //this is the connection to the visual basic user table
        public virtual AspNetUser AspNetUser { get; set; }
    }
}