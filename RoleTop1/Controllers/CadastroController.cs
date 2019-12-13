using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RoleTop.Models;
using RoleTop.Repositories;
using RoleTop.ViewModels;

namespace RoleTop.Controllers
{
    public class CadastroController : AbstractController
    {
        ClienteRepository clienteRepository = new ClienteRepository();
        public IActionResult Index()
        {
            return View(new RespostaViewModel(){
                NomeView = "Cadastro",
                UsuarioEmail = ObterUsuarioSession(),
                UsuarioNome = ObterUsuarioNomeSession()
            });
        }
        public IActionResult Cadastrar(IFormCollection form)
        {
            try{
                if(form["senha"] == form["confirmar-senha"]){
                    Cliente cliente = new Cliente(
                        form["nome"], 
                        form["cpf"],
                        form["email"], 
                        form["cep"], 
                        form["logradouro"], 
                        form["complemento"], 
                        form["telefone"], 
                        form["senha"]);
                    clienteRepository.Inserir(cliente);
                    if (form["nome"] == "Administrador"){
                        return View("Index", new RespostaViewModel (" * Esse nome não é válido * "));
                    } else {
                    return View("Sucesso", new RespostaViewModel("O cliente foi cadastrado com sucesso."));
                    }
                }
                return View("Index", new RespostaViewModel(" * As senhas não são iguais *"));

            } catch(Exception e) {
                System.Console.WriteLine(e.StackTrace);
                return View("Erro", new RespostaViewModel("O cadastro não pode ser concluído."));
            }
        }
    }
}