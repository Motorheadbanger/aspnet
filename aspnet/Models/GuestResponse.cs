using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace aspnet.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage="Please, submit the name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please, submit the e-mail address")]
        [RegularExpression(".+\\@.+\\..+", ErrorMessage="Incorrect e-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Please, submit the phone number")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Please, submit your decision")]
        public bool? WillAttend { get; set; }
    }
}