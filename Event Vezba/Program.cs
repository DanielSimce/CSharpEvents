using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Vezba
{
    public class Program
    {
        static void Main(string[] args)
        {
            Football football = new Football();
            Goal goal = new Goal();
            football.GoalArrived += new GoalHandler(goal.Messi);
            football.Connect();

            Console.ReadLine();


        }

        
    }
}
