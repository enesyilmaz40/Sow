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
    public class WordRepository : Repository<Word>, IWordRepository
    {
        private Context _context => Context as Context;
        public WordRepository(Context context) : base(context)
        {
        }

        public async Task<IEnumerable<Word>> GetWordsWithEvent()
        {
            return await _context.Words.Include(x => x.Event).ToListAsync();
        }
    }
}
