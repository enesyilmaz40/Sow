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
    public class AppUserRepository : Repository<AppUser>, IAppUserRepository
    {
        private Context _context => Context as Context;
        public AppUserRepository(Context context) : base(context)
        {
        }

        public IEnumerable<OperationClaim> GetClaims(AppUser user)
        {
            var result = from uoc in _context.UserOperationClaims
                         join oc in _context.OperationClaims
                         on uoc.Id equals oc.Id
                         where uoc.UserId == user.Id
                         select new OperationClaim { Id = oc.Id, Name = oc.Name };
            return result.ToList();
        }
    }
}
