﻿using Sow.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sow.Core.Repository
{
   public interface IScoreRepository:IRepository<Score>
    {
        Task<IEnumerable<Score>> GetScoresWithUser(int id);
    }
}
