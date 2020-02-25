using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HotelManager.Models.HotelDB
{
    public class Room
    {
        public Room()
        {
            Reservations = new List<Reservation>();
        }

        [Required]
        public int ID { get; set; }

        [Required]
        public int Capacity { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public double AdultPrice { get; set; }

        [Required]
        public double KidPrice { get; set; }

        [Required]
        public string Number { get; set; }

        List<Reservation> Reservations { get; set; }
    }
}