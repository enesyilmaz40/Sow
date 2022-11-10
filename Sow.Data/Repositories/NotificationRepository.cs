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
    public class NotificationRepository : Repository<Notification>, INotificationRepository
    {
        private Context _context => Context as Context;
        public NotificationRepository(DbContext context) : base(context)
        {
        }
    }
}
