//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nsk.OnlineStore.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public Customer()
        {
            this.Orders = new HashSet<Order>();
            this.OfficeAddress = new PostalAddress();
        }
    
        public string Id { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
    
        public PostalAddress OfficeAddress { get; set; }
    
        public virtual ICollection<Order> Orders { get; set; }
    }
}
