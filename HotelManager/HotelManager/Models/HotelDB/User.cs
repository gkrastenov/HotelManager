using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelManager.Models
{
    public class User
    {
        public User()
        {
            Reservations = new List<Reservation>();
        }

        public int ID { get; set; }

        [Required]
        public string UserID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string MiddleName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string EGN { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public DateTime HireDate { get; set; }

        [Required]
        public bool IsActive { get; set; }

        public DateTime? FiredDate { get; set; }

        [Required]
        public bool IsAdmin { get; set; }

        public List<Reservation> Reservations { get; set; }
    }
}