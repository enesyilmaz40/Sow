using Sow.Core;
using Sow.Core.Models;
using Sow.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sow.Services
{
    public class AppUserService : IAppUserService
    {
        private readonly IUnitOfWork _uow;

        public AppUserService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<AppUser> Create(AppUser item)
        {
            await _uow.AppUsers.AddAsync(item);
            await _uow.SaveAsync();
            return item;
        }

        public async Task Delete(int id)
        {
            var item = await _uow.AppUsers.GetByIdAsync(id);
            _uow.AppUsers.Remove(item);
            await _uow.SaveAsync();
        }

        public async Task<IEnumerable<AppUser>> GetAll()
        {
            return await _uow.AppUsers.GetAllAsync();
        }

        public async Task<AppUser> GetById(int id)
        {
            return await _uow.AppUsers.GetByIdAsync(id);
        }

        public AppUser GetByMail(string email)
        {
            var userwithmail = _uow.AppUsers.FindQuery(u => u.Email == email);
            return userwithmail.FirstOrDefault();
        }
        public IEnumerable<OperationClaim> GetClaims(AppUser user)
        {
            return _uow.AppUsers.GetClaims(user);
        }
        public async Task Update(AppUser item)
        {
            _uow.AppUsers.Update(item);
            await _uow.SaveAsync();
        }
    }
}
