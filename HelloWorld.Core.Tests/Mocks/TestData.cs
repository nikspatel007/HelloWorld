using System;
using System.Collections;
using HelloWorld.Core.Models;
using NUnit.Framework;

namespace HelloWorld.Core.Tests.Mocks
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

        public static IEnumerable ConfigData
        {
            get
            {
                yield return new TestCaseData("WriteMode", "Console");
                yield return new TestCaseData("InvalidKey", string.Empty);
                yield return new TestCaseData(null , string.Empty);
            }
        }
    }
}