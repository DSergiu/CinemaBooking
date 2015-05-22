namespace Cinema.Domain
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    
    [DataContract]
    public class MovieInfo
    {
        public MovieInfo()
        {
            Movies = new List<Movie>();
        }

        [DataMember]
        public int MovieInfoId { get; set; }

        [DataMember]
        [Required]
        public string Title { get; set; }

        [DataMember]
        public string Description { get; set; }

        [DataMember]
        public string Director { get; set; }

        [DataMember]
        public string Actors { get; set; }

        [DataMember]
        public DateTime ReleaseDate { get; set; }

        [DataMember]
        public int? LenghtTime { get; set; }

        [DataMember]
        public AgeRestriction AgeRestriction { get; set; }

        [DataMember]
        public string Genre { get; set; }

        public virtual ICollection<Movie> Movies { get; set; }
    }
}
