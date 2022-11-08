﻿using Sow.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sow.Core.Services
{
   public interface ICommentService:ICrudService<Comment>
    {
        Task<IEnumerable<Comment>> GetListWithBlog();
    }
}
