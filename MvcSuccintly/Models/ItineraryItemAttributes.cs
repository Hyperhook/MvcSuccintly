using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Web.Mvc;

namespace MvcSuccintly.Models
{
    class ItineraryItemAttributes
    {
        [Required(ErrorMessage = "You must specify a date")]
        [Remote("VerifyAvailability", "Itinerary", AdditionalFields = "Description")]
        public DateTime? When { get; set; }

        [Required(ErrorMessage = "You must set a description")]
        [MaxLength(140, ErrorMessage = "Description must be less than 140 chars")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required(ErrorMessage = "You must specify how long the event will last")]
        [Range(1, 120, ErrorMessage = "Event should be between one minute and two hours")]
        [RegularExpression(@"\d{1,3}", ErrorMessage = "Only numbers allowed")]
        public int? Duration { get; set; }
    }
}
