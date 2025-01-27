using AcunMedyaPortfolioProject.Models;
using System;
using System.Linq;
using System.Web.Mvc;

namespace AcunMedyaPortfolioProject.Views.Statistic
{
    public class StatisticController : Controller
    {
        // Veritabanı bağlamı
        PortfolioDbEntities db = new PortfolioDbEntities();

        // GET: Statistic
        public ActionResult Statistic()
        {
            var totalProjects = db.Projects.Count();
            var totalCategories = db.Categories.Count();
            var totalExperiences = db.Experiences.Count();

            ViewBag.TotalProjects = totalProjects;
            ViewBag.TotalCategories = totalCategories;
            ViewBag.TotalExperiences = totalExperiences;

            return View();
        }
    }
}
