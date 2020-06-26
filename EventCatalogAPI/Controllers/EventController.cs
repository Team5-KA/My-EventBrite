using EventCatalogAPI.Data;
using EventCatalogAPI.Domain;
using EventCatalogAPI.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace EventCatalogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EventController : ControllerBase
    {
        private readonly EventContext _context;
        private readonly IConfiguration _config;

        public EventController(EventContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        // To get display of events with pagenumber, counts tec. on top.

        [HttpGet("[action]")]
        public async Task<IActionResult> EventItems(
            [FromQuery] int pageIndex = 0,
            [FromQuery] int pageSize = 6)
        {
            var eventItemsCount = await _context.EventItems.LongCountAsync();

            var eventItems = await _context.EventItems
                            .OrderBy(c => c.Title)
                            .Skip(pageIndex * pageSize)
                            .Take(pageSize)
                            .ToListAsync();

            eventItems = ChangePictureUrl(eventItems);

            var model = new PaginatedItemsViewModel<EventItem>
            {
                PageIndex = pageIndex,
                PageSize = eventItems.Count,
                Count = eventItemsCount, 
                Data = eventItems
            };
            
            return Ok(model);
        }

        //To replace url
        private List<EventItem> ChangePictureUrl(List<EventItem> eventItems)
        {
            eventItems.ForEach(eventItem =>
                eventItem.PictureUrl = eventItem.PictureUrl.Replace(
                                    "http://externaleventbaseurltobereplaced",
                                    _config["ExternalCatalogBaseUrl"]));
            return eventItems;
        }

        //To filter based on Types
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> EventTypes()
        {
            var types = await _context.EventTypes.ToListAsync();
            return Ok(types);
        }

        //Filter based on Categories
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> EventCategories()
        {
            var categories = await _context.EventCategories.ToListAsync();
            return Ok(categories);
        }

        //Filter based on subcategories
        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> EventSubCategories()
        {
            var subCategories = await _context.EventSubCategories.ToListAsync();
            return Ok(subCategories);
        }

                
        [HttpGet("[action]/type/{eventTypeId}/category/{eventCategoryId}/subCategory/{eventSubCategoryId}")]
        public async Task<IActionResult> EventItems(
            int? eventTypeId,
            int? eventCategoryId,
            int? eventSubCategoryId,
            [FromQuery] int pageIndex = 0,
            [FromQuery] int pageSize = 6
            )
        {
            var query = (IQueryable<EventItem>)_context.EventItems;

     
            if (eventTypeId.HasValue)
            {
                query = query.Where(c => c.EventTypeId == eventTypeId);
            }

            if (eventCategoryId.HasValue)
            {
                query = query.Where(c => c.EventCategoryId == eventCategoryId);
            }

            if (eventSubCategoryId.HasValue)
            {
                query = query.Where(c => c.EventSubCategoryId == eventSubCategoryId);
            }

            var eventItemsCount = await query.LongCountAsync();

            var eventItems = await query
                            .OrderBy(c => c.Title)
                            .Skip(pageIndex * pageSize)
                            .Take(pageSize)
                            .ToListAsync();

            eventItems = ChangePictureUrl(eventItems);

            var model = new PaginatedItemsViewModel<EventItem>
            {
                PageIndex = pageIndex,
                PageSize = eventItems.Count,
                Count = eventItemsCount,
                Data = eventItems
            };

            return Ok(model);
        }
        
    }
}
