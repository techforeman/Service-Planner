using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ServicePlanner.Models
{
    public class Method
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Method Name")]
        public string MethodName { get; set; }

        [Required]
        [Display(Name = "Norm of method")]
        public string NormName { get; set; }

        [Required]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
