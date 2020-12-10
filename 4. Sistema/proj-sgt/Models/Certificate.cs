using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proj_sgt.Models
{
    public class Certificate
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Usuário")]
        public String Name { get; set; }

        [Display(Name = "Carga Horaria")]
        public int Workload { get; set; }

        [Display(Name = "Data Emissão")]
        public DateTime EmissionDate { get; set; }


        //public User User { get; set; }

        //[Display(Name = "Usuário")]
        //public int UserId { get; set; }

        // public Boolean DirectorSignature { get; set; }

        // public Boolean AdvisorSignature { get; set; }
    }
}