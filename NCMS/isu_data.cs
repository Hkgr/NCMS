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
    
    public partial class isu_data
    {
        public int action_id { get; set; }
        public Nullable<int> order_number { get; set; }
        public Nullable<int> item_numer { get; set; }
        public Nullable<int> qty { get; set; }
        public string remarks { get; set; }
    
        public virtual item item { get; set; }
        public virtual isu_form isu_form { get; set; }
    }
}
