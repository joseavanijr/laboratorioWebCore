
using System;
using System.Collections.Generic;
using LaboratorioWebCore.Models;
using LaboratorioWebCore.Services;
using Microsoft.AspNetCore.Mvc;

namespace LaboratorioWebCore.Controllers
{
    public class CidadeController : Controller
    {
        protected readonly CidadeService cidadeService;

        public CidadeController(CidadeService cidadeService)
        {
            this.cidadeService = cidadeService;
        }

        public ActionResult Listar()
        {
            return View(cidadeService.GetAll());
        }

        public ActionResult Novo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Novo(Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                cidadeService.Save(cidade);
            }
            return RedirectToAction("Listar");
        }

        public ActionResult Editar(Guid id)
        {
            return View(cidadeService.GetById(id));
        }

        [HttpPost]
        public ActionResult Editar(Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                cidadeService.Save(cidade);
            }
            return RedirectToAction("Listar");
        }

        public ActionResult Excluir(Guid id)
        {
            return View(cidadeService.GetById(id));
        }

        [HttpPost]
        public ActionResult Excluir(Cidade cidade)
        {
            if (ModelState.IsValid)
            {
                cidadeService.Delete(cidade);
            }
            return RedirectToAction("Listar");
        }

        #region Usando PARTVIEW
        //Faço com Cidade e Estado e os alunos com Plano e Paciente
        public ActionResult ListarComFiltroPorEstado()
        {
            return View();
        }









        public ActionResult ListarPorEstado(Estado estado)
        {
            IEnumerable<Cidade> cidades = cidadeService.GetByEstado(estado);
            return PartialView("_ListarCidades", cidades);
        }

        public ActionResult ListarPorEstadoPraCliente(Estado estado)
        {
            IEnumerable<Cidade> cidades = cidadeService.GetByEstado(estado);
            return PartialView("_ListarCidadesNoCLiente", cidades);
        }
        #endregion
    }
}