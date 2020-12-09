using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsPersistent.Data;
using TechJobsPersistent.Models;
using TechJobsPersistent.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsPersistent.Controllers
{
    public class EmployerController : Controller
    {
        private JobDbContext Context;

        public EmployerController(JobDbContext context)
        {
            Context = context;
        }

        // GET: /<controller>/   //Employer

        public IActionResult Index()
        {
            List<Employer> employers = Context.Employers.ToList();
            return View(employers);
        }

        // /Employer/Add    //GET
        public IActionResult Add()
        {
            AddEmployerViewModel viewModel = new AddEmployerViewModel();
            return View(viewModel);
        }

        //POST       /Employer/ProcessAddEmplyerForm
        public IActionResult ProcessAddEmployerForm(AddEmployerViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                Employer employer = new Employer
                {
                    Name = viewModel.Name,
                    Location = viewModel.Location
                };

                Context.Employers.Add(employer);
                Context.SaveChanges();

                return Redirect("/Employer");
            }
            return View("Add", viewModel);
            }

            //GET         /Employer/About/{id}
            public IActionResult About(int id)
        {
                Employer employer = Context.Employers.Find(id);
                return View(employer);
            }
    }
}
