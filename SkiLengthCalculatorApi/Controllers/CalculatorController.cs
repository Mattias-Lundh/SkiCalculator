using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SkiLengthCalculatorApi.Calculator;
using Microsoft.AspNetCore.WebUtilities;
using SkiLengthCalculatorApi.Tools;

namespace SkiLengthCalculatorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        private ISkiCalculator calculator = new SkiCalculator();

        // GET api/calculator
        [HttpGet]
        public string Get()
        {
            var queryParams = QueryHelpers.ParseQuery(Request.QueryString.Value);

            var recommendation =
                calculator.CalculateRecomendation(
                    new CalculatorParameters(
                        EnumParser.Parse<SkiStyle>(queryParams["style"]),
                        int.Parse(queryParams["age"]),
                        int.Parse(queryParams["height"])));

            Response.Headers.Add("Access-Control-Allow-Origin", "*");
            return JsonConvert.SerializeObject(recommendation);
        }
    }
}
