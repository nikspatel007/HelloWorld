using System.Collections;
using System.Net.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Results;
using HelloWorld.Core.Models;
using HelloWorld.WebApi.Controllers;

namespace HelloWorld.WebApi.Tests.Mocks
{
    public class TestData
    {
        public static IEnumerable MessageData
        {
            get
            {
                yield return new MessageModel() { Message = null };
                yield return new MessageModel() { Message = "Hello World" };
            }
        }
    }

    public class TestableHttpActionContext : HttpActionContext
    {
        public virtual new HttpRequestMessage Request { get; set; }
    }
}