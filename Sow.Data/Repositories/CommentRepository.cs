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
    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        private Context _context => Context as Context;
        public CommentRepository(Context context) : base(context)
        {
        }

        public async Task<IEnumerable<Comment>> GetListWithBlog()
        {
            return await _context.Comments.Include(x => x.Blog).ToListAsync();
        }
    }
}
