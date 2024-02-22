using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TasteFoodIt.Entity
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
    }
}