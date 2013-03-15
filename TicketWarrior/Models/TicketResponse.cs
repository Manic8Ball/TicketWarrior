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

        public string Address
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
        public string State
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public bool MailedOrPickUp
        {
            get;
            set;
        }
    }
}