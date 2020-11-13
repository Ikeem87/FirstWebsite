using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ModelView.Models;

namespace ModelView.Controllers
{
    public class InformationController : Controller
    {
        // GET: Information

        
        public ActionResult Index()
        {
            var Cars = new List<Cars>()
            {
                new Cars{Name = "Lambo", Price = 1000000, Year = 2020},
                new Cars{Name = "GTR", Price = 1000000, Year = 2019},
                new Cars{Name = "Chevelle", Price = 1000000, Year = 2020},
                new Cars{Name = "Porche", Price = 1000000, Year = 2022},
            };

            var Customer = new List<Customer>()
            {
                new Customer{Custname= "Josh", CustId = 101, Custcity = "STL"},
                new Customer{Custname= "Dave", CustId = 102, Custcity = "KC"},
                new Customer{Custname= "Ikeem", CustId = 103, Custcity = "Texas"},
                new Customer{Custname= "Mackenzey", CustId = 104, Custcity = "Foristell"},
            };

            var InformationViewmodel1 = new InformationViewModel1
            {
                Car = Cars,
                Customers = Customer
            };
            return View(InformationViewmodel1);


        }
        
    }
}