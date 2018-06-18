﻿using System;

namespace mallform.Models
{
    public class Rent
    {

        public int Id { get; set; }
        public DateTime startDate { get; set; }

        public DateTime endDate { get; set; }

        public string Amount { get; set; }

        public Tenant Tenant { get; set; }

        public Unit Unit { get; set; }
    }
}