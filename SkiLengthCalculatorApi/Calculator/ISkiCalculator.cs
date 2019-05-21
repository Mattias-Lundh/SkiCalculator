using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SkiLengthCalculatorApi.Calculator
{
    public interface ISkiCalculator
    {
        SkiRecommendation CalculateRecomendation(CalculatorParameters calcparams);
    }
}
