using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelManager.Models
{
    public class Reservation
    {
        public Reservation()
        {
            Clients = new List<Client>();
        }

        [Required]
        public int ID { get; set; }

        [Required]
        public int RoomID { get; set; }
        [Required]
        public Room Room { get; set; }

        [Required]
        public int UserID { get; set; }
        [Required]
        public User User { get; set; }

        [Required]
        public List<Client> Clients { get; set; }

        [Required]
        public DateTime ArrivalDate { get; set; }

        [Required]
        public DateTime DeparatureDate { get; set; }

        [Required]
        public bool HasBreakfast { get; set; }

        [Required]
        public bool IsAllInclusive { get; set; }

        [Required]
        public double Price { get; set; }

    }
}