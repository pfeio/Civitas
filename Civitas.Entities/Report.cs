using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Civitas.Entities
{
    public class Report
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        [Required]
        public Location Location { get; set; }
        public DateTime Creation { get; set; }

        [Required]
        public User Reporter { get; set; } 
        public List<Vote> Support{ get; set;}


    }
}
