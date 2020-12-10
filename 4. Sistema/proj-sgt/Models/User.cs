using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proj_sgt.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "E-mail")]
        public String Email { get; set; }

        [Display(Name = "Senha")]
        public String Password { get; set; }

        [Display(Name = "Nome")]
        public String Name { get; set; }

        [Display(Name = "Cargo")]
        public UserType Occupation { get; set; }

    }
} 