using Sow.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sow.Core.Repository
{
   public interface IEventRepository:IRepository<Event>
    {
        Task<IEnumerable<Event>> GetListWithWord();
        Task<IEnumerable<Event>> GetListWithWordByWriter(int id);
      
    }
}
