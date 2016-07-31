using System.Threading.Tasks;

namespace HelloWorld.Core.Api
{
    /// <summary>
    /// Write message to the persistence mechanism. 
    /// This interface will provide an Api to different writer mechanism based on the how dependecies are solved.
    /// 
    /// Requirement a :  write “Hello World” to the console/screen.
    /// </summary>
    public interface IWriter
    {
        /// <summary>
        /// Write a message to the persistence mechanism.
        /// </summary>
        /// <param name="typeT">type of T to be written</param>
        void Write<T>(T typeT);

        /// <summary>
        /// Write method using async await pattern.
        /// </summary>
        /// <param name="typeT">type of T to be written</param>
        /// <returns>Async Task instead of void.</returns>
        Task WriteAsync<T>(T typeT);
    }
}