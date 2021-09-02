using Microsoft.EntityFrameworkCore;
using MODELOS;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UTILES;

namespace ACCESO
{
    public interface IContext<T> : ICrud<T>
    {

    }
    public class Context<T> : IContext<T> where T:class, IBaseEntidad
    {
        private readonly DbSet<T> _items;
        private readonly HogwartsContext _context;

        public Context(HogwartsContext context)
        {
            _context = context;
            _items = context.Set<T>();
                
        }
        public T Actualizar(T entidad)
        {
            _items.Update(entidad);
            _context.SaveChanges();

            return entidad;
        }

        public T Consultar(int id)
        {
            var entidad = _items.FirstOrDefault(x => x.Id == id);
           
            return entidad;
        }

        public void Eliminar(int id)
        {
            var entidad = _items.FirstOrDefault(x => x.Id == id);
            if (entidad!= null)
            {
                _items.Remove(entidad);
                _context.SaveChanges();
            }
           
        }

        public T Enviar(T entidad)
        {
            _items.Add(entidad);
            _context.SaveChanges();
            return entidad;
        }

        public IList<T> Listado()
        {
           return _items.ToList();
        }
    }
}
