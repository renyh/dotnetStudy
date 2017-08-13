using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace firstWeb.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]//登陆控制器
        public ActionResult Login(Models.LoginModel loginModel)
        {
            string info = "";
            if (loginModel.UserName == "张三" && loginModel.Password == "123456")
                info = "恭喜您，登录成功！";
            else
                info = "<span style='color:red'>登录失败：用户名或密码不正确！</span>";

            ViewBag.LoginInfo = info;
            return View();
        }


    }
}