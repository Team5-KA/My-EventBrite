using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Domain
{
    public class EventItem
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string PictureUrl { get; set; }

        public int EventTypeId { get; set; }
        public int EventCategoryId { get; set; }
        public int EventSubCategoryId { get; set; }

        public EventType EventType { get; set; }
        public EventCategory EventCategory { get; set; }
        public EventSubCategory EventSubCategory { get; set; }
        public EventLocation Location { get; set; }
        public EventDateAndTime DateAndTime { get; set; }
        public int DateAndTimeId { get; set; }
        public int LocationId { get; set; }

        public int Price { get; set;}
        public string Contact { get; set; } 


        // public int EventDateAndTimeId { get; set; }
        // public int EventLocationId { get; set; }

        // public EventDateAndTime EventDateAndTime { get; set; }
        //public EventLocation EventLocation { get; set; }

        //public int EventOrganizerID { get; set; }

        //public EventOrganizer EventOrganizer { get; set; }
    }
}
