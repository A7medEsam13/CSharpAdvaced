using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.CountDown_Timer
{
    public class App
    {
        static public void Run()
        {
            CountDownTimer Counter=new CountDownTimer();
            CountDownTimer.Tick += CountDownTimer.Counter;
            CountDownTimer.TimeUp += CountDownTimer.StopCountDown;
            Counter.StartCountDown(10);
        }
    }
}
