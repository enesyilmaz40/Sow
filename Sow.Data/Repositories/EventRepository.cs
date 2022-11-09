using Microsoft.EntityFrameworkCore;
using Sow.Core.Models;
using Sow.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sow.Data.Repositories
{
    public class EventRepository : Repository<Event>, IEventRepository
    {
        private Context _context => Context as Context;
        public EventRepository(Context context) : base(context)
        {
        }

        public async Task<IEnumerable<Event>> GetListWithWord()
        {
            return await _context.Events.Include(x => x.Words).ToListAsync();
        }

        public async Task<IEnumerable<Event>> GetListWithWordByWriter(int id)
        {
            return await _context.Events.Include(x => x.Words).Where(y => y.AppUserID == id).ToListAsync();
            //throw new NotImplementedException();
        }

        //public async Task<IEnumerable<Event>> GetListWithWordByWriter(int id)
        //{
        //    return await _context.Events.Include(x => x.Words).Where(y=>y)
        //}
    }
}
