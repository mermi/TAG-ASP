using Data.Models;
using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace GUI.Controllers
{
    public class ArticleController : Controller
    {
        IArticleService ause;
        public ArticleController(IArticleService ause)
        {
            this.ause = ause;
        }

        // GET: Article
        public ActionResult Index()
        {
            var l = ause.getAllArticles();
            return View(l);
        }

        // GET: Article/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Article/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Article/Create
        [HttpPost]
        public ActionResult Create(article a)
        {
                if (ModelState.IsValid)
                {
                    ause.AddArticle(a);
                    return RedirectToAction("Index");
                }
                else
                {
                    return View();
                }

           
        }

        // GET: Article/Edit/5
        public ActionResult Edit(int id)
        {
            article article = ause.getArticle(id);
            if (article == null)
            {
                return HttpNotFound();
            }
            return View();

        }

        // POST: Article/Edit/5
        [HttpPost]
        public ActionResult Edit(article a)
        {
            if (ModelState.IsValid)
            {
                ause.UpdateArticle(a);
                return RedirectToAction("Index");
            }
            return View();

        }

        // GET: Article/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Article/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
