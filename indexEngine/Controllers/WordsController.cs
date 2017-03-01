using Indexer;
using Indexer.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace indexEngine.Controllers
{
    public class WordsController : Controller
    {
        private Facade facade = new Facade();
        // GET: Words
        public ActionResult Index()
        {
            return View();
        }

        public void PostCompany(Words word)
        {
            facade.GetWordsRepository().Add(word);

        }
    }
}