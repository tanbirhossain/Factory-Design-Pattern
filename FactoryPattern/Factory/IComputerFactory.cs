
using Factory.Companies;

namespace Factory.Factory
{
    public interface IComputerFactory
    {
        ICompany GetCompany(string name);
    }
}
