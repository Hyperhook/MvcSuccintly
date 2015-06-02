using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcSuccintly.Models
{
    [MetadataType(typeof (ItineraryItemAttributes))]
    public class ItineraryItem
    {
        public DateTime? When { get; set; }
        public string Description { get; set; }
        public int? Duration { get; set; }
        public bool IsActive { get; set; }
        public bool? Confirmed { get; set; }
        /*[UIHint("Phone")]
        public string ContactNumber { get; set; }*/
    }
}