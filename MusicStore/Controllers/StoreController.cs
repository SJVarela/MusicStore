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
        // GET: Store
        public ActionResult Index()
        {
            return View(new List<Genre>
            {
                new Genre {Name = "Disco" },
                new Genre {Name = "Jazz" },
                new Genre {Name = "Rock" }
            });
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