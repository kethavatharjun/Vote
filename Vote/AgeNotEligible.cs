using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vote
{
    public class AgeNotEligible : Exception //Inheritance
    {
        public AgeNotEligible(string message) : base(message) //Constructor
        {

        }
    }
}
