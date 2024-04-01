using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot
{
    public class Robot
    {
        /*
        private string model;

        public string GetModel()
        {
            return model;
        }

        public void SetModel(string model) 
        {
            this.model = model;
        }
        */

        public string Model { get; init; }

        public int BatteryCapacity { get; private set; }

        private int _batteryLevel;
        public int BatteryLevel 
        {   
            get 
            { 
                return _batteryLevel; 
            }

            private set 
            { 
                if(value < 0)
                {
                    _batteryLevel = 0;
                }
                else if (value > 100)
                {
                    _batteryLevel = 100;
                }
                else
                {
                    _batteryLevel = value;
                }
            }
        }

        private string _task;
        public string Task 
        { 
            get 
            { 
                if(_task is null)
                {
                    return "No Task Set";
                }
                else
                {
                    return _task;
                }
            } 
            set
            {
                _task = value;
            }
        }


        public Robot()
        {
            Model= string.Empty;
            BatteryCapacity = 1000;
            BatteryLevel = 100;
            Task = null;
        }
        public Robot(string model)
        {
            Model = model;

            if (model == "X003")
            {
                Model = model;
                BatteryCapacity = 5500;
                BatteryLevel = 100;
                Task = null;
            }
            else if(model == "X002")
            {
                Model = model;
                BatteryCapacity = 2500;
                BatteryLevel = 100;
                Task = null;
            }
            else
            {
                Model = model;
                BatteryCapacity = 1000;
                BatteryLevel = 100;
                Task = null;
            }

        }

        public void Charge(int minutes)
        {
            Task = $"Charged: {minutes} minutes";

            while(minutes-- > 0)
            {
                BatteryLevel++;
            }

        }

        public void MoveForward()
        {
            //cost 1%
            if(BatteryLevel > 1)
            {
                BatteryLevel--;
                Task = "Moved Forward";
            }
            else
            {
                Task = "Unable to Move Going to Charge for 5 minutes";
                Charge(5);
            }
            
        }

        public override string ToString()
        {
            string info = "";
            info += $"Model: {Model}\n";
            info += $"Batter Capacity: {BatteryCapacity}\n";
            info += $"Battery Level: {BatteryLevel}\n";
            info += $"Last Task: {Task}\n";
            return info;
        }
      

      
    }
}
