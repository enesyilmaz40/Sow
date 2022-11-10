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
    public class ScoreRepository : Repository<Score>, IScoreRepository
    {
        private Context _context => Context as Context;
        public ScoreRepository(DbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Score>> GetScoresWithUser(int id)
        {
            return await _context.Scores.Include(x => x.ScoreCount).Where(y => y.AppUserId == id).ToListAsync();
        }
    }
}
