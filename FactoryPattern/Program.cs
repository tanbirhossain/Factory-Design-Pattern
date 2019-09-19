using Factory.Factory;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace Factory
{
    class Program
    {

        static void Main(string[] args)
        {
            var serviceProvider = ServiceProvider(); // Call Service Provider
            var factory = serviceProvider.GetRequiredService<IComputerFactory>(); // Resolve dependency

            //call factory
            var result_apple = factory.GetCompany("apple").DoWork(); // call factory for apple brand
            Console.WriteLine(result_apple);
            
            var result_hp = factory.GetCompany("hp").DoWork(); //  call factory for hp brand
            Console.WriteLine(result_hp);

            var result_lenovo = factory.GetCompany("lenovo").DoWork(); //  call factory for hp brand
            Console.WriteLine(result_lenovo);
            
            Console.ReadLine(); 
        }

        //Setup IOC 
        public static ServiceProvider ServiceProvider()
        {
            var provider = new ServiceCollection()
             .AddSingleton<IComputerFactory, ComputerFactory>()
             .BuildServiceProvider();
            return provider;
        }
    }
}





