﻿using System;
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
            var membershipTypes = _context.MembershipTypes.ToList();

            CustomerFormViewModel viewModel = new CustomerFormViewModel
            {
                MembershipTypes = membershipTypes
            };


            return View("CustomerForm", viewModel);
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return HttpNotFound();


            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("CustomerForm",viewModel);
        }

        [HttpPost]
        public ActionResult Save(Customer customer)
        {

            if (customer.Id == null)
            {
                _context.Customers.Add(customer);
            }
            else {
                var customertobeUpdated = _context.Customers.Single(c => c.Id == customer.Id);
                customertobeUpdated.Name = customer.Name;
                customertobeUpdated.DateofBirth = customer.DateofBirth;
                customertobeUpdated.MembershipTypeId = customer.MembershipTypeId;
                customertobeUpdated.IsSubscribedForNewsLetter = customer.IsSubscribedForNewsLetter;
            }
           
            _context.SaveChanges();


            return RedirectToAction("Index");
        }

        #endregion
    }
}