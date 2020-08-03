using EventCatalogAPI.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EventCatalogAPI.Data
{
    public static class CatalogSeed
    {
        public static void Seed(CatalogContext catalogContext)
        {
            //Migrate to database

            catalogContext.Database.Migrate();
            
            //DatesAndTimes

            if (catalogContext.DatesAndTimes.Any())
            {
                catalogContext.DatesAndTimes.RemoveRange(catalogContext.DatesAndTimes);
                catalogContext.SaveChanges();
            }
            if (!catalogContext.DatesAndTimes.Any())
            {
                catalogContext.DatesAndTimes.AddRange(GetDatesAndTimes());
                catalogContext.SaveChanges();
            }


            //ZipCodes
            if (catalogContext.ZipCodes.Any())
            {
                catalogContext.ZipCodes.RemoveRange(catalogContext.ZipCodes);
                catalogContext.SaveChanges();
            }
            if (!catalogContext.ZipCodes.Any())
            {
                catalogContext.ZipCodes.AddRange(GetEventZipCodes());
                catalogContext.SaveChanges();
            }

            // Locations
            if (catalogContext.Locations.Any())
            {
                catalogContext.Locations.RemoveRange(catalogContext.Locations);
                catalogContext.SaveChanges();
            }
            if (!catalogContext.Locations.Any())
            {
                catalogContext.Locations.AddRange(GetLocations());
                catalogContext.SaveChanges();
            }

            //EventTypes

            if (catalogContext.EventTypes.Any())
            {
                catalogContext.EventTypes.RemoveRange(catalogContext.EventTypes);
                catalogContext.SaveChanges();
            }
                
            if (!catalogContext.EventTypes.Any())
            {
                catalogContext.EventTypes.AddRange(GetEventTypes());
                catalogContext.SaveChanges();
            }

            //Event Categories

            if (catalogContext.EventCategories.Any())
            {
                catalogContext.EventCategories.RemoveRange(catalogContext.EventCategories);
                catalogContext.SaveChanges();
            }
            if (!catalogContext.EventCategories.Any())
            {
               catalogContext.EventCategories.AddRange(GetEventCategories());
               catalogContext.SaveChanges();
            }

            //Event Subcategories

            if (catalogContext.EventSubCategories.Any())
            {
                catalogContext.EventSubCategories.RemoveRange(catalogContext.EventSubCategories);
                catalogContext.SaveChanges();
            }

            if (!catalogContext.EventSubCategories.Any())
            {
                catalogContext.EventSubCategories.AddRange(GetEventSubCategories());
                catalogContext.SaveChanges();
            }

            //EventItems

            if (catalogContext.EventItems.Any())
            {
                catalogContext.EventItems.RemoveRange(catalogContext.EventItems);
                catalogContext.SaveChanges();
            }
            if (!catalogContext.EventItems.Any())
            {
                catalogContext.EventItems.AddRange(GetEventItems());
                catalogContext.SaveChanges();
            }

        }
    

        //Event Types
        private static IEnumerable<Domain.EventType> GetEventTypes()
        {
            return new List<Domain.EventType>
            {
                new Domain.EventType { Type = "Concert or Performance" },
                new Domain.EventType { Type = "Festival or Fair" },
                new Domain.EventType { Type = "Health & Wellness" }
            };
        }

        //Event Category
        private static IEnumerable<EventCategory> GetEventCategories()
        {
            return new List<EventCategory>
            {
                new EventCategory { Category = "Music" },
                new EventCategory { Category = "Seasonal & Holiday" },
                new EventCategory { Category = "Wellbeing" }
            };
        }

        //Event Subcategory
        private static IEnumerable<EventSubCategory> GetEventSubCategories()
        {
            return new List<EventSubCategory>
            {
                new EventSubCategory { SubCategory = "Father's Day" },
                new EventSubCategory { SubCategory = "Independence Day" },
                new EventSubCategory { SubCategory = "Jazz" },
                new EventSubCategory { SubCategory = "Ariana Grande" },
                new EventSubCategory { SubCategory = "Song Writing" },
                new EventSubCategory { SubCategory = "Mindfulness" },
                new EventSubCategory { SubCategory = "Ayurveda" },
                new EventSubCategory { SubCategory = "Yoga" }
            };
        }
        //Event Zipcodes
        private static IEnumerable<ZipCode> GetEventZipCodes()
        {
            return new List<ZipCode>
            {
                new ZipCode { Zipcode = 0 },
                new ZipCode { Zipcode = 95965 },
                new ZipCode { Zipcode = 98052 },
                new ZipCode { Zipcode = 98101 },
                new ZipCode { Zipcode = 98035 },
                new ZipCode { Zipcode = 98007 },
                
            };
        }

        //Event Location
        private static IEnumerable<Location> GetLocations()
        {
            return new List<Location>
            {
                new Location
                {
                    Id=1,
                    LocationType = Location.LocationEnum.Venue,
                    Address = "Oroville Airport, CA",
                    ZipCodeId = 2
                },
                new Location 
                {
                    Id=2,
                    LocationType = Location.LocationEnum.OnlineEvent,
                    ZipCodeId = 1
                },
                new Location
                {
                    Id=3,
                    LocationType = Location.LocationEnum.Venue,
                    Address = "Redmond High School audiotorium, Redmond WA",
                    ZipCodeId = 3
                },
                new Location
                {
                    Id=4,
                    LocationType = Location.LocationEnum.Venue,
                    Address = "XYZ Restaurant, Seattle, WA",
                    ZipCodeId = 4
                },
                new Location
                {
                    Id=5,
                    LocationType = Location.LocationEnum.Venue,
                    Address = "Dance Studio, Kent, WA",
                    ZipCodeId = 5
                },
                new Location
                {
                    Id=6,
                    LocationType = Location.LocationEnum.Venue,
                    Address = "Pacific Nothwest Fair, Seattle, WA",
                    ZipCodeId = 4
                },
                new Location
                {
                    Id=7,
                    LocationType = Location.LocationEnum.Venue,
                    Address = "Downtown Bellevue Park, WA",
                    ZipCodeId = 6
                },
                new Location
                {
                    Id=8,
                    LocationType = Location.LocationEnum.Venue,
                    Address = "Community Center, Bellevue, WA",
                    ZipCodeId = 6
                }

            };
        }

        //Event Dates and Times
        private static IEnumerable<DateAndTime> GetDatesAndTimes()
        {
            return new List<DateAndTime>
            {
                new DateAndTime
                {
                    Id=1,StartDateTime=new DateTime(2020,7,4,21,0,0,DateTimeKind.Local), EndDateTime=new DateTime(2020,7,4,22,0,0,DateTimeKind.Local), Recurrence=DateAndTime.RecurrenceEnum.SingleEvent
                },
                new DateAndTime
                {
                    Id=2,StartDateTime=new DateTime(2020,7,10,17,0,0,DateTimeKind.Local), EndDateTime=new DateTime(2020,7,10,19,0,0,DateTimeKind.Local), Recurrence=DateAndTime.RecurrenceEnum.SingleEvent
                },
                new DateAndTime
                {
                    Id=3,StartDateTime=new DateTime(2020,6,21,11,30,0,DateTimeKind.Local), EndDateTime=new DateTime(2020,6,21,13,30,0,DateTimeKind.Local),Recurrence=DateAndTime.RecurrenceEnum.SingleEvent
                },
                new DateAndTime
                {
                    Id=4,StartDateTime= new DateTime(2020,6,21,17,0,0,DateTimeKind.Local), EndDateTime=new DateTime(2020,6,21,17,0,0,DateTimeKind.Local),Recurrence=DateAndTime.RecurrenceEnum.SingleEvent
                },
                new DateAndTime
                {
                    Id=5,StartDateTime= new DateTime(2020,6,21,10,0,0,DateTimeKind.Local), EndDateTime=new DateTime(2020,6,21,18,0,0,DateTimeKind.Local),Recurrence=DateAndTime.RecurrenceEnum.SingleEvent
                },
                new DateAndTime
                {
                    Id=6,StartDateTime= new DateTime(2020,7,21,12,0,0,DateTimeKind.Local), EndDateTime=new DateTime(2020,7,21,18,0,0,DateTimeKind.Local),Recurrence=DateAndTime.RecurrenceEnum.SingleEvent
                },
                new DateAndTime
                {
                    Id=7,StartDateTime= new DateTime(2020,8,10,10,0,0,DateTimeKind.Local), EndDateTime=new DateTime(2020,8,10,11,0,0,DateTimeKind.Local),Recurrence=DateAndTime.RecurrenceEnum.SingleEvent
                },
                new DateAndTime
                {
                    Id=8,StartDateTime= new DateTime(2020,9,10,11,0,0,DateTimeKind.Local), EndDateTime=new DateTime(2020,9,10,12,0,0,DateTimeKind.Local),Recurrence=DateAndTime.RecurrenceEnum.SingleEvent
                },
                new DateAndTime
                {
                    Id=9,StartDateTime= new DateTime(2020,9,14,16,0,0,DateTimeKind.Local), EndDateTime=new DateTime(2020,9,14,18,0,0,DateTimeKind.Local),Recurrence=DateAndTime.RecurrenceEnum.SingleEvent
                },
                new DateAndTime
                {
                    Id=10,StartDateTime= new DateTime(2020,10,6,10,0,0,DateTimeKind.Local), EndDateTime=new DateTime(2020,10,6,11,0,0,DateTimeKind.Local),Recurrence=DateAndTime.RecurrenceEnum.SingleEvent
                },
                new DateAndTime
                {
                    Id=11,StartDateTime= new DateTime(2020,7,21,10,0,0,DateTimeKind.Local), EndDateTime=new DateTime(2020,7,21,12,0,0,DateTimeKind.Local),Recurrence=DateAndTime.RecurrenceEnum.SingleEvent
                },
                new DateAndTime
                {
                    Id=12,StartDateTime= new DateTime(2020,6,21,10,0,0,DateTimeKind.Local), EndDateTime=new DateTime(2020,6,21,12,0,0,DateTimeKind.Local),Recurrence=DateAndTime.RecurrenceEnum.SingleEvent
                }
            };

        }

        //Event Data - seeded data.

        private static IEnumerable<EventItem> GetEventItems()
        {
            return new List<EventItem>
            {
                new EventItem
                {
                    Title="Fourth of July Fireworks Show",
                    Description="The July 4, 2020 event starts at 9 p.m., but without a designated viewing area. The fireworks will be launched from the Oroville Airport on the west side of town in 2020, so it will be easier for residents to view the show from their front yards. Viewing is also possible from higher elevation points in the city or around Forebay or Afterbay, all while maintaining social distance from other spectators.",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/1",
                    EventTypeId = 2,
                    EventCategoryId = 2,
                    EventSubCategoryId = 2,
                    LocationId = 1,
                    Price=10,
                    Contact="Adarsha@gmail.com",
                    DateAndTimeId = 1,

                },
                new EventItem
                {
                    Title="July 4th : A Tribute to the American Spirit Concert",
                    Description="A Tribute to the American Spirit” will highlight the resilience of all Americans, honor our veterans, and celebrate Independence Day with some patriotic favorites.",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/2",
                    EventTypeId = 2,
                    EventCategoryId = 2,
                    EventSubCategoryId = 2,
                    LocationId = 2,
                    Price=11,
                    Contact="Vidya@gmail.com",
                    DateAndTimeId = 2,

                },
                new EventItem
                {
                    Title="Creative Academy of Music Composers",
                    Description="Join us for this memorable evening of great music performed by high school students of Lake Washington School District.",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/3",
                    EventTypeId = 2,
                    EventCategoryId = 2,
                    EventSubCategoryId = 2,
                    LocationId = 3,
                    Price=18,
                    Contact="Tapasya@gmail.com",
                    DateAndTimeId = 3,
                },

                new EventItem
                {
                    Title="Father's Day Special Brunch",
                    Description="Let us serve you our All-you-can-eat brunch favorites this Father's day",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/4",
                    EventTypeId = 2,
                    EventCategoryId = 2,
                    EventSubCategoryId = 1,
                    LocationId = 4,
                    Price=23,
                    Contact="Hrudya@gmail.com",
                    DateAndTimeId = 4,
                },
                new EventItem
                {
                    Title="Dad & Daughter Dance Party",
                    Description="Dads, this is an opportunity for you to express your love for your daughter and to show her that she is a special treasure who deserves to be treated with kindness and respect. This formal event is for dads and daughters of all ages!",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/5",
                    EventTypeId = 2,
                    EventCategoryId = 2,
                    EventSubCategoryId = 1,
                    LocationId = 5,
                    Price=18,
                    Contact="Adarsha@gmail.com",
                    DateAndTimeId = 5,
                },
                new EventItem
                {
                    Title="Father's Day Extravaganza!",
                    Description="Join us for a day full of fun activities for families. Activities are free for Dads on the occasion of Father's day.",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/6",
                    EventTypeId = 2,
                    EventCategoryId = 2,
                    EventSubCategoryId = 1,
                    LocationId = 6,
                    Price=20,
                    Contact="Hrudya@gmail.com",
                    DateAndTimeId = 6,
                },
                new EventItem
                {
                    Title="JazzFest",
                    Description="Enjoy Wonderful Live Music while having Lunch or coffee, soft Latin sounds with some Motown thrown in for Fun!",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/7",
                    EventTypeId = 1,
                    EventCategoryId = 1,
                    EventSubCategoryId = 3,
                    LocationId = 7,
                    Price=14,
                    Contact="Tapasya@gmail.com",
                    DateAndTimeId = 7,
                },
                new EventItem
                {
                    Title="Ariana Grande Virtual Concert",
                    Description="Ariana grande is performing at the first of its kind Virtual Concert on August 5! Be the first person to book your tickets!",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/8",
                    EventTypeId = 1,
                    EventCategoryId = 1,
                    EventSubCategoryId = 4,
                    LocationId = 2,
                    Price=35,
                    Contact="Vidya@gmail.com",
                    DateAndTimeId = 8,
                },
                new EventItem
                {
                    Title="Free Songwriters Workshop",
                    Description="This free online songwriting workshop for non-professional songwriters will be a fun challenge. Get free songwriting tips and techniques from passionate fellow songwriters from all around the world.",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/9",
                    EventTypeId = 1,
                    EventCategoryId = 1,
                    EventSubCategoryId = 5,
                    LocationId = 2,
                    Price=25,
                    Contact="Adarsha@gmail.com",
                    DateAndTimeId = 9,
                },
                new EventItem
                {
                    Title="Workshop on Mindfulness",
                    Description="Come experience the stress relieving experience of mindfulness workshop" ,
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/10",
                    EventTypeId = 3,
                    EventCategoryId = 3,
                    EventSubCategoryId = 6,
                    LocationId = 2,
                    Price=5,
                    Contact="Hrudya@gmail.com",
                    DateAndTimeId = 10,
                },
                new EventItem
                {
                    Title="A talk on Ayurveda",
                    Description="Join us for a talk on Ayurveda - the sister science of Yoga by renowned Guru of Ayurveda",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/11",
                    EventTypeId = 3,
                    EventCategoryId = 3,
                    EventSubCategoryId = 7,
                    LocationId = 2,
                    Price=0,
                    Contact="Tapasya@gmail.com",
                    DateAndTimeId = 11,
                },
                new EventItem
                {
                    Title="Yoga for all",
                    Description="YogaForAll proudly presents 5th Annual Yoga Day celebration. Please join us for a yoga session with family and friends",
                    PictureUrl="http://externaleventbaseurltobereplaced/api/pic/12",
                    EventTypeId = 3,
                    EventCategoryId = 3,
                    EventSubCategoryId = 8,
                    LocationId = 8,
                    Price=11,
                    Contact="Vidya@gmail.com",
                    DateAndTimeId = 12,
                }
            };

        }

    }
}
