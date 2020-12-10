using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proj_sgt.Models
{
    public class Occurrence
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Justificativa")]
        public String Justification { get; set; }

        [Display(Name = "Data")]
        public DateTime Date { get; set; }

        public CertificateRequest CertificateRequest { get; set; }

        [Display(Name = "Requisição")]
        public int CertificateRequestId { get; set; }
    }
}