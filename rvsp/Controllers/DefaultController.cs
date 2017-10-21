using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using rvsp.Models;

namespace rvsp.Controllers
{
    public class DefaultController : Controller
    {
      
        // GET: Default
        public ViewResult Index()
        {
            ViewBag.Day = DateTime.Now.DayOfWeek;
            return View();
        }
        [HttpGet]
        public ViewResult RvspForm()
        {
            return View();
        }
        [HttpPost]
        public ViewResult RvspForm(GuestResponse guestResponse)
        {//Sprawdzanie bledow kontroli poprawnosci  formularza
            if(ModelState.IsValid)
            { 
            return View("Thanks", guestResponse);
            }
            else//gdy warunek nie zostanie spelniony
            {
                
                return View();
            }
        }
    }
}