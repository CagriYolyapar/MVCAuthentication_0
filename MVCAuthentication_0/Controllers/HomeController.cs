using MVCAuthentication_0.AuthenticationClasses;
using MVCAuthentication_0.DesignPatterns.SingletonPattern;
using MVCAuthentication_0.Models.Context;
using MVCAuthentication_0.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCAuthentication_0.Controllers
{

    public class HomeController : Controller
    {

        MyContext _db;

        public HomeController()
        {
            _db = DBTool.DBInstance;
        }



        [AdminAuthentication]

        public ActionResult Index()
        {
            
            HomeVM hvm = new HomeVM
            {
                AppUsers = _db.AppUsers.ToList()
            };
            return View(hvm);
        }
    }
}