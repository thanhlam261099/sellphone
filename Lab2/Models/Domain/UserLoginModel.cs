using Lab2.Models.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models
{
    public class UserLoginModel
    {   
        
        [Required(ErrorMessage = "Email is required.")]
        public string Email { get; set; }
       
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        public bool RememberMe { get; set; }  
        public string ReturnUrl { get; set; }
    }
}
