
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebBanDienThoai.Models;

namespace WebBanDienThoai.Models
{
    public class ProductCart
    {
        WebDBEntities1 db = null;

        public ProductCart()
        {
            db = new WebDBEntities1();
        }
        public Product ViewDetail(int ProductID)
        {
            return db.Products.Find(ProductID);
        }
    }
}