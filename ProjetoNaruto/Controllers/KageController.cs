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
    public class KageController : Controller
    {
        private readonly IKageService _svc;

        public KageController(IKageService svc)
        {
            _svc = svc;
        }
            public IActionResult Cadastrar()
            {
                return View();
            }
            public IActionResult Login()
            {
                return View();
            }

            [HttpPost]
            public async Task<IActionResult> Login(string nome, string senha)
            {
                try
                {
                    KageDTO kage = await _svc.Autenticar(nome, senha);
                    Response.Cookies.Append("USERIDENTITY", kage.ID.ToString());
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception ex)
                {
                    ViewBag.Erros = ex.Message;
                }
                return View();
            }

        [HttpPost]
        public async Task<IActionResult> Cadastrar(KageViewModel viewModel)
        {
            var configuration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<KageViewModel, KageDTO>();
            });
            IMapper mapper = configuration.CreateMapper();
            KageDTO kage = mapper.Map<KageDTO>(viewModel);
            try
            {
                await _svc.Insert(kage);
                return RedirectToAction("Home", "Index");
            }
            catch (ExameException ex)
            {
                ViewBag.Errors = ex.Errors;
                return View();
            }
            catch (Exception ex)
            {
                ViewBag.ErroGenerico = ex.Message;
                return View();
            }


        }

        
    
    }
}