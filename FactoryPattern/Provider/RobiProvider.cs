using Factory.Interface;

namespace Factory.Provider
{
    public class RobiProvider : IMessage
    {
        public string Send()
        {
            return "send successfully from Robi";
        }
    }
}
