using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace TicketWarrior.Models
{
    public class TicketResponse
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string Name
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please enter your address")]
        public string Address
        {
            get;
            set;
        }
        [Required(ErrorMessage = "Please enter your city")]
        public string City
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please enter your state")]
        public string State
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please enter your email address")]
        [RegularExpression(".+\\@.+\\..+",
        ErrorMessage = "Please enter a valid email address")]
        public string Email
        {
            get;
            set;
        }

        [Required(ErrorMessage = "Please choose delivery type")]
        public bool MailedOrPickUp
        {
            get;
            set;
        }
    }
}