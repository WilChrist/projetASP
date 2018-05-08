using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models
{
    public class Article
    {
        
        private int numArticle;
        private String name;
        private Double price;
        private int quantity;
        private String picture;
        private String description;
        private Category category;

        
        [Required]
        public string Name { get => name; set => name = value; }

        [Required]
        public double Price { get => price; set => price = value; }

        [Required]
        public int Quantity { get => quantity; set => quantity = value; }

        [Required]
        public string Picture { get => picture; set => picture = value; }

        [Required]
        public string Description { get => description; set => description = value; }

        [Required]
        public Category Category { get => category; set => category = value; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NumArticle { get => numArticle; set => numArticle = value; }
    }
}