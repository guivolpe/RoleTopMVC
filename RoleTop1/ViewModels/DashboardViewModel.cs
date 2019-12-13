using System.Collections.Generic;
using RoleTop.Models;

namespace RoleTop.ViewModels
{
    public class DashboardViewModel : BaseViewModel
    {
        public List<Contrato> Contratos {get;set;}
        public ushort ContratosAprovados {get;set;}
        public ushort ContratosPendentes {get;set;}
        public ushort ContratosReprovados {get;set;}
        public DashboardViewModel()
        {
            this.Contratos= new List<Contrato>();
        }
    }
}