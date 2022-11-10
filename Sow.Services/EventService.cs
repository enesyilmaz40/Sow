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
    public class EventService : IEventService
    {
        private readonly IUnitOfWork _uow;

        public EventService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Event> Create(Event item)
        {
            await _uow.Events.AddAsync(item);
            await _uow.SaveAsync();
            return item;
        }

        public async Task Delete(int id)
        {
            var value = await _uow.Events.GetByIdAsync(id);
            _uow.Events.Remove(value);
            await _uow.SaveAsync();
        }

        public async Task<IEnumerable<Event>> GetAll()
        {
            return await _uow.Events.GetAllAsync();
        }

        public async Task<Event> GetById(int id)
        {
            return await _uow.Events.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Event>> GetListWithWord()
        {
            return await _uow.Events.GetListWithWord();
        }

        public async Task<IEnumerable<Event>> GetListWithWordByWriter(int id)
        {
            return await _uow.Events.GetListWithWordByWriter(id);
        }

        public async Task Update(Event item)
        {
            _uow.Events.Update(item);
            await _uow.SaveAsync();
        }
    }
}
