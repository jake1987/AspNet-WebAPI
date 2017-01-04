using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Net.Http;
using System.Web.Http;
using WebAPIDemo.Models;
using WebAPIDemo.Filters;

namespace WebAPIDemo.Controllers
{
    [WebApiExceptionFilter]
    public class UserController : ApiController
    {
        [HttpGet]
        public HttpResponseMessage QueryUser(int ID)
        {
            UserInfo user = new UserInfo { ID = 1, Name = "jake", BirthDate = Convert.ToDateTime("1987/07/20") };
            string strResponse = "{\"success\":\"true\"}";
            //返回Json时:text/json
            //返回字符串时:text/plain
            //返回XML时:text/xml
            return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(strResponse, Encoding.UTF8, "text/json") };
        }

        [HttpPost]
        public HttpResponseMessage CreateUser(dynamic obj)
        {
            var list = obj.Person;
            string strKey = obj.key;
            foreach (var p in list)
            {
                string Name = p.Name;
            }
            string strResponse = "{\"success\":\"true\"}";
            throw new Exception("error");
            //return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(strResponse, Encoding.UTF8, "text/json") };
        }

        [HttpPut]
        public HttpResponseMessage UpdateUser(dynamic obj)
        {
            string strResponse = "{\"success\":\"true\"}";
            return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(strResponse, Encoding.UTF8, "text/json") };
        }

        [HttpDelete]
        public HttpResponseMessage DeleteUser(dynamic obj)
        {
            string strResponse = "{\"success\":\"true\"}";
            return new HttpResponseMessage(HttpStatusCode.OK) { Content = new StringContent(strResponse, Encoding.UTF8, "text/json") };
        }
    }
}