using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;
using System.Web;
namespace ChannelAPI.Controllers
{
    [RoutePrefix("api/Channel")]
    public class ChannelController : ApiController {
        [Route("GetChannels")]
        public HttpResponseMessage GetChannels()
    {
            var json = File.ReadAllText(HttpContext.Current.Server.MapPath(@"~/App_Data/channel.json"));

            return new HttpResponseMessage()
            {
                Content = new StringContent(json, Encoding.UTF8, "application/json"),
                StatusCode = HttpStatusCode.OK
            };
            //var a = Environment.CurrentDirectory;
            //string allText = System.IO.File.ReadAllText("~/Models/channel.json");

            //object jsonObject = JsonConvert.DeserializeObject(allText);
            //return jsonObject;
        }
}  
}   
   

