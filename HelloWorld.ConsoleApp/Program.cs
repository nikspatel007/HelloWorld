using System;
using System.Configuration;
using HelloWorld.Core.Api;
using HelloWorld.Core.Models;
using HelloWorld.Core.Repositories;
using HelloWorld.Core.Repositories.Writer;
using Ninject;

namespace HelloWorld.ConsoleApp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var kernel = CreateKernel();
            var writer = kernel.Get<IWriter>();

            //Fulfill business requirement here.
            writer.Write("Hello World");

            Console.ReadLine();
        }

        public  static IKernel CreateKernel()
        {
            var kernel = new StandardKernel();

            kernel.Bind<IConfigProvider>().To<ConfigProvider>();
            kernel.Bind<IWriter>().To<DatabaseWriter>()
                .When(x => kernel.Get<IConfigProvider>().Get("WriteMode").Equals("database", StringComparison.OrdinalIgnoreCase));
            kernel.Bind<IWriter>().To<ConsoleWriter>();

            return kernel;
        }
    }
}
