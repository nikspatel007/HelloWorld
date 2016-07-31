using System;
using System.Collections.Generic;
using HelloWorld.Core.Api;
using HelloWorld.Core.Models;

namespace HelloWorld.Core.Repositories.Writer
{
    /// <summary>
    /// Database Writer will be used to get Db Context (Preferrably injected) and write data to the database.
    /// </summary>
    public class DatabaseWriter : BaseWriter , IWriter
    {        
        /// <summary>
        /// Not implemented.
        /// </summary>
        /// <typeparam name="T">type that needs to be written to the database.</typeparam>
        /// <param name="typeT">object of type T</param>
        public override void Write<T>(T typeT)
        {
           throw new NotImplementedException("No Databases set.");
        }
    }    
}