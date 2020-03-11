using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Impl;
using BLL.Interfaces;
using Common;
using DTO;
using Microsoft.AspNetCore.Mvc;
using ProjetoNaruto.Models;

namespace ProjetoNaruto.Controllers
{
    public class EquipeController : Controller
    {
        private readonly IEquipeService _svc;

        public EquipeController(IEquipeService svc)
        {
            _svc = svc;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(EquipeViewModel viewModel)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EquipeViewModel, EquipeDTO>();
            });
            IMapper mapper = configuration.CreateMapper();
            EquipeDTO equipe = mapper.Map<EquipeDTO>(viewModel);

            try
            {
                await _svc.Insert(equipe);
                return RedirectToAction("Index", "Produto");
            }
            catch (ExameException ex)
            {
                ViewBag.Errors = ex.Errors;
            }
            catch (Exception ex)
            {
                ViewBag.ErroGenerico = ex.Message;
            }
            return View();
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}