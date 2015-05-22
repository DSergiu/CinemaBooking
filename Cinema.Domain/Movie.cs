namespace Cinema.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    
    [DataContract]
    public class Movie
    {
        public Movie()
        {
            Screenings = new HashSet<Screening>();
        }

        [DataMember]
        public int MovieId { get; set; }

        [DataMember]
        [Required]
        public int MovieInfoId { get; set; } 

        [DataMember]
        public bool Is3D { get; set; }

        [DataMember]
        public MovieInfo MovieInfo { get; set; }


        public ICollection<Screening> Screenings { get; set; }
    }
}
