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
    public class AppRoleRepository : Repository<AppRole>, IAppRoleRepository
    {
        public AppRoleRepository(Context context) : base(context)
        {
        }
    }
}
