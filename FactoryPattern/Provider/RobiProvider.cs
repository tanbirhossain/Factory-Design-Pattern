using Factory.Interface;

namespace Factory.Provider
{
    public class RobiProvider : IMessage
    {
        private string _number;
        public RobiProvider(string number)
        {
            _number = number;
        }


        public string Send() => $"send successfully from {_number}";

    }
}
