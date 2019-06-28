using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace InfoManager.Models
{
    public class CategoryOfInfo
    {
        [Key]
        [Required]
        public int CategoryOfInfoID { get; set; }

        public string Description { get; set; }
    }
}