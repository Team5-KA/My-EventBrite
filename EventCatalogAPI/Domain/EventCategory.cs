using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Domain
{
    public class EventCategory
    {
        
        public int Id { get; set; }
        public string Category { get; set; }
        
    }
}

