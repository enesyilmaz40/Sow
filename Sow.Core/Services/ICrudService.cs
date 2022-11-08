using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sow.Core.Services
{
   public interface ICrudService<T> 
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetById(int id);
        Task<T> Create(T item);
        Task Update(T item);
        Task Delete(int id);

    }
}
