using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    class SpaceXDragon : SpaceCraft
    {
        public SpaceXDragon()
        {

        }

        public SpaceXDragon(string name): base(name)
        {
            Name = name;
        }

        public override void FlySpaceCraft()
        {
            Console.WriteLine("bbbbbbbblllllllllllassssssssssstttttttooooooooffffffff!!!!!!");
        }

        public override int NumberOfEngines
        {
            get
            {
                return base.NumberOfEngines;
            }

            set
            {
                base.NumberOfEngines = 9;
            }
        }
    }
}
