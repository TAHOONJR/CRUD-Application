using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;
using WebApplication1.Models;
using IHostingEnvironment = Microsoft.AspNetCore.Hosting.IHostingEnvironment;

namespace WebApplication1.Controllers
{
    [Authorize]
    
    public class ItemsController : Controller
    {
        
        public ItemsController(AppDbContext db , IHostingEnvironment host)
        {
            _db = db;
            _host = host;
        }

        private readonly IHostingEnvironment _host;
        private readonly AppDbContext _db;

        public IActionResult Index()
        {
            IEnumerable<Items> itemList = _db.Items.ToList();
            return View(itemList);
        }

        //GET - CREATE
        [Authorize(Roles = clsRoles.roleAdmin)]
        public IActionResult Create()
        {
            return View();
        }

        //POST - CREATE
        [HttpPost]
        [Route("Items/Create")]
        [ValidateAntiForgeryToken] //to prevent cross site request forgery
        public IActionResult Create(Items item)
        {
            if (ModelState.IsValid)
            {
                string fileName = string.Empty;
                if (item.clientFile != null)
                {
                    string myUpload = Path.Combine(_host.WebRootPath, "images");
                    fileName = item.clientFile.FileName;
                    string fullPath = Path.Combine(myUpload, fileName);
                    item.clientFile.CopyTo(new FileStream(fullPath, FileMode.Create));
                    item.ImagePath = fileName;
                }
            _db.Items.Add(item);
            _db.SaveChanges();
            TempData["message"]= "item has been created successfully";
            return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        //GET - EDIT
        [Authorize(Roles = clsRoles.roleAdmin)]
        public IActionResult Edit(int? Id)
        {
            if(Id == null || Id == 0)
            {
                return NotFound();
            }
            var item = _db.Items.Find(Id);
            if(item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        //POST - EDIT
        [HttpPost]
        [ValidateAntiForgeryToken] //to prevent cross site request forgery
        public IActionResult Edit(Items item)
        {
            if (ModelState.IsValid)
            {
            _db.Items.Update(item);
            _db.SaveChanges();
            TempData["message"]= "item has been updated successfully";
            return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        //GET - DELETE
        [HttpGet]
        [Authorize(Roles = clsRoles.roleAdmin)]
        [Route("Items/Delete/{Id}")]
        public IActionResult Delete(int? Id)
        {
            if(Id == null || Id == 0)
            {
                return NotFound();
            }
            var item = _db.Items.Find(Id);
            if(item == null)
            {
                return NotFound();
            }
            return View(item);
        }

        //POST - DELETE
        [HttpPost]
        [ValidateAntiForgeryToken] //to prevent cross site request forgery
        [Route("Items/Delete/{Id}")] //to prevent cross site request forgery
        public IActionResult DeleteItem(int? Id)
        {
            var item = _db.Items.Find(Id);
            if(item == null)
            {
                return NotFound();
            }
            _db.Items.Remove(item);
            _db.SaveChanges();
            TempData["message"]= "item has been deleted successfully";
            return RedirectToAction("Index");
        }


    }
}













//Author: Mohamed Tahoon