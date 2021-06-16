using System;

namespace Series
{
    public class Serie : EntidadeBasecs // a classe serie herda da entidade base
    {
        // Atributos
        private Genero Genero { get; set; }
        private string Titulo { get; set; }
        private string Descricao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }
           
        // Métodos
        public Serie(int id, Genero genero, string Titulo, string Descricao, int ano)
        {
            this.Id = id;
            this.Genero = Genero;
            this.Titulo = Titulo;
            this.Descricao = Descricao;
            this.Ano = Ano;
            this.Excluido = false;
        }

        public override string ToString()
        {
            
            string retorno = "";
            retorno += "Gênero:" + this.Genero + Environment.NewLine;
            retorno += "Título:" + this.Titulo + Environment.NewLine;
            retorno += "Descrição:" + this.Descricao + Environment.NewLine;
            retorno += "Ano de Inicio:" + this.Ano + Environment.NewLine;
            retorno += "Excluido:" + this.Excluido;
            return retorno;
           
        }

        public string retornaTitulo()
        {
            return this.Titulo;

        }

          public int retornaId()
        {
            return this.Id;

        }

          public void Excluir()
        {
            this.Excluido = true;

        }

          public bool retornaExcluido()
        {
            return this.Excluido;

        }
    }
}