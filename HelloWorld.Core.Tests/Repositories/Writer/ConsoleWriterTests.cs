using System;
using System.Threading.Tasks;
using HelloWorld.Core.Models;
using HelloWorld.Core.Repositories.Writer;
using HelloWorld.Core.Tests.Mocks;
using NUnit.Framework;

namespace HelloWorld.Core.Tests.Repositories.Writer
{
    [TestFixture]
    public class ConsoleWriterTests
    {
        [Test, TestCaseSource(typeof(TestData), "MessageData")]
        public void ConsoleWriter_Write(MessageModel message)
        {
            //Arrange
            var sut = new ConsoleWriter();

            //Act
            sut.Write(message);


            //Assert
            //Make Sure no exceptions were thrown.
            Assert.IsTrue(true);
        }

        [Test, TestCaseSource(typeof(TestData), "MessageData")]
        public async Task ConsoleWriter_WriteAsync(MessageModel message)
        {
            //Arrange
            var sut = new ConsoleWriter();
            //Act
            await sut.WriteAsync(message);

            //Assert
            //Make Sure no exceptions were thrown.
            Assert.IsTrue(true);
        }

        [Test]
        public void ConsoleWriter_Null_ThrowsException()
        {
            //Arrange
            var sut = new ConsoleWriter();

            //Act
            //Make Sure null throws an exception.

            //Assert
            Assert.Throws<NullReferenceException>(() => sut.Write<MessageModel>(null));
            Assert.ThrowsAsync<NullReferenceException>(() => sut.WriteAsync<MessageModel>(null));
        }

    }
}