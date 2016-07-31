using System.Threading.Tasks;
using HelloWorld.Core.Api;
using HelloWorld.Core.Models;
using Moq;

namespace HelloWorld.WebApi.Tests.Mocks
{
    public static class Interfaces
    {
        public static IWriter GetIWriter()
        {
            var writer = new Mock<IWriter>();


            writer.Setup(x => x.Write(It.IsAny<MessageModel>())).Verifiable();
            writer.Setup(x => x.WriteAsync(It.IsAny<MessageModel>())).Returns(Task.FromResult(true));


            return writer.Object;
        }
    }
}