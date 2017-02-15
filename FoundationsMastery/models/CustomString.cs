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


        //zipper effect
        //uses content and IEnumberable 
        public string Interleave(IEnumerable<char> first, IEnumerable<char> second)
        {
            //should take two IEnumerable<char> arguments
            //interweave the two arguments and return as one string
            //i.e.
            //var first = new string[] {"1","2","3"};
            //var second = new string[] {"a","b","c"};
            //return string "1a2b3c"
            string result="";
            List<char> charList = new List<char>();
            for(var i = 0; i < 3; i++)
            {
                charList.Add(first.ElementAt(1));
                charList.Add(second.ElementAt(i));
            }
            result = charList.ToString();
            return result;
        }

        public string Print()
        {
            throw new NotImplementedException();
        }

        public virtual void nameOfClass()
        {
            Console.WriteLine("Default");
        }
    }
}
