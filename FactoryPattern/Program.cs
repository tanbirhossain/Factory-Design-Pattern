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
// What kind of problem we are trying to solve using factory design pattern
// what is factory design pattern
// In the oop design its the most common and and useful desing patter. What actualy doing factory design patter. factory design its kind of object factory . in the real world you already heard the factory word. like food factory , machine factory etc. 
// Factory is a collection of object . where you can deside which object you will get . this factory design pattern help us onject creation problem.

//Lets focus of the problem. Suppose we have a 3 Computer Manufacturers . They providing support us . if customer face any problem we have to call the manufacturer based on their  
//manufacturer brand name. so our main problem here create our manufaturer object based on theri brand name. 
//Here we will create a factory . This factory help us create object.
// Lets start coding
//




