using BoxingProto.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.Converters;
using Xamarin.CommunityToolkit.Extensions;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.Xaml;

namespace BoxingProto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

    public partial class QuickStartPage2 : ContentPage
    {

        string[] timeSource = new string[60];
        string[] roundnumbersSource = new string[20];
        string[] levelSource = new string[] { "Beginner", "Intermediate", "Pro", "Custom" };
        List<string> minComboSource = new List<String>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        List<string> maxComboSource = new List<String>() { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        String[] comboSource = new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        private double SliderStepSize = .05;
        private Intensity _intensity;

        SliderBundle[] comboSlidersArray = new SliderBundle[10];
        
        private ObservableCollection<Strike> strikes { get; set; } = new ObservableCollection<Strike>();

        private bool advsettingsvis = false;
        public bool AdvSettingsVis
        {
            get
            {
                return advsettingsvis;
            }

            set
            {
                advsettingsvis = value;
                OnPropertyChanged();
            }
        }


        private string numberofrounds = "5";
        public string NumberOfRounds
        {
            get
            {
                return numberofrounds;
            }

            set
            {
                numberofrounds = value;
                OnPropertyChanged();
            }
        }


        private string roundlengthmin = "3";

        public string RoundLengthMin
        {
            get
            {
                return roundlengthmin;
            }

            set
            {
                roundlengthmin = value;
                OnPropertyChanged();
            }
        }

        private string roundlengthsec = "00";

        public string RoundLengthSec
        {
            get
            {
                return roundlengthsec;
            }


            set
            {
                roundlengthsec = value;
                OnPropertyChanged();
            }
        }

        private string restlengthmin = "1";

        public string RestLengthMin
        {
            get
            {
                return restlengthmin;
            }

            set
            {
                restlengthmin = value;
                OnPropertyChanged();
            }
        }

        private string restlengthsec = "00";

        public string RestLengthSec
        {
            get
            {
                return restlengthsec;
            }

            set
            {
                restlengthsec = value;
                OnPropertyChanged();
            }
        }


        private Boolean strikecallouts = false;

        public Boolean StrikeCallout
        {
            get
            {
                return strikecallouts;
            }

            set
            {
                strikecallouts = value;
                OnPropertyChanged();
            }
        }


        private TimeSpan workoutduration = new TimeSpan(0, 18, 0);
        public TimeSpan WorkoutDuration
        {
            get
            {
                return workoutduration;
            }

            set
            {
                workoutduration = value;
                OnPropertyChanged();
            }
        }


        private int comboint = 5;

        public int ComboInt
        {
            get
            {
                return comboint;
            }

            set
            {
                comboint = value;
                OnPropertyChanged();
            }
        }


        private int combolengthmin = 1;

        public int ComboLengthMin
        {
            get
            {
                return combolengthmin;
            }

            set
            {
                combolengthmin = value;
                OnPropertyChanged();
            }
        }


        private int combolengthmax = 5;

        public int ComboLengthMax
        {
            get
            {
                return combolengthmax;
            }

            set
            {
                combolengthmax = value;
                OnPropertyChanged();
            }
        }



        private double currentMaxStrikePercentage;
        private double currentMaxComboPercentage;


        private string onepercentagestring;

        public string OnePercentageString
        {
            get
            {
                return onepercentagestring;
            }

            set
            {
                onepercentagestring = value;
                OnPropertyChanged();
            }
        }

        private bool strikeCalloutsVis = false;
        public bool StrikeCalloutsVis
        {
            get
            {
                return strikeCalloutsVis;
            }

            set
            {
                strikeCalloutsVis = value;
                OnPropertyChanged();
            }
        }


        public QuickStartPage2() 
        {

            BindingContext = this;

            InitializeComponent();

            boxingringimage.Source = ImageSource.FromResource("BoxingProto.Images.ring.png");
            timerimage.Source = ImageSource.FromResource("BoxingProto.Images.timer.png");
            batteryimage.Source = ImageSource.FromResource("BoxingProto.Images.rest.png");

            if (Xamarin.Forms.Application.Current.Properties.ContainsKey("roundcount"))
                Xamarin.Forms.Application.Current.Properties.Remove("roundcount");

            if (Xamarin.Forms.Application.Current.Properties.ContainsKey("workoutBegan"))
                Xamarin.Forms.Application.Current.Properties.Remove("workoutBegan");

            fillArrays();
            UpdateWorkoutDuration();

            double zeroValue = 0f;
            calculateStrikeSliderMax(zeroValue);
            calculateComboSliderMax(zeroValue);

            SetLevelToBeginner();

        }

        private void fillArrays()
        {
            for (int i = 0; i < timeSource.Length; i++)
            {
                timeSource[i] = (i).ToString();

            }

            for (int i = 0; i < roundnumbersSource.Length; i++)
            {
                roundnumbersSource[i] = (i).ToString();
            }

            for (int i = 0; i < 8; i++)
            {
                Strike newstrike = new Strike() { strikeNumber = i + 1 };
                strikes.Add(newstrike);
            }

            for (int i = 0; i < 10; i++)
            {
                comboSlidersArray[i] = new SliderBundle();
            }

            comboSlidersArray[0].slider = comboSlider1;
            comboSlidersArray[1].slider = comboSlider2;
            comboSlidersArray[2].slider = comboSlider3;
            comboSlidersArray[3].slider = comboSlider4;
            comboSlidersArray[4].slider = comboSlider5;
            comboSlidersArray[5].slider = comboSlider6;
            comboSlidersArray[6].slider = comboSlider7;
            comboSlidersArray[7].slider = comboSlider8;
            comboSlidersArray[8].slider = comboSlider9;
            comboSlidersArray[9].slider = comboSlider10;


            comboSlidersArray[0].percentageLabel = comboPercentLabel1;
            comboSlidersArray[1].percentageLabel = comboPercentLabel2;
            comboSlidersArray[2].percentageLabel = comboPercentLabel3;
            comboSlidersArray[3].percentageLabel = comboPercentLabel4;
            comboSlidersArray[4].percentageLabel = comboPercentLabel5;
            comboSlidersArray[5].percentageLabel = comboPercentLabel6;
            comboSlidersArray[6].percentageLabel = comboPercentLabel7;
            comboSlidersArray[7].percentageLabel = comboPercentLabel8;
            comboSlidersArray[8].percentageLabel = comboPercentLabel9;
            comboSlidersArray[9].percentageLabel = comboPercentLabel10;


            comboSlidersArray[0].valueLabel = combolength1Label;
            comboSlidersArray[1].valueLabel = combolength2Label;
            comboSlidersArray[2].valueLabel = combolength3Label;
            comboSlidersArray[3].valueLabel = combolength4Label;
            comboSlidersArray[4].valueLabel = combolength5Label;
            comboSlidersArray[5].valueLabel = combolength6Label;
            comboSlidersArray[6].valueLabel = combolength7Label;
            comboSlidersArray[7].valueLabel = combolength8Label;
            comboSlidersArray[8].valueLabel = combolength9Label;
            comboSlidersArray[9].valueLabel = combolength10Label;


            comboSlidersArray[0].descriptionLabel = comboLabel1;
            comboSlidersArray[1].descriptionLabel = comboLabel2;
            comboSlidersArray[2].descriptionLabel = comboLabel3;
            comboSlidersArray[3].descriptionLabel = comboLabel4;
            comboSlidersArray[4].descriptionLabel = comboLabel5;
            comboSlidersArray[5].descriptionLabel = comboLabel6;
            comboSlidersArray[6].descriptionLabel = comboLabel7;
            comboSlidersArray[7].descriptionLabel = comboLabel8;
            comboSlidersArray[8].descriptionLabel = comboLabel9;
            comboSlidersArray[9].descriptionLabel = comboLabel10;


            slider1.Value = 0;
            slider2.Value = 0;
            slider3.Value = 0;
            slider4.Value = 0;
            slider5.Value = 0;
            slider6.Value = 0;
            slider7.Value = 0;
            slider8.Value = 0;

            comboSlidersArray[0].slider.Value = 0;
            comboSlidersArray[1].slider.Value = 0;
            comboSlidersArray[2].slider.Value = 0;
            comboSlidersArray[3].slider.Value = 0;
            comboSlidersArray[4].slider.Value = 0;
            comboSlidersArray[5].slider.Value = 0;
            comboSlidersArray[6].slider.Value = 0;
            comboSlidersArray[7].slider.Value = 0;
            comboSlidersArray[8].slider.Value = 0;
            comboSlidersArray[9].slider.Value = 0;

        }

        private async void roundButtonClicked(object sender, EventArgs e)
        {
            string _numberofrounds = await DisplayActionSheet("# of rounds", "Cancel", null, roundnumbersSource);
            if (_numberofrounds != "Cancel")
                NumberOfRounds = _numberofrounds;

            UpdateWorkoutDuration();
        }

        private async void restlengthSecButton_Clicked(object sender, EventArgs e)
        {
            string _restlengthsec = await DisplayActionSheet("Rest: Seconds", "Cancel", null, timeSource);
            if (_restlengthsec != "Cancel")
                RestLengthSec = _restlengthsec;

            UpdateWorkoutDuration();
        }

        private async void restlengthMinButton_Clicked(object sender, EventArgs e)
        {
            string _restlengthmin = await DisplayActionSheet("Rest: Minutes", "Cancel", null, timeSource);
            if (_restlengthmin != "Cancel")
                RestLengthMin = _restlengthmin;

            UpdateWorkoutDuration();
        }

        private async void roundlengthSecButton_Clicked(object sender, EventArgs e)
        {
            string _roundlengthsec = await DisplayActionSheet("Round Time: Seconds", "Cancel", null, timeSource);
            if (_roundlengthsec != "Cancel")
                RoundLengthSec = _roundlengthsec;

            UpdateWorkoutDuration();
        }

        private async void roundlengthMinButton_Clicked(object sender, EventArgs e)
        {
            string _roundlengthmin = await DisplayActionSheet("Round Time: Minutes", "Cancel", null, timeSource);
            if (_roundlengthmin != "Cancel")
                RoundLengthMin = _roundlengthmin;

            UpdateWorkoutDuration();
        }

        private void Switch_Toggled(object sender, ToggledEventArgs e)
        {
            if (toggle.IsToggled == true)
            {
                toggleStrikeMenu(true);
            }

            if (toggle.IsToggled == false)
            {
                toggleStrikeMenu(false);

            }

        }

        private async void toggleStrikeMenu(bool toggleValue)
        {
            if (toggleValue == true)
            {

                StrikeCalloutsVis = true;
                genWorkoutBut1.IsVisible = false;
                genWorkoutBut2.IsVisible = true;

                scrollview.IsEnabled = toggleValue;
                await scrollview.ScrollToAsync(strikecalloutlabel, ScrollToPosition.Start, true);
                

            }
            if (toggleValue == false)
            {
                StrikeCalloutsVis = false;
                genWorkoutBut1.IsVisible = true;
                genWorkoutBut2.IsVisible = false;

                scrollview.IsEnabled = toggleValue;
                await scrollview.ScrollToAsync(workoutdurationlabel, ScrollToPosition.End, true);
               

            }
        }



        private async void levelbutton_clicked(object sender, EventArgs e)
        {
            string level = await DisplayActionSheet("Rest: Seconds", "Cancel", null, levelSource);
           

            switch (level)
            {
                case "Beginner":
                    {

                        SetLevelToBeginner();
                        return;
                    }


                case "Intermediate":
                    {
                        SetLevelToIntermediate();
                        return;
                    }

                case "Pro":
                    {

                        SetLevelToPro();
                        return;
                    }

                case "Cancel":
                    {
                        return;
                    }


                case "Custom":
                    SetLevelToCustom();
                    return;
            }
        }

        private void UpdateWorkoutDuration()
        {

            int _roundCount = Convert.ToInt16(NumberOfRounds);
            int _roundlengthmin = _roundCount * Convert.ToInt16(RoundLengthMin);
            int _roundlengthsec = _roundCount * Convert.ToInt16(RoundLengthSec);
            int _restlengthmin = (_roundCount - 1) * Convert.ToInt16(RestLengthMin);
            int _restlengthsec = (_roundCount - 1) * Convert.ToInt16(RestLengthSec);
            

            WorkoutDuration = new TimeSpan(0, _roundlengthmin + _restlengthmin, _roundlengthsec + _restlengthsec);
            

        }


        private async void runWorkout_clicked(object sender, EventArgs e)
        {

            ObservableCollection<Round> _roundlist = new ObservableCollection<Round>();
            TimeSpan _roundlength = new TimeSpan(0, Convert.ToInt16(RoundLengthMin), Convert.ToInt16(RoundLengthSec));
            TimeSpan _restlength = new TimeSpan(0, Convert.ToInt16(RestLengthMin), Convert.ToInt16(RestLengthSec));
            if (StrikeCallout == false)
            {
                for (int i = 0; i < Convert.ToInt16(NumberOfRounds); i++)
                {
                    Round _round = new Round(_roundlength);
                    Round _round2 = new Round(_restlength) { isRestRound = true };

                    _roundlist.Add(_round);
                    if (i < Convert.ToInt16(NumberOfRounds) - 1) 
                    {

                        _roundlist.Add(_round2);
                    }

                }
            }


            if (StrikeCallout == true)
            {

                List<Strike> StrikesList = createStrikesList();
                List<ComboLength> ComboLengthList = createComboLengthList();


                for (int i = 0; i < Convert.ToInt16(NumberOfRounds); i++)
                {
                    Round _round = new Round(_roundlength, ComboInt, StrikesList, ComboLengthList) { strikesEnabled = true, intensity = _intensity };
                    Round _round2 = new Round(_restlength) { isRestRound = true };

                    _roundlist.Add(_round);
                    if (i < Convert.ToInt16(NumberOfRounds) - 1) 
                    {

                        _roundlist.Add(_round2);
                    }

                }


            }

            Workout _workout = new Workout() { roundList = _roundlist, Name = "Quick Workout" };


            await Navigation.PushAsync(new WorkoutRunner(_workout));

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {

            ObservableCollection<Round> _roundlist = new ObservableCollection<Round>();
            TimeSpan _roundlength = new TimeSpan(0, Convert.ToInt16(RoundLengthMin), Convert.ToInt16(RoundLengthSec));
            TimeSpan _restlength = new TimeSpan(0, Convert.ToInt16(RestLengthMin), Convert.ToInt16(RestLengthSec));



            if (StrikeCallout == false)
            {
                for (int i = 0; i < Convert.ToInt16(NumberOfRounds); i++)
                {
                    Round _round = new Round(_roundlength);
                    Round _round2 = new Round(_restlength) { isRestRound = true };

                    _roundlist.Add(_round);
                    if (i < Convert.ToInt16(NumberOfRounds) - 1) 
                    {

                        _roundlist.Add(_round2);
                    }

                }
            }


            if (StrikeCallout == true)
            {

                List<Strike> StrikesList = createStrikesList();
                List<ComboLength> ComboLengthList = createComboLengthList();

                for (int i = 0; i < Convert.ToInt16(NumberOfRounds); i++)
                {
                    Round _round = new Round(_roundlength, ComboInt, StrikesList, ComboLengthList) { strikesEnabled = true };
                    Round _round2 = new Round(_restlength) { isRestRound = true };

                    _roundlist.Add(_round);
                    if (i < Convert.ToInt16(NumberOfRounds) - 1) 
                    {

                        _roundlist.Add(_round2);
                    }
                }
            }

            Workout _workout = new Workout() { roundList = _roundlist, Name = "Quick Workout" };
            Navigation.PushAsync(new WorkoutRunner(_workout));

        }


        private async void  intervalbutton_Clicked(object sender, EventArgs e)
        {
            string interval = await DisplayActionSheet("Seconds between combos:", "Cancel", null, comboSource);
            if (interval != "Cancel")
            {
                ComboInt = Convert.ToInt16(interval);
                SetLevelToCustom();
            }
        }

        private async void ComboLengthMinButton_clicked(object sender, EventArgs e)
        {
            string combolengthmin = await DisplayActionSheet("Minimum # of strikes in combo", "Cancel", null, minComboSource.ToArray());
            if (combolengthmin != "Cancel")
            {
                ComboLengthMin = Convert.ToInt16(combolengthmin);
                SetLevelToCustom();
            }
                

            updateComboMaxLengthSource();
            AdjustComboSliders(ComboLengthMin, ComboLengthMax);
        }

        private async void ComboLengthMaxButton_clicked(object sender, EventArgs e)
        {
            string combolengthmax = await DisplayActionSheet("Maximum # of strikes in combo", "Cancel", null, maxComboSource.ToArray());
            if (combolengthmax != "Cancel")
            {
                ComboLengthMax = Convert.ToInt16(combolengthmax);
                SetLevelToCustom();
            }
                

            updateComboMinLengthSource();
            AdjustComboSliders(ComboLengthMin, ComboLengthMax);


        }

        private void updateComboMaxLengthSource()
        {
            maxComboSource.Clear();

            for (int i = ComboLengthMin; i < 10; i++)
            {
                maxComboSource.Add(i.ToString());
            }

            if (ComboLengthMin > ComboLengthMax)
                ComboLengthMax = ComboLengthMin + 1;
        }

        private void updateComboMinLengthSource()
        {
            minComboSource.Clear();

            for(int i = 1; i < ComboLengthMax; i++)
            {
                minComboSource.Add(i.ToString());
            }


            if (ComboLengthMin > ComboLengthMax)
                ComboLengthMin = ComboLengthMax - 1;

        }

        private void slider1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / SliderStepSize);
            UpdateSliderIncrement(slider1, slider1label, newStep);
        }


        private void slider1_DragStarted(object sender, EventArgs e)
        {
            calculateStrikeSliderMax(slider1.Value);
            SetLevelToCustom();
        }

        private void slider2_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            
            
            var newStep = Math.Round(e.NewValue / SliderStepSize);
            UpdateSliderIncrement(slider2, slider2label, newStep);

        }

        private void slider2_DragStarted(object sender, EventArgs e)
        {
            calculateStrikeSliderMax(slider2.Value);
            SetLevelToCustom();
        }


        private void slider3_ValueChanged(object sender, ValueChangedEventArgs e)
        {

            var newStep = Math.Round(e.NewValue / SliderStepSize);
            UpdateSliderIncrement(slider3, slider3label, newStep);

        }
        private void slider3_DragStarted(object sender, EventArgs e)
        {
            calculateStrikeSliderMax(slider3.Value);
            SetLevelToCustom();
        }
        private void slider4_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / SliderStepSize);
            UpdateSliderIncrement(slider4, slider4label, newStep);
        }
        private void slider4_DragStarted(object sender, EventArgs e)
        {
            calculateStrikeSliderMax(slider4.Value);
            SetLevelToCustom();
        }

        private void slider5_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / SliderStepSize);
            UpdateSliderIncrement(slider5, slider5label, newStep);
        }

        private void slider5_DragStarted(object sender, EventArgs e)
        {
            calculateStrikeSliderMax(slider5.Value);
            SetLevelToCustom();
        }

        private void slider6_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / SliderStepSize);
            UpdateSliderIncrement(slider6, slider6label, newStep);
        }

        private void slider6_DragStarted(object sender, EventArgs e)
        {
            calculateStrikeSliderMax(slider6.Value);
            SetLevelToCustom();
        }

        private void slider7_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / SliderStepSize);
            UpdateSliderIncrement(slider7, slider7label, newStep);
        }

        private void slider7_DragStarted(object sender, EventArgs e)
        {
            calculateStrikeSliderMax(slider7.Value);
            SetLevelToCustom();
        }

        private void slider8_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / SliderStepSize);
            UpdateSliderIncrement(slider8, slider8label, newStep);
        }

        private void slider8_DragStarted(object sender, EventArgs e)
        {
            calculateStrikeSliderMax(slider8.Value);
            SetLevelToCustom();
        }

        private void calculateStrikeSliderMax(double slidervalue)
        {

            double cumulativeSliderValues = slider1.Value + slider2.Value + slider3.Value + slider4.Value + slider5.Value + slider6.Value + slider7.Value + slider8.Value - slidervalue;

            currentMaxStrikePercentage = 1 - ( (Math.Round(cumulativeSliderValues / SliderStepSize)) * SliderStepSize);

        }

        private void calculateComboSliderMax(double slidervalue)
        {

            double cumulativeSliderValues = comboSlider1.Value + comboSlider2.Value + comboSlider3.Value + comboSlider4.Value + comboSlider5.Value + comboSlider6.Value + comboSlider7.Value + comboSlider8.Value + comboSlider9.Value + comboSlider10.Value - slidervalue;

            currentMaxComboPercentage = 1 - ((Math.Round(cumulativeSliderValues / SliderStepSize)) * SliderStepSize);

        }


        private void SetLevelToBeginner()
        {
            slider1.Value = .85;
            slider1label.Text = (slider1.Value * 100).ToString();

            slider2.Value = .15;
            slider2label.Text = (slider2.Value * 100).ToString();

            slider3.Value = 0;
            slider3label.Text = (slider3.Value * 100).ToString();

            slider4.Value = 0;
            slider4label.Text = (slider4.Value * 100).ToString();

            slider5.Value = 0;
            slider5label.Text = (slider5.Value * 100).ToString();

            slider6.Value = 0;
            slider6label.Text = (slider6.Value * 100).ToString();

            slider7.Value = 0;
            slider7label.Text = (slider7.Value * 100).ToString();

            slider8.Value = 0;
            slider8label.Text = (slider8.Value * 100).ToString();

            ComboInt = 5;

            ComboLengthMin = 1;
            ComboLengthMax = 4;

            AdjustComboSliders(ComboLengthMin, ComboLengthMax);

            comboSlidersArray[0].slider.Value = .05;
            comboSlidersArray[1].slider.Value = .20;
            comboSlidersArray[2].slider.Value = .35;
            comboSlidersArray[3].slider.Value = .40;
            
            comboSlidersArray[0].valueLabel.Text = (comboSlidersArray[0].slider.Value * 100).ToString();
            comboSlidersArray[1].valueLabel.Text = (comboSlidersArray[1].slider.Value * 100).ToString();
            comboSlidersArray[2].valueLabel.Text = (comboSlidersArray[2].slider.Value * 100).ToString();
            comboSlidersArray[3].valueLabel.Text = (comboSlidersArray[3].slider.Value * 100).ToString();

            if (levelbutton.Text != "Beginner")
                levelbutton.Text = "Beginner";

            _intensity = Intensity.Beginner;


        }

        private void SetLevelToIntermediate()
        {
            slider1.Value = .70;
            slider1label.Text = (slider1.Value * 100).ToString();

            slider2.Value = .20;
            slider2label.Text = (slider2.Value * 100).ToString();

            slider3.Value = .05;
            slider3label.Text = (slider3.Value * 100).ToString();

            slider4.Value = .05;
            slider4label.Text = (slider4.Value * 100).ToString();

            slider5.Value = 0;
            slider5label.Text = (slider5.Value * 100).ToString();

            slider6.Value = 0;
            slider6label.Text = (slider6.Value * 100).ToString();

            slider7.Value = 0;
            slider7label.Text = (slider7.Value * 100).ToString();

            slider8.Value = 0;
            slider8label.Text = (slider8.Value * 100).ToString();

            ComboInt = 4;

            ComboLengthMin = 1;
            ComboLengthMax = 5;

            if (levelbutton.Text != "Intermediate")
                levelbutton.Text = "Intermediate";

            _intensity = Intensity.Intermediate;


        }

        private void SetLevelToPro()
        {
            slider1.Value = .60;
            slider1label.Text = (slider1.Value * 100).ToString();

            slider2.Value = .10;
            slider2label.Text = (slider2.Value * 100).ToString();

            slider3.Value = .05;
            slider3label.Text = (slider3.Value * 100).ToString();

            slider4.Value = .05;
            slider4label.Text = (slider4.Value * 100).ToString();

            slider5.Value = .05;
            slider5label.Text = (slider5.Value * 100).ToString();

            slider6.Value = .05;
            slider6label.Text = (slider6.Value * 100).ToString();

            slider7.Value = .05;
            slider7label.Text = (slider7.Value * 100).ToString();

            slider8.Value = .05;
            slider8label.Text = (slider8.Value * 100).ToString();


            ComboInt = 3;

            ComboLengthMin = 1;
            ComboLengthMax = 5;

            if (levelbutton.Text != "Pro")
                levelbutton.Text = "Pro";

            _intensity = Intensity.Pro;


        }

        private void SetLevelToCustom()
        {
            if (levelbutton.Text != "Custom")
                levelbutton.Text = "Custom";

            _intensity = Intensity.Custom;

        }



        private List<Strike> createStrikesList()
        {
            List<Strike> strikeslist = new List<Strike>();

            if (slider1.Value >= .05)
            {
                Strike strikeOne = new Strike() { enabled = true, frequency = (float)slider1.Value, strikeNumber = 1 };
                strikeslist.Add(strikeOne);
            }

            if (slider2.Value >= .05)
            {
                Strike strikeTwo = new Strike() { enabled = true, frequency = (float)slider2.Value, strikeNumber = 2 };
                strikeslist.Add(strikeTwo);
            }

            if (slider3.Value >= .05)
            {
                Strike strikeThree = new Strike() { enabled = true, frequency = (float)slider3.Value, strikeNumber = 3 };
                strikeslist.Add(strikeThree);
            }

            if (slider4.Value >= .05)
            {
                Strike strikeFour = new Strike() { enabled = true, frequency = (float)slider4.Value, strikeNumber = 4 };
                strikeslist.Add(strikeFour);
            }

            if (slider5.Value >= .05)
            {
                Strike strikeFive = new Strike() { enabled = true, frequency = (float)slider5.Value, strikeNumber = 5 };
                strikeslist.Add(strikeFive);
            }

            if (slider6.Value >= .05)
            {
                Strike strikeSix = new Strike() { enabled = true, frequency = (float)slider6.Value, strikeNumber = 6 };
                strikeslist.Add(strikeSix);
            }

            if (slider7.Value >= .05)
            {
                Strike strikeSeven = new Strike() { enabled = true, frequency = (float)slider7.Value, strikeNumber = 7 };
                strikeslist.Add(strikeSeven);
            }

            if (slider8.Value >= .05)
            {
                Strike strikeEight = new Strike() { enabled = true, frequency = (float)slider8.Value, strikeNumber = 8 };
                strikeslist.Add(strikeEight);
            }

            return strikeslist;
        }

        private List<ComboLength> createComboLengthList()
        {
            List<ComboLength> combolengthlist = new List<ComboLength>();
            if (comboSlider1.Value >= .05)
            {
                ComboLength oneStrikeCombo = new ComboLength() { frequency = (float)comboSlider1.Value, strikesInCombo = 1 };
                combolengthlist.Add(oneStrikeCombo);

            }

            if (comboSlider2.Value >= .05)
            {
                ComboLength twoStrikeCombo = new ComboLength() { frequency = (float)comboSlider2.Value, strikesInCombo = 2 };
                combolengthlist.Add(twoStrikeCombo);

            }

            if (comboSlider3.Value >= .05)
            {
                ComboLength threeStrikeCombo = new ComboLength() { frequency = (float)comboSlider3.Value, strikesInCombo = 3 };
                combolengthlist.Add(threeStrikeCombo);
            }

            if (comboSlider4.Value >= .05)
            {
                ComboLength fourStrikeCombo = new ComboLength() { frequency = (float)comboSlider4.Value, strikesInCombo = 4 };
                combolengthlist.Add(fourStrikeCombo);
            }

            if (comboSlider5.Value >= .05)
            {
                ComboLength fiveStrikeCombo = new ComboLength() { frequency = (float)comboSlider5.Value, strikesInCombo = 5 };
                combolengthlist.Add(fiveStrikeCombo);

            }

            if (comboSlider6.Value >= .05)
            {
                ComboLength sixStrikeCombo = new ComboLength() { frequency = (float)comboSlider6.Value, strikesInCombo = 6 };
                combolengthlist.Add(sixStrikeCombo);
            }

            if (comboSlider7.Value >= .05)
            {
                ComboLength sevenStrikeCombo = new ComboLength() { frequency = (float)comboSlider7.Value, strikesInCombo = 7 };
                combolengthlist.Add(sevenStrikeCombo);
            }

            if (comboSlider8.Value >= .05)
            {
                ComboLength eightStrikeCombo = new ComboLength() { frequency = (float)comboSlider8.Value, strikesInCombo = 8 };
                combolengthlist.Add(eightStrikeCombo);

            }

            if (comboSlider9.Value >= .05)
            {
                ComboLength nineStrikeCombo = new ComboLength() { frequency = (float)comboSlider9.Value, strikesInCombo = 9 };
                combolengthlist.Add(nineStrikeCombo);

            }

            if (comboSlider10.Value >= .05)
            {
                ComboLength tenStrikeCombo = new ComboLength() { frequency = (float)comboSlider10.Value, strikesInCombo = 10 };
                combolengthlist.Add(tenStrikeCombo);

            }

            return combolengthlist;

        }



        private void comboSlider1_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / SliderStepSize);
            UpdateComboSliderIncrement(comboSlider1, combolength1Label, newStep);

        }

        private void comboSlider1_DragStarted(object sender, EventArgs e)
        {
            calculateComboSliderMax(comboSlider1.Value);
            SetLevelToCustom();
        }

        private void comboSlider2_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / SliderStepSize);
            UpdateComboSliderIncrement(comboSlider2, combolength2Label, newStep);

        }

        private void comboSlider2_DragStarted(object sender, EventArgs e)
        {
            calculateComboSliderMax(comboSlider2.Value);
            SetLevelToCustom();
        }

        private void comboSlider3_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / SliderStepSize);
            UpdateComboSliderIncrement(comboSlider3, combolength3Label, newStep);


        }

        private void comboSlider3_DragStarted(object sender, EventArgs e)
        {
            calculateComboSliderMax(comboSlider3.Value);
            SetLevelToCustom();
        }

        private void comboSlider4_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / SliderStepSize);
            UpdateComboSliderIncrement(comboSlider4, combolength4Label, newStep);

        }

        private void comboSlider4_DragStarted(object sender, EventArgs e)
        {
            calculateComboSliderMax(comboSlider4.Value);
            SetLevelToCustom();
        }

        private void comboSlider5_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / SliderStepSize);
            UpdateComboSliderIncrement(comboSlider5, combolength5Label, newStep);

        }

        private void comboSlider5_DragStarted(object sender, EventArgs e)
        {
            calculateComboSliderMax(comboSlider5.Value);
            SetLevelToCustom();
        }

        private void comboSlider6_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / SliderStepSize);
            UpdateComboSliderIncrement(comboSlider6, combolength6Label, newStep);

        }

        private void comboSlider6_DragStarted(object sender, EventArgs e)
        {
            calculateComboSliderMax(comboSlider6.Value);
            SetLevelToCustom();
        }

        private void comboSlider7_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / SliderStepSize);
            UpdateComboSliderIncrement(comboSlider7, combolength7Label, newStep);
        }

        private void comboSlider7_DragStarted(object sender, EventArgs e)
        {
            calculateComboSliderMax(comboSlider7.Value);
            SetLevelToCustom();
        }

        private void comboSlider8_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / SliderStepSize);
            UpdateComboSliderIncrement(comboSlider8, combolength8Label, newStep);

        }

        private void comboSlider8_DragStarted(object sender, EventArgs e)
        {
            calculateComboSliderMax(comboSlider8.Value);
            SetLevelToCustom();
        }

        private void comboSlider9_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / SliderStepSize);
            UpdateComboSliderIncrement(comboSlider9, combolength9Label, newStep);


        }

        private void comboSlider9_DragStarted(object sender, EventArgs e)
        {
            calculateComboSliderMax(comboSlider9.Value);
            SetLevelToCustom();
        }

        private void comboSlider10_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var newStep = Math.Round(e.NewValue / SliderStepSize);
            UpdateComboSliderIncrement(comboSlider10, combolength10Label, newStep);


        }

        private void comboSlider10_DragStarted(object sender, EventArgs e)
        {
            calculateComboSliderMax(comboSlider10.Value);
        }


        private void UpdateSliderIncrement(Xamarin.Forms.Slider slider, Label label, double newstep) 
        {
            if (newstep * SliderStepSize <= currentMaxStrikePercentage)
            {
                slider.Value = newstep * SliderStepSize;
                label.Text = (slider.Value * 100).ToString();

            }

            else
            {
                slider.Value = currentMaxStrikePercentage;
                label.Text = (currentMaxStrikePercentage * 100).ToString();
            }
        }



        private void UpdateComboSliderIncrement(Xamarin.Forms.Slider slider, Label label, double newstep)
        {
            if (newstep * SliderStepSize <= currentMaxComboPercentage)
            {
                slider.Value = newstep * SliderStepSize;
                label.Text = (slider.Value * 100).ToString();

            }

            else
            {
                slider.Value = currentMaxComboPercentage;
                label.Text = (currentMaxComboPercentage * 100).ToString();
            }
        }

        private void AdjustComboSliders(int min, int max)
        {
            for (int i = min -1; i < max; i++)
            {

                comboSlidersArray[i].ShowBundle();
            }

            for (int i=0; i < min - 1; i++)
            {
                comboSlidersArray[i].HideBundle();
            }

            for (int i = max; i < 10; i++)
            {
                comboSlidersArray[i].HideBundle();

            }


        }

        private async void AdvancedSettingsBut_Clicked(object sender, EventArgs e)
        {
            
            if(AdvSettingsVis == false)
            {
                AdvSettingsVis = true;
                AdvancedSettingsBut.FadeTo(.5, 300, Easing.Linear);
                AdvancedSettingsBut.Text = "- ADVANCED SETTINGS";
                await scrollview.ScrollToAsync(AdvancedSettingsBut, ScrollToPosition.Start, true);
                return;


            }
    

            if(AdvSettingsVis == true)
            {
                AdvSettingsVis = false;
                AdvancedSettingsBut.FadeTo(1, 300, Easing.Linear);
                AdvancedSettingsBut.Text = "+ ADVANCED SETTINGS";
                return;
            }



        }


    }




}