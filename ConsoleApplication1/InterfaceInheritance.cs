using System;

namespace ConsoleApplication1
{
    interface IExercise
    {
        void Run();
        void ChestWorkout();
        void BicepsWorkout();
        void BackWorkout();
    }

    class Monday : IExercise
    {
        public void Run()
        {
            Console.WriteLine("Run 2 miles on Monday");
        }

        public void ChestWorkout()
        {
            Console.WriteLine("Do benchpresses on Monday");
        }

        public void BicepsWorkout()
        {
            Console.WriteLine("No Biceps on Monday");
        }

        public void BackWorkout()
        {
            Console.WriteLine("No Backs on Monday");
        }
    }
    internal class InterfaceInheritance
    {
        public static void Main(string[] args)
        {
            Monday monday = new Monday();
            monday.Run();
            monday.BackWorkout();
            monday.BicepsWorkout();
            monday.ChestWorkout();
        }
    }
}