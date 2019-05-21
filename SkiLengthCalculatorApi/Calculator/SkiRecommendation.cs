using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiLengthCalculatorApi.Calculator
{
    public class SkiRecommendation
    {
        public SkiRecommendation(int value)
        {
            Value = value;
        }

        public int Value { get; set; }
    }
}
