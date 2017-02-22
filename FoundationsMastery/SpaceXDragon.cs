using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    public class SpaceXDragon : SpaceCraft
    {
        public SpaceXDragon()
        {
            Name = "Dragon";

        }


        public override void FlySpaceCraft()
        {
            Console.WriteLine("bbbbbbbblllllllllllassssssssssstttttttooooooooffffffff!!!!!!");
        }

        public override int NumberOfEngines
        {
            get
            {
                return NumberOfEngines;
            }

            set
            {
                base.NumberOfEngines = 9;
            }
        }
    }
}
