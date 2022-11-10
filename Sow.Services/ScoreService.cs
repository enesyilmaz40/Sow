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
   public class ScoreService:IScoreService
    {
        private readonly IUnitOfWork _uow;

        public ScoreService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<Score> Create(Score item)
        {
            await _uow.Scores.AddAsync(item);
            await _uow.SaveAsync();
            return item;
        }

        public async Task Delete(int id)
        {
            var value = await _uow.Scores.GetByIdAsync(id);
            _uow.Scores.Remove(value);
            await _uow.SaveAsync();
        }

        public async Task<IEnumerable<Score>> GetAll()
        {
            return await _uow.Scores.GetAllAsync();
        }

        public async Task<Score> GetById(int id)
        {
            return await _uow.Scores.GetByIdAsync(id);
        }

        public async Task<IEnumerable<Score>> GetScoresWithUser(int id)
        {
            return await _uow.Scores.GetScoresWithUser(id);
        }

        public async Task Update(Score item)
        {
            _uow.Scores.Update(item);
            await _uow.SaveAsync();
        }
    }
}
