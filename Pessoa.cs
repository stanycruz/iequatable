using System;

namespace iequatable
{
    internal class Pessoa : IEquatable<Pessoa>
    {
        private string nome;
        private string cpf;
        private string rg;
        private DateTime dataNascimento;

        public Pessoa(string nome, string cpf, string rg, DateTime dataNascimento)
        {
            this.nome = nome;
            this.cpf = cpf;
            this.rg = rg;
            this.dataNascimento = dataNascimento;
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }

        public DateTime DataNascimento
        {
            get { return dataNascimento; }
            set { dataNascimento = value; }
        }

        public override string ToString()
        {
            return $"[Nome: {this.nome}, CPF: {this.cpf}, RG: {this.rg}, Data Nascimento: {this.dataNascimento}]";
        }

        public bool Equals(Pessoa outro)
        {
            if (outro == null) return false;

            return
                this.nome.Equals(outro.nome) &&
                this.cpf.Equals(outro.cpf) &&
                this.rg.Equals(outro.rg) &&
                this.dataNascimento.Equals(outro.dataNascimento);
        }

        public override bool Equals(object obj)
        {
            var outro = obj as Pessoa;

            if (outro == null) return false;

            return this.Equals(obj);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                return
                    this.nome.GetHashCode() ^
                    this.cpf.GetHashCode() ^
                    this.rg.GetHashCode() ^
                    this.dataNascimento.GetHashCode();
            }
        }
    }
}
