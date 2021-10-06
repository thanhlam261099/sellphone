using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Lab2.Models.Domain
{
    public class User : IdentityUser
    {
        [PersonalData]
        [Column(TypeName = "nvarchar(30)")]
        public string FirstName { get; set; }
        [PersonalData]
        [Column(TypeName = "nvarchar(30)")]
        public string LastName { get; set; }
    }
}
