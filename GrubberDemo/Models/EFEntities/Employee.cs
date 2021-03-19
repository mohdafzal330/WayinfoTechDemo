using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GrubberDemo.Models.EFEntities
{
    public class Employee
    {
        [Key]
        [Column(Order=1)]
        [Required]
        public long PkEmployeeId { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public int RowStatus { get; set; }
    }
}