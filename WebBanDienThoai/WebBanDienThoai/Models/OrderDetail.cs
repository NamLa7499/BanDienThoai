//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanDienThoai.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderDetail
    {
        public int orderDetailID { get; set; }
        public int orderID { get; set; }
        public int ProductID { get; set; }
        public decimal Price { get; set; }
        public int Quanlity { get; set; }
        public float TotalProduct { get; set; }
        public bool Status { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}