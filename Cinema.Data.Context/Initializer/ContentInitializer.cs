namespace Cinema.Data.Context.Initializer
{
    using System;
    using System.Data.Entity;
    using Sources;
    using Domain;

    // DropCreateDatabaseIfModelChanges<CinemaContext>
    // DropCreateDatabaseAlways<CinemaContext>
    // CreateDatabaseIfNotExistss<CinemaContext>
    public class ContentInitializer : CreateDatabaseIfNotExists<CinemaContext>
    {
        private const string HashedPassword = "A9C090F6F0C863FAF82F05F3C604B2CC";   // Str0ngpass
        private const string Salt = "3L4bJ96IboV7HA==";

        protected override void Seed(CinemaContext context)
        {
            context.Users.Add(
                    new User("system-dmai0913@ucn.dk", "+4540789162", HashedPassword) { 
                        Salt = Salt,
                        UserGuid = new Guid(Constants.SystemAccountGuid),
                        AccessLevel = AccessType.Employee,
                        LastLogin = DateTime.UtcNow,
                        CreatedBy = new Guid(Constants.SystemAccountGuid),
                        CreatedOn = DateTime.UtcNow,
                        UpdatedBy = new Guid(Constants.SystemAccountGuid),
                        UpdatedOn = DateTime.UtcNow,
                        LastName  = "System",
                        FirstName = "System"
                    }
                );

            context.Halls.Add(
                new Hall { 
                    HallId = 1, 
                    HallName = "Hall1"
                }
            );

            // Add A Default Hall Seat Map
            for (int i = 1; i <= 11; i++)
                for (int j = 2; j <= 23; j++) 
                    if(i != 7)  // remove 7th row
                        context.Seats.Add(new Seat(1, i, j));



            context.MovieInfos.Add(
                new MovieInfo { 
                    MovieInfoId = 1,
                    Title = "Test Movie",
                    Director = "John Director",
                    Actors = "One Actor, Two Actor",
                    ReleaseDate = DateTime.UtcNow.AddMonths(-1),
                    LenghtTime = 120,
                    AgeRestriction = AgeRestriction.R_11,
                    Genre = "Comedy"
                }
            );


            context.Movies.Add(
                new Movie {
                    MovieId = 1,
                    MovieInfoId = 1
                }
            );

            context.ScreeningInfos.Add(
                new ScreeningInfo { 
                    ScreeningInfoId = 1,
                    TicketPrice = 89,
                    MovieId = 1,
                    HallId = 1
                }
            );

            context.Screenings.Add(new Screening {
                ScreeningId = 1,
                ScreeningInfoId = 1,
                ScreeningDateTime = DateTime.UtcNow.AddDays(1).AddHours(3)
            });


            context.TicketTypes.Add(new TicketType { TicketTypeId = 1, Type = "Basic", Discount = 0 });
            context.TicketTypes.Add(new TicketType { TicketTypeId = 2, Type = "Students", Discount = 10 });
            context.TicketTypes.Add(new TicketType { TicketTypeId = 3, Type = "Elder", Discount = 12 });

            context.Bookings.Add(new Booking {
                BookingId = 1,
                ScreeningId = 1,
                CreatedOn = DateTime.UtcNow,
                CreatedBy = new Guid(Constants.SystemAccountGuid),
                UserGuid = new Guid(Constants.SystemAccountGuid)
            });

            context.Tickets.Add(new Ticket {
                BookingId = 1,
                Row = 1,
                Column = 5,
                TicketTypeId = 1
            });

            context.Tickets.Add(new Ticket
            {
                BookingId = 1,
                Row = 1,
                Column = 6,
                TicketTypeId = 1
            });

            base.Seed(context);
        }
    }
}
