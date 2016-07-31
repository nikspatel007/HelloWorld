using System;
using HelloWorld.Core.Api;
using HelloWorld.Core.Models;
using HelloWorld.Core.Repositories.Writer;
using NUnit.Framework;

namespace HelloWorld.Core.Tests.Repositories.Writer
{
    [TestFixture]
    public class DatabaseWriterTests
    {
        [Test]
        public void DatabaseWriter_Write_NotImplemented()
        {
            //Arrange
            IWriter writer = new DatabaseWriter();

            //Assert.
            Assert.Throws<NotImplementedException>(() => writer.Write<MessageModel>(null));
            Assert.ThrowsAsync<NotImplementedException>(() => writer.WriteAsync<MessageModel>(null));
        }
    }
}