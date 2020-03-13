using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Interfaces;
using Common;
using DTO;
using Microsoft.AspNetCore.Mvc;
using ProjetoNaruto.Models;
using ProjetoNaruto.Query;

namespace ProjetoNaruto.Controllers
{
    public class BatalhaController : Controller
    {
        private readonly IBatalhaService _bvc;
        private readonly IEquipeService _svc;


        public BatalhaController(IBatalhaService bvc, IEquipeService svc)
        {
            _bvc = bvc;
            _svc = svc;
        }
        public async Task<IActionResult> Cadastrar()
        {
            List<EquipeDTO> equipe = await _svc.GetEquipes();

            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<EquipeDTO, EquipeQueryViewModel>();
            });

            IMapper mapper = configuration.CreateMapper();

            List<EquipeQueryViewModel> dadosEquipe = mapper.Map<List<EquipeQueryViewModel>>(equipe);

            ViewBag.Batalhas = dadosEquipe;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(BatalhaViewModel viewModel)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BatalhaViewModel, BatalhaDTO>();
            });

            IMapper mapper = configuration.CreateMapper();
            BatalhaDTO batalha = mapper.Map<BatalhaDTO>(viewModel);

            try
            {
                await _bvc.Insert(batalha);
                return RedirectToAction("Index", "Home");
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