using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CMS2020.Models
{
    public class Post
    {
        public int Id { get; set; }
        [Required]
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        [Required]
        [StringLength(100)]
        public String Subject { get; set; }
        [Required]
        [StringLength(5000)]
        public String Body { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime PublicationDate { get; set; }
        public String AuthorName { get; set; }
        public int Readers { get; set; }
        public String ImageUrl { get; set; }

    }
}
