using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Results;
using HelloWorld.Core.Api;
using HelloWorld.Core.Models;
using HelloWorld.WebApi.Controllers;
using HelloWorld.WebApi.Filters;
using HelloWorld.WebApi.Tests.Mocks;
using Moq;
using NUnit.Framework;

namespace HelloWorld.WebApi.Tests.Controllers
{
    [TestFixture]
    public class MessageControllerTests
    {
        private IWriter _writer;

        [OneTimeSetUp]
        public void Setup()
        {
            _writer = Interfaces.GetIWriter();
        }

        [Test, TestCaseSource(typeof(TestData), "MessageData")]
        public async Task Post(MessageModel model)
        {
            //Arrange
            var sut = new MessageController(_writer);

            //Act
            IHttpActionResult result = await sut.Post(model);

            //Assert
            Assert.That(result, Is.TypeOf<OkNegotiatedContentResult<string>>());
        }
    }
}