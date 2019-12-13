using System;
using RoleTop.Enums;

namespace RoleTop.Models
{
    public class Evento
    {
        public DateTime Data {get;set;}
        public string Tipo {get;set;}
        public string Convidados {get;set;}
        public string Privacidade {get;set;}
        public string Servicos {get;set;}
        public Cliente Cliente{get;set;}
        public uint Id {get;set;}
        public ushort Status {get;set;}

        public Evento()
        {

        }

        public Evento(DateTime data, string tipo, string convidados, string privacidade, string servicos)
        {
            this.Data = data;
            this.Tipo = tipo;
            this.Convidados = convidados;
            this.Privacidade = privacidade;
            this.Servicos = servicos;
            this.Cliente = new Cliente();
            this.Id = 0;
            this.Status = (ushort) StatusContrato.PENDENTE;
        }
    }
}