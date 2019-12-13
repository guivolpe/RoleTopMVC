using Microsoft.AspNetCore.Mvc;
using RoleTop.Enums;
using RoleTop.Repositories;
using RoleTop.ViewModels;

namespace RoleTop.Controllers
{
    public class AdministradorController : AbstractController
    {
        ContratoRepository contratoRepository = new ContratoRepository();
        [HttpGet]
        public IActionResult Dashboard()
        {
            var tipoUsuarioSession = uint.Parse(ObterUsuarioTipoSession());
            if(tipoUsuarioSession.Equals((ushort) TipoUsuario.ADMINISTRADOR))
            {
            var contratos = contratoRepository.ObterTodos();
            DashboardViewModel dashboardViewModel = new DashboardViewModel();
            foreach(var contrato in contratos)
            {
                switch(contrato.Evento.Status)
                {
                case (ushort) StatusContrato.REPROVADO:
                    dashboardViewModel.ContratosReprovados++;
                break;
                case (ushort) StatusContrato.APROVADO:
                    dashboardViewModel.ContratosAprovados++;
                break;
                default:
                    dashboardViewModel.ContratosPendentes++;
                    dashboardViewModel.Contratos.Add(contrato);
                break;
                }
            }
            dashboardViewModel.NomeView = "Dashboard";
            dashboardViewModel.UsuarioEmail = ObterUsuarioSession();
            return View(dashboardViewModel);
            } else {
                return View("Erro", new RespostaViewModel(){
                    NomeView = "Dashboard",
                    Mensagem = "Você não é digno de entrar nesta tela."
                });
            }
        }
    }
}