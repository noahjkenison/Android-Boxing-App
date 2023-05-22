using BoxingProto.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BoxingProto

{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WorkoutEditPage : ContentPage
    {
        Workout workout { get; set; } = new Workout();
        public string[] strings { get; set; } = new string[2];

        public WorkoutEditPage(Workout Workout)
        {
            InitializeComponent();
            workout = Workout;
            

            workoutlabel.BindingContext = workout;
            workoutlabel.SetBinding(Label.TextProperty, "Name");

            editpageview.ItemsSource = workout.roundList;
            strings[0] = "Edit";
            strings[1] = "Delete";

            Workout.RecalculateIndices();
            
        }



        private void Button_Pressed(object sender, EventArgs e)
        {


            TimeSpan timespan = new TimeSpan(0, 3, 0);
            double combointerval = 5;
            List <ComboLength> combolengthList = new List<ComboLength>();

            List<Strike> strikes = new List<Strike>();


            Strike strike1 = new Strike() { strikeNumber = 1, frequency = .7f};
            Strike strike2 = new Strike() { strikeNumber = 2,  frequency = .2f};
            Strike strike3 = new Strike() { strikeNumber = 3, frequency = .1f };

            strikes.Add(strike1);
            strikes.Add(strike2);
            strikes.Add(strike3);


            Round round = new Round(timespan, combointerval,  strikes, combolengthList);
            workout.roundList.Add(round);
            workout.roundList.IndexOf(round);
        }

        private async void editpageview_ItemTapped(object sender, ItemTappedEventArgs e)
        {

                var response = await DisplayActionSheet("Round Number", "Back", null, strings);
                var round = e.Item as Round;

                switch (response)
                {
                    case "Delete":
                        {
                            workout.roundList.Remove(round);
                            await WorkoutService.RemoveRound(round.Id);
                            return;
                        }

                    case "Edit":
                        {
                            await Navigation.PushAsync(new NewEditRoundPage(round));
                            return;
                        }
                }


            }
        }
    }
