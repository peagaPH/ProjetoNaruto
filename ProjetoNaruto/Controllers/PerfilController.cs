using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ProjetoNaruto.Controllers
{
    public class PerfilController : Controller
    {
        
        private readonly IKageService _svc;
        public PerfilController(IKageService svc)
        {
            _svc = svc;
        }
            
        public IActionResult Index()
        {
            return View();
        }
    }
}