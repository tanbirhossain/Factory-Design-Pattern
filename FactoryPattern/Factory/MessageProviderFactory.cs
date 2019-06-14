using Factory.Interface;
using Factory.Provider;
using System;

namespace Factory.Factory
{
    public class MessageProviderFactory : IMessageFactory
    {
        public IMessage GetProvier(string number)
        {


            switch (number)
            {
                case "robi":
                    return new RobiProvider(number);
                case "grameen":
                    return new GrameenPhoneProvider();
                case "airtel":
                    return new AirtelProvider();

                default:
                    throw new ApplicationException("unknow provider");
            }

        }
    }
}
