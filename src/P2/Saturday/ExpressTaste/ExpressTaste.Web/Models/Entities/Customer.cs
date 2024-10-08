﻿using System.ComponentModel.DataAnnotations;

namespace ExpressTaste.Web.Models.Entities
{

    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [StringLength(50)] 
        public string Name { get; set; }

        [StringLength(50)] 
        public string Lastname { get; set; }

        [StringLength(25)]
        [EmailAddress]
        public string Email { get; set; }

        [StringLength(15)]
        [Phone]
        public string Phone { get; set; }

        public bool IsActive { get; set; }
        public char Gender { get; set; }

        public List<Order> Orders { get; set; }
    }
}
