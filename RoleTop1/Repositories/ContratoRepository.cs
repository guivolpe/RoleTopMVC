using System;
using System.IO;
using RoleTop.Models;
using System.Collections.Generic;
using RoleTop.Enums;

namespace RoleTop.Repositories
{
    public class ContratoRepository : RepositoryBase
    {
        private const string PATH = "Database/Evento.csv";
        public ContratoRepository()
        {
            if(!File.Exists(PATH))
            {
                File.Create(PATH).Close();
            }
        }
        public bool Inserir(Contrato contrato){
            var quantidadeLinhas = File.ReadAllLines(PATH).Length;
            contrato.Evento.Id = (uint) ++quantidadeLinhas;
            var linha = new string[] {PrepararRegistroCSV(contrato)};
            File.AppendAllLines(PATH, linha);

            return true;
        }
        public List<Contrato> ObterTodos()
        {
            var linhas = File.ReadAllLines(PATH);
            List<Contrato> contratos = new List<Contrato>();
            foreach(var linha in linhas)
            {
                Contrato contrato = new Contrato();
                contrato.Evento.Id = uint.Parse(ExtrairValorDoCampo("id", linha));
                contrato.Evento.Status = ushort.Parse(ExtrairValorDoCampo("status_pedido", linha));
                contrato.Cliente.Nome = ExtrairValorDoCampo("cliente_nome", linha);
                contrato.Cliente.CPF = ExtrairValorDoCampo ("cliente_cpf", linha);
                contrato.Cliente.Telefone = ExtrairValorDoCampo("cliente_telefone", linha);
                contrato.Cliente.Email = ExtrairValorDoCampo("cliente_email", linha);
                contrato.Evento.Tipo = ExtrairValorDoCampo("evento_tipo", linha);
                contrato.Evento.Data = DateTime.Parse(ExtrairValorDoCampo("evento_data", linha));
                contrato.Evento.Convidados = ExtrairValorDoCampo("evento_convidados", linha);
                contrato.Evento.Privacidade = ExtrairValorDoCampo("evento_privacidade", linha);
                contrato.Evento.Servicos = ExtrairValorDoCampo("evento_servicos", linha);
                contratos.Add(contrato);
            }
            return contratos;
        }

        private string PrepararRegistroCSV(Contrato contrato)
        {
            Cliente cliente = contrato.Cliente;
            Evento evento = contrato.Evento;
            return $"id={evento.Id};status_pedido={evento.Status};cliente_nome={cliente.Nome};cliente_cpf={cliente.CPF};cliente_telefone={cliente.Telefone};cliente_email={cliente.Email};evento_tipo={evento.Tipo};evento_data={evento.Data};evento_convidados={evento.Convidados};evento_privacidade={evento.Privacidade};evento_servicos={evento.Servicos}";
        }

        public Contrato ObterPor(uint id)
        {
            var contratosTotais = ObterTodos();
            foreach(var contrato in contratosTotais)
            {
                if(contrato.Evento.Id == id)
                {
                    return contrato;
                }
            }
            return null;
        }

        public List<Contrato> ObterTodosPorCliente(string email)
        {
            var contratosTotais = ObterTodos();
            List<Contrato> contratosCliente = new List<Contrato>();
            foreach(var contrato in contratosTotais)
            {
                if(contrato.Cliente.Email.Equals(email)){
                    contratosCliente.Add(contrato);
                }
            }
                return contratosTotais;
        }

        public void AtualizarEstado(uint id,string NovoEstado){
            Contrato contrato = ObterPor(id);
            int linha = 0;
            if(NovoEstado == "Aprovar"){
                contrato.Evento.Status = (ushort) StatusContrato.APROVADO;
            }else if(NovoEstado == "Reprovar")
            {
                contrato.Evento.Status = (ushort) StatusContrato.REPROVADO;
            }
            var contratosTotais = ObterTodos();
            for(int i=0; i < contratosTotais.Count; i++)
            {
                if(contratosTotais[i].Evento.Id == id)
                {
                    linha = i;
                    break;
                }
            }
            var linhas = File.ReadAllLines(PATH);    
            linhas[linha] = PrepararRegistroCSV(contrato);
            File.WriteAllLines(PATH,linhas);
        }

        public bool Atualizar(Contrato contrato)
        {
            var contratosTotais = File.ReadAllLines(PATH);
            var agendamentoCSV = PrepararRegistroCSV(contrato);
            var linhaContrato = -1;
            var resultado = false;
            var id = contrato.Evento.Id;
            for(int i = 0 ; i < contratosTotais.Length ; i++)
            {
                var idConvertido = uint.Parse((ExtrairValorDoCampo("id", contratosTotais[i])));
                if(id.Equals(idConvertido))
                {
                    linhaContrato = i;
                    resultado = true;
                    break;
                }
            }
            if(!resultado)
            {
                contratosTotais[linhaContrato] = agendamentoCSV;
                File.WriteAllLines(PATH, contratosTotais);
            }
            return resultado;
        }
    }
}