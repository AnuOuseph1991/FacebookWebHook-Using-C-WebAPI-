using SocialWebHooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Http;

namespace SocialWebHooks.Controllers
{
    public class WebHookController : ApiController
    {
        public class WebhooksController : ApiController
        {
            #region Get Request
            [HttpGet]
            public HttpResponseMessage Get()
            {
                var response = new HttpResponseMessage(HttpStatusCode.OK)
                {
                    Content = new StringContent(System.Web.HttpContext.Current.Request.QueryString["hub.challenge"])
                };
                response.Content.Headers.ContentType = new MediaTypeHeaderValue("text/plain");
                return response;
            }
            #endregion Get Request

            #region Post Request

            [HttpPost]
            public HttpResponseMessage Post(Feed data)
            {
                try
                {
                    //You got the data do whatever you want here!!!Happy programming!!
                    return new HttpResponseMessage(HttpStatusCode.OK);
                }
                catch (Exception ex)
                {
                    return new HttpResponseMessage(HttpStatusCode.BadGateway);
                }
            }

            #endregion

        }
    }
}

