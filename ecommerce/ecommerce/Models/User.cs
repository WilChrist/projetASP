using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace ecommerce.Models
{
    public class User
    {
        
        private String email;
        private String login;
        private String password;
        private String firstname;
        private String lastname;
        private String city;
        private String phone;
        private String type;
        private ICollection<Order> order;

        [Key]
        public string Email { get => email; set => email = value; }

        public string Login { get => login; set => login = value; }

        [Required]
        [StringLength(15, MinimumLength = 3)]
        public string Password { get => password; set => password = value; }

        [Required]
        public string Firstname { get => firstname; set => firstname = value; }

        [Required]
        public string Lastname { get => lastname; set => lastname = value; }

        public string City { get => city; set => city = value; }
        public string Phone { get => phone; set => phone = value; }

        [Required]
        public string Type { get => type; set => type = value; }

        public ICollection<Order> Order { get => order; set => order = value; }
    }
}