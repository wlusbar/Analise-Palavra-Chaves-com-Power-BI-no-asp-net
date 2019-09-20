using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AppTccWebBD.Models;

namespace AppTccWebBD.Controllers
{
    public class TccController : Controller
    {
        private readonly ITccDAL tccDeAluno;
        public TccController(ITccDAL tcc) => tccDeAluno = tcc;

        public IActionResult Index()
        {
            List<Tcc> listaTcc = new List<Tcc>();
            listaTcc = tccDeAluno.GetAllTcc().ToList();
            return View(listaTcc);
        }
        [HttpGet]
        public IActionResult Details(int? id)    
        {    
            if (id == null)
            {
                return NotFound();
            }
            Tcc tcc = tccDeAluno.GetTcc(id);
            if (tcc == null)

            {
                return NotFound();
            }
            return View(tcc);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind] Tcc tcc)
        {
            if (ModelState.IsValid)
            {
                tccDeAluno.AddTcc(tcc);
                return RedirectToAction("Index");
            }
            return View(tcc);
        }
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Tcc tcc = tccDeAluno.GetTcc(id);
            if (tcc == null)
            {
                return NotFound();
            }
            return View(tcc);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind]Tcc tcc)
        {
            if (id != tcc.AlunoId)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                tccDeAluno.UpdateTcc(tcc);
                return RedirectToAction("Index");
            }
            return View(tcc);
        }
        [HttpGet]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Tcc tcc = tccDeAluno.GetTcc(id);
            if (tcc == null)
            {
                return NotFound();
            }
            return View(tcc);
        }
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int? id)
        {
            tccDeAluno.DeleteTcc(id);
            return RedirectToAction("Index");
        }
    }
}