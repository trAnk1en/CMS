using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
        private readonly CmsContext context;

        public HomeController(CmsContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            ViewBag.IsLoginFail = "hidden";
            ViewBag.IsWrong = "";
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public IActionResult Index(string role, string username, string password)
        {
            if(username == null || password == null)
            {
                ViewBag.IsWrong = "is-invaled";
            }
            else
            {
                if(role == new Admin().GetType().Name)
                {
                    try
                    {
                        var admin = context.Admins.Where(admin => admin.UserName == username && admin.PassWord == password).Single();
                        return RedirectToAction("Index", "Admins");
                    }
                    catch(Exception exception)
                    {
                        Console.WriteLine(exception);
                        ViewBag.IsWrong = "";
                        return View();
                    }
                }
                if (role == new Trainingstaff().GetType().Name)
                {
                    try
                    {
                        var ts = context.Trainningstaffs.Where(ts => ts.UserName == username && ts.PassWord == password).Single();
                        return RedirectToAction("Index", "Trainingstaffs");
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                        ViewBag.IsWrong = "";
                        return View();
                    }
                }
                if (role == new Trainer().GetType().Name)
                {
                    try
                    {
                        var tn = context.Trainers.Where(tn => tn.UserName == username && tn.PassWord == password).Single();
                        return RedirectToAction("Index", "Trainers");
                    }
                    catch (Exception exception)
                    {
                        Console.WriteLine(exception);
                        ViewBag.IsWrong = "";
                        return View();
                    }
                }
            }
            return View();
        }

    }
}
