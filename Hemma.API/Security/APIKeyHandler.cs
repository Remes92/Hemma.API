using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Configuration;

namespace Hemma.API.Security
{
    public class APIKeyHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request,CancellationToken cancellationToken)
        {
            bool isValidAPIKey = false;
            IEnumerable<string> requestHeader;

            var checkApiKeyExists = request.Headers.TryGetValues("API_KEY", out requestHeader);

            if (checkApiKeyExists){
                if (requestHeader.FirstOrDefault().Equals(WebConfigurationManager.AppSettings["API_KEY"].ToString()))
                    isValidAPIKey = true;
            }

            if (!isValidAPIKey)
                return request.CreateResponse(HttpStatusCode.Forbidden, "Bad API KEY");

            var respone = await base.SendAsync(request, cancellationToken);

            return respone;
        } 
    }
}