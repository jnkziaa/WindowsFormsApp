using System;

namespace ConsoleApplication1.Properties
{
    interface IExercise
    {
        void Run();
        void ChestWorkout();
        void BackWorkout();
        void BicepsWorkout();
    }

    interface ITodo
    {
        void CleanRoom();
        void CleanCar();
        void CleanKitcher();
    }

    class Saturday : IExercise, ITodo
    {
        public void Run()
        {
            Console.WriteLine("Run atleast 5 miles on Saturday");
        }

        public void ChestWorkout()
        {
            Console.WriteLine("Saturday is no chest day");
        }

        public void BackWorkout()
        {
            Console.WriteLine("Saturday is Back workout day");
        }

        public void BicepsWorkout()
        {
            Console.WriteLine("Saturday is no biceps day");
        }

        public void CleanRoom()
        {
            Console.WriteLine("Saturday is clean room day");
        }

        public void CleanCar()
        {
            Console.WriteLine("Saturday is not a clean car day");
        }

        public void CleanKitcher()
        {
            Console.WriteLine("Saturday is clean Kitchen day");
        }
    }
    public class MultipleInterfaceInheritance
    {
        public static void Main(string[] args)
        {
            Saturday saturday = new Saturday();
            saturday.Run();
            saturday.BackWorkout();
            saturday.BicepsWorkout();
            saturday.ChestWorkout();
            saturday.CleanCar();
            saturday.CleanKitcher();
            saturday.CleanRoom();
        }
    }
}