namespace RoleTop.Models
{
    public class Contrato
    {
        public Cliente Cliente {get;set;}
        public Evento Evento {get;set;}

        public Contrato()
        {
            this.Cliente = new Cliente();
            this.Evento = new Evento();
        }
    }
}