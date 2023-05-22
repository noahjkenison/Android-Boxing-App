using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoxingProto.Classes
{
    public class Strike
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [ForeignKey(typeof(Round))]
        public int RoundId { get; set; }

        public int strikeNumber { get; set; }
        public float frequency { get; set; }

        public Boolean enabled { get; set; } = false; 
                                                      

        [ManyToOne]
        public Round Round { get; set; }

        public Strike(int StrikeNumber, float Frequency)
        {
            strikeNumber = StrikeNumber;
            frequency = Frequency;
        }

        public Strike()
        {

        }
    }

    

}
