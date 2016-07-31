using System;
using System.Configuration;
using System.IO;
using HelloWorld.Core.Api;
using HelloWorld.Core.Models;

namespace HelloWorld.Core.Repositories
{
    public class ConfigProvider : IConfigProvider
    {
        public string Get(string key)
        {
            return ConfigurationManager.AppSettings[key] ?? string.Empty;
        }
    }
}