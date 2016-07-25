using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.ViewModels;
using Vidly.Models;
using System.Data.Entity;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        ApplicationDbContext _context;
        IEnumerable<Customer> customers;

        #region "Page Events"
        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        #endregion
        
        #region "Private Methods/Functions"
        private IEnumerable<Customer> GetCustomers()
        {
            customers = _context.Customers.Include(c => c.MembershipType);

            return customers;
        }
        #endregion

        #region "Actions"
                
        
        // GET: Customers
        public ViewResult Index()
        {
            return View(GetCustomers());
        }

        //Get Customer Details
        public ActionResult Details(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).Where(c => c.Id == id).FirstOrDefault();

            return View(customer);
        }

        public ActionResult New()
        {
            //update
            return View();
        }

        public ActionResult Update()
        {
            return View();
        }

        #endregion
    }
}