namespace Cinema.Domain
{    
    public enum AccessType
    { 
        Basic = 0,
        Employee = 1
    }

    public enum AgeRestriction
    {
        R_A = 0,
        R_7 = 1,
        R_11 = 2,
        R_15 = 3,
        R_F = 4
    }

    public enum SeatType
    {
        NoSeat = 0,
        NormalSeat = 1,
        HandicapSeat = 2
    }

    public class Constants 
    {
        public const string SystemAccountGuid = "{6352edfa-7cf3-4b04-ae42-f7b00e25f2c2}";
    }
}
