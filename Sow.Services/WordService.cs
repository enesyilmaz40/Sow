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
   public class WordService:IWordService
    {
        private readonly IUnitOfWork _uow;

        public WordService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Word> Create(Word item)
        {
            await _uow.Words.AddAsync(item);
            await _uow.SaveAsync();
            return item;
        }

        public async Task Delete(int id)
        {
            var value = await _uow.Words.GetByIdAsync(id);
            _uow.Words.Remove(value);
            await _uow.SaveAsync();
        }

        public async Task<IEnumerable<Word>> GetAll()
        {
            return await _uow.Words.GetAllAsync();
        }

        public async Task<Word> GetById(int id)
        {
            return await _uow.Words.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Word>> GetWordsWithEvent()
        {
            return await _uow.Words.GetWordsWithEvent();
        }

        public async Task Update(Word item)
        {
            _uow.Words.Update(item);
            await _uow.SaveAsync();
        }
    }
}
