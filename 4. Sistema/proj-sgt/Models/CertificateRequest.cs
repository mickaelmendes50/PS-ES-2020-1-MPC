using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proj_sgt.Models
{
    public class CertificateRequest
    {
        [Required]
        public int Id { get; set; }

        //public User User { get; set; }

        //[Display(Name = "Usuário")]
        //public int UserId { get; set; }

        [Display(Name = "Carga Horária")]
        public int Workload { get; set; }

        [Display(Name = "Data Solicitação")]
        public DateTime Date { get; set; }

        [Display(Name = "Aprovado")]
        public Boolean IsApproved { get; set; }
    }
}