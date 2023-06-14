using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pr3
{
    internal class Questions
    {
        public string question { get; set; }
        public string answer { get; set; }
        public int Point { get; set; }
        public Questions(string questoins, string answers, int points)
        {
            question = questoins;
            answer = answers;
            Point = points;
        }
    }
}

