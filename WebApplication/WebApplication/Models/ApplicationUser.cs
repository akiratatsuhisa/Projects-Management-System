﻿using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication.Models
{
    public class ApplicationUser : IdentityUser
    {
        [PersonalData]
        [Required]
        [StringLength(256)]
        public string FirstName { get; set; }

        [PersonalData]
        [Required]
        [StringLength(256)]
        public string LastName { get; set; }

        [PersonalData]
        public bool Gender { get; set; }

        [Column(TypeName = "date")]
        [PersonalData]
        [Required]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        public virtual Lecturer Lecturer { get; set; }

        public virtual Student Student { get; set; }

    }
}
