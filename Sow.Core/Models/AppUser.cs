using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sow.Core.Models
{
   public class AppUser:IdentityUser<int>
    {
        public string NameSurname { get; set; }
        public string ImageUrl { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] passwordHash2 { get; set; }


        public List<Blog> Blogs { get; set; }
        public List<Event> Events { get; set; }
        public List<Score> Scores { get; set; }













        public virtual ICollection<Message> WriterSender { get; set; }
        public virtual ICollection<Message> WriterReceiver { get; set; }



    }
}
