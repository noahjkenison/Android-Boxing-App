using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace BoxingProto.Classes
{

    public class Round : INotifyPropertyChanged //trying to make color change update on listview. not working tho. I made all these properties, but not sure how to link to listview? Listview must be subscribed to this event? How?
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [ForeignKey(typeof(Workout))]
        public int WorkoutId { get; set; }

        [ManyToOne]
        public Workout Workout { get; set; }





        public event PropertyChangedEventHandler PropertyChanged;

        [Ignore]
        private Color cellcolor { get; set; } = Color.LightGray;

        string timerformat = @"mm\:ss";

        [Ignore]
        public Color CellColor
        {
            get { return cellcolor; }

            set
            {
                if (cellcolor == value)       //this triggers if we attempt to "set" / change the CellColor.
                    return;

                cellcolor = value;


                OnPropertyChanged();
                

            }
        }

        //The below is to do INotifyPropertyChanged 
        //TLDR: when a property of Round is changed, it will notify subscribers... but how do I make listview a subscriber? Is it implicit? ---> I bind to CellColor.
        private void OnPropertyChanged([CallerMemberName] string propertyName = "")



        //somehow, string propertyName = null automatically gets our propertyname?
        //"because we have not supplied an argument, propertyName will be null, and because of attribute [CallerMemberName], 
        //the name of the caller (in this case, Color) will be placed in the argument instead.
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //additionally, the ?. here checks to see if PropertyChanged != null. if null, stop. if not null, continue.
        }



        private TimeSpan _roundlength;
        public TimeSpan _roundLength
        {
            get
            {
                return _roundlength;
            }

            set
            {
                _roundlength = value;
                _roundlengthstring = value.ToString(@"mm\:ss");
            }
        }

        private TimeSpan _remainingroundtime;

        public TimeSpan _RemainingRoundTime
        {
            get
            {
                return _remainingroundtime;
            }

            set
            {
                _remainingroundtime = value;
                _roundLengthString = _remainingroundtime.ToString(@"mm\:ss");
                OnPropertyChanged();
            }
        }

        private string _roundlengthstring;



        public string _roundLengthString
        {
            get
            {
                return _roundlengthstring;
            }

            set
            {
                _roundlengthstring = value;
                OnPropertyChanged();
            }
        }
        public double _comboInterval { get; set; }


        //[TextBlob("StrikesBlobbed")]
        [OneToMany(CascadeOperations = CascadeOperation.All)]


        //public Strike[] _strikesArray {get; set; } = new Strike[7];

        public List<Strike> _strikesList { get; set; } = new List<Strike>();
        //public string StrikesBlobbed { get; set; }


        public string strikesString { get; private set; }




        [OneToMany(CascadeOperations = CascadeOperation.All)]

        //[TextBlob("ComboLengthsBlobbed")]
        public List<ComboLength> combolengthlist { get; set; } = new List<ComboLength>();
        // public string ComboLengthsBlobbed { get; set; }

        

        //public ComboLength[] combolengtharray = new ComboLength[9];
        string[] cars = new string[4];


        //[TextBlob("RoundStatusBlobbed")]
        public RoundStatus roundstatus { get; set; } = RoundStatus.Incomplete;

        //public string RoundStatusBlobbed { get; set; }

        public bool isRestRound { get; set; } = false;

        private string visibleindex;
        public string visibleIndex
        {
            get
            {
                return visibleindex;
            }

            set
            {
                visibleindex = value;
                OnPropertyChanged();
            }
        }



        public bool strikesEnabled { get; set; } = false;

        public Intensity intensity { get; set; }


        public Round(TimeSpan RoundLength, double ComboInterval, List<Strike> StrikesList, List<ComboLength> ComboLengthList)
        {
            //this.name = Name;
            this._roundLength = RoundLength;
            this._comboInterval = ComboInterval;
            this._strikesList = StrikesList;
            this.combolengthlist = ComboLengthList;
            

            for (int i = 0; i < _strikesList.Count; i++)
                    strikesString = strikesString + _strikesList[i].strikeNumber;

            _roundLengthString = _roundLength.ToString(timerformat);
            _RemainingRoundTime = _roundLength;
        }


        public Round(TimeSpan RoundLength)
        {
            this._roundLength = RoundLength;

            Strike one = new Strike(1, 0.7f);
            Strike two = new Strike(2, 0.2f);
            Strike three = new Strike(3, 0.1f);

            _strikesList.Add(one);
            _strikesList.Add(two);
            _strikesList.Add(three);

            //_strikesArray[0] = one;
            //_strikesArray[1] = two;
            //_strikesArray[2] = three;


            _comboInterval = 5;
            //_comboLength = new ComboLength() { lowerRange = 2, upperRange = 5 };



            _RemainingRoundTime = _roundLength;
            _roundLengthString = _RemainingRoundTime.ToString(timerformat);
        }

        public Round()
        {

            

            Strike one = new Strike(1, 0.7f);
            Strike two = new Strike(2, 0.2f);
            Strike three = new Strike(3, 0.1f);

            _strikesList.Add(one);
            _strikesList.Add(two);
            _strikesList.Add(three);


            //_strikesArray[0] = one;
            //_strikesArray[1] = two;
            //_strikesArray[2] = three;

            _comboInterval = 5;


            
            _RemainingRoundTime = _roundLength;
            _roundLengthString = _RemainingRoundTime.ToString(timerformat);
        }

        public void ResetRound()
        {
            roundstatus = RoundStatus.Incomplete;
            _RemainingRoundTime = _roundLength;
            _roundLengthString = _RemainingRoundTime.ToString(timerformat);
            cellcolor  = Color.LightGray;
    }

    }
}


public enum RoundStatus {Incomplete, Inprogress, Complete}

public enum Intensity  { Beginner, Intermediate, Pro, Custom}
