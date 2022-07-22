using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MVC.App.Models;

namespace MVC.App.Controllers
{
    public class UsersController : Controller
    {
        // GET: UsersController
        public ActionResult Index()
        {
            return View("Edit", new UserViewModel());
        }

        // GET: UsersController/Details/5
        public ActionResult Details(UserViewModel userViewModel)
        {
            return View(userViewModel);
        }

        // GET: UsersController/Create
        public ActionResult Create(UserViewModel userViewModel)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction(nameof(Details), userViewModel);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
