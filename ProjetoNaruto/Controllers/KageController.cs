using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using AutoMapper;
using BLL.Impl;
using BLL.Interfaces;
using Common;
using DTO;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
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
            if (await _svc.Autenticar(nome, senha) != null)
            {
                var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Name, nome)
                    };
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                var principal = new ClaimsPrincipal(identity);
                var props = new AuthenticationProperties();
                HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal, props).Wait();
                ViewBag.UsuarioLogado = true;
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
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
                return RedirectToAction("Index", "Home");
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