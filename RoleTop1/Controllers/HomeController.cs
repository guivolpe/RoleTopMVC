using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RoleTop.Controllers;
using RoleTop.ViewModels;

namespace RoleTop.Controllers
{
    public class HomeController : AbstractController
    {
        public IActionResult Index()
        {
            
            return View(new BaseViewModel(){
                NomeView = "Home",
                UsuarioNome = ObterUsuarioNomeSession(),
                UsuarioEmail = ObterUsuarioSession()
            });
        }
    }
}