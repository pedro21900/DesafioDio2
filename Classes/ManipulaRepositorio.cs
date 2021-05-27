using System;
using System.Collections.Generic;
using Desafiodio5.Interfaces;
namespace Desafiodio5.Classes
{
    public class ManipulaRepositorio : Interfaces<Serie>
    {
        private List<Serie> listaSeries = new List<Serie>();
        public void Atualiza(int id, Serie entidade)
        {
            listaSeries[id]=entidade;
        }

        public void Exclui(int id)
        {
            listaSeries[id].Exclui();
        }

        public void Insere(Serie entidade)
        {
           listaSeries.Add(entidade);
        }

        public List<Serie> Listar()
        {
           return listaSeries;
        }

        public int PreoximoId()
        {
           return listaSeries.Count;
        }

        public Serie RetornaPorId(int id)
        {
           return listaSeries[id];
        }
    }


}