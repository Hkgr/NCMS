//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NCMS
{
    using System;
    using System.Collections.Generic;
    
    public partial class dmg_form
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dmg_form()
        {
            this.dmg_data = new HashSet<dmg_data>();
        }
    
        public int order_number { get; set; }
        public string form_number { get; set; }
        public Nullable<System.DateTime> order_date { get; set; }
        public Nullable<int> member1 { get; set; }
        public Nullable<int> member2 { get; set; }
        public Nullable<int> member3 { get; set; }
        public Nullable<int> member4 { get; set; }
        public string created_by { get; set; }
        public Nullable<System.DateTime> created_at { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dmg_data> dmg_data { get; set; }
        public virtual employee employee { get; set; }
        public virtual employee employee1 { get; set; }
        public virtual employee employee2 { get; set; }
        public virtual employee employee3 { get; set; }
    }
}
