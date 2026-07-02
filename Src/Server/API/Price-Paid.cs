using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Linq.Expressions;
using System.Net;
using System.Text;

namespace POC_PricePaidData;

public class Price_Paid
{
    private readonly ILogger<Price_Paid> _logger;

    public Price_Paid(ILogger<Price_Paid> logger)
    {
        _logger = logger;
    }

    [Function("Properties")]
    [OpenApiOperation(operationId: "years", Description = "Get list of available years")]
    [OpenApiResponseWithoutBody(statusCode: HttpStatusCode.InternalServerError, Description = "Configuration issue")]
    [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "text/plain", bodyType: typeof(Array), Description = "The OK response")]
    public HttpResponseData GetDelta([HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "years")] HttpRequestData req)
    {
        var response = req.CreateResponse(HttpStatusCode.OK);

        var years = new int[] { 2020, 2021, 2022, 2023 };

        Console.WriteLine("Available years: " + String.Join(", ", years));
        response.WriteAsJsonAsync( years);
        return response;
    }

}