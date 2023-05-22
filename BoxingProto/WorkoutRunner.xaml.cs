using BoxingProto.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.Xaml;
using static Xamarin.Essentials.Permissions;
using DevExpress.XamarinForms.CollectionView;
using BoxingProto.Models;
using BoxingProto.ViewModels;
using System.Windows.Input;
using System.Diagnostics;

namespace BoxingProto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkoutRunner : ContentPage
    {
        public System.Timers.Timer restRoundTimer;
        public System.Timers.Timer startWorkoutTimer;

        public Workout workout { get; set; }
        public int currentRoundIndex { get; set; }
        

        public string currentroundstring { get; set; }

        public TimeSpan timeremaining { get; private set; }
        public TimeSpan timebetweenrounds { get; private set; } = new TimeSpan(0, 0, 10);

        TimeSpan oneSecond = new TimeSpan(0, 0, 1);
        TimeSpan zeroSeconds = new TimeSpan(0, 0, 0);


        private bool restroundrunning { get; set; } = false;



        public bool RestRoundRunning
        {
            get
            {
                return restroundrunning;
            }

            set
            {
                restroundrunning = value;
                OnPropertyChanged();
            }
        }











        private bool workoutpaused { get; set; } = true;
        public bool WorkoutPaused
        {
            get
            {
                return workoutpaused;
            }

            set
            {
                workoutpaused = value;
                OnPropertyChanged();
            }
        }

        //bool workoutPaused = true;


        private bool workoutbegan = false;
        public bool workoutBegan
        {
            get
            {
                return workoutbegan;
            }

            set
            {
                workoutbegan = value;
                if (workoutbegan == true)
                    InverseWorkoutBegan = false;

                if (workoutbegan == false)
                    InverseWorkoutBegan = true;
                OnPropertyChanged();
            }
        }

        private bool inverseworkoutbegan = true;
        public bool InverseWorkoutBegan
        {
            get
            {
                return inverseworkoutbegan;
            }

            set
            {
                inverseworkoutbegan = value;
                OnPropertyChanged();
            }
        }


        //private bool inverseworkoutpaused = false;
        //public bool InverseWorkoutPaused
        //{
        //    get
        //    {
        //        return inverseworkoutpaused;
        //    }

        //    set
        //    {
        //        inverseworkoutpaused = value;
        //        OnPropertyChanged();
        //    }
        //}


        private int currentRoundNumber = 1;

        Round currentround;
        public int CurrentRoundNumber
        {
            get { return currentRoundNumber; }
            set { if (value == currentRoundNumber)
                    return;

                    currentRoundNumber = value;
                    OnPropertyChanged();
            }
        }

        public string[] strings { get; set; } = new string[2] { "Delete", "Edit" };

        private string workouttimeremaining;
        public string WorkoutTimeRemaining
        {
            get
            {
                return workouttimeremaining;
            }

            set
            {
                workouttimeremaining = value;
                OnPropertyChanged();
            }
        }


        private float pageopacity = 1f;

        public float PageOpacity
        {
            get
            {
                return pageopacity;
            }

            set
            {
                pageopacity = value;
                OnPropertyChanged();
            }
        }


        private int firstroundprepsec { get; set; }
        public int FirstRoundPrepSec
        {
            get
            {
                return firstroundprepsec;
            }

            set
            {
                firstroundprepsec = value;
                OnPropertyChanged();
            }
        }


        public System.Timers.Timer timertest;




        protected override bool OnBackButtonPressed()
        {
            // Begin an asyncronous task on the UI thread because we intend to ask the users permission.
            Device.BeginInvokeOnMainThread(async () =>
            {

                if (workoutBegan == true)
                {
                    if (await DisplayAlert("Exit workout?", "Are you sure you want to exit this workout? This workout's progress will be lost", "Yes", "No") == true)
                    {
                        //base.OnBackButtonPressed(); //"base" lets us access the normal behavior of the back button? Guide included it, but is it necessary?

                        ResetActiveWorkout();
                        await Navigation.PopAsync();
                    }
                }

                else
                    await Navigation.PopAsync();


            });

            // Always return true because this method is not asynchronous.
            // We must handle the action ourselves: see above.
            return true; // "True" stays on the same page. However, above, we intercept and Pop the page back.
        }




        Round selectedround = new Round();
        Round editedroundcopy = new Round();
        int selectedindex = -1;
        int roundupdateflag = 0;

        public void ResetActiveWorkout()
        {
            RunWorkoutBut.IsVisible = true;
            PauseWorkoutBut.IsVisible = false;

            workout.ResetWorkout();

            CurrentRoundNumber = 1;
            currentRoundIndex = 0;

            if (Application.Current.Properties.ContainsKey("roundcount"))
                Application.Current.Properties.Remove("roundcount");

            if (Application.Current.Properties.ContainsKey("workoutBegan"))
                Application.Current.Properties.Remove("workoutBegan");

            workout.RecalculateIndices();
            workoutBegan = false;
            calculateWorkoutTimeRemaining();

            for (int i = 0; i < workout.roundList.Count; i++)
                workout.roundList[i].CellColor = Color.LightGray;
        }



        public WorkoutRunner(Workout Workout)
        {

            MessagingCenter.Subscribe<RoundRunner, Round>(this, "currentround", SetCurrentRound); //where to put this? onappearing or here?
            MessagingCenter.Subscribe<NewEditRoundPage, Round>(this, "editedround", SetEditedRound);

            workout = Workout;
            Application.Current.Properties["roundcount"] = CountActiveRounds(workout);
            InitializeComponent();
            addroundbutton.Source = ImageSource.FromResource("BoxingProto.Images.maroonPlus.png");
            boxingglovesimage.Source = ImageSource.FromResource("BoxingProto.Images.boxingGloves.png");

            BindingContext = this;

            Appearing += WorkoutRunner_Appearing;
            Disappearing += WorkoutRunner_Disappearing;

            restRoundTimer = new System.Timers.Timer(100);
            restRoundTimer.Elapsed += RestRoundTimer_Elapsed; 
            restRoundTimer.AutoReset = true;
            restRoundTimer.Enabled = false;




            //filledplay3
            //savedplay



            RunWorkoutBut.Source = ImageSource.FromResource("BoxingProto.Images.workoutRun.png");
            SaveWorkoutBut.Source = ImageSource.FromResource("BoxingProto.Images.toolbarsave.png");
            PauseWorkoutBut.Source = ImageSource.FromResource("BoxingProto.Images.workoutPause.png");

        }

        private void RestRoundTimer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            throw new NotImplementedException();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            

            if (roundupdateflag == 1)
            {
                ReplaceRound(workout, editedroundcopy, selectedindex);

                editedroundcopy = new Round();
                selectedround = new Round();
                selectedindex = 0;
                roundupdateflag = 0;
            }
        }

        private void WorkoutRunner_Appearing(object sender, EventArgs e) 
        {
            FirstRoundPrepSec = 5;
            PageOpacity = 1;
            int y = 0;
            //Can get rid of y and just use roundindex I believe.



            workoutnamestack.Opacity = 1;
            timeremainingstack.Opacity = 1;
            roundstacklayout.Opacity = 1;
            timeremaininglabel.Opacity = 1;
            collectionview.Opacity = 1;
            addroundbutton.Opacity = 1;
            prepstack.Opacity = 0;
            collectionview.IsVisible = true; addroundbutton.IsVisible = true;


            workout.RecalculateIndices();
            calculateWorkoutTimeRemaining();

            //set application key for total # of rounds herea    

            for (int i = 0; i < workout.roundList.Count; i++)
            {
    
                if (workout.roundList[i].roundstatus == RoundStatus.Complete)
                {
                    y++;
                                        
                    
                }
            }


            currentRoundIndex = y;
            CurrentRoundNumber = y + 1;
            Application.Current.Properties["currentroundnumber"] = CurrentRoundNumber;



            if (y == workout.roundList.Count)
            {
                SendEndRoundMessage(workout);

                ResetActiveWorkout();




                y = 0;
            }


        }

        private void WorkoutRunner_Disappearing(object sender, EventArgs e)
        {

        }


        private void SetCurrentRound(RoundRunner sender, Round _round)
        {
            currentround = _round;
        }

        private void SetEditedRound(NewEditRoundPage sender, Round _editedround)
        {
            editedroundcopy = _editedround;
            roundupdateflag = 1;

        }

        private async void PlayWorkout(object sender, EventArgs e)
        {
            await RunWorkoutBut.ScaleTo(RunWorkoutBut.Scale + .02, 50, Easing.Linear);
            await RunWorkoutBut.ScaleTo(RunWorkoutBut.Scale - .02, 50, Easing.Linear);


            if (workoutBegan == true)
            {
                //await Navigation.PushAsync(new RoundRunner(workout.roundList[currentRoundIndex]));
            }

            else
            {
                //PauseWorkoutBut.IsVisible = true;

                //WorkoutPaused = false;
                workoutBegan = true;
                //Checking if this is the very first start of this workout.

                if (Application.Current.Properties.ContainsKey("workoutBegan") == false)
                {
                    Application.Current.Properties["workoutBegan"] = true;
                    workoutnamestack.FadeTo(0, 1500, Easing.CubicIn);
                    timeremainingstack.FadeTo(0, 1500, Easing.Linear);
                    roundstacklayout.FadeTo(0, 1500, Easing.Linear);
                    timeremaininglabel.FadeTo(0, 1500, Easing.Linear);
                    collectionview.FadeTo(0, 1500, Easing.Linear);
                    addroundbutton.FadeTo(0, 1500, Easing.Linear);
                    RunWorkoutBut.FadeTo(0, 1500, Easing.Linear);

                    prepstack.FadeTo(1, 1500, Easing.Linear);
                    
                    collectionview.IsVisible = false; addroundbutton.IsVisible = false;
                    
                    RunWorkoutStartScreen(FirstRoundPrepSec);

                }

                else
                {
                    Application.Current.Properties["workoutBegan"] = true;
                    //workoutBegan = true; //THIS IS BOUND TO VISIBILITY OF CERTAIN ELEMENTS ON PAGE. BETTER WAY TO DO THIS?
                    Run();
                }
            }

            




        }


        private async void RunWorkoutStartScreen(int seconds)
        {
            Device.StartTimer(new TimeSpan(0, 0, 1), () =>
            {
                

                if (seconds == 0)
                {
                    WorkoutPaused = false;
                    Run();
                    return false;
                    
                }


                Device.BeginInvokeOnMainThread(() =>
                {
                    seconds = seconds - 1;
                    FirstRoundPrepSec = seconds;
                    //boxingglovesimage.ScaleTo(1.1, 500, Easing.Linear);
                    
                });


                return true;


            });

            


        }

        public void Run()
        {
            Device.StartTimer(new TimeSpan(0, 0, 1),  () =>
            {

                if (WorkoutPaused == true)
                {
                    return false;
                }



                if (workout.roundList[currentRoundIndex].isRestRound == true) //current problem is that This timer (original workout timer), is running every second. so every second
                //it is creating a new RunRestRound timer. Solutions:
                //1. create bool here that checks if rest round is running (if yes, t hen we don't create a new timer).
                    //however, this will leave 2 timers running. performance?
                //2.somehow PAUSE the Workout Runner timer (this is what I expected to happen). Essentially, create a "loop" with the second timer, where that's the only active one.
                //perhaps I can make it return false after running my rest Round?  Then run Run() after restRound is finished.
                
                {
                    runRestRound(workout.roundList[currentRoundIndex]);
                    return false;
                    
                }



                if (timeremaining == zeroSeconds && workout.roundList[currentRoundIndex].isRestRound != true)
                {
                    Navigation.PushAsync(new RoundRunner(workout.roundList[currentRoundIndex]));

           
                    return false;

                }


                


                Device.BeginInvokeOnMainThread(() =>
                {
                    timeremaining = timeremaining - oneSecond;      //i believe I will need to use INotifyPropertyChanged to bind this to label.text.
                    timeremaininglabel.Text = timeremaining.ToString();                                                // label.Text = timeremaining.ToString();

                });



                if (WorkoutPaused == false)
                    return true;


                return true;


            });

        }


        private async void addroundbutton_Clicked(object sender, EventArgs e)
        {

            await addroundbutton.ScaleTo(addroundbutton.Scale + .02, 50, Easing.Linear);
            await addroundbutton.ScaleTo(addroundbutton.Scale - .02, 50, Easing.Linear);

            TimeSpan _restlength = new TimeSpan(0, Convert.ToInt16(1), Convert.ToInt16(0));
            TimeSpan _roundlength = new TimeSpan(0, Convert.ToInt16(3), Convert.ToInt16(0));
            List<Strike> StrikesList = workout.roundList[0]._strikesList;
            //Strike[] StrikesArray = workout.roundList[0]._strikesArray;

            List<ComboLength> ComboLengthList = workout.roundList[0].combolengthlist;
            //ComboLength[] ComboLengthArray = workout.roundList[0].combolengtharray; 
            double ComboInt = workout.roundList[0]._comboInterval;


            Round round1 = new Round(_roundlength, ComboInt, StrikesList, ComboLengthList) { strikesEnabled = workout.roundList[0].strikesEnabled };
            Round round2 = new Round(_restlength) { isRestRound = true };

            workout.roundList.Add(round2);
            workout.roundList.Add(round1);
            


            workout.RecalculateIndices();
            calculateWorkoutTimeRemaining();

            collectionview.ScrollTo(workout.roundList.Count(), position: ScrollToPosition.End);


        }


        //private void recalculateIndices()
        //{
        //    string index = "1";


        //    for (int i = 0; i < workout.roundList.Count(); i++)
        //    {


        //        if (workout.roundList[i].isRestRound == false)
        //        {
        //            workout.roundList[i].visibleIndex = index;
        //            index = Convert.ToString(Convert.ToInt16(index) + 1);
        //        }

        //    }
        //}

        private async void collectionview_SelectionChanged(object sender, SelectionChangedEventArgs e)

            //"sender" object is something that does something specifi and interesting to other classes. All objects interested in the event can register and listen to it.
            //Simply put, the "sender" is the object which raised the event.

            //the EventArgs object representsan object which holds event-specific message. 


        {

            if (collectionview.SelectedItem == null)
            {
                return;
            }




            //Round _round = (Round)collectionview.SelectedItem;
            selectedround = (Round)collectionview.SelectedItem;
            

            if (selectedround.roundstatus == RoundStatus.Inprogress)
            {
                await Navigation.PushAsync(new RoundRunner(workout.roundList[currentRoundIndex]));
                collectionview.SelectedItem = null;
                return;

            }



            var response = await DisplayActionSheet("Round Number", "Back", null, strings);

            switch (response)
            {

                case "Edit":
                    {
                        await Navigation.PushAsync(new NewEditRoundPage(selectedround));
                        selectedindex = workout.roundList.IndexOf(selectedround);
                        //testround = editedroundcopy;
                        

                        
                        return;
                    }

                case "Delete":
                    {
                        workout.roundList.Remove(selectedround);
                        workout.RecalculateIndices();
                        return;
                    }


            }

            if (collectionview.SelectedItem != null)
            {
                collectionview.SelectedItem = null;
            }



        }

        private void calculateWorkoutTimeRemaining()
        {

            TimeSpan _workoutTimeSpanRemaining = new TimeSpan();

            for (int i = 0; i < workout.roundList.Count(); i++)
            {
                _workoutTimeSpanRemaining = _workoutTimeSpanRemaining + workout.roundList[i]._RemainingRoundTime;
            }

            WorkoutTimeRemaining = _workoutTimeSpanRemaining.ToString(@"hh\:mm\:ss");

        }

        private void runRestRound(Round round)
        {
            round.roundstatus = RoundStatus.Inprogress;
            round.CellColor = Color.LightYellow;
            RestRoundRunning = true;

            Device.StartTimer(new TimeSpan(0, 0, 1), () =>
            {

                if (round._RemainingRoundTime == TimeSpan.Zero)
                {
                    round.roundstatus = RoundStatus.Complete;
                    round.CellColor = Color.LightGreen;
                    currentRoundIndex += 1;
                    RestRoundRunning = false;
                    Run();
                    return false;

                }


                Device.BeginInvokeOnMainThread(() =>
                {
                    round._RemainingRoundTime -= oneSecond;

                });


                return true;

            });



        }

        //private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
        //{
        //    var frame = (sender as Element).Parent as Frame;
        //    frame.BackgroundColor = Color.Red;

        //    Grid griddy = (Grid)frame.Content;
        //    griddy.BackgroundColor = Color.Blue;


        //    var frame2 = e.Data;
           
        //}

        private int CountActiveRounds(Workout _workout)
        {
            int count = 0;

            for (int i = 0; i < _workout.roundList.Count; i++)
            {
                if (_workout.roundList[i].isRestRound == false)
                    count++;
            }

            return count;
        }

        private async void SaveWorkout(object sender, EventArgs e)
        {

            await SaveWorkoutBut.ScaleTo(SaveWorkoutBut.Scale + .08, 50, Easing.Linear);
            await SaveWorkoutBut.ScaleTo(SaveWorkoutBut.Scale - .08, 50, Easing.Linear);




            if (workout.Name == "Quick Workout")
            {
                string workoutname = await DisplayPromptAsync("Save workout", "Enter a name for this workout.");
                workout.Name = workoutname;
                await WorkoutService.AddWorkoutToDB(workout);
                MessagingCenter.Send(this, "newworkout", workout);



            }
            else
            {
                bool answer = await DisplayAlert("Overwrite workout", "Would you like to save any changes to this workout?", "Yes", "No");


                if (answer == true)
                    await WorkoutService.UpdateWorkout(workout);


            }


            

            //workout.roundList.RemoveAt(selectedindex);
            //workout.roundList.Insert(selectedindex, editedroundcopy);
            //workout.RecalculateIndices();

            //editedroundcopy = new Round();
            //selectedround = new Round();
            //selectedindex = 0;

        }

        private void ReplaceRound(Workout _workout, Round _round, int _index)
        {
            _workout.roundList.RemoveAt(_index);
            _workout.roundList.Insert(_index, _round);
            _workout.RecalculateIndices();


        }

        private async void SendEndRoundMessage(Workout _workout)
        {


            await DisplayAlert("Workout", "Workout Complete!", "Back");

            if (_workout.Name == "Quick Workout")
            {
                bool answer = await DisplayAlert("Save workout?", "Would you like to save this workout?", "Yes", "No");

                if(answer == true)
                {
                    string newworkoutname = await DisplayPromptAsync("Save workout", "Enter a name for this workout.");
                    _workout.Name = newworkoutname;
                    await WorkoutService.UpdateWorkout(_workout);
                }

            }


        }



        private async void PauseWorkout(object sender, EventArgs e)
        {
            await PauseWorkoutBut.ScaleTo(PauseWorkoutBut.Scale + .02, 50, Easing.Linear);
            await PauseWorkoutBut.ScaleTo(PauseWorkoutBut.Scale - .02, 50, Easing.Linear);
            WorkoutPaused = true;
        }

        //private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        //{
        //    var response = await DisplayActionSheet("Round Number", "Back", null, strings);
        //    string result = await DisplayPromptAsync("Question 1", "What's your name?");

        //    Round _round = (Round)collectionview.SelectedItem; // "selected item?"


        //    switch (response)
        //    {
        //        case "Delete":
        //            {
        //                workout.roundList.Remove(_round);
        //                workout.RecalculateIndices();
        //                return;
        //            }

        //        case "Edit":
        //            {
        //                await Navigation.PushAsync(new editround3());
        //                return;
        //            }
        //    }

        //}
    }
    }