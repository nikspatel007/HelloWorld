using System;
using HelloWorld.Core.Models;

namespace HelloWorld.Core.Api
{
    /// <summary>
    /// Config provider provides config from different config mechanisms. 
    /// It helps to change application behvior without re-deploying the application.
    /// </summary>
    public interface IConfigProvider
    {
        /// <summary>
        /// Retruns the value based on a key using ConfigurationManager.
        /// </summary>
        /// <param name="key">Key in AppSettings</param>
        /// <returns>Value attached to the Key</returns>
        string Get(string key);
    }
}