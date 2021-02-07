using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dio.Series.Interfaces
{
   public  interface IReporitorio<T>
    {
        List<T> Lista();
        T RetornoPorId(int id);
        void Insere(T entidade);
        void Exclui(int id); // T entidade);
        void Atualiza(int id, T entidade);
        int ProximoId();

    }
}
