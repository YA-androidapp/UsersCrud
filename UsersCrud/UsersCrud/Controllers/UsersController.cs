using System;
using Microsoft.AspNetCore.Mvc;

namespace UsersCrud.Controllers
{
    [Route("Users/[action]")]
    public class UsersController : Controller
    {
        // GET: Users
        public ActionResult Index()
        {
            Console.WriteLine("UsersController Index()");
            return View();
        }

        // GET: Users/Details/5
        [Route("Users/Details")]
        public ActionResult Details(int id)
        {
            Console.WriteLine("UsersController Details("+id.ToString()+")");
            return View();
        }

        // GET: Users/Create
        [Route("Users/Create")]
        public ActionResult Create()
        {
            Console.WriteLine("UsersController Create()");
            return View();
        }

        //// POST: Users/Create
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Create(IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Users/Edit/5
        [Route("Users/Edit")]
        public ActionResult Edit(int id)
        {
            Console.WriteLine("UsersController Edit(" + id.ToString() + ")");
            return View();
        }

        //// POST: Users/Edit/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        // GET: Users/Delete/5
        [Route("Users/Delete")]
        public ActionResult Delete(int id)
        {
            Console.WriteLine("UsersController Delete(" + id.ToString() + ")");
            return View();
        }

        //// POST: Users/Delete/5
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Delete(int id, IFormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction(nameof(Index));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
    }
}