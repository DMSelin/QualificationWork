using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using QualificationWork.Models;

namespace QualificationWork.Controllers
{
    public class BrancheController : Controller
    {
        private readonly ProjectDbContext dbContext;

        public BrancheController(ProjectDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index(int page = 1)
        {
            int pageSize = 5; // количество объектов на страницу
            var Count = dbContext.Branches;
            IEnumerable<Branche> source = dbContext.Branches;
            var branchesPerPages = source.OrderBy(m => m.Name).Skip((page - 1) * pageSize).Take(pageSize);
            PageInfo pageInfo = new PageInfo { PageNumber = page, PageSize = pageSize, TotalItems = source.Count() };
            IndexViewModel ivm = new IndexViewModel { PageInfo = pageInfo, Branches = branchesPerPages };
            return View(ivm);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View("Edit");
        }

        [HttpPost]
        public IActionResult Create(Branche branche)
        {
            branche.Id = Guid.NewGuid();
            dbContext.Branches.Add(branche);
            dbContext.SaveChanges();
            return RedirectToAction("Edit", new { id = branche.Id });
        }

        [HttpGet]
        public IActionResult Edit(Guid id)
        {
            var nomenclature = dbContext.Nomenclatures.First(n => n.Id == id);
            return View("Edit", nomenclature);
        }

        [HttpPost]
        public IActionResult Edit(Branche branche)
        {
            var old = dbContext.Branches.First(n => n.Id == branche.Id);
            old.Code = branche.Code;
            old.Name = branche.Name;
            old.Director = branche.Director;
            old.Adress = branche.Adress;
            old.CreatedDate = DateTime.Now;
            old.UpdateDate = DateTime.Now;
            dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}