using System;
using System.Collections.Generic;
using System.Net;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SkiLengthCalculatorApi.Calculator;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Primitives;
using SkiLengthCalculatorApi.Tools;

namespace SkiLengthCalculatorApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        public CalculatorController(ISkiCalculator calculator)
        {
            this.calculator = calculator;
        }

        private ISkiCalculator calculator;

        // GET api/calculator
        [HttpGet]
        public string Get()
        {
            var queryParams = QueryHelpers.ParseQuery(Request.QueryString.Value);

            if (QueryParametersAreValid(queryParams))
            {

                var recommendation =
                    calculator.CalculateRecomendation(
                        new CalculatorParameters(
                            CustomParser.ParseEnum<SkiStyle>(queryParams["style"]),
                            int.Parse(queryParams["age"]),
                            int.Parse(queryParams["height"])));

                Response.Headers.Add("Access-Control-Allow-Origin", "*");
                return JsonConvert.SerializeObject(recommendation);
            }

            Response.StatusCode = (int) HttpStatusCode.BadRequest;
            return string.Empty;
        }

        private bool QueryParametersArePresent(Dictionary<string,StringValues> dict)
        {
            if (dict.ContainsKey("style") && dict.ContainsKey("age") && dict.ContainsKey("height")) return true;

            return false;
        }

        private bool QueryParametersAreValid(Dictionary<string, StringValues> dict)
        {
            if (!QueryParametersArePresent(dict)) return false;

            if (
                CustomParser.TryParseEnum<SkiStyle>(dict["style"]) &&
                CustomParser.TryParseInt(dict["age"]) &&
                CustomParser.TryParseInt(dict["height"])
            ) return true;

            return false;
        }
    }
}
