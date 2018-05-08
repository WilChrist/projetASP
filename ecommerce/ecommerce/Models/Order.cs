using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ecommerce.Models
{
    public class Order
    {
        
        private int numOrder;
        private DateTime dateOrder;
        private User user;
        private List<Article> articles;
        private List<int> quantites;

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NumOrder { get => numOrder; set => numOrder = value; }

        [Required]
        public DateTime DateOrder { get => dateOrder; set => dateOrder = value; }

        [Required]
        public User User { get => user; set => user = value; }

        [Required]
        public virtual List<Article> Articles { get => articles; set => articles = value; }

        [Required]
        public virtual List<int> Quantites { get => quantites; set => quantites = value; }
    }
}