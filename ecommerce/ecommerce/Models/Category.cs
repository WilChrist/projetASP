using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models
{
    public class Category
    {
        
        private int refCategory;
        private String nameCategory;
        private ICollection<Article> articles;
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RefCategory { get => refCategory; set => refCategory = value; }

        [Required]
        public string NameCategory { get => nameCategory; set => nameCategory = value; }

        public ICollection<Article> Articles { get => articles; set => articles = value; }
    }
}