using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace WebApplication2.Models
{
    public class RunInput
    {
        
        [Display(Name = "Distance run")]
        [Required(ErrorMessage = "A distance is required")]
        public int Distance { get; set; }
        [Display(Name = "Time in minutes")]
        public int Time { get; set; }

        [Display(Name = "Heart Rate")]
        public int HeartRate { get; set; }
        public int Calories { get; set; }
        [Key]
        public DateTime ? Date { get; set; }

    }
}