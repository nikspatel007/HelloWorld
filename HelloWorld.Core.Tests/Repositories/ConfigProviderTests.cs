using HelloWorld.Core.Api;
using HelloWorld.Core.Repositories;
using HelloWorld.Core.Tests.Mocks;
using NUnit.Framework;

namespace HelloWorld.Core.Tests.Repositories
{
    [TestFixture]
    public class ConfigProviderTests
    {
        [Test, TestCaseSource(typeof(TestData), nameof(TestData.ConfigData))]
        public void ConfigProvider_Check_WriteMode(string key , string value)
        {
            //Arrange
            IConfigProvider sut = new ConfigProvider();

            //Act
            var writeMode = sut.Get(key);

            //Assert
            Assert.That(writeMode, Is.EqualTo(value));
        }
    }
}