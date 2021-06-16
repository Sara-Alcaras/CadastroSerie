using System;
using System.Collections.Generic;

namespace Series.Interfaces
{
    public interface IRepositorio<T>
    {
         List<T> Lista(); //Método que chama lista e retorna uma Lista de T
         T RetornaPorId(int id); // Passa o id por parametro
         void Insere(T entidade);
         void Exclui(int id);
         void Atualiza(int id, T entidade);
         int ProximoId();
    }
}