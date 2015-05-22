namespace Cinema.Domain
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;

    [DataContract]
    public class Seat
    {
        public Seat() { }
        public Seat(int hallId, int row, int column)
        {
            this.HallId = hallId;
            this.Row = row;
            this.Column = column;
            this.Value = SeatType.NormalSeat;
        }

        [DataMember]
        [Required]
        public int HallId { get; set; }

        [DataMember]
        [Required]
        public int Row { get; set; }

        [DataMember]
        [Required]
        public int Column { get; set; }

        [DataMember]
        [Required]
        public SeatType Value { get; set; }
        
        public Hall Hall { get; set; }



        public bool Equals(Seat other)
        {
            if (ReferenceEquals(null, other))
            {
                return false;
            }

            if (ReferenceEquals(this, other))
            {
                return true;
            }

            return Equals(other.Row, this.Row) && Equals(other.Column, this.Column);
        }

        public override bool Equals(Object obj)
        {
            if (ReferenceEquals(null, obj))
            {
                return false;
            }

            if (ReferenceEquals(this, obj))
            {
                return true;
            }

            if (obj.GetType() != typeof(Seat))
            {
                return false;
            }

            return Equals((Seat)obj);
        }
    }
}
