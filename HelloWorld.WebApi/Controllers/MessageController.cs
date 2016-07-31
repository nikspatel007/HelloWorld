using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using HelloWorld.Core.Api;
using HelloWorld.Core.Models;
using HelloWorld.WebApi.Filters;

namespace HelloWorld.WebApi.Controllers
{
    [RoutePrefix("api/Message")]
    [ValidationActionFilter]
    public class MessageController : ApiController
    {
        private readonly IWriter _writer;

        public MessageController(IWriter writer)
        {
            _writer = writer;
        }

        [Route("")]
        [HttpPost]
        public async Task<IHttpActionResult> Post(MessageModel model)
        {
            await _writer.WriteAsync(model);
            return Ok(model.Message);
        }
    }
}
