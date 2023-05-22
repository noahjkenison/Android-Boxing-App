using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Text;

namespace BoxingProto.Classes
{

    public class ComboLength
    {

        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [ForeignKey(typeof(Round))]
        public int RoundId { get; set; }

        public int strikesInCombo { get; set; }

        public double frequency { get; set; }

        [ManyToOne]
        public Round Round { get; set; }

        public ComboLength()
        {
        }

        public ComboLength(int strikesincombo, double frequency)
        {


        }

        

        
    }
}


