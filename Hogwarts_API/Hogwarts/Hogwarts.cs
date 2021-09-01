using REPOSITORIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTILES;

namespace Hogwarts
{
   public interface IHogwarts<T>:ICrud<T>
    {
    }

    public class Hogwarts<T> : IHogwarts<T>
    {
        private readonly IRepositorio<T> _repositorio;

        public Hogwarts(IRepositorio<T> repositorio)
        {
            _repositorio = repositorio;
        }
        public T Actualizar(T entidad)
        {
            _repositorio.Actualizar(entidad);
            return entidad;
        }

        public T Consultar(int id)
        {
           T entidad= _repositorio.Consultar(id);
            return entidad;
        }

        public void Eliminar(int id)
        {
            _repositorio.Eliminar(id);
        }

        public T Enviar(T entidad)
        {
            _repositorio.Enviar(entidad);
            return entidad;
        }

        public IList<T> Listado()
        {
            return _repositorio.Listado();
        }
    }
}
