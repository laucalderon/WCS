
using System;
using System.Collections.Generic;

namespace HELPERS
{
    public interface ICrud<T>
    {
       T Enviar(T entidad);
       T Actualizar(T entidad);
       T Consultar(int id);
       IList<T> Listado();
       void Eliminar(int id);

    }
}




