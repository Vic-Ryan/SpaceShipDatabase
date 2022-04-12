﻿using System;
using System.ComponentModel.DataAnnotations;

namespace SP.Data
{
    public class Ship
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public Guid OwnerId { get; set; }
        [Required]
        public string ShipName { get; set; }
        public DateTimeOffset Created_At { get; set; }
        //[ForeignKey(nameof(Origin))]
        public int? OriginId { get; set; }
        //public virtual Origin Origin { get; set; } 
        [Required]
        public string Manufacturer { get; set; }
        [Required]
        public string ShipSize { get; set; } //Maybe an int?
        [Required]
        public string ShipPurpose { get; set; }
        [Required]
        public string CaptainName { get; set; }
        [Required]
        public int CrewSize { get; set; }
        [Required]
        public string Capacity { get; set; }
        [Required]
        public string TopSpeed { get; set; } //Also maybe an int?
    }
}