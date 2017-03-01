using Indexer;
using Indexer.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace indexEngine.Controllers
{
    public class PathsController : Controller
    {

        private Facade facade = new Facade();
        // GET: Paths
        public ActionResult Index()
        {
            return View();
        }

        public void PostCompany(Paths path)
        {
            facade.GetPathsRepository().Add(path);

        }
    }
}