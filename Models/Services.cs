using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proekt_v2.Models
{
    public class Services
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }

        [StringLength(300, ErrorMessage = "Описанието на услугата не отговаря на изискванията.")]
        public string Description { get; set; }

        public bool IsAvailable { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        public decimal MaterialsPrice { get; set; }
        [DataType(DataType.Currency)]
        public decimal RepairPrice { get; set; }

        [Range(2, 30)]
        public int ExpectedRepairDays { get; set; }

        public virtual ICollection<InRepair> InRepair { get; set; }

    }
}