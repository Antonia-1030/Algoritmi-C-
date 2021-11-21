using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proekt_v2.Models
{
    public class InRepair
    {
        public int Id { get; set; }

        public int? ServicesId { get; set; }
        public virtual Services Services { get; set; }

        [Required]
        [StringLength(120)]
        public string ProductName { get; set; }
        [StringLength(120)]
        public string ClientName { get; set; }

        [Required]
        [Range(1, 9999, ErrorMessage = "Невалиден номер!")]
        public int ProductNumber { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(10.0, 500.00, ErrorMessage = "Цената не влиза в лимита от 10.0 до 200.0 !")]
        public decimal TotalPrice { get; set; }

        [DataType(DataType.Date)]
        public DateTime Received { get; set; }
        [DataType(DataType.Date)]
        public DateTime Returning { get; set; }

        public virtual ICollection<Reviews> Reviews { get; set; }
    }
}