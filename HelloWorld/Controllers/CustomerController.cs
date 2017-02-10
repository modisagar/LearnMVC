using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;
using HelloWorld.Binders;
using HelloWorld.Dal;

namespace HelloWorld.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Load()
        {
            var cust =
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
        //public ActionResult Submit([ModelBinder(typeof(CustomerBinder))] Customer cust)
        public ActionResult Submit(Customer cust)
        {
            if (ModelState.IsValid)
            {
                var Dal = new CustomerDal();
                Dal.Customers.Add(cust);
                Dal.SaveChanges();
                return View("Customer", cust);
            }
            else
                return View("AddCustomer");
        }
    }
}