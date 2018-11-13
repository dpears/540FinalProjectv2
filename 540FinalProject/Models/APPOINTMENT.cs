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
    using System.ComponentModel.DataAnnotations;

    public partial class APPOINTMENT
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public APPOINTMENT()
        {
            this.JOBDONEs = new HashSet<JOBDONE>();
        }
    
        public int IDAppoint { get; set; }
        
        [Display(Name = "Client ID")]
        public int IDClientAppoint { get; set; }
        
        [Display(Name = "Style ID")]
        public byte IDStypeAppoint { get; set; }

        [Display(Name = "Appointment Date")]
        public System.DateTime DateAppoint { get; set; }

        [Display(Name = "Take out previous hair?")]
        public Nullable<bool> AddTakeOffAppoint { get; set; }

        [Display(Name = "Appointment Start Time")]
        public Nullable<System.TimeSpan> BeginnTimeAppoint { get; set; }
    
        public virtual CLIENT CLIENT { get; set; }
        public virtual STYLE STYLE { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<JOBDONE> JOBDONEs { get; set; }
    }
}
