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
                .AddSingleton<IMessageFactory, MessageProviderFactory>()
                .BuildServiceProvider();


            #region dummy code

            //IMessageFactory factory = new MessageProviderFactory();
            //var factory = new MessageProviderFactory();
            //var provider = factory.GetProvier("robi");
            //var result = provider.Send();

            #endregion


            var factory = serviceProvider.GetService<IMessageFactory>();
            //single point call factory
            var result_robi = factory.GetProvier("robi").Send();
            Console.WriteLine(result_robi);

            var result_grameen = factory.GetProvier("grameen").Send();
            Console.WriteLine(result_grameen);

            var result_airtel = factory.GetProvier("airtel").Send();
            Console.WriteLine(result_airtel);

            Console.ReadLine();
        }
    }
}
