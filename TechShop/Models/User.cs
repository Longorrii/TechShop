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
    
    public partial class User
    {
        public string UserName { get; set; }
        public string Avatar { get; set; }
        public string Password { get; set; }
        public string PasswordLevel2 { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public bool Sex { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> LastLoginDate { get; set; }
        public Nullable<System.DateTime> LastChangePassword { get; set; }
        public string GroupID { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public string CreatedBy { get; set; }
    
        public virtual UserGroup UserGroup { get; set; }
    }
}
