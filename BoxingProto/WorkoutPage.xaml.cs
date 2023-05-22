using BoxingProto.Classes;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BoxingProto
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkoutPage : ContentPage
    {

        public ObservableCollection <Workout> workoutList { get;  set; } 
        string[] strings = new string[4];
        public int AddWorkoutFlag = 0;
        public Workout ReceivedWorkout = new Workout();



        private void WorkoutPage_Disappearing(object sender, EventArgs e)
        {
            
        }


        protected override async void OnAppearing() 
        {
            base.OnAppearing();
            
            if (Application.Current.Properties.ContainsKey("WorkoutsLoaded"))
            {
                workoutList = new ObservableCollection<Workout>(await WorkoutService.GetWorkouts());
                Application.Current.Properties.Remove("WorkoutsLoaded");
            }

            listView.ItemsSource = workoutList;


            if (AddWorkoutFlag == 1)
            {
                workoutList.Add(ReceivedWorkout);
                AddWorkoutFlag = 0;
                ReceivedWorkout = new Workout();
            }
        }

        
        public WorkoutPage()
        {
            InitializeComponent();

            MessagingCenter.Subscribe<WorkoutRunner, Workout>(this, "newworkout", AddReceivedwWorkout);


            Disappearing += WorkoutPage_Disappearing;

            strings[0] = "Begin";
            strings[1] = "Edit";
            strings[2] = "Delete";
            strings[3] = "Rename";


            BindingContext = this;

        }

        private async void listView_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var workout = e.Item as Workout;
            var response = await DisplayActionSheet(workout.Name, "Back", null, strings );
            


            switch (response)
            {
                case "Delete":
                    {
                        workoutList.Remove(workout);
                        await WorkoutService.RemoveWorkout(workout.Id);
                        return;
                    }

                case "Edit":
                    {
                        await Navigation.PushAsync(new WorkoutEditPage(workout));
                        return;
                    }

                case "Begin":
                    {
                        await Navigation.PushAsync(new WorkoutRunner(workout));
                        return;
                    }
            }

        }

        async private void AddWorkout(object sender, EventArgs e)
        {
            Workout workout = new Workout();
            workout.Name = "New Workout";

            workout.AddGenericRounds(5);
            workoutList.Add(workout);


            await WorkoutService.AddWorkoutToDB(workout);
        }


        private void AddReceivedwWorkout(WorkoutRunner sender, Workout _workout)
        {
            ReceivedWorkout = _workout;
            AddWorkoutFlag = 1;

        }

    }
}