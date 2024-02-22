using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TasteFoodIt.Entity
{
    public class OpenDayHour
    {
        
        public int OpenDayHourID { get; set; }

        [StringLength(9)]
        [Required]
        public string DayName { get; set; }
        [StringLength(9)]
        public string OpenHourRange { get; set; }
    }
}