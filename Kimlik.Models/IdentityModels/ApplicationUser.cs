﻿using Kimlik.Models.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kimlik.Models.IdentityModels
{
    public class ApplicationUser:IdentityUser
    {
        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        [Required]
        [StringLength(25)]
        public string Surname { get; set; }
        public DateTime Register { get; set; } = DateTime.Now;

        public virtual List<Message> Messages { get; set; } = new List<Message>();
    }
}
