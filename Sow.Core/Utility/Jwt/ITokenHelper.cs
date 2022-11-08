using Sow.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sow.Core.Utility.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(AppUser user, IEnumerable<OperationClaim> operationClaims);


    }
}
