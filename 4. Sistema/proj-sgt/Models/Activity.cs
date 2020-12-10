using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace proj_sgt.Models
{
    public class Activity
    {
        [Required]
        public int Id { get; set; }

        [Display(Name = "Descrição")]
        public String Description { get; set; }

        [Display(Name = "Time")]
        public String Team { get; set; }

        [Display(Name = "Tempo gasto em horas")]
        public int TimeSpentInHours { get; set; }

        [Display(Name = "Data Inicial")]
        [DisplayFormat(DataFormatString =
        "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime InicialDate { get; set; }

        [Display(Name = "Data Final")]
        [DisplayFormat(DataFormatString =
        "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? FinalDate { get; set; }

        //public User User { get; set; }

        //[Display(Name = "Usuario")]
        //public int UserId { get; set; }
    }
}