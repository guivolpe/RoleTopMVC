using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTop.Repositories;
using RoleTop.ViewModels;
using RoleTop.Models;
using RoleTop.Enums;

namespace RoleTop.Controllers
{
    public class ContratoController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        ContratoRepository contratoRepository = new ContratoRepository();

        public IActionResult Index()
        {
            ContratoViewModel contrato = new ContratoViewModel();

            var UsuarioLogado = ObterUsuarioSession();
            var NomeUsuarioLogado = ObterUsuarioNomeSession();
            if(!string.IsNullOrEmpty(NomeUsuarioLogado)){
                contrato.NomeUsuario = NomeUsuarioLogado;
            }

            var ClienteLogado = clienteRepository.ObterPor(UsuarioLogado);
            if(ClienteLogado != null){
                contrato.Cliente = ClienteLogado;
            }
            contrato.NomeView = "Contrato";
            contrato.NomeUsuario = ObterUsuarioNomeSession();
            contrato.UsuarioEmail = ObterUsuarioSession();
            return View(contrato);
        }
        
        public IActionResult Contratar(IFormCollection form)
        {
            Contrato contrato = new Contrato();
            Evento evento = new Evento(DateTime.Parse(form["data"]),
            form["tipo"], 
            form["convidados"], 
            form["privacidade"], 
            form["servicos"]);
            evento.Cliente = clienteRepository.ObterPor(ObterUsuarioSession());
            contrato.Evento = evento;
            contrato.Cliente = evento.Cliente;
            if(contratoRepository.Inserir(contrato))
            {
                return View("Sucesso", new RespostaViewModel(){
                    Mensagem = "Aguarde a aprovação dos nosso administradores",
                    NomeView = "Contrato",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            } else {
                return View("Erro", new RespostaViewModel(){
                    Mensagem = "Houve um erro ao processar seu pedido, tente novamente.",
                    NomeView = "Contrato",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
        public IActionResult Aprovar(uint id)
        {
            
            contratoRepository.AtualizarEstado(id,"Aprovar");
            Contrato contrato = contratoRepository.ObterPor(id);

            if (contratoRepository.Atualizar(contrato))
            {
                return RedirectToAction("Dashboard", "Administrador");
            } else {
                return View("Erro", new RespostaViewModel(){
                    Mensagem = "Houve um erro ao aprovar seu pedido.",
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
            
        }
        public IActionResult Reprovar(uint id)
        {
            contratoRepository.AtualizarEstado(id,"Reprovar");
            Contrato contrato = contratoRepository.ObterPor(id);
            if (contratoRepository.Atualizar(contrato))
            {
                return RedirectToAction("dashboard", "Administrador");
            } else {
                return View("Erro", new RespostaViewModel(){
                    Mensagem = "Houve um erro ao reprovar seu pedido.",
                    NomeView = "Dashboard",
                    UsuarioEmail = ObterUsuarioSession(),
                    UsuarioNome = ObterUsuarioNomeSession()
                });
            }
        }
    }
}