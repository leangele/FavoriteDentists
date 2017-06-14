﻿using System;

namespace FavoriteDentists.Models
{
    public class Treatment
    {

        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Price { get; set; }
        public string Detail { get; set; }


    }
}