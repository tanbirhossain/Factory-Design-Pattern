
namespace Factory.Companies
{
    public class LenovoCompany : ICompany
    {
        private string _name;
        public LenovoCompany(string name)
        {
            _name = name;
        }
        public string DoWork () => $"object successfully created from {_name}";

    }
}
