﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Civitas.Entities
{
    public class Report
    {
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public Guid Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        //public Location Location { get; set; }
        public DateTime Creation { get; set; }

        //[Required]
        //public User Reporter { get; set; } 



    }
}
