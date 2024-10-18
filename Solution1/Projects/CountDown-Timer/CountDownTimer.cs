using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.CountDown_Timer
{
    public class CountDownTimer
    {
        public delegate void TickEventHandler(int seconds);
        static public event  TickEventHandler Tick;
        static public event  TickEventHandler TimeUp;
        public void StartCountDown(int seconds)
        {
            for(var i = seconds; i >= 0; i--)
            {
                Tick?.Invoke(i);

                if (i == 0)
                {
                    TimeUp?.Invoke(i);
                }
            }
        }

        static public void Counter(int second)
        {
            Console.WriteLine(second);
        }

        static public void StopCountDown(int seconds)
        {
            Console.WriteLine("Time's UP!.....Counter Ended!");
        }
    }
}
