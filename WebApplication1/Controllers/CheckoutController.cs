﻿using Microsoft.AspNetCore.Mvc;
using Stripe;
using PetInformation.Helper;
using PetInformation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PetInformation.Controllers
{
    public class CheckoutController : Controller
    {
        public string TotalAmount;

        public IActionResult Index()
        {

            // var cart = SessionHelper.GetObjectFromJson<List<Item>>(HttpContext.Session, "cart");
            //var cart = "12";
           // ViewBag.cart = 12;
            //ViewBag.DollarAmount= cart;
            //ViewBag.total = Math.Round(ViewBag.DollarAmount,2)*100;
            //ViewBag.total = Convert.ToInt64(ViewBag.cart);
           // long total =ViewBag.total;
            //TotalAmount = total.ToString();
            TotalAmount = "12";
           // TempData["TotalAmount"] = TotalAmount;
            return View();
        }
        public IActionResult Processing(string stripeToken,string stripeEmail)
        {
            var optionCust = new CustomerCreateOptions
            {
                Email = stripeEmail,
                Name = "Rizwan Yousaf",
                Phone = "338595119"
            };
            var serviceCust = new CustomerService();
            Customer customer = serviceCust.Create(optionCust);
            var optionsCharge = new ChargeCreateOptions
            {
                Amount = Convert.ToInt64(TotalAmount),
                
                Currency = "USD",
                Description="Pet Selling amount",
                Source=stripeToken,
                ReceiptEmail=stripeEmail

            };
            var serviceCharge = new ChargeService();
            Charge charge = serviceCharge.Create(optionsCharge);
            if(charge.Status== "succeeded")
            {
                ViewBag.AmountPaid =Convert.ToDecimal(charge.Amount)%100/100+(charge.Amount)/100;
                //ViewBag.Customer = customer.Name;
            }
            return View();


        }
    }
}
