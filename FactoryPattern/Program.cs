using Factory.Factory;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Factory
{
    class Program
    {

        static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = ServiceProvider();
            var factory = serviceProvider.GetService<IComputerFactory>(); // find our factory service

            //call factory
            var result_apple = factory.GetCompany("apple").DoWork();
            Console.WriteLine(result_apple);

            var result_hp = factory.GetCompany("hp").DoWork();
            Console.WriteLine(result_hp);

            var result_lenovo = factory.GetCompany("lenovo").DoWork();
            Console.WriteLine(result_lenovo);

            Console.ReadLine();

        }

        public static ServiceProvider ServiceProvider()
        {
            var provider = new ServiceCollection()
             .AddSingleton<IComputerFactory, ComputerFactory>()
             .BuildServiceProvider();
            return provider;
        }
    }
}




