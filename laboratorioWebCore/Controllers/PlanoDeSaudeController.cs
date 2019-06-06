using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LaboratorioWebCore.Models;
using LaboratorioWebCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace LaboratorioWebCore.Controllers
{
    public class PlanoDeSaudeController : Controller
    {
        private readonly PlanoDeSaudeService planoDeSaudeService;

        public PlanoDeSaudeController(PlanoDeSaudeService planoDeSaudeService)
        {
            this.planoDeSaudeService = planoDeSaudeService;
        }

        public IActionResult Listar()
        {
            return View(planoDeSaudeService.GetAll());
        }

        public IActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Novo(PlanoDeSaude plano)
        {
            if (ModelState.IsValid)
            {
                planoDeSaudeService.Save(plano);
                return RedirectToAction("Listar");
            }           
            return View(plano);
        }
    }
}