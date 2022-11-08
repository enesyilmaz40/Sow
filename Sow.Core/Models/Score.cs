using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sow.Core.Models
{
    public class Score
    {
        [Key]
        public int ScoreId { get; set; }
        public int ScoreCount { get; set; }

        public int AppUserId { get; set; }
        public AppUser AppUser { get; set; }





    }
}
