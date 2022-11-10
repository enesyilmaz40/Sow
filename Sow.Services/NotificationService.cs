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
   public class NotificationService: INotificationService
    {
        private readonly IUnitOfWork _uow;

        public NotificationService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Notification> Create(Notification item)
        {
            await _uow.Notifications.AddAsync(item);
            await _uow.SaveAsync();
            return item;
        }

        public async Task Delete(int id)
        {
            var value = await _uow.Notifications.GetByIdAsync(id);
            _uow.Notifications.Remove(value);
            await _uow.SaveAsync();
        }

        public async Task<IEnumerable<Notification>> GetAll()
        {
            return await _uow.Notifications.GetAllAsync();
        }

        public async Task<Notification> GetById(int id)
        {
            return await _uow.Notifications.GetByIdAsync(id);
        }

        public async Task Update(Notification item)
        {
            _uow.Notifications.Update(item);
            await _uow.SaveAsync();
        }
    }
}
