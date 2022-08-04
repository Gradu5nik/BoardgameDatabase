using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BoardgameDatabase.Models;
using BoardgameDatabase.Services;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Http;

namespace BoardgameDatabase.Controllers
{
    public class BoardgameController : Controller
    {
        private IRepoService _service;

        public BoardgameController(IRepoService service)
        {
            _service = service;

        }
        #region BoardgameActions
        // GET: BoardgameController
        public ActionResult Index()
        {
            List<Boardgame> data = _service.GetBoardgames();
            return View(data);
        }

        // GET: BoardgameController/Details/5
        public ActionResult Details(int id)
        {
            Boardgame data = _service.GetBoardgameById(id);
            return View(data);
        }

        // GET: BoardgameController/Create
        public ActionResult Create()
        {
            List<SelectListItem> people = new List<SelectListItem>();

            foreach (var adress in _service.GetAdresses())
            {
                people.Add(new SelectListItem(adress.ToString(), adress.Name));
            }
            ViewBag.People = people;
            return View();
        }

        // POST: BoardgameController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Boardgame boardgame)
        {

            try
            {
                _service.AddBoardgame(boardgame);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BoardgameController/Edit/5
        public ActionResult Edit(int id)
        {
            Boardgame data = _service.GetBoardgameById(id);
            List<SelectListItem> people = new List<SelectListItem>();
            foreach (var adress in _service.GetAdresses())
            {
                people.Add(new SelectListItem(adress.ToString(), adress.Name));
            }
            ViewBag.People = people;
            return View(data);
        }

        // POST: BoardgameController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Boardgame boardgame)
        {
            try
            {
                _service.UpdateBoardgame(boardgame);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BoardgameController/Delete/5
        public ActionResult Delete(int id)
        {
            Boardgame data = _service.GetBoardgameById(id);
            return View(data);
        }

        // POST: BoardgameController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                _service.DeleteBoardgame(id);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
        #endregion
    }
}
