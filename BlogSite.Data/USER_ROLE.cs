//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BlogSite.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class USER_ROLE
    {
        public int ID { get; set; }
        public int ROLEID { get; set; }
        public int USERID { get; set; }
        public System.DateTime INSERTDATE { get; set; }
        public Nullable<System.DateTime> UPDATEDATE { get; set; }
        public int STATUS { get; set; }
    
        public virtual ROLES ROLES { get; set; }
        public virtual USERS USERS { get; set; }
    }
}
