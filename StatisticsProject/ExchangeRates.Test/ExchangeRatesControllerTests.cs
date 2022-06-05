using ExchangeRates.BusinessModels;
using ExchangeRates.BusinessModels.ExchangeRates;
using ExchangeRates.Controllers;
using ExchangeRates.Services;
using ExchangeRates.Services.Helpers;
using ExchangeRates.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xunit;

namespace ExchangeRates.Test
{
    public class ExchangeRatesControllerTests
    {
        ExchangeRatesController _controller;
        IExchangeRatesService _service;
        IExchangeRateRequestValidator _validator;
        ILogger<ExchangeRatesController> _logger;
        
        public ExchangeRatesControllerTests()
        {
            _validator = new ExchangeRateRequestValidator();
            _service = new ExchangeRatesService();
            _controller = new ExchangeRatesController(_logger, _service, _validator);

        }
        [Fact]
        public async Task ValidateStatisticsCalculation()
        {
            // Arrange
            decimal minVal = 0.952702m;
            decimal maxVal = 0.979845m;
            decimal average = 0.9702316666666667m;
            string minDate = "2018-03-01";
            string maxDate = "2018-02-15";

            // Act
            var actionResult =  _controller.Get(new ExchangeRateRequest
            {
                Dates = new List<string> { "2018-02-01", "2018-02-15", "2018-03-01" },
                FromCurrency = "SEK",
                ToCurrency = "NOK"
            });
            // Assert 
            Assert.IsType<OkObjectResult>(actionResult.Result);
            var response = actionResult.Result as OkObjectResult;

            Assert.IsType<ApiResult<StatisticsResponse>>(response.Value);

            var responseCasted = response.Value as ApiResult<StatisticsResponse>;

            Assert.Equal(minVal, responseCasted.Data.MinValue);
            Assert.Equal(minDate, responseCasted.Data.MinDate);
            Assert.Equal(maxVal, responseCasted.Data.MaxValue);
            Assert.Equal(maxDate, responseCasted.Data.MaxDate);
            Assert.Equal(average, responseCasted.Data.Average);




        }
    }
}
