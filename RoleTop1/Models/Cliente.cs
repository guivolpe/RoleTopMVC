namespace RoleTop.Models
{
    public class Cliente
    {
        public string Nome {get;set;}
        public string CPF {get;set;}
        public string Email {get;set;}
        public string CEP {get;set;}
        public string Logradouro{get;set;}
        public string Complemento{get;set;}
        public string Telefone {get;set;}
        public string Senha {get;set;}
        public ushort TipoUsuario {get;set;}

        public Cliente()
        {

        }

        public Cliente(string nome, string cpf, string email, string cep, string logradouro, string complemento, string telefone, string senha)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Email = email;
            this.CEP = cep;
            this.Logradouro = logradouro;
            this.Complemento = complemento;
            this.Telefone = telefone;
            this.Senha = senha;
            this.TipoUsuario = 1;
        }
    }
}