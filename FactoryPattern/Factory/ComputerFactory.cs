using Factory.Companies;
using System;

namespace Factory.Factory
{
    public class ComputerFactory : IComputerFactory
    {
        public ICompany GetCompany(string name)
        {
            switch (name)
            {
                case "apple":
                    return new AppleCompany(name);
                case "hp":
                    return new HPCompany(name);
                case "lenovo":
                    return new LenovoCompany(name);
                default:
                    throw new ApplicationException("unknown company");
            }
        }
    }
}
