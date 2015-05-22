namespace Cinema.Domain
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Runtime.Serialization;
    using System.Collections.ObjectModel;

    [DataContract]
    public class Screening
    {
        public Screening()
        {
            Bookings = new List<Booking>();
        }

        [DataMember]
        public int ScreeningId { get; set; }

        [DataMember]
        [Required]
        public int ScreeningInfoId { get; set; }        

        [DataMember]
        public DateTime ScreeningDateTime { get; set; }

        [DataMember]
        public virtual ScreeningInfo ScreeningInfo { get; set; }        

        public virtual ICollection<Booking> Bookings { get; set; }





        /// <summary>
        /// Returns a list of seats suggestion based on a map and a number of tickets
        /// </summary>
        /// <param name="map">Map of the hall</param>
        /// <param name="n">Number of tickets</param>
        /// <returns>An array of seats</returns>

        public Seat[] GetSuggestion(Seat[] map, int n)
        {
            // First check if there are at least 'n' available seats
            if(map.Length < n)
            {
                return null;
            }

            bool[,] smap;   // create a new Data Type for Seat Map for ease in finding best suitable seats

            int rows = map.Max(s => s.Row) + 1;     // find number of rows
            int cols = map.Max(s => s.Column) + 1;  // find number of columns

            smap = new bool[rows,cols];   // allocate mem as we know no of rows & columns


            // Construct our new Seat Map Matrix which has TRUE for available seats
            foreach (var seat in map)
                smap[seat.Row, seat.Column] = true;



            /*
             * REQUIREMENTS:
             * Best case  : everyone sits together 
             * Worst case : everyone sits alone
             * Fewer groups are preferred over more groups
             * Balanced groups are preferred (3+3 is more preferred than 4+2)
             * Sitting alone is least preferred.
             * 
             * As we limit the number of tickets to 9, we can hard code the rules, 
             * which will be a plus for performance. We do not generate them each time,
             * as the big O of the algorithm will be at least O(n*n).
             * 
             * The rules are the follow (from desired to worst):
             * 1 user: 1
               2 users: 2, 1+1
               3 users: 3, 1+2, 1+1+1
               4 users: 4, 2+2, 1+3, 1+1+2, 1+1+1+1
               5 users: 5, 2+3, 1+4, 1+2+2, 1+1+3, 1+1+1+2, 1+1+1+1+1
               6 users: 6, 3+3, 2+4, 2+2+2, 1+5, 1+2+3, 1+1+4, 1+1+2+2, 1+1+1+3, 1+1+1+1+2, 1+1+1+1+1+1
               7 users: 7, 3+4, 2+5, 2+2+3, 1+6, 1+3+3, 1+2+4, 1+2+2+2, 1+1+5, 1+1+2+3, 1+1+1+4, 1+1+1+2+2, 1+1+1+1+3, 1+1+1+1+1+2, 1+1+1+1+1+1+1
               8 users: 8, 4+4, 3+5, 2+6, 2+3+3, 2+2+4, 2+2+2+2, 1+7, 1+3+4, 1+2+5, 1+2+2+3, 1+1+6, 1+1+3+3, 1+1+2+4, 1+1+2+2+2, 1+1+1+5, 1+1+1+2+3, 1+1+1+1+4, 1+1+1+1+2+2, 1+1+1+1+1+3, 1+1+1+1+1+1+2, 1+1+1+1+1+1+1+1
               9 users: 9, 4+5, 3+6, 3+3+3, 2+7, 2+3+4, 2+2+5, 2+2+2+3, 1+8, 1+4+4, 1+3+5, 1+2+6, 1+2+3+3, 1+2+2+4, 1+2+2+2+2, 1+1+7, 1+1+3+4, 1+1+2+5, 1+1+2+2+3, 1+1+1+6, 1+1+1+3+3, 1+1+1+2+4, 1+1+1+2+2+2, 1+1+1+1+5, 1+1+1+1+2+3, 1+1+1+1+1+4, 1+1+1+1+1+2+2, 1+1+1+1+1+1+3, 1+1+1+1+1+1+1+2, 1+1+1+1+1+1+1+1+1
             *
             * As the maximum number is 9, we can eliminate the plus, because we will have only one digit numbers             * 
             */

            string[][] rules = new string[10][];
            rules[1] = new string[1]  {"1"};
            rules[2] = new string[2]  {"2","11"};
            rules[3] = new string[3]  {"3","12","111"};
            rules[4] = new string[5]  {"4","22","13","112","1111"};
            rules[5] = new string[7]  {"5","23","14","122","113","1113","1111"};
            rules[6] = new string[11] {"6", "33", "24", "222", "15", "123", "114", "1122", "1113", "11112", "111111"};
            rules[7] = new string[15] {"7","34","25","223","16","133","124","1222","115","1123","1114","11122","11113","111112","1111111"};
            rules[8] = new string[22] {"8","44","35","26","233","224","2222","17","134","125","1223","116","1133","1124","11222","1115","11123","11114","111122","111113","1111112","11111111"};
            rules[9] = new string[30] {"9","45","36","333","27","234","225","2223","18","144","135","126","1233","1224","12222","117","1134","1125","11223","1116","11133","11124","111222","11115","111123","111114","1111122","1111113","11111112","111111111",};


            /* =====================================================
             * An array of n-1 elements must be created. 
             * An element on position i will contain a List of 
             * those seats which have in the right i available seats 
             * Each Seat which follows the above rule will also have a Dist parameter
             * which is calculated as: SUM of distances between first Seat and Center Seat and last Seat and Center Seat
             * dist = SUM( DIST(firstSeat, centerSeat), DIST(lastSeat, centerSeat) )
             * ======================================================
            */
            List<RowCol>[] grouppedSeats = new List<RowCol>[n+1];

            int csRow = (rows + 1) / 2; // center seat row
            int csCol = (cols + 1) / 2; // center seat col 

            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++ )
                {
                    if(smap[i,j])
                    {
                        RowCol startRC = new RowCol(i,j);

                        while (j < cols && smap[i, j]) 
                            j++;

                        int noSeats = j - startRC.Col; // number of seats one near other
                        int diff = 0;

                        if (noSeats > n)
                        {
                            diff = noSeats - n;

                            noSeats = n;
                        }

                        if (grouppedSeats[noSeats] == null)
                            grouppedSeats[noSeats] = new List<RowCol>();

                        for (int k = 0; k <= diff; k++)
                        {
                            RowCol rc = new RowCol(startRC.Row, startRC.Col + k);

                            rc.Dist  = DIST(startRC.Row, startRC.Col,           csRow, csCol);
                            rc.Dist += DIST(startRC.Row, startRC.Col + noSeats, csRow, csCol);

                            grouppedSeats[noSeats].Add(rc);
                        }
                    }
                }


            // Each list must be ordered by distance from center seat
            for (int i=1;i<=n;i++)
            {
                if(grouppedSeats[i] != null)
                {
                    grouppedSeats[i] = grouppedSeats[i].OrderBy(r => r.Dist).ToList<RowCol>();
                }
            }

            // We parse the rules, and as soon as we found a valid rule 
            // based on our group of seats we return the suggestion
            Dictionary<RowCol, int> suggestion;

            foreach (var rule in rules[n])
            {
                suggestion = new Dictionary<RowCol, int>(); // reset suggestion hashset for each rule

                bool isRuleWorking = true;

                for (int i = 0; isRuleWorking && i < rule.Length; i++)
                {
                    int no = rule[i] - '0'; // convert char to int

                    isRuleWorking = false;    // Set as: not found a group to match the rule

                    // Start parsing all the groups until we found one which was not already used
                    for (int j = 0; !isRuleWorking && j < grouppedSeats[no].Count; j++)
                    {
                        if(!suggestion.ContainsKey(grouppedSeats[no][j]))
                        {
                            suggestion[grouppedSeats[no][j]] = no;
                            isRuleWorking = true;  
                        }
                    }
                }

                if(isRuleWorking)
                {
                    Seat[] finalSugg = new Seat[n];  // allocate mem for final suggestion array as we know no of tickets

                    int k = 0;
                    foreach (var key in suggestion.Keys)    // parse all keys in suggestion (starting seats)
                    {
                        for (int i = 0; i < suggestion[key]; i++)    // adding suggestion[key] no of seats to the final suggestion
                        {
                            finalSugg[k++] = new Seat { Row = key.Row, Column = (key.Col + i) };
                        }
                    }

                    return finalSugg;  // return the final suggestion array 
                                       // which will contain all tickets
                }
            }



            return null;
        }

        private int DIST(int x, int y,  int cx, int cy) 
        {
            int dist = Math.Abs(cx - x) + Math.Abs(cy - y);
            return dist;
        }
    }


    public class RowCol 
    {
        public RowCol(int row, int col) 
        {
            this.Row = row;
            this.Col = col;
            this.Dist = 0;
        }

        public int Row { get; set; }
        public int Col { get; set; }
        public int Dist { get; set; }
    }

}
