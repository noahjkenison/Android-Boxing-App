using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using SQLiteNetExtensions;
using SQLiteNetExtensions.Extensions;
using SQLiteNetExtensionsAsync.Extensions;
using System.Linq;

namespace BoxingProto.Classes
{
    public static class WorkoutService 
    {
        static SQLiteAsyncConnection db; 

        static async Task Init() 
        {
            if (db != null)
                return;

            var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "WorkoutsNew.db");
            db = new SQLiteAsyncConnection(databasePath); 

            await db.CreateTableAsync<Workout>(); 
            await db.CreateTableAsync<Round>();
            await db.CreateTableAsync<Strike>();
            await db.CreateTableAsync<ComboLength>();

        }


        public static async Task AddWorkoutToDB(Workout workout)
        {
            await Init();
            workout.storedRounds = workout.roundList.ToList();
            await db.InsertWithChildrenAsync(workout);
        }

        public static async Task UpdateWorkout(Workout workout)
        {
            await Init();
            await RemoveWorkout(workout.Id);
            await AddWorkoutToDB(workout);

        }

        public static async Task RemoveRound(int Id) 
        {
            await Init();
            await db.DeleteAsync<Round>(Id);

        }



        public static async Task RemoveWorkout(int Id) 
        {
            await Init();
            await db.DeleteAsync<Workout>(Id);

        }

        public static async Task<IEnumerable<Workout>> GetWorkouts()
        {
            await Init();
            List<Workout> workouts = await db.GetAllWithChildrenAsync<Workout>();

            for (int i = 0; i < workouts.Count(); i++)
            {
                workouts[i].roundList = new ObservableCollection<Round>(workouts[i].storedRounds);
            }


            return workouts;
        }

        public static async Task ClearWorkouts()
        {
            await db.DeleteAllAsync<Workout>();
        }

    }
}
