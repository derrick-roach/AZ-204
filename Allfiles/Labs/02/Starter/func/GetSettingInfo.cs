using System.Net;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Azure.Functions.Worker.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace func;

public class GetSettingInfo
{
    private readonly ILogger<GetSettingInfo> _logger;

    public GetSettingInfo(ILogger<GetSettingInfo> logger)
    {
        _logger = logger;
    }

    [Function("GetSettingInfo")]
    public HttpResponseData Run([HttpTrigger(AuthorizationLevel.Function, "get", "post")] HttpRequestData req, 
        [BlobInput("content/settings.json", Connection = "AzureWebJobsStorage")] string blobContent
        )
    {
        _logger.LogInformation("C# HTTP trigger function processed a request.");
        _logger.LogInformation($"{blobContent}");

        var response = req.CreateResponse(HttpStatusCode.OK);
        response.Headers.Add("Content-Type", "text/plain; charset=utf-8");
        response.WriteString($"{blobContent}");

        return response;
    }

}
