using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proekt_v2.Models
{
    public class Reviews
    {
        public int Id { get; set; }
        public int InRepairId { get; set; }
        public virtual InRepair InRepair { get; set; }

        [Required]
        [StringLength(120, MinimumLength = 3)]
        public string Client { get; set; }
        [StringLength(20)]
        public string Title { get; set; }
        [StringLength(800)]
        public string Comment { get; set; }

        [DataType(DataType.Date)]
        public DateTime Published { get; set; }

        [Range(1, 5)]
        public int Rating { get; set; }
        public long Reads { get; set; }
    }
}