using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BLL;
using BLL.Interfaces;
using Common;
using DTO;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ProjetoNaruto.Models;

namespace ProjetoNaruto.Controllers
{
    [Authorize]
    public class GenninController : Controller
    {
        private readonly IGenninService _svc;

        public GenninController(IGenninService svc)
        {
            _svc = svc;
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(GenninViewModel viewModel)
        {

            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<GenninViewModel, GenninDTO>();
            });

            IMapper mapper = configuration.CreateMapper();
            GenninDTO dto = mapper.Map<GenninDTO>(viewModel);

            try
            {
                await _svc.Insert(dto);
                return RedirectToAction("Index", "Home");
            }
            catch (ExameException ex)
            {
                ViewBag.Errors = ex.Errors;
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
            }
            return View();
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}