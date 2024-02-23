using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H3ArT.Models.Models
{
    public class Category
    {
        [Key]
        public int categoryId { get; set; }

        [Required]
        [DisplayName("Category Name")]
        public string categoryName { get; set; }

        [DisplayName("Display Order")]
        public int displayOrder { get; set; }
    }
}
