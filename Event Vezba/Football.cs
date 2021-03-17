using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Event_Vezba
{
    public delegate void GoalHandler(string goalMessage);


    public class Football
    {

        public event GoalHandler GoalArrived;
        private Timer timer;

        public Football()
        {
            timer = new Timer(3000);
            timer.Elapsed += new ElapsedEventHandler(Message);


        }

        public void Connect() => timer.Start();

        Random rnd = new Random();

        public void Message(object sender, ElapsedEventArgs e)
        {
            Console.WriteLine("Utakmicata pocna");
            if (rnd.Next(9) == 0 )
            {
                GoalArrived("Messi dade gol od sloboden udar");
            }

        }



    }
}
