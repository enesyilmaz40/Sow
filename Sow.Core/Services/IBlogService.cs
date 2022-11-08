﻿using Sow.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sow.Core.Services
{
   public interface IBlogService:ICrudService<Blog>
    {
        Task<IEnumerable<Blog>> GetListWithCategory();
        Task<IEnumerable<Blog>> GetListWithCategoryByWriter(int id);
    }
}
