using Sow.Core.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sow.Core
{
   public interface IUnitOfWork:IDisposable
    {
        IAdminRepository Admins { get; }
        IAppRoleRepository AppRoles { get; }
        IAppUserRepository AppUsers { get; }
        IBlogRepository Blogs { get; }
        ICategoryRepository Categories { get; }
        ICommentRepository Comments { get; }
        IEventRepository Events { get; }
        IMessageRepository Messages { get; }
        INotificationRepository Notifications { get; }
        IScoreRepository Scores { get; }
        IWordRepository Words { get; }
        Task<int> SaveAsync();
    }
}
