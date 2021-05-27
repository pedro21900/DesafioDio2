using System;
namespace Desafiodio5.Classes
{
    public class Serie : EntidadeBase
    {
        //Atributos 
        public string Titulo {get; set;}
        public string Descrição {get; set;}
        public int Ano {get; set;}
        public Tipos tipoSerie {get; set;}
        private bool Excluido {get; set;}

         //Métodos 
        public Serie (int id ,Tipos tipo, string titulo , string descrição,int ano)
        {
            this.Id=id;
            this.Titulo=titulo;
            this.Descrição=descrição;
            this.Ano=ano;
            this.tipoSerie=tipo;
            this.Excluido=false;

        }

        public override string ToString()
        {
            string retorno="";
            retorno +="Gênero : " + this.tipoSerie + Environment.NewLine;
            retorno +="Título : " + this.Titulo + Environment.NewLine;
            retorno +="Descrição : " + this.Descrição + Environment.NewLine;
            retorno +="Ano : " + this.Ano + Environment.NewLine;
            retorno +="Excluido : " + this.Excluido;


            return retorno;
        }
        public string retornaTitulo(){
            return this.Titulo;
        }
        public int retornaId(){
            return this.Id;
        }
         public bool retornaExcluido(){
            return this.Excluido;
        }
        public void Exclui(){
            this.Excluido=true;
        }
    }
}