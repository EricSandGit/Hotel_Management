using System.Collections.Generic;

namespace WinFormsApp1.Persistencia
{
    public interface IRepositorio<T>
    {
        List<T> ObtenerTodos();
        T ObtenerPorId(int id);
        int Agregar(T entidad);
        bool Actualizar(T entidad);
        bool Eliminar(int id);
    }
}
