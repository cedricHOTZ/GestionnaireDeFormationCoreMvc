using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AvisFormationsCore.Web.UI.Models;
using Data;
using Microsoft.AspNetCore.Mvc;

namespace AvisFormationsCore.Web.UI.Controllers
{
    public class FormationController : Controller
    {
        public IActionResult Index()
        {
            var vm = new ToutesLesFormationsViewModel();
            vm.Message = "Coucou";
            vm.Nombre = 10;
            return View(vm);
        }
        public IActionResult ToutesLesFormations()
        {
            FormationMemoryRepository repository = new FormationMemoryRepository();
            var ListFormations = repository.GetAllFormation();

            return View(ListFormations);

           
        }
    }
}