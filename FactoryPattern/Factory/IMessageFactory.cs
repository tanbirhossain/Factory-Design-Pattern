using Factory.Interface;

namespace Factory.Factory
{
    public interface IMessageFactory
    {
        IMessage GetProvier(string number);
    }
}
