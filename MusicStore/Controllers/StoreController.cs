using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MusicStore.Models;

namespace MusicStore.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities storeDb = new MusicStoreEntities();
        // GET: Store
        public ActionResult Index()
        {
            return View(storeDb.Genres.ToList());
        }
        public ActionResult Browse(string genre)
        {
            return View(new Genre { Name = genre});
        }
        public ActionResult Details(int id)
        {
            return View(new Album { Title = "Album "+ id});
        }
    }
}