using System.Threading.Tasks;

namespace HelloWorld.Core.Repositories.Writer
{
    /// <summary>
    /// Base Writer exposes synchronus and async method to its child classes. This will help provide async calls without writing them.
    /// </summary>
    public abstract class BaseWriter
    {
        /// <summary>
        /// Abstract method to be implemented by child classes.
        /// </summary>
        /// <typeparam name="T">type to be written.</typeparam>
        /// <param name="typeT">object of type T</param>
        public abstract void Write<T>(T typeT);

        /// <summary>
        /// Internally calls write method in async context.
        /// </summary>
        /// <typeparam name="T">type to be written.</typeparam>
        /// <param name="typeT">object of type T</param>
        /// <returns>returns a System.Threading.Task</returns>
        public async Task WriteAsync<T>(T typeT)
        {
           await Task.Run(() => Write(typeT));
        }
    }
}