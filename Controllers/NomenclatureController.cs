using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using QualificationWork.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace QualificationWork.Controllers
{
    public class NomenclatureController : Controller
    {
        private readonly ProjectDbContext dbContext;
        public NomenclatureController(ProjectDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public ActionResult Index(int page = 1)
        {
            int pageSize = 5; // количество объектов на страницу
            var Count = dbContext.Nomenclatures;
            IEnumerable<Nomenclature> source = dbContext.Nomenclatures;
            var nomenclaturesPerPages = source.OrderBy(m => m.Code).Skip((page - 1) * pageSize).Take(pageSize);
            PageInfo pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = source.Count()};
            IndexViewModel ivm = new IndexViewModel { PageInfo = pageInfo, Nomenclatures = nomenclaturesPerPages };
            return View(ivm);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Edit");
        }

        [HttpPost]
        public IActionResult Create(Nomenclature nomenclature)
        {
            nomenclature.Id = Guid.NewGuid();
            dbContext.Nomenclatures.Add(nomenclature);
            dbContext.SaveChanges();
            return RedirectToAction("Edit", new { id = nomenclature.Id });
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var nomenclature = dbContext.Nomenclatures.First(n => n.Id == id);
            return View("Edit", nomenclature);
        }

        [HttpPost]
        public IActionResult Edit(Nomenclature nomenclature)
        {
            var old = dbContext.Nomenclatures.First(n => n.Id == nomenclature.Id);
            old.Code = nomenclature.Code;
            old.Name = nomenclature.Name;
            old.Date = nomenclature.Date;
            old.CreatedDate = DateTime.Now;
            old.CreateUserId = nomenclature.CreateUserId;
            old.Price = nomenclature.Price;
            old.UpdateDate = DateTime.Now;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Details(Guid id)
        {
            var nomenclature = dbContext.Nomenclatures.First(n => n.Id == id);
            return View("Details", nomenclature);
        }
    }
}