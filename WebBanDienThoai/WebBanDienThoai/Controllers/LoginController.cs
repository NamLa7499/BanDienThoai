using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebBanDienThoai.Models;

namespace WebBanDienThoai.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        private WebDBEntities1 db = new WebDBEntities1();
        public ActionResult LoginAccount()
        {
            return View();
        }

        [HttpPost]
        public ActionResult LoginAccount(string email, string password)
        {
            //Md5Encode md5 = new Md5Encode();
            //var passmd5 = md5.EncodeMd5Encrypt(password);
            var login = db.Users.SingleOrDefault(x => x.Email == email && x.Password == password && x.Status == true);

            if (login != null)
            {


                Session["UserID"] = login.UserID;
                Session["Username"] = login.Username;
                Session["Email"] = login.Email;
                Session["Password"] = login.Password;
                Session["Image"] = login.Image;
                return Redirect("~/AdminHome/Index");


            }
            else
            {

                ViewBag.error = "Tên Tài Khoản Hoặc Mật Khẩu Không Đúng";
            }
            return View();
        }
    }
}