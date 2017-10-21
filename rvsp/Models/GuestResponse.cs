using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace rvsp.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage ="Prosze podać prawidłowe imię")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Prosze podać prawidłowe nazwisko")]
        public string Surname { get; set; }
        [RegularExpression(".+\\@.+\\..+",
        ErrorMessage ="Prosze podac prawidlowy adres email")]
        public string Email{ get; set; }
        [RegularExpression("^\\d+$",
            ErrorMessage ="Prosze podac prawidlowy numer telefonu")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Prosze okreslic, czy wezmiesz udzial")]
        public bool? WillAttend { get; set; }
    }
}