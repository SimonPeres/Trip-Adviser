//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Trip_Adviser
{
    using System;
    using System.Collections.Generic;
    
    public partial class FOOD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FOOD()
        {
            this.PICTUREs = new HashSet<PICTURE>();
            this.REVIEW_RATING = new HashSet<REVIEW_RATING>();
        }
    
        public int FoodId { get; set; }
        public int ResId { get; set; }
        public string FoodName { get; set; }
        public string FoodDesc { get; set; }
        public Nullable<int> FoodPrice { get; set; }
    
        public virtual RESTAURANT RESTAURANT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PICTURE> PICTUREs { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<REVIEW_RATING> REVIEW_RATING { get; set; }
    }
}
