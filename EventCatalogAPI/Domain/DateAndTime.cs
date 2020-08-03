using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Domain
{
    public class DateAndTime
    {
        public enum RecurrenceEnum
        {
            SingleEvent,
            RecurringEvent
        }
        public int Id { get; set; }
        public RecurrenceEnum Recurrence { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}
