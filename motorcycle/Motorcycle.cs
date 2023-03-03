using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace motorcycle
{
    class Motorcycle
    {
        private bool started;
        private int rpm;
        private int gear;
        private string name;
        public string Name
        {

            get { return name; }
           
        }

        public Motorcycle()
        {
            name = "";
            started = false;
            rpm = 0;
            gear = 0;
        }

        public Motorcycle(string name, bool started)
        {
            this.name = name;
            this.started = started;
            
            if (started)
            {
                rpm = 1000;
            }
            else
            {
                rpm = 0;
            }

            gear = 0;
        }


        public int Rpm {

            get { return rpm; }
            
            set
            {
                if (started && value > 8000)
                {
                    rpm = value;
                }
                else if (value < 1000)
                {
                    stop();
                }
                
            }
        }


        public bool isStarted()
        {
            return started;
        }

        public void start()
        {
            if (!started)
            {
                started = true;
                rpm = 1000;
                gear= 0;
            }

            
        }

        public void stop()
        {
            started = false;
            rpm= 0;
            gear = 0;
        }

        public int getSpeed()
        {
            return rpm * gear / 200;
        }

        public void shiftGearsUp()
        {
            if (started && gear < 5)
            {
                gear++;
            }
        }

        public void shiftGearsDown(int g)
        {
            if (started && g < gear && g > 0 )
            {
                gear = g;
                    
            }
        }

        public int getGear()
        {
            return gear;
        }


        public override string ToString()
        {
            return $"Name: {Name}\nSpeed: {getSpeed()}\nGear: {gear}\nRpm: {rpm}\n\n";
        }

    }
}
