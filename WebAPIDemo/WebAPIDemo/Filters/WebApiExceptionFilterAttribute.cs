using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http.Filters;
using System.Net.Http;
using System.Text;
using WebAPIDemo.Common;

namespace WebAPIDemo.Filters
{
    public class WebApiExceptionFilterAttribute:ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext actionExecutedContext)
        {
            LogHelper.Write(actionExecutedContext.Exception);
            string strResponse="{\"success\":\"false\"}";
            actionExecutedContext.Response = new HttpResponseMessage(System.Net.HttpStatusCode.OK) { Content = new StringContent(strResponse, Encoding.UTF8, "text/json") };
            base.OnException(actionExecutedContext);
        }
    }
}