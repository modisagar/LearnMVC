using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;

namespace HelloWorld.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Load()
        {
            Customer cust =
                new Customer
                {
                    CustomerCode = "1001",
                    CustomerName = "Sagar"
                };

            return View("Customer",cust);
        }

        public ActionResult Add()
        {
            return View("AddCustomer");
        }
        public ActionResult Submit(Customer cust)
        {
            //Customer cust = new Customer();
            //cust.CustomerCode = Request.Form["CustomerCode"];
            //cust.CustomerName = Request.Form["CustomerName"];
            return View("Customer",cust);
        }
    }
}