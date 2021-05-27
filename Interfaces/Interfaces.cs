using System.Collections.Generic;
namespace Desafiodio5.Interfaces
{
    public interface Interfaces<T>
    {
        List<T> Listar();
        T RetornaPorId(int id);
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id , T entidade);
        int PreoximoId();
    }
}