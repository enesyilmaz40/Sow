﻿using Sow.Core.Dtos;
using Sow.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sow.Core.Services
{
   public interface IAuthService
    {
        Task<AppUser> Login(UserForLoginDto userForLoginDto);
        Task<AppUser> Register(UserForRegisterDto userForRegisterDto, string password);
        Task<AppUser> Update(UserForRegisterDto user, string password);
        bool UserExist(string email);
        AccessToken CreateAccessToken(AppUser user);
    }
}
