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
    public class JounninController : Controller
    {
        private readonly IJounninService _svc;

        public JounninController(IJounninService svc)
        {
            _svc = svc;
        }

        public IActionResult Cadastrar()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(JounninViewModel viewModel)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<JounninViewModel, JounninDTO>();
            });
            IMapper mapper = configuration.CreateMapper();
            JounninDTO jounnin = mapper.Map<JounninDTO>(viewModel);

            try
            {
                await _svc.Insert(jounnin);
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