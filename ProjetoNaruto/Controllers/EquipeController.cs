using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL;
using BLL.Impl;
using BLL.Interfaces;
using Common;
using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoNaruto.Models;
using ProjetoNaruto.Query;

namespace ProjetoNaruto.Controllers
{
    [Authorize]
    public class EquipeController : Controller
    {
        private readonly IGenninService _gvc;
        private readonly IJounninService _jvc;
        private readonly IEquipeService _svc;

        public EquipeController(IGenninService gvc, IJounninService jvc, IEquipeService svc)
        {
            _gvc = gvc;
            _jvc = jvc;
            _svc = svc;
        }

        public async Task<IActionResult> Cadastrar()
        {
            List<GenninDTO> gennin = await _gvc.GetGennins();
            List<JounninDTO> jounnin = await _jvc.GetJounnin();
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<GenninDTO, GenninQueryViewModel>();
                cfg.CreateMap<JounninDTO, JounninQueryViewModel>();
            });

            IMapper mapper = configuration.CreateMapper();

            List<GenninQueryViewModel> dadosGennin = mapper.Map<List<GenninQueryViewModel>>(gennin);
            List<JounninQueryViewModel> dadosJounnin = mapper.Map<List<JounninQueryViewModel>>(jounnin);

            ViewBag.Gennins = dadosGennin;
            ViewBag.Jounnins = dadosJounnin;

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