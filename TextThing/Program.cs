using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextThing
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            if(input.Contains("new"))
            {
                var game = new TextGame();
            }
        }
    }
}
