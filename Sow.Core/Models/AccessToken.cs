using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sow.Core.Models
{
    public class AccessToken
    {
        [Key]
        public string Token { get; set; }
        public DateTime Expiration { get; set; }
    }
}
