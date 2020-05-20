using Microsoft.AspNet.Identity;
using MyFitness.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyFitness.Controllers
{
    public class UserController : Controller
    {
        ApplicationDbContext _context;
        public UserController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: User
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AddUserInfo(UserInfo info)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var userid = User.Identity.GetUserId();
                    UserInfo userDB = new UserInfo();
                    userDB.UserId = userid;
                    userDB.BeratBadan = info.BeratBadan;
                    userDB.tanggal_lahir = info.tanggal_lahir;
                    userDB.Punggung = info.Punggung;
                    userDB.Perut = info.Perut;
                    userDB.NamaLengkap = info.NamaLengkap;
                    userDB.LenganTricep = info.LenganTricep;
                    userDB.LenganBicep = info.LenganBicep;
                    userDB.Kaki = info.Kaki;
                    userDB.Dada = info.Dada;
                    userDB.Bokong = info.Bokong;
                    userDB.Bahu = info.Bahu;
                    userDB.Tingkatan = info.Tingkatan;
                    
                    userDB.tanggal_update = DateTime.Now;

                    _context.UserInfo.Add(userDB);
                    _context.SaveChanges();

                }
                catch
                {
                    return View();
                }
            }
            return View();
        }
    }
}