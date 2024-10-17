using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projects.Events
{
    internal class TempratureSensor
    {
        public delegate void TempratureEceededEventHandler(int Temprature);
        public event TempratureEceededEventHandler TempratureEceeded;
        public event TempratureEceededEventHandler TempratureBelow;
        public void Limited(int Temprature)
        {
            if (Temprature >= 100)
            {
                TempratureEceeded?.Invoke(Temprature);
            }
            else
            {
                TempratureBelow?.Invoke(Temprature);
            }
        }
    }
}
