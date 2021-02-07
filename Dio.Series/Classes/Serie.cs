using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dio.Series
{
    public class Serie :EntidadeBase
    {
        private Genero Genero { get; set; } //genereo é um enum
        private string titulo { get; set; }
        private string Descrcao { get; set; }
        private int Ano { get; set; }
        private bool Excluido { get; set; }

        //contrutor
        //Metodos - 
        public Serie(int id, Genero genero, string titulo, string descricao, int ano)
        {
            this.Id = id;
            this.Genero = genero;
            this.titulo = titulo;
            this.Descrcao = descricao;
            this.Ano = ano;
            this.Excluido = false;
        }

        //retorno
        public override string ToString()
        {
            string retorno = "";
            retorno += "Genero: " +  this.Genero + Environment.NewLine;
            retorno += "Titulo: " +  this.titulo + Environment.NewLine;
            retorno += "Descricao: " + this.Descrcao + Environment.NewLine;
            retorno += "Ano: " + this.Ano + Environment.NewLine;
            retorno += "Excluida: " + this.Excluido;
            return retorno;
       }

        //Encapsulaento
        public string retornaTitulo()
        {
            return this.titulo;
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
