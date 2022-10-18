using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WordOfTanks
{
    public class Tank
    {
        protected string name;
        protected int Ammunition;
        protected int ArmorLevel;
        protected int ManeuverabilityLevel;
        public Tank(int Ammunition, int ArmorLevel, int ManeuverabilityLevel, string name)
        {

            this.Ammunition = Ammunition;
            this.ArmorLevel = ArmorLevel;
            this.ManeuverabilityLevel = ManeuverabilityLevel;
            this.name = name;
        }
        public Tank()
        {
            Ammunition = 0;
            ArmorLevel = 0;
            ManeuverabilityLevel = 0;
            name = "null";
        }
        public void Print()
        {
            Console.WriteLine("name - " + name);
            Console.WriteLine("Ammunition = " + Ammunition + " ArmorLevel = " + ArmorLevel + " ManeuverabilityLevel = " + ManeuverabilityLevel);
        }

        public static Tank operator *(Tank T34, Tank Pantera)
        {
            if (T34.Ammunition > Pantera.Ammunition && T34.ArmorLevel > Pantera.ArmorLevel)
            {
                return T34;
            }
            if (T34.Ammunition > Pantera.Ammunition && T34.ManeuverabilityLevel > Pantera.ManeuverabilityLevel)
            {
                return T34;
            }
            if (T34.ArmorLevel > Pantera.ArmorLevel && T34.ManeuverabilityLevel > Pantera.ManeuverabilityLevel)
            {
                return T34;
            }
            else
            {
                return Pantera;
            }
        }
    }
}
