using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinkChoice
{
    public class SodaChoice 
    {

        public SodaType Soda { get; init; }

        public bool Chosen { get; set; }

        public SodaChoice(SodaType type)
        {
            Soda = type;
        }

        public override string ToString()
        {
            switch (Soda)
            {
                case SodaType.Coke:
                    return "Coke";
                case SodaType.DietCoke:
                    return "Diet Coke";
                case SodaType.DrPepper:
                    return "Dr. Pepper";
                case SodaType.DietDrPepper:
                    return "Diet Dr. Pepper";
                case SodaType.MountainDew:
                    return "Mountain Dew";
                case SodaType.Sprite:
                    return "Sprite";
                case SodaType.RootBeer:
                    return "Root Beer";
                default:
                    return "No match";
            }
        }
    }
}
