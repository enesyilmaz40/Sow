using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sow.Core.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }

        public string EventName { get; set; }
        public string EventDescription { get; set; }
        public string EventImage { get; set; }
        public bool EventStatus { get; set; }
        public DateTime EventCreateDate { get; set; }
        public DateTime EventLastDate{ get; set; }


        [ForeignKey("AppUserID")]
        public int AppUserID { get; set; }
        public AppUser AppUser { get; set; }

        public List<Word> Words { get; set; }
        public List<Blog> Blogs { get; set; }
       



    }
}
