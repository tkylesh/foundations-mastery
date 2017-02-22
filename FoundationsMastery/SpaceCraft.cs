using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery
{
    class SpaceCraft
    {
        public SpaceCraft()
        {

        }

        public SpaceCraft(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public bool Active { get; set; }
        public string[] PlanetsLandedOn { get; set; }
        public int NumberOfEngines { get; set; }
        public int TopSpeed { get; set; }




        public virtual void FlySpaceCraft()
        {
            Console.WriteLine("ppppppppppppphhhhhhhhhheeeeeeeeeeewwwwwwwwwwwwwwwwwww");
        }

    }
}
