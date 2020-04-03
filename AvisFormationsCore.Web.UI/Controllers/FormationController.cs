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
        //affiche toutes les formations
        public IActionResult ToutesLesFormations()
        {
            FormationMemoryRepository repository = new FormationMemoryRepository();
            var ListFormations = repository.GetAllFormation();

            return View(ListFormations);

           
        }

        //affiche la description d'une formation

        public IActionResult DetailFormation(string idformation)
        {
            int iIdformation = 1;
            if(!Int32.TryParse(idformation,out iIdformation))
            {
                return RedirectToAction("ToutesLesFormations");
            }
            FormationMemoryRepository repository = new FormationMemoryRepository();
            var formation = repository.GetFormationById(iIdformation);
            if(formation == null)
            {
                return RedirectToAction("ToutesLesFormations");
            }

            return View(formation);


        }
    }
}