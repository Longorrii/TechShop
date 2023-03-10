//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TechShop.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductCategory
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ProductCategory()
        {
            this.Products = new HashSet<Product>();
        }
    
        public long ID { get; set; }
        public string Title { get; set; }
        public string MetaTitle { get; set; }
        public string Images { get; set; }
        public string NavImages { get; set; }
        public string BannerImages { get; set; }
        public string ShortDesc { get; set; }
        public string Description { get; set; }
        public Nullable<int> Order { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public string MetaKeywords { get; set; }
        public string MetaDescription { get; set; }
        public bool Status { get; set; }
        public Nullable<long> ParentID { get; set; }
        public string Style { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Product> Products { get; set; }
    }
}
