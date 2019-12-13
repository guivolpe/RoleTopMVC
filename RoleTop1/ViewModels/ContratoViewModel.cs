using RoleTop.Models;

namespace RoleTop.ViewModels
{
    public class ContratoViewModel : BaseViewModel
    {
        public Cliente Cliente {get;set;}
        public Evento Evento {get;set;}
        public string NomeUsuario {get;set;}
        public ContratoViewModel(){
            this.Cliente = new Cliente();
            this.Evento = new Evento();
        }
    }
}