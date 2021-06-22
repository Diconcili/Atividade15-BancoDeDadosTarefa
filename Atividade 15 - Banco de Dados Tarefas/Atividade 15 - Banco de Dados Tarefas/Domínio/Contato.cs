namespace Atividade_15___Banco_de_Dados_Tarefas
{
    class Contato
    {
        int id;
        string nome;
        string email;
        string empresa;
        string cargo;
        string telefone;

        public Contato(int id, string nome, string email, string empresa, string cargo,string telefone)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Empresa = empresa;
            this.Cargo = cargo;
            this.Telefone = telefone;
        }

        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public string Empresa { get => empresa; set => empresa = value; }
        public string Cargo { get => cargo; set => cargo = value; }

        public string Telefone { get => telefone; set => telefone = value; }
    }
}
