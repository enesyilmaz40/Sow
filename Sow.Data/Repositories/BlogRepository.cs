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
    public class BlogRepository : Repository<Blog>, IBlogRepository
    {
        private Context _context => Context as Context;
        public BlogRepository(Context context) : base(context)
        {
        }

        public async Task<IEnumerable<Blog>> GetListWithCategory()
        {
            return await _context.Blogs.Include(x => x.Category).ToListAsync();

        }

        public async Task<IEnumerable<Blog>> GetListWithCategoryByWriter(int id)
        {
            return await _context.Blogs.Include(x => x.Category).Where(x => x.AppUserID == id).ToListAsync();




        }
    }
}
