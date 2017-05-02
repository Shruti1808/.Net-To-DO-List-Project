using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ToDoList.Controllers
{
    public class ItemsController : Controller
    {
        private ToDoListContext db = new ToDoListContext();
        //public IActionResult Index()
        //{
        //    return View(db.Items.Include(items => items.Category).ToList());
        //}

            //This is just for the sake of testing withot Category involved in the database  - if you want to return category - make sure to comment Category BACK IN from the DbContext, and the Item and Category Models.---!
        public IActionResult Index()
        {
            return View(db.Items.ToList());
        }

        //        public IActionResult Details(int id)
        //        {
        //            var thisItem = db.Items.FirstOrDefault(items => items.ItemId == id);
        //            var thisCategory = db.Categories.FirstOrDefault(categories => categories.CategoryId == thisItem.CategoryId);
        //            var dictionary = new Dictionary<string, Object> { { "item", thisItem }, { "category", thisCategory } };
        //            return View(dictionary);
        //        }

        //public IActionResult Create()
        //{
        //    ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "Name");
        //    return View();
        //}

        // this is for Item test ONLY
        public IActionResult Create()
        {
            return View();
        }

        // this is for Item test ONLY
        [HttpPost]
        public IActionResult Create(Item item)
        {
            db.Items.Add(item);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //        [HttpPost]
        //        public IActionResult Create(Item item)
        //        {
        //            db.Items.Add(item);
        //            db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }

        //        public IActionResult Edit(int id)
        //        {
        //            var thisItem = db.Items.FirstOrDefault(items => items.ItemId == id);
        //            ViewBag.CategoryId = new SelectList(db.Categories, "CategoryId", "Name");
        //            return View(thisItem);
        //        }

        //        [HttpPost]
        //        public IActionResult Edit(Item item)
        //        {
        //            db.Entry(item).State = EntityState.Modified;
        //            db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }

        //        public IActionResult Delete(int id)
        //        {
        //            var thisItem = db.Items.FirstOrDefault(items => items.ItemId == id);
        //            return View(thisItem);
        //        }

        //        [HttpPost, ActionName("Delete")]
        //        public IActionResult DeleteConfirmed(int id)
        //        {
        //            var thisItem = db.Items.FirstOrDefault(items => items.ItemId == id);
        //            db.Items.Remove(thisItem);
        //            db.SaveChanges();
        //            return RedirectToAction("Index");
        //        }

    }
}
