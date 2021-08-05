using Microsoft.AspNetCore.Mvc;
using ShoestoreSoulinthavong.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoestoreSoulinthavong.Controllers
{
    public class ShoeController : Controller
    {
        private ShoeContext context { get; set; }

        public ShoeController(ShoeContext ctx)
        {
            context = ctx;
        }

        [HttpGet]
        public IActionResult Add()
        {
            ViewBag.Action = "Add";
            ViewBag.Shoes = context.Shoes.OrderBy(s => s.Brand).ToList();
            return View("Edit", new Shoe());
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Action = "Edit";
            ViewBag.Brand = context.Shoes.OrderBy(b => b.
            Brand).ToList();
            var shoe = context.Shoes.Find(id);
            return View(shoe);
        }

        [HttpPost]
        public IActionResult Edit(Shoe shoe)
        {
            if (ModelState.IsValid)
            {
                if (shoe.ShoeId == 0)
                    context.Shoes.Add(shoe);
                else
                {
                    context.Shoes.Update(shoe);
                }
                context.SaveChanges();
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Action = (shoe.ShoeId == 0) ? "Add" : "Edit";
                ViewBag.Shoes = context.Shoes.OrderBy(b => b.
            Brand).ToList();
                return View(shoe);
            }
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var shoe = context.Shoes.Find(id);
            return View(shoe);
        }

        [HttpPost]
        public IActionResult Delete(Shoe shoe)
        {
            context.Shoes.Remove(shoe);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
    }
}
