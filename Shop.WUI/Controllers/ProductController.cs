using Shop.BOL.Cervices.Common;
using Shop.BOL.Cervices.Instatnt;
using Shop.BOL.Models;
using Shop.DAL.Entities;
using Step.RepositoryInstatnt.Instatnt;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Shop.WUI.Controllers
{
    public class ProductController : Controller
    {
		IDTOService<CartVM> cartService;
		//ShopContext SC = new ShopContext();
		IDTOService<ProductVM> productRep;
		IDTOService<PhotoVM> photoRep;

		public ProductController(IDTOService<CartVM> cartService, IDTOService<ProductVM> productRep_, IDTOService<PhotoVM> photoRep_)
		{
			this.cartService = cartService;
			productRep = productRep_;
			photoRep = photoRep_;
		}

		//public ProductController()
		//{
		//	this.cartService = new CartVMService(new CartRep(new ShopContext()));
		//	productRep = new ProductVMService(new ProductRep(new ShopContext()));
		//	photoRep = new PhotoVMService(new PhotoRep(new ShopContext()));
		//}

		// GET: Product
		public ActionResult Index()
        {
			IEnumerable<ProductVM> model = productRep.GetAll();

			return View(model);
        }

		// GET: Product/Shortly/5
		public ActionResult Shortly(/*Guid id*/)
        {
			//ProductVM  model = productRep.Get(id);
			ProductVM model = productRep.GetAll().First();
			PhotoVM prima = photoRep.FindBy(p=>p.PrimePhoto==true||p.ProductId == model.ProductId).First();
			ViewBag.prima = prima.PhotoURL;

			return View(model);
        }

        // GET: Product/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Product/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Product/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Product/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Product/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
