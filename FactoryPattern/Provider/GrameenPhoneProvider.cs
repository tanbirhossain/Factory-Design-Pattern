using Factory.Interface;

namespace Factory.Provider
{
    public class GrameenPhoneProvider : IMessage
    {
        public string Send()
        {
            return "send successfully from GrameenPhone";
        }
    }
}
