using Factory.Interface;

namespace Factory.Provider
{
    public class AirtelProvider : IMessage
    {
        public string Send()
        {
            return "send successfully from Airtel";
        }
    }
}
