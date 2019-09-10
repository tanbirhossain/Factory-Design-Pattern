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
            var serviceProvider = new ServiceCollection()
                .AddSingleton<IComputerFactory, ComputerFactory>()
                .BuildServiceProvider();

            var factory = serviceProvider.GetService<IComputerFactory>(); // find our factory



            //call factory
            var result_apple = factory.GetCompany("apple").DoWork();
            Console.WriteLine(result_apple);

            var result_hp = factory.GetCompany("hp").DoWork();
            Console.WriteLine(result_hp);

            var result_lenovo = factory.GetCompany("lenovo").DoWork();
            Console.WriteLine(result_lenovo);

            Console.ReadLine();
        }
    }
}
