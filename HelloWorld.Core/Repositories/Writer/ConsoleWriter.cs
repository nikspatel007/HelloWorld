using System;
using System.Linq;
using System.Reflection;
using System.Text;
using HelloWorld.Core.Api;

namespace HelloWorld.Core.Repositories.Writer
{
    /// <summary>
    /// writes data to the console.
    /// </summary>
    public class ConsoleWriter : BaseWriter , IWriter
    {
        /// <summary>
        /// Writes passed model and all its properties the console.
        /// This method iterates through the properties and its values to t
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="typeT"></param>
        public sealed override void Write<T>(T typeT)
        {
            Type type = typeT.GetType();
            if (type.IsPrimitive || type.IsValueType || (type == typeof(string)))
            {
                Console.WriteLine(typeT);
            }
            else
            {
                try
                {
                    StringBuilder builder = new StringBuilder(typeT.GetType().Name + Environment.NewLine);
                    typeT.GetType().GetProperties().ToList()
                        .ForEach(pi => builder.Append($"{pi.Name} : {pi.GetValue(typeT, null)}" + Environment.NewLine));
                    Console.WriteLine(builder.ToString());
                }
                catch (NullReferenceException)
                {
                    //Can be used in future when logging is available to log errors.
                    throw;
                }

            }
        }
    }
}