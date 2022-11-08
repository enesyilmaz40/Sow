using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sow.Core.Models
{
    public class Word
    {
        [Key]
        public int WordID { get; set; }
        public string WordName { get; set; }


        public int EventID { get; set; }
        public Event Event { get; set; }


    }
}
