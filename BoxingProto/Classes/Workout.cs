using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;

namespace BoxingProto.Classes
{
    public class Workout
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        public string Name { get; set; }

        public TimeSpan Duration { get; set; }

        //[TextBlob("RoundsBlobbed")]

        [Ignore]
        public ObservableCollection<Round> roundList { get; set; } = new ObservableCollection<Round>(); //what would happen if i didn't give this an auto value?

        [OneToMany(CascadeOperations = CascadeOperation.All)]

        //[TextBlob("RoundsBlobbed")]
        public List<Round> storedRounds { get; set; }

        public int roundCount { get; set; }


        public void setWorkoutDuration()
        {
            for (int i = 0; i < roundList.Count; i++)
            {
                Duration = Duration + roundList[i]._roundLength;
            }
        }

        public void addRound(Round round)
        {
            roundList.Add(round);
            storedRounds.Add(round);
        }

        public void removeRound(int roundNumber)
        {
            roundList.RemoveAt(roundNumber);
            storedRounds.RemoveAt(roundNumber);
        }

        public Workout()
        {
            //roundCount = roundList.Count;
            //will be roundList.count later, this is for UI work


        }

        public void RecalculateIndices()
        {
            int index = 1;

            for (int i = 0; i < roundList.Count; i++)
            {


                if (roundList[i].isRestRound == false)
                {
                    roundList[i].visibleIndex = index.ToString();
                    index = index + 1;
                }

            }

            setWorkoutDuration();
        }


        public void AddGenericRound()
        {

            TimeSpan _roundlength = new TimeSpan(0, Convert.ToInt16(3), Convert.ToInt16(0));
            Round round1 = new Round(_roundlength);
            roundList.Add(round1);
        }

        public void AddGenericRestRound()
        {
            TimeSpan _restlength = new TimeSpan(0, Convert.ToInt16(1), Convert.ToInt16(0));
            Round restround = new Round(_restlength) { isRestRound = true };
            roundList.Add(restround);
        }

        public void AddGenericRounds(int numberofrounds)
        {
            for(int i = 0; i < numberofrounds; i++)
            {
                AddGenericRound();

                if(i != numberofrounds - 1)
                    AddGenericRestRound();


            }

            setWorkoutDuration();
        }

        public void ResetWorkout()
        {
            for (int i = 0; i<roundList.Count; i++)
            {
                roundList[i].ResetRound();
            }
        }


        //public StackLayout stack { get; private set; }

        //Consider adding a stackLayout as a property?

    }
}
