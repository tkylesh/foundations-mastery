using FoundationsMastery.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoundationsMastery.models
{
    public class CustomString : ICustomString
    {
        public CustomString()
        {

        }

        public CustomString(IEnumerable<char> args)
        {
            Contents = args;
        }

        public IEnumerable<char> Contents { get; set; }

        public int Length
        {
            get
            {
                return Contents.Count();
            }
        }

        public void Clear()
        {
            Contents = null;
        }

        public string Concat(IEnumerable<char> rhs)
        {
            string concatString = "";

            foreach(char c in rhs)
            {
                concatString += c;
            }

            return concatString;
        }

        public string Interleave(IEnumerable<char> rhs)
        {
            throw new NotImplementedException();
        }

        public string Print()
        {
            throw new NotImplementedException();
        }
    }
}
