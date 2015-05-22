namespace Cinema.Data.Context.Sources
{    
    using System.Data.Entity;

    using Domain;

    using Mapping;

    public class CinemaContext : DbContext
    {
        public CinemaContext() : base("Name=CinemaContext") 
        {
            Database.SetInitializer(new Initializer.ContentInitializer());

            Configuration.LazyLoadingEnabled = false;   // disable lazy loading (enable eager loading :D)
            Configuration.ProxyCreationEnabled = false; // disble proxy creation
            //this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);  // Uncomment to see SQL queries in Output area
        }

        #region DbSets

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Hall> Halls { get; set; }
        public DbSet<LoginToken> LoginTokens { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<MovieInfo> MovieInfos { get; set; }
        public DbSet<Screening> Screenings { get; set; }
        public DbSet<ScreeningInfo> ScreeningInfos { get; set; }
        public DbSet<Seat> Seats { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<TicketType> TicketTypes { get; set; }
        public DbSet<User> Users { get; set; }

        #endregion 

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookingMap());
            modelBuilder.Configurations.Add(new HallMap());
            modelBuilder.Configurations.Add(new LoginTokenMap());
            modelBuilder.Configurations.Add(new MovieInfoMap());
            modelBuilder.Configurations.Add(new MovieMap());
            modelBuilder.Configurations.Add(new ScreeningInfoMap());
            modelBuilder.Configurations.Add(new ScreeningMap());
            modelBuilder.Configurations.Add(new SeatMap());
            modelBuilder.Configurations.Add(new TicketMap());
            modelBuilder.Configurations.Add(new TicketTypeMap());
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
