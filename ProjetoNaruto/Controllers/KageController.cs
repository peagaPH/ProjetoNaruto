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


        [HttpGet]
            public ActionResult Cadastrar()
            {
                return View();
            }
            public ActionResult Login()
            {

                return View();
            }

            [HttpPost]
            public async Task<ActionResult> Login(string nome, string senha)
            {
                try
                {
                    KageDTO kage = await _svc.Autenticar(nome, senha);
                    Response.Cookies.Append("USERIDENTITY", kage.ID.ToString());
                    var TESTE = Request.Cookies["USERIDENTITY"].ToString();
                    return RedirectToAction("Index", "Home");
                }
                catch (Exception ex)
                {
                    ViewBag.Erros = ex.Message;
                }
                return View();
            }

            [HttpPost]
            public async Task<ActionResult> Cadastrar(KageViewModel viewModel)
            {

                var configuration = new MapperConfiguration(cfg =>
                {
                    cfg.CreateMap<KageViewModel, KageDTO>();
                });

                IMapper mapper = configuration.CreateMapper();
            // new SERService().GetSERByID(4);
            //Transforma o ClienteInsertViewModel em um ClienteDTO
            KageDTO dto = mapper.Map<KageDTO>(viewModel);
                try
                {
                    await _svc.Insert(dto);
                    //Se funcionou, redireciona pra página inicial
                    return RedirectToAction("Home", "Index");
                }
                catch (ExameException ex)
                {
                    //Se caiu aqui, o ClienteService lançou a exceção por validação de campos
                    ViewBag.ValidationErrors = ex.Errors;
                }
                catch (Exception ex)
                {
                    //Se caiu aqui, o ClienteService lançou uma exceção genérica, provavelmente por falha de acesso ao banco
                    ViewBag.ErrorMessage = ex.Message;
                }
                //Se chegou aqui, temos erro
                return View();
            }

        
    
    }
}