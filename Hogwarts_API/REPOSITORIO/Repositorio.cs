using ACCESO;
using System;
using System.Collections.Generic;
using UTILES;

namespace REPOSITORIO
{
    public interface IRepositorio<T> : ICrud<T>
    {

    }

    public class Repositorio<T> : IRepositorio<T>
    {
        private readonly IContext<T> _context;

        public Repositorio(IContext<T> context)
        {
            _context = context;
        }
        public T Actualizar(T entidad)
        {
           return _context.Actualizar(entidad);
        }

        public T Consultar(int id)
        {
           return _context.Consultar(id);
           
        }

        public void Eliminar(int id)
        {
            _context.Eliminar(id);
        }
        public T Enviar(T entidad)
        {
           return _context.Enviar(entidad);
        }

        public IList<T> Listado()
        {
            return _context.Listado();
        }
    }
}
