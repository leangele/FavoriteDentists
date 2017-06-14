using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace FavoriteDentists.Models
{
    public class Patient
    {

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Identification { get; set; }
        public int Age { get; set; }
        public string ContactNumber { get; set; }
        public string ContactName { get; set; }
        public DateTime LastAppointment { get; set; }
        public DateTime NextAppointment { get; set; }
        public ICollection<Treatment> Treatments { get; set; }
    }
}