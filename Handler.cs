using Amazon.Lambda.Core;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Amazon.Lambda.APIGatewayEvents;

// [assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]
namespace GraphQLDynamo
{
    public class Handler
    {
        public async Task<APIGatewayProxyResponse> GetData(APIGatewayProxyRequest request, ILambdaContext context)
        {
     
            context.Logger.LogLine($"Found data");

            Message page = new Message
            {
                Data = "heya"
            };

            var response = new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = JsonConvert.SerializeObject(page)
 
            };

            return response;
        }
    }

    public class Message {
        public string Data { get; set; }
    }
}
